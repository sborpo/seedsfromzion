using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace seedsfromzion.DataAccess
{
    class ConfigFile 
    {
        private static ConfigFile file;
        ConfigFile() { }

        public static ConfigFile getInstance
        {
            get
            {
                if (file == null)
                {
                    file = new ConfigFile();
                }
                return file;
            }
        }

        public string ImagesPath
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string BackupPath
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string MySqlPath
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string LastOptimizationDate
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int OptimizingFrequency
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int VisaExpireDays
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int OrderDueDate
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int MinUnitsInStorage
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string ConnectionString
        {
            get { throw new NotImplementedException(); }
        }


        private String getProperty(String propertyName)
        {

            Configuration config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location);
            ConfigurationSectionGroup configGroup = config.SectionGroups["applicationSettings"];
            ClientSettingsSection ar =configGroup.Sections["seedsfromzion.configurations"] as ClientSettingsSection;
            SettingElementCollection elements =ar.Settings;
            //load the elemnts
            return elements.Get(propertyName).Value.ValueXml.InnerText;
        }

        private String setProperty(String propertyName, String value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location);
            ConfigurationSectionGroup configGroup = config.SectionGroups["applicationSettings"];
            ClientSettingsSection ar = configGroup.Sections["seedsfromzion.configurations"] as ClientSettingsSection;
            SettingElementCollection elements = ar.Settings;
            //load the elemnts
            return elements.Get(propertyName).Value.ValueXml.InnerText = value;
        }
    }
}
