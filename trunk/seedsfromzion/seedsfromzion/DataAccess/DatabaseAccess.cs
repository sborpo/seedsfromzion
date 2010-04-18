using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace seedsfromzion.DataAccess
{
    class DatabaseAccess
    {

        private string connectionString;
        private string username;
        private string password;

        DatabaseAccess()
        {

        }
        public void performDbBackup(string targerDir)
        {

        }

        private void ToggleConfigEncryption(string exeConfigName)
        {
            try
            {
                // Open the configuration file and retrieve 
                // the connectionStrings section.
                Configuration config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location);
                ConnectionStringsSection section = config
  .GetSection("connectionStrings")
                    as ConnectionStringsSection;

                if (section.SectionInformation.IsProtected)
                {
                    // Remove encryption.
                    section.SectionInformation.UnprotectSection();
                }
                else
                {
                    // Encrypt the section.
                    section.SectionInformation.ProtectSection(
                        "DataProtectionConfigurationProvider");
                }
                // Save the current configuration.
                config.Save();

                Console.WriteLine("Protected={0}",
                    section.SectionInformation.IsProtected);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




    }
}
