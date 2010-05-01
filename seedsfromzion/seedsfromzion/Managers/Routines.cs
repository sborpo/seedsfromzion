using System;
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
            private Form1 notify;

            public Worker(Form1 notify)
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
                //if we didn't ask to terminate
                while (!terminate)
                {
                    checkOrderDate();
                    try
                    {
                        //sleep for a given time
                        Thread.Sleep(new TimeSpan(0, 0, ConfigFile.getInstance.OrderFreq));
                    }
                    catch (ThreadInterruptedException ex)
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
                while (!terminate)
                {
                    try
                    {
                        checkVisaExpirationDate();
                        Thread.Sleep(new TimeSpan(0, 0, ConfigFile.getInstance.VisaFreq));
                    }
                    catch (ThreadInterruptedException ex)
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
                while (!terminate)
                {
                    try
                    {
                        checkUnits();
                        Thread.Sleep(new TimeSpan(0, 0, ConfigFile.getInstance.UnitsFreq));
                    }
                    catch (ThreadInterruptedException ex)
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
                MySqlCommand command = DataAccessUtils.commandBuilder("SELECT P.name,P.type,U.units FROM seedsdb.planttypes P, (SELECT plantId,SUM(units) AS units FROM seedsdb.finishedstorage"+
                " GROUP BY plantId) U WHERE  P.plantId=U.plantId AND U.units<@Units", "@Units", ConfigFile.getInstance.MinUnitsInStorage.ToString());
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
                    sb.Append(String.Format(row["name"] +" מסוג "+row["type"]+"'"+" - "+row["units"]+ " יחידות "));
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
                MySqlCommand command = DataAccessUtils.commandBuilder("SELECT name FROM seedsdb.workers W, seedsdb.workersvisas WS , seedsdb.Visas VS "
                + "WHERE VS.expireDate<@Date AND VS.visaId=WS.visaId AND W.id=WS.workerId", "@Date", date);
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
                    sb.Append((String)row["name"] + "\n");
                }
                //display the notification
                notify.Invoke(notify.displayFunc, (String.Format("הלקוחות הבאים יגיעו לקחת את סחורתם בעוד כ {0} ימים", ConfigFile.getInstance.VisaExpireDays)), sb.ToString());
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
                MySqlCommand command = DataAccessUtils.commandBuilder("SELECT id,name FROM seedsdb.Orders O, seedsdb.Clients C "
                + "WHERE O.dueDate<@Date AND C.id=O.clientId", "@Date", date);
                DataTable res = DatabaseAccess.getResultSetFromDb(command);
                StringBuilder sb = new StringBuilder();
                //check if we have suck kind of orders
                if (res.Rows.Count == 0)
                {
                    return;
                }
                foreach (DataRow row in res.Rows)
                {
                    sb.Append(row["id"] + "  " + row["name"] + "\n");
                }
                //display the notification
                notify.Invoke(notify.displayFunc, (String.Format("הלקוחות הבאים יגיעו לקחת את סחורתם בעוד כ {0} ימים", ConfigFile.getInstance.OrderDueDate)), sb.ToString());
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

        public Routines(Form1 notifyWind)
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
        /// performs an automatic backup of the system into 
        /// a zip file , which will be located in the Backups
        /// directory.
        /// The zip file structure is:
        /// Dir : Images Path -> images files.
        /// Dir: Database -> the sql dump file
        /// </summary>
        public void performAutomaticBackup()
        {
            string executionPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fileName = "Backup_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".zip";
            string backupfileLocation = executionPath + @"\" + ConfigFile.getInstance.BackupPath + @"\" + fileName;
            seedsfromzion.Managers.SystemManager.performBackup(backupfileLocation);
        }

       

    }
}
