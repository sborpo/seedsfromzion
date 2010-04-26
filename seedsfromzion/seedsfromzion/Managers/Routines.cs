using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using seedsfromzion.DataAccess;
using MySql.Data.MySqlClient;
using System.Data;

namespace seedsfromzion.Managers
{
    public static class Routines
    {
        private static Notification notify;
        private static BackgroundWorker notificationsThread;

        static Routines()
        {
            notify = new Notification(null);
            InitializeBackgroundWorker();
        }

        private static void InitializeBackgroundWorker()

        {
            notificationsThread.WorkerReportsProgress = false;
            notificationsThread.WorkerSupportsCancellation = true;
            notificationsThread.DoWork += new DoWorkEventHandler(notificationCheck);
        }

        static void notificationCheck(object sender, DoWorkEventArgs e)
        {
            while (!notificationsThread.CancellationPending)
            {
                checkVisaExpirationDate();

            }
            
        }

        private static void checkVisaExpirationDate()
        {
            String date=String.Format("{0:yyyy-M-d}", DateTime.Now.AddDays(ConfigFile.getInstance.VisaExpireDays)); 
            DataAccessUtils.commandBuilder("SELECT name FROM seedsdb.workers W, seedsdb.workersvisas WS , seedsdb.Visas VS"
            +"WHERE VS.expireDate<@Date AND VS.visaId=WS.visaId AND W.id=VS.visaId","@Date",date);
            DataTable res= getResultSetFromDb(command);
            StringBuilder sb = new StringBuilder();
            if (res.Rows.Count != 0)
            {
                foreach (DataRow row in res.Rows)
                {

                    sb.Append((String)row["name"] + "\n");
                }
            }
            notify.showNotification("לעובדים הבאים תגמר אשרת העבודה תוך 3 ימים",sb.ToString());
           
        }

        public void checkNotifications()
        {
        }
        public void abortChecking()
        {
            notificationsThread.CancelAsync();
           
        }
    }
}
