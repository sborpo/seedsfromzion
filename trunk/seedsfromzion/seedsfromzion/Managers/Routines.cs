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

namespace seedsfromzion.Managers
{
    public class Routines
    {


        private class Worker
        {


            private Form1 notify;

            public Worker(Form1 notify)
            {
                //notify = new Notification(position);
                //notify.setIcon(ic);
                this.notify = notify;
            }

            public void Close()
            {
                // notify.close();
            }
            public void HandleDueDate()
            {
                while (!terminate)
                {
                    checkOrderDate();
                    try
                    {
                        
                        Thread.Sleep(new TimeSpan(0, 0, ConfigFile.getInstance.OrderFreq));
                    }
                    catch (ThreadInterruptedException ex)
                    {
                        return;
                    }
                }
            }

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

            private void checkUnits()
            {
                MySqlCommand command = DataAccessUtils.commandBuilder("SELECT P.name,P.type,U.units FROM seedsdb.planttypes P, (SELECT plantId,SUM(units) AS units FROM seedsdb.finishedstorage"+
                " GROUP BY plantId) U WHERE  P.plantId=U.plantId AND U.units<@Units", "@Units", ConfigFile.getInstance.MinUnitsInStorage.ToString());
                DataTable res = DatabaseAccess.getResultSetFromDb(command);
                StringBuilder sb = new StringBuilder();
                if (res.Rows.Count == 0)
                {
                    return;
                }
                foreach (DataRow row in res.Rows)
                {
                    sb.Append(String.Format(row["name"] +" מסוג "+row["type"]+"'"+" - "+row["units"]+ " יחידות "));
                }
                notify.Invoke(notify.displayFunc, (String.Format("מצב המלאי עבור הצמחים הבאים ירד מתחת ל {0} יחידות", ConfigFile.getInstance.MinUnitsInStorage)), sb.ToString());
            }


            private void checkVisaExpirationDate()
            {
                String date = String.Format("{0:yyyy-M-d}", DateTime.Now.AddDays(ConfigFile.getInstance.VisaExpireDays));
                MySqlCommand command = DataAccessUtils.commandBuilder("SELECT name FROM seedsdb.workers W, seedsdb.workersvisas WS , seedsdb.Visas VS "
                + "WHERE VS.expireDate<@Date AND VS.visaId=WS.visaId AND W.id=WS.workerId", "@Date", date);
                DataTable res = DatabaseAccess.getResultSetFromDb(command);
                StringBuilder sb = new StringBuilder();
                if (res.Rows.Count == 0)
                {
                    return;
                }
                foreach (DataRow row in res.Rows)
                {
                    sb.Append((String)row["name"] + "\n");
                }
                notify.Invoke(notify.displayFunc, (String.Format("הלקוחות הבאים יגיעו לקחת את סחורתם בעוד כ {0} ימים", ConfigFile.getInstance.VisaExpireDays)), sb.ToString());
            }

            private void checkOrderDate()
            {
                String date = String.Format("{0:yyyy-M-d}", DateTime.Now.AddDays(ConfigFile.getInstance.OrderDueDate));
                MySqlCommand command = DataAccessUtils.commandBuilder("SELECT id,name FROM seedsdb.Orders O, seedsdb.Clients C "
                + "WHERE O.dueDate<@Date AND C.id=O.clientId", "@Date", date);
                DataTable res = DatabaseAccess.getResultSetFromDb(command);
                StringBuilder sb = new StringBuilder();
                if (res.Rows.Count == 0)
                {
                    return;
                }
                foreach (DataRow row in res.Rows)
                {
                    sb.Append(row["id"] + "  " + row["name"] + "\n");
                }
                notify.Invoke(notify.displayFunc, (String.Format("הלקוחות הבאים יגיעו לקחת את סחורתם בעוד כ {0} ימים", ConfigFile.getInstance.OrderDueDate)), sb.ToString());
            }
        }

        private Thread[] controller;
        private Worker threadWorker;
        private static bool terminate;

        public Routines(Form1 notifyWind)
        {
            threadWorker = new Worker(notifyWind);
            //TODO: control number of threads
            controller = new Thread[3];
            terminate = false;

        }

        public void checkNotifications()
        {

            controller[0] = new Thread(threadWorker.HandleDueDate);
            controller[1] = new Thread(threadWorker.HandleVisa);
            controller[2] = new Thread(threadWorker.HandleUnits);
            foreach (Thread th in controller)
            {
                th.Start();
            }

        }

        public void abortChecking()
        {
            foreach (Thread th in controller)
            {
                th.Interrupt();
            }
            terminate = true;


        }
    }
}
