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
        public int VisaFreq
        {
            get
            {
                return Properties.Settings.Default.VisaFrequency;
            }
            set
            {
                Properties.Settings.Default.VisaFrequency = value;
                Properties.Settings.Default.Save();
            }

        }

        public int OrderFreq
        {
            get
            {
                return Properties.Settings.Default.OrderFrequency;
            }
            set
            {
                Properties.Settings.Default.OrderFrequency = value;
                Properties.Settings.Default.Save();
            }

        }

        public int UnitsFreq
        {
            get
            {
                return Properties.Settings.Default.UnitsFrequency;
            }
            set
            {
                Properties.Settings.Default.UnitsFrequency = value;
                Properties.Settings.Default.Save();
            }

        }
        public string ImagesPath
        {
            get
            {
                return Properties.Settings.Default.ImageFolder;
            }
            set
            {
                Properties.Settings.Default.ImageFolder = value;
                Properties.Settings.Default.Save();
            }
        }

        public string BackupPath
        {
            get
            {
                return Properties.Settings.Default.BackupFolder;
            }
            set
            {
                Properties.Settings.Default.BackupFolder = value;
                Properties.Settings.Default.Save();
            }
        }

        public string MySqlPath
        {
            get
            {
                return Properties.Settings.Default.SqlFolder;
            }
            set
            {
                Properties.Settings.Default.SqlFolder = value;
                Properties.Settings.Default.Save();
            }
        }

        public DateTime LastOptimizationDate
        {
            get
            {
                return Properties.Settings.Default.LastOptimizeDate;
            }
            set
            {
                Properties.Settings.Default.LastOptimizeDate = value;
                Properties.Settings.Default.Save();
            }
        }

        public int OptimizingFrequency
        {
            get
            {
                return Properties.Settings.Default.OptimizeFrequency;
            }
            set
            {
                Properties.Settings.Default.OptimizeFrequency = value;
                Properties.Settings.Default.Save();
            }
        }

        public int VisaExpireDays
        {
            get
            {
                return Properties.Settings.Default.VisaNotify;
            }
            set
            {
                Properties.Settings.Default.VisaNotify = value;
                Properties.Settings.Default.Save();
            }
        }

        public int OrderDueDate
        {
            get
            {
                return Properties.Settings.Default.OrderNotify;
            }
            set
            {
                Properties.Settings.Default.OrderNotify = value;
                Properties.Settings.Default.Save();

            }
        }

        public int MinUnitsInStorage
        {
            get
            {
                return Properties.Settings.Default.UnitsNotify;
            }
            set
            {
                Properties.Settings.Default.UnitsNotify = value;
                Properties.Settings.Default.Save();
            }
        }

        public string ConnectionString
        {
            get 
            {
        
                Configuration config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location);
                ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;
                if (section.SectionInformation.IsProtected)
                {
                    // Remove encryption.
                    section.SectionInformation.UnprotectSection();
                }
                return section.ConnectionStrings["seedsfromzion.Settings1.connection"].ConnectionString;
            }
        }

    }
}
