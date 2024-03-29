﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using seedsfromzion.DataAccess;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using seedsfromzion.GUI;

namespace seedsfromzion.Managers
{
    /// <summary>
    /// Class that should handle the routines of the system
    /// like checking for notification , performing system backup
    /// and ect.
    /// </summary>
    public class Routines
    {

       
        /// <summary>
        /// Class which represent a working thread that
        /// checks the database for notifications alternately (defined
        /// sleep times in the configuration file).
        /// </summary>
        private class Worker
        {
            /// <summary>
            /// the form to which the worker should notify
            /// </summary>
            private seedsFromZion notify;

            public Worker(seedsFromZion notify)
            {
                this.notify = notify;
            }
            
            /// <summary>
            /// The method handles the client orders due date notification
            /// the thread checks the notification in time periods defined 
            /// in OrderFreq.
            /// </summary>
            public void HandleDueDate()
            {
                if (ConfigFile.getInstance.OrderFreq < 0)
                {
                    return;
                }
                //if we didn't ask to terminate
                while (!terminate)
                {
                    checkOrderDate();
                    try
                    {
                        //sleep for a given time
                        Thread.Sleep(new TimeSpan( ConfigFile.getInstance.OrderFreq, 0,0));
                    }
                    catch (ThreadInterruptedException ex)
                    {   
                        return;
                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                }
            }
            /// <summary>
            /// The method handles the worker due date notification
            /// the thread checks the notification in time periods defined 
            /// in VisaFreq.
            /// </summary>
            public void HandleVisa()
            {
                if (ConfigFile.getInstance.VisaFreq< 0)
                {
                    return;
                }
                while (!terminate)
                {
                    try
                    {
                        checkVisaExpirationDate();
                        Thread.Sleep(new TimeSpan(ConfigFile.getInstance.VisaFreq, 0, 0));
                    }
                    catch (ThreadInterruptedException ex)
                    {
                        return;
                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                }

            }

            /// <summary>
            /// The method handles the storage notification
            /// the thread checks the notification in time periods defined 
            /// in UnitsFreq. 
            /// </summary>
            public void HandleUnits()
            {
                if (ConfigFile.getInstance.UnitsFreq< 0)
                {
                    return;
                }
                while (!terminate)
                {
                    try
                    {
                        checkUnits();
                        Thread.Sleep(new TimeSpan(ConfigFile.getInstance.UnitsFreq, 0, 0));
                    }
                    catch (ThreadInterruptedException ex)
                    {
                        return;
                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                }

            }
            /// <summary>
            /// The method performs the checking with the database if there
            /// are plants that their units are below a given treshold defined by
            /// MinUnits in storage.
            /// if yes, it invokes the method which represent the notification
            /// on the screen.
            /// </summary>
            private void checkUnits()
            {
                //execture the select command of the database
                MySqlCommand command = DataAccessUtils.commandBuilder("SELECT DISTINCT P.name,P.type,U.units FROM seedsdb.planttypes P, (SELECT plantId,SUM(units) AS units FROM seedsdb.finishedstorage"+
                " GROUP BY plantId) U WHERE  P.plantId=U.plantId AND U.units<@Units AND units>0", "@Units", ConfigFile.getInstance.MinUnitsInStorage.ToString());
                DataTable res = DatabaseAccess.getResultSetFromDb(command);
                StringBuilder sb = new StringBuilder();
                //check if we have such kind of plants
                if (res.Rows.Count == 0)
                {
                    return;
                }
                //there are plants that below the treshold , so iterate through them
                //and display.
                foreach (DataRow row in res.Rows)
                {
                    sb.Append(String.Format(row["name"] +" מסוג "+row["type"]+"'"+" - "+row["units"]+ " יחידות ")+"\n");
                }
                //display the notification
                notify.Invoke(notify.displayFunc, (String.Format("מצב המלאי עבור הצמחים הבאים ירד מתחת ל {0} יחידות", ConfigFile.getInstance.MinUnitsInStorage)), sb.ToString());
            }

            /// <summary>
            /// The method performs the checking with the database if there
            /// are worker that their visa should be expire within number of days
            /// that is defined in VisaExpireDays
            /// if yes, it invokes the method which represent the notification
            /// on the screen.
            /// </summary>
            private void checkVisaExpirationDate()
            {
                //execture the select command of the database
                String date = String.Format("{0:yyyy-M-d}", DateTime.Now.AddDays(ConfigFile.getInstance.VisaExpireDays));
                MySqlCommand command = DataAccessUtils.commandBuilder("SELECT DISTINCT name,MIN(expireDate) AS date FROM seedsdb.workers W, seedsdb.workersvisas WS , seedsdb.Visas VS "
                + "WHERE VS.expireDate<=@Date AND VS.expireDate>=@DateNow AND VS.visaId=WS.visaId AND W.id=WS.workerId GROUP BY name", "@Date", date,"@DateNow", String.Format("{0:yyyy-M-d}",DateTime.Now));
                DataTable res = DatabaseAccess.getResultSetFromDb(command);
                StringBuilder sb = new StringBuilder();
                //check if we have such kind of workers
                //that their visas will expire
                if (res.Rows.Count == 0)
                {
                    return;
                }
                foreach (DataRow row in res.Rows)
                {
                    DateTime time=DateTime.Now.ToLocalTime();
                    long ticks = (((DateTime)row["date"]).Ticks - time.Ticks);
                    if (ticks <= 0)
                    {
                        continue;
                    }
                    TimeSpan duration = TimeSpan.FromTicks(ticks);
                    
                    String str = "ימים";
                    int timespan = duration.Days;
                    if (timespan < 1)
                    {
                        str = "שעות";
                        timespan = duration.Hours;
                    }
                    sb.Append((String)row["name"] + " " + " תפוג בעוד כ" + timespan + " " + str + "\n");
                }
                if (sb.ToString().Equals(String.Empty))
                {
                    return;
                }
                //display the notification
                notify.Invoke(notify.displayFunc, (String.Format("אשרות העבודה של העובדים הבאים יפגוגו בטווח של עד כ {0} ימים", ConfigFile.getInstance.VisaExpireDays)), sb.ToString());
            }

            /// <summary>
            /// The method performs the checking with the database if there
            /// are customers that should take their orders withwin number of days
            /// that is defined in OrderDueDate
            /// if yes, it invokes the method which represent the notification
            /// on the screen.
            /// </summary>
            private void checkOrderDate()
            {
                //execture the select command of the database
                String date = String.Format("{0:yyyy-M-d}", DateTime.Now.AddDays(ConfigFile.getInstance.OrderDueDate));
                MySqlCommand command = DataAccessUtils.commandBuilder("SELECT id,name,MIN(O.dueDate) AS date FROM seedsdb.Orders O, seedsdb.Clients C "
                + "WHERE O.dueDate<=@Date AND O.dueDate>=@DateNow AND O.status='0' AND C.id=O.clientId GROUP BY id,name", "@Date", date, "@DateNow", String.Format("{0:yyyy-M-d}", DateTime.Now));
                DataTable res = DatabaseAccess.getResultSetFromDb(command);
                StringBuilder sb = new StringBuilder();
                //check if we have suck kind of orders
                if (res.Rows.Count == 0)
                {
                    return;
                }
                foreach (DataRow row in res.Rows)
                {

                    DateTime time = DateTime.Now.ToLocalTime();
                    long ticks = (((DateTime)row["date"]).Ticks - time.Ticks);
                    if (ticks <= 0)
                    {
                        continue;
                    }
                    TimeSpan duration = TimeSpan.FromTicks(ticks);
                    String str = "ימים";
                    int timespan = duration.Days;
                    if (timespan < 1)
                    {
                        str = "שעות";
                        timespan = duration.Hours;
                    }

                    sb.Append(row["id"] + "  " + row["name"] +" "+" יגיע בעוד כ"+timespan+" "+str+"\n");
                }
                if (sb.ToString().Equals(String.Empty))
                {
                    return;
                }
                //display the notification
                notify.Invoke(notify.displayFunc, (String.Format("הלקוחות הבאים יגיעו לקחת את סחורתם בטווח של עד כ {0} ימים", ConfigFile.getInstance.OrderDueDate)), sb.ToString());
            }
        }
       
        /// <summary>
        /// The workers Thread array. each thread checks different
        /// notification of the Worker class.
        /// </summary>
        private Thread[] controller;
        /// <summary>
        /// thread Worker which deals with the notifications
        /// </summary>
        private Worker threadWorker;

        /// <summary>
        /// flag which tells us if the client asked to terminate 
        /// the routines
        /// </summary>
        private static bool terminate;

        public Routines(seedsFromZion notifyWind)
        {
            //sets the new Worker with the window 
            //of the notifications
            threadWorker = new Worker(notifyWind);
            //the worker thread array, we have 3 notifications
            controller = new Thread[3];
            terminate = false;

        }

        /// <summary>
        /// this method runs the notification checks.
        /// </summary>
        public void checkNotifications()
        {
            //set the notifications handlers, each notification
            //will be checked on different thread
            controller[0] = new Thread(threadWorker.HandleDueDate);
            controller[1] = new Thread(threadWorker.HandleVisa);
            controller[2] = new Thread(threadWorker.HandleUnits);
            //start runing the notifications
            foreach (Thread th in controller)
            {
                th.Start();
            }

        }

        /// <summary>
        /// this method aborts the notification checks. 
        /// it interupts every thread from his work and
        /// tells each one of the to stop.
        /// </summary>
        public void abortChecking()
        {
            terminate = true;
            foreach (Thread th in controller)
            {
                //send an interrupt to each thread
                th.Interrupt();
            }
        }

        /// <summary>
        /// Checks if performing automatic backup is neccessary
        /// returns true if yes , otherwise returns false.
        /// </summary>
        /// <returns></returns>
        public static bool shouldPerformAutomaticBackup()
        {
            DateTime lastBackup = ConfigFile.getInstance.LastAutomaticBackupDate;
            //check that the last backup date + backup frequency is less then todays date
            //if yes return otherwise perform the backup
            if (lastBackup.AddDays(ConfigFile.getInstance.BackupFrequency).CompareTo(DateTime.Now) < 0)
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// performs an automatic backup of the system into 
        /// a zip file , which will be located in the Backups
        /// directory.
        /// The zip file structure is:
        /// Dir : Images Path -> images files.
        /// Dir: Database -> the sql dump file
        /// </summary>
        public static void performAutomaticBackup()
        {
            if (!shouldPerformAutomaticBackup())
            {
                return;
            }
            string executionPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fileName = "Backup_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".zip";
            string backupfileLocation = executionPath + @"\" + ConfigFile.getInstance.BackupPath + @"\" + fileName;
            seedsfromzion.Managers.SystemManager.performBackup(backupfileLocation);
            DateTime time =  DateTime.Now;
            ConfigFile.getInstance.LastAutomaticBackupDate = new DateTime(time.Year, time.Month, time.Day);
        }


        /// <summary>
        /// Checks whenever an optimization should be performed ,
        /// returns true if yes , otherwise false.
        /// </summary>
        /// <returns></returns>
        public static bool shouldPerformOptimization()
        {
            DateTime lastOptimize = ConfigFile.getInstance.LastOptimizationDate;
            //check that the last optimization date date + optimization frequency is less then todays date
            //if yes return otherwise perform the optimization
            if (lastOptimize.AddDays(ConfigFile.getInstance.OptimizingFrequency).CompareTo(DateTime.Now) < 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Performs an optimization on the work hours table ,
        /// moves old record to an archive engine table
        /// </summary>
        public static void performDbOptimization()
        {

            if (!shouldPerformOptimization())
            {
                return;
            }
            DataAccess.DatabaseAccess.optimizeDb(DateTime.Now.Subtract(new TimeSpan(ConfigFile.getInstance.OptimizingFrequency*30,0,0,0)));
            DateTime time = DateTime.Now;
            ConfigFile.getInstance.LastOptimizationDate = new DateTime(time.Year, time.Month, time.Day);
        }
       

    }
}
