using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Text.RegularExpressions;
namespace seedsfromzion.DataAccess
{
    /// <summary>
    /// The class is responsible to the communication with the DBMS.
    /// this is a singelton class.
    /// </summary>
    public class DatabaseAccess : pIDatabaseAccess
    {
        #region Data
        private static DatabaseAccess dbAccess; //the DatabaseAccess Singelton
        private string connectionString; //the connection string to the database
        //connection string arguments
        private string username;
        private string password;
        private string databaseName;
        //system arguments
        private String sqlDir;
        #endregion

        #region Methods
        DatabaseAccess()
        {
            configSetter();
            //retrieves connection information from the connection string
            username = Regex.Split(Regex.Split(connectionString, "Uid = ")[1], ";")[0];
            password = Regex.Split(Regex.Split(connectionString, "Pwd = ")[1], ";")[0];
            databaseName = Regex.Split(Regex.Split(connectionString, "Database = ")[1], ";")[0];

        }

        public static IDatabaseAccess getInstance()
        {
            if (dbAccess == null)
            {
                dbAccess = new DatabaseAccess();
            }
                return dbAccess;
        }


        /// <summary>
        /// Performs a complete database restoration , using the given sql file backup.
        /// </summary>
        /// <param name="backupFile"></param>
        public void restoreDb(string backupFile)
        {
            string back = String.Format(@"""{0}""", backupFile);
            string command = String.Format(@"mysql -u {0} --password={1} <{2}", username, password, back);
            proccessInvocator(command);
        }


        /// <summary>
        /// Performs a complete database backup and saves it into the given 
        /// target directory
        /// </summary>
        /// <param name="targerDir"></param>
        public void performDbBackup(string targerDir)
        {
            string back = String.Format(@"""{0}""", targerDir);
            string command = String.Format(@"mysqldump.exe --add-drop-table -B {0} -u {1} --password={2} >{3}", databaseName, username, password, back);
            proccessInvocator(command);
        }


        /// <summary>
        /// Invocates the given command using the CMD.
        /// </summary>
        /// <param name="command"></param>
        private void proccessInvocator(string command)
        {
            System.Diagnostics.ProcessStartInfo DBProcessStartInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", @"/C " + command);
            //Redirect the output to standard window
            DBProcessStartInfo.RedirectStandardOutput = false;
            DBProcessStartInfo.WorkingDirectory = sqlDir;
            //The output display window need not be falshed onto the front.
            DBProcessStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            DBProcessStartInfo.UseShellExecute = false;
            //Create the process and run it
            System.Diagnostics.Process dbProcess;
            dbProcess = System.Diagnostics.Process.Start(DBProcessStartInfo);
            //wait till the process will finish
            dbProcess.WaitForExit();
        }

      
        // TODO: move this to the install class
        /// <summary>
        /// Encryps the ConnectionString section. 
        /// </summary>
        private void encryptConfig()
        {
            try
            {
                // Open the configuration file and retrieve 
                // the connectionStrings section.
                Configuration config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location);
                ConnectionStringsSection section = config .GetSection("connectionStrings") as ConnectionStringsSection;
                if (!section.SectionInformation.IsProtected)
                {
                    // Encrypt the section.
                    section.SectionInformation.ProtectSection(
                        "DataProtectionConfigurationProvider");
                }
                // Save the current configuration.
                config.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        /// <summary>
        /// Sets the initiale configuration of the DatabaseAccess class , using the application's
        /// configuration file.
        /// </summary>
        private void configSetter()
        {
                // Open the configuration file and retrieve 
                // the connectionStrings section.
                Configuration config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location);
                ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;
                if (section.SectionInformation.IsProtected)
                {
                    // Remove encryption.
                    section.SectionInformation.UnprotectSection();
                }
                connectionString= section.ConnectionStrings["seedsfromzion.configurations.connection"].ConnectionString;
                
                //Now we will load the rest of the configuration
                ConfigurationSectionGroup configGroup = config.SectionGroups["applicationSettings"];
                ClientSettingsSection ar =configGroup.Sections["seedsfromzion.configurations"] as ClientSettingsSection;
                SettingElementCollection elements =ar.Settings;
                //load the elemnts
                sqlDir = elements.Get("SqlFolder").Value.ValueXml.InnerText;
        }
        #endregion
    }
}
