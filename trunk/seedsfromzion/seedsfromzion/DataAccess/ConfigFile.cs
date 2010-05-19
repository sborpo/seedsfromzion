using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;

namespace seedsfromzion.DataAccess
{
    /// <summary>
    /// This class gives the access to the Settings File of the
    /// application.
    /// It is a singleton class.
    /// </summary>
    class ConfigFile
    {
        //the singelton field
        private static ConfigFile file;
        ConfigFile()
        {
        }

        /// <summary>
        /// Singleton method for getting the object
        /// </summary>
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

        /// <summary>
        /// Sets and gets the frequency in hours that the system
        /// should check for expired visa notifications
        /// </summary>
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

        /// <summary>
        /// Sets and gets the frequency in hours that the system
        /// should check for incoming customers notification
        /// </summary>
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

        /// <summary>
        /// Sets and gets the frequency in hours that the system
        /// should check for low inventory count of units notification
        /// </summary>
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

        /// <summary>
        /// Sets and gets the images path where the plants photos are stored 
        /// </summary>
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

        /// <summary>
        /// Sets and gets the automatic backups path.
        /// </summary>
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

        /// <summary>
        /// Sets and gets the MySql DMBS installation folder
        /// </summary>
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

        /// <summary>
        /// Sets and gets the last Database optimization date
        /// </summary>
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

        /// <summary>
        /// Sets and gets the last Database Automatic Backup Date
        /// </summary>
        public DateTime LastAutomaticBackupDate
        {
            get
            {
                return Properties.Settings.Default.LastBackupDate;
            }
            set
            {
                Properties.Settings.Default.LastBackupDate = value;
                Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// Sets and gets the backup frequency of the system in days
        /// </summary>
        public int BackupFrequency
        {
            get
            {
                return Properties.Settings.Default.BackupFrequency;
            }
            set
            {
                Properties.Settings.Default.BackupFrequency = value;
                Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// Sets and gets the optimization frequency of the system in days
        /// </summary>
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

        /// <summary>
        /// Sets and gets the number of days that the system notifies the user
        /// before visa expiration.
        /// </summary>
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

        /// <summary>
        /// Sets and gets the number of days that the system notifies the user
        /// before customers come to take their order
        /// </summary>
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

        /// <summary>
        /// Sets and gets the units treshold , which below it , the system will notify 
        /// that the inventory status is low.
        /// </summary>
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

        /// <summary>
        /// Sets and gets the favorite plants of the system.
        /// Is stores a string list of plant ids.
        /// </summary>
        public System.Collections.Specialized.StringCollection Favorites
        {
            get
            {
                if (Properties.Settings.Default.Favorites == null)
                {
                    Properties.Settings.Default.Favorites = new StringCollection();
                    Properties.Settings.Default.Save();
                }
                return Properties.Settings.Default.Favorites;
            }
            set
            {
                Properties.Settings.Default.Favorites = value;
                Properties.Settings.Default.Save();

            }
        }

        /// <summary>
        /// Gets the connection string to the DBMS. 
        /// the connection string is decrypted before it returned
        /// to the user.
        /// </summary>
        public string ConnectionString
        {
            get
            {
                //open the configuration file
                Configuration config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location);
                //get the connection string section
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
