using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seedsfromzion.DataAccess
{
    interface IConfigFile
    {
        string ImagesPath
        {
            get;
            set;
        }

        string BackupPath
        {
            get;
            set;
        }

        string MySqlPath
        {
            get;
            set;
        }

        string LastOptimizationDate
        {
            get;
            set;
        }

        int OptimizingFrequency
        {
            get;
            set;
        }

        int VisaExpireDays
        {
            get;
            set;
        }
        int OrderDueDate
        {
            get;
            set;
        }
        int MinUnitsInStorage
        {
            get;
            set;
        }

        string ConnectionString
        {
            get;
        }

    }
}
