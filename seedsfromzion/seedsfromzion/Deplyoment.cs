using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.Configuration;
using System.IO;


namespace seedsfromzion
{
    [RunInstaller(true)]
    public class Deplyoment : Installer
    {
        public override void Install(IDictionary savedState)
        {
            base.Install(savedState);
            Configuration config = ConfigurationManager.OpenExeConfiguration(
                //Gets the source directory of the installation from the default 
             Context.Parameters["assemblypath"]);
            // Get the connectionStrings section. 
            ConfigurationSection section = config.GetSection("connectionStrings");
            //Ensures that the section is not already protected 
            if (!section.SectionInformation.IsProtected)
            {
                //Uses the Windows Data Protection API (DPAPI) to encrypt the 
                //configuration section using a machine-specific secret key 
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                config.Save();
            }
            String TargetDirectory = Path.GetDirectoryName(Context.Parameters["AssemblyPath"]);
            seedsfromzion.Managers.SystemManager.performSystemRestore(TargetDirectory + @"\am.zip");
        }

        public override void Commit(IDictionary savedState)
        {

        }
    }
}
