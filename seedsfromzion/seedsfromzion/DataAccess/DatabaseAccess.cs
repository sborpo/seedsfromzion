using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
namespace seedsfromzion.DataAccess
{
    /// <summary>
    /// The class is responsible to the communication with the DBMS.
    /// this is a singelton class.
    /// </summary>
    public class DatabaseAccess : IDatabaseAccess
    {
        #region Data
        private static string connectionString; //the connection string to the database
        //connection string arguments
        private static string username;
        private static string password;
        private static string databaseName;
        //system arguments
        private static String sqlDir;
        #endregion

        #region IDatabaseAccess Members
        static DatabaseAccess()
        {
            configSetter();
            //retrieves connection information from the connection string
            username = Regex.Split(Regex.Split(connectionString, "Uid = ")[1], ";")[0];
            password = Regex.Split(Regex.Split(connectionString, "Pwd = ")[1], ";")[0];
            databaseName = Regex.Split(Regex.Split(connectionString, "Database = ")[1], ";")[0];

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
        private static void configSetter()
        {
            ConfigFile config = ConfigFile.getInstance;
            connectionString=config.ConnectionString;
            sqlDir = config.MySqlPath;
        }

        /// <summary>
        /// performes a DML command on the database.
        /// information about defining MySqlCommand object can be found 
        /// here:
        /// http://www.csharp-station.com/Tutorials/AdoDotNet/Lesson06.aspx
        /// </summary>
        /// <param name="query"></param>
        public void performDMLQuery(MySql.Data.MySqlClient.MySqlCommand query)
        {
            MySqlCommand[] arr = new MySqlCommand[1];
            arr[0] = query;
            performDMLTransaction(arr);
        }


        /// <summary>
        /// performs a transcation of several commands,if one command
        /// fails then there is a rollback , otherwise commit.
        /// </summary>
        /// <param name="queries"></param>
        public void performDMLTransaction(MySql.Data.MySqlClient.MySqlCommand[] queries)
        {
            //open connection to the DBMS
            MySqlConnection conn=null;
            MySqlTransaction transaction=null;
            try
            {
            conn= new MySqlConnection(connectionString);
            conn.Open();
            //create a transaction
            transaction = conn.BeginTransaction();
            //define to each command the transaction and the connection it should be executed
            foreach (MySqlCommand command in queries)
            {
                command.Connection = conn;
                command.Transaction = transaction;
            }
                //execute each command
                foreach (MySqlCommand command in queries)
                {
                    command.ExecuteNonQuery();
                }
                //commit the changes
                transaction.Commit();
            }
            catch (Exception ex)
            {
                //if we recieved a problem , rollback and throw execption to user
                if (transaction != null) { transaction.Rollback(); }
                throw ex; 
            }
            finally
            {
                if (conn != null) { conn.Close(); }
            }
        }

        /// <summary>
        /// executes the given sql query and returns the answer in 
        /// a dataset.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public System.Data.DataSet getResultSetFromDb(MySql.Data.MySqlClient.MySqlCommand query)
        {
           MySqlConnection conn = new MySqlConnection(connectionString);
           query.Connection = conn;
           MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
           dataAdapter.SelectCommand = query;
            try{
                DataSet result = new DataSet();
                dataAdapter.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                
                if ((!(conn==null))&&(conn.State != ConnectionState.Closed)) { conn.Close(); }
                throw ex;
            }
            //the fill method should close if everything is fine the connection
        }

        /// <summary>
        /// Used for retriving a single value from the database.
        /// executes the given sql query and returns the answer in 
        /// an Object which represent a scalar object.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public object getScalarFromDb(MySql.Data.MySqlClient.MySqlCommand query)
        {
            MySqlConnection conn=null;
            try
            {
                conn=new MySqlConnection(connectionString);
                conn.Open();
                query.Connection = conn;
                Object result = query.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                if (conn != null) { conn.Close(); }
                throw ex;
            }

        }


        /// <summary>
        /// moves records older then the given date from the table WorkHours to the
        /// the same table which works on an archive engine.
        /// more information about Archive Engine:
        /// http://dev.mysql.com/tech-resources/articles/storage-engine.html
        /// </summary>
        /// <param name="startTime"></param>
        public void optimizeDb(DateTime threshold)
        {
            MySqlCommand moveCommand = new MySqlCommand("INSERT INTO  seedsdb.workarchive (workerId, date, startTime, endTime)"
                                                    +"(SELECT workerId, date, startTime, endTime FROM seedsdb.workdays "+
                                                    "WHERE date< @Date);");
            MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM seedsdb.workdays WHERE date< @Date;");
            MySqlParameter dateParam = new MySqlParameter();
            dateParam.ParameterName = "@Date";
            dateParam.Value = String.Format("{0:yyyy-M-d}", threshold); 
            moveCommand.Parameters.Add(dateParam);
            deleteCommand.Parameters.Add(dateParam);
            MySqlCommand[] arr = new MySqlCommand[2];
            arr[0] = moveCommand; arr[1] = deleteCommand;
            performDMLTransaction(arr);
        }

        #endregion
    }
}
