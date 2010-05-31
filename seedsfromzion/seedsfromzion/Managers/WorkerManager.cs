#region usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using seedsfromzion.DataAccess;
using MySql.Data.MySqlClient;
using seedsfromzion.DataStructures;
using System.Data; 
#endregion

namespace seedsfromzion.Managers
{
    /// <summary>
    /// WorkerManager class is a manager class, which is part of the control layer
    /// responsible of the workers data in the system.
    /// It's main purpose is to handle the connection between the GUI(of the workeres) layer,
    /// and the db(of the workers) layer.
    /// </summary>
    public class WorkerManager
    {
        #region Public Methods

        #region general worker table handling
        /// <summary>
        /// Adding a new worker to the workers table in the DB.
        /// </summary>
        /// <param name="p_ID"></param>
        /// <param name="p_name"></param>
        public void AddWorker(int p_ID, string p_name)
        {
            int zero = 0;

            if (checkWorkerExists(p_ID))
            {
                throw new ArgumentException("Worker already exists");
            }
            MySqlCommand command = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.workers (id, name, phone, comments) " +
                "VALUES(@P_ID, @P_NAME, NULL, NULL)", "@P_ID", p_ID.ToString(), "@P_NAME", p_name);
            DatabaseAccess.performDMLQuery(command);

            //inserting the worker into the payments table, with 0 payments.
            command = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.payments (workerId, advancedPay, postponedPay) " +
                "VALUES(@P_ID, @NULL, @NULL2)", "@P_ID", p_ID.ToString(), "@NULL", zero.ToString(), "@NULL2", zero.ToString());
            DatabaseAccess.performDMLQuery(command);
        }

        /// <summary>
        /// Adding a new worker to the workers table in the DB.
        /// </summary>
        /// <param name="p_ID"></param>
        /// <param name="p_name"></param>
        /// <param name="p_phone"></param>
        /// <param name="p_comments"></param>
        public void AddWorker(int p_ID, string p_name, string p_phone, string p_comments)
        {
            //first add the worker id and name to the DB
            AddWorker(p_ID, p_name);

            //now add worker phone and comments about the worker
            MySqlCommand command = DataAccessUtils.commandBuilder("UPDATE seedsdb.workers " +
                     "SET phone=@P_PHONE, comments=@P_COMMENTS WHERE id=@P_ID",
                     "@P_PHONE", p_phone,
                     "@P_COMMENTS", p_comments,
                     "@P_ID", p_ID.ToString());
            DatabaseAccess.performDMLQuery(command);
        }

        public DataTable FindWorker(string p_name)
        {
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT * From seedsdb.workers WHERE name=@P_NAME",
                "@P_NAME", p_name);
            return DatabaseAccess.getResultSetFromDb(command);
        }

        /// <summary>
        /// returns the workers properties with the specific id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public DataTable FindWorker(int p_id)
        {
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT * From seedsdb.workers WHERE id=@P_ID",
                "@P_ID", p_id.ToString());
            return DatabaseAccess.getResultSetFromDb(command);
        }

        /// <summary>
        /// removes a worker from the data base.
        /// </summary>
        /// <param name="p_id"></param>
        public void RemoveWorker(int p_id)
        {
            if (!checkWorkerExists(p_id))
            {
                return;
            }
            MySqlCommand[] commands = new MySqlCommand[4];
            commands[0] = DataAccessUtils.commandBuilder("DELETE FROM seedsdb.workers WHERE id=@P_ID", "@P_ID",
                p_id.ToString());
            commands[1] = DataAccessUtils.commandBuilder("DELETE FROM seedsdb.workersvisas WHERE workerId=@P_ID", "@P_ID",
                p_id.ToString());
            commands[2] = DataAccessUtils.commandBuilder("DELETE FROM seedsdb.workdays WHERE workerId=@P_ID", "@P_ID",
                p_id.ToString());
            commands[3] = DataAccessUtils.commandBuilder("DELETE FROM seedsdb.payments WHERE workerId=@P_ID", "@P_ID",
                p_id.ToString());
            DatabaseAccess.performDMLTransaction(commands);
        }

        public void GenerateWorkerReport(int p_id) { } 
        #endregion general worker table handling

        #region hours
        /// <summary>
        /// adding working hours to the set of workers.
        /// </summary>
        /// <param name="p_id"></param>
        /// <param name="p_date"></param>
        /// <param name="p_startTime"></param>
        /// <param name="p_endTime"></param>
        public void AddWorkerHours(int[] p_id, DateTime p_date, string p_startTime, string p_endTime) 
        {
            MySqlCommand[] commands = new MySqlCommand[p_id.Length];
            int i = 0;
            //iterating over the workers and adding for each of them the hours
            foreach (int worker in p_id)
            {
                if (!checkWorkerExists(worker))
                {
                    throw new ArgumentException("worker doesn't exists");
                }
                //check if there is already working hours this date
                if (GetWorkerHours(worker, p_date).Rows.Count == 1)
                {
                    commands[i] = DataAccessUtils.commandBuilder("UPDATE seedsdb.workdays " +
                     "SET startTime=@P_STARTTIME, endTime=@P_ENDTIME WHERE workerID=@P_WORKERID AND date=@P_DATE",
                     "@P_STARTTIME", p_startTime,
                     "@P_ENDTIME", p_endTime,
                     "@P_WORKERID", worker.ToString(),
                     "@P_DATE", String.Format("{0:yyyy-M-d}", p_date));
                }
                else
                {
                    commands[i] = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.workdays " +
                         "VALUES(@P_WORKERID, @P_DATE, @P_STARTTIME, @P_ENDTIME)",
                         "@P_WORKERID", worker.ToString(),
                         "@P_DATE", String.Format("{0:yyyy-M-d}", p_date),
                         "@P_STARTTIME", p_startTime,
                         "@P_ENDTIME", p_endTime);
                }
                i++;
            }
            //preforming the trasaction:
            DatabaseAccess.performDMLTransaction(commands);
        }

        /// <summary>
        /// updating the working hours for a set of workers.
        /// </summary>
        /// <param name="p_id"></param>
        /// <param name="p_date"></param>
        /// <param name="p_startTime"></param>
        /// <param name="p_endTime"></param>
        public void UpdateWorkerHours(int[] p_id, DateTime p_date, string p_startTime, string p_endTime) 
        {
            MySqlCommand[] commands = new MySqlCommand[p_id.Length];
            int i = 0;
            //iterating over the workers and adding for each of them the hours
            foreach (int worker in p_id)
            {
                if (!checkWorkerExists(worker))
                {
                    throw new ArgumentException("worker doesn't exists");
                }
                commands[i] = DataAccessUtils.commandBuilder("UPDATE seedsdb.workdays " +
                     "SET starTIme=@P_STARTTIME, endTime=@P_ENDTIME WHERE workerID=@WORKERID AND date=@P_DATE",
                     "@P_STARTTIME", p_startTime,
                     "@P_ENDTIME", p_endTime,
                     "@P_WORKERID", worker.ToString(),
                     "@P_DATE", String.Format("{0:yyyy-M-d}", p_date));
                i++;
            }
            //preforming the trasaction:
            DatabaseAccess.performDMLTransaction(commands);
        }

        /// <summary>
        /// returns the hours the p_id worker workes on p_date
        /// </summary>
        /// <param name="p_id"></param>
        /// <param name="p_date"></param>
        public DataTable GetWorkerHours(int p_id, DateTime p_date)
        {
            if (!this.checkWorkerExists(p_id))
            {
                throw new ArgumentException("worker doesnwt exists");
            }
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT startTime, endTime FROM seedsdb.workdays " +
                "WHERE workerId=@P_ID AND date=@P_DATE",
                "@P_ID", p_id.ToString(),
                "@P_DATE", String.Format("{0:yyyy-M-d}", p_date));
            return DatabaseAccess.getResultSetFromDb(command);
        }

        /// <summary>
        /// returns the hours the p_id worker workes on p_month
        /// </summary>
        /// <param name="p_id"></param>
        /// <param name="p_date"></param>
        public DataTable GetWorkerHoursPerMonth(int p_id, DateTime p_month)
        {
            DateTime nextMonth = new DateTime(p_month.Year, p_month.Month, 1);
            nextMonth = nextMonth.AddMonths(1);

            if (!this.checkWorkerExists(p_id))
            {
                throw new ArgumentException("worker doesnwt exists");
            }
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT date, startTime, endTime FROM seedsdb.workdays " +
                "WHERE workerId=@P_ID AND date>=@P_DATE AND date<@NEXTMONTH",
                "@P_ID", p_id.ToString(),
                "@P_DATE", String.Format("{0:yyyy-M-d}", p_month),
                "@NEXTMONTH", String.Format("{0:yyyy-M-d}", nextMonth));
            return DatabaseAccess.getResultSetFromDb(command);
        }
        #endregion hours

        #region visa
        /// <summary>
        /// adds a new visa to the data base.
        /// </summary>
        /// <param name="p_visaID"></param>
        /// <param name="p_expireDate"></param>
        /// <param name="p_contact"></param>
        public void AddVisa(int p_visaID, DateTime p_expireDate, string p_contact)
        {
            if (checkVisaExists(p_visaID))
            {
                throw new ArgumentException("visa already exists");
            }
            MySqlCommand command = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.visas (visaID, expireDate, contact) " +
                "VALUES(@P_VISAID, @P_EXPIREDATE, @P_CONTACT)",
                "@P_VISAID", p_visaID.ToString(),
                "@P_EXPIREDATE", String.Format("{0:yyyy-M-d}", p_expireDate),
                "@P_CONTACT", p_contact);
            DatabaseAccess.performDMLQuery(command);
        }

        /// <summary>
        /// attachs a worker to a visa.
        /// both worker and visa should firs be in the data base.
        /// </summary>
        /// <param name="p_workerID"></param>
        /// <param name="p_visaId"></param>
        public void AttachWorkerToVisa(int p_workerID, int p_visaID)
        {
            #region parameter validation
            if (!checkWorkerExists(p_workerID))
            {
                throw new ArgumentException("worker doesn't exists");
            }
            if (!checkVisaExists(p_visaID))
            {
                throw new ArgumentException("visa doesn't exists");
            } 
            #endregion

            MySqlCommand command = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.workersvisas (workerid, visaid) " +
                "VALUES(@P_WORKERID, @P_VISAID)", "@P_WORKERID", p_workerID.ToString(), "@P_VISAID", p_visaID.ToString());
            DatabaseAccess.performDMLQuery(command);
        }

        /// <summary>
        /// updates visa's information.
        /// </summary>
        /// <param name="p_visaID"></param>
        /// <param name="p_expireDate"></param>
        /// <param name="p_contact"></param>
        public void UpdateVisa(int p_visaID, DateTime p_expireDate, string p_contact) 
        {
            if (!checkVisaExists(p_visaID))
            {
                throw new ArgumentException("visa doesn't exists");
            }
            MySqlCommand command = DataAccessUtils.commandBuilder("UPDATE seedsdb.visas SET expireDate=@P_EXPIREDATE, contact=@P_CONTACT WHERE visaID=@P_VISAID",
                "@P_EXPIREDATE", String.Format("{0:yyyy-M-d}", p_expireDate),
                "@P_CONTACT", p_contact,
                @"P_VISAID", p_visaID.ToString());
            DatabaseAccess.performDMLQuery(command);

        }

        /// <summary>
        /// removes a visa from the DB
        /// </summary>
        /// <param name="p_visaID"></param>
        public void RemoveVisa(int p_visaID)
        {
            if (!checkVisaExists(p_visaID))
            {
                return;
            }
            MySqlCommand[] commands = new MySqlCommand[2];
            commands[0] = DataAccessUtils.commandBuilder("DELETE FROM seedsdb.visas WHERE visaId=@P_VISAID",
                "@P_VISAID", p_visaID.ToString());
            commands[1] = DataAccessUtils.commandBuilder("DELETE FROM seedsdb.workersvisas WHERE visaId=@P_VISAID",
                "@P_VISAID", p_visaID.ToString());
            DatabaseAccess.performDMLTransaction(commands);
        }
        
        /// <summary>
        /// returns dateTable attached of workers attached to visas
        /// </summary>
        /// <param name="p_visaID"></param>
        /// <returns></returns>
        public DataTable GetWorkersAttachedToVisa(int p_visaID)
        {
            if (!checkVisaExists(p_visaID))
            {
                throw new ArgumentException("visa doesn't exists");
            }
            //getting all the workers id which connected to the visa from the workersvisa table
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT workerid FROM seedsdb.workersvisas WHERE visaid=@P_VISAID",
                @"P_VISAID", p_visaID.ToString());
            DataTable workersID = DatabaseAccess.getResultSetFromDb(command);
            



            return workersID;
        }
        #endregion visa

        #region payments
        /// <summary>
        /// updates the value the advanced payment of the worker.
        /// </summary>
        /// <param name="p_id"></param>
        /// <param name="p_payment"></param>
        public void UpdateAdvancePayment(int p_id, double p_payment) 
        {
            updatePayment(p_id, p_payment, true);
        }

        /// <summary>
        /// updates the value the postponed payment of the worker.
        /// </summary>
        /// <param name="p_id"></param>
        /// <param name="p_payment"></param>
        public void UpdatePostpondedPayment(int p_id, double p_payment) 
        {
            updatePayment(p_id, p_payment, false);
        }
        #endregion payments
        #endregion

        #region Properties
        public DataTable Visas 
        {
            get
            {
                MySqlCommand command = DataAccessUtils.commandBuilder("SELECT * FROM seedsdb.visas");
                return DatabaseAccess.getResultSetFromDb(command);
            }
        }

        public DataTable Workers
        {
            get
            {
                MySqlCommand command = DataAccessUtils.commandBuilder("SELECT * FROM seedsdb.workers");
                return DatabaseAccess.getResultSetFromDb(command);
            }
        }

        public DataTable WorkersWithPayments
        { 
            get 
            {
                MySqlCommand command = DataAccessUtils.commandBuilder("SELECT id, name, advancedPay, postponedPay FROM seedsdb.workers, seedsdb.payments WHERE id=workerid");
                return DatabaseAccess.getResultSetFromDb(command);
            }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// checking if a specific worker exists in the DB
        /// </summary>
        /// <param name="p_ID"></param>
        /// <returns></returns>
        private bool checkWorkerExists(int p_ID)
        {
            return DataAccessUtils.rowExists("SELECT id FROM seedsdb.workers WHERE id=@P_ID;", "@P_ID", p_ID.ToString());
        }

        /// <summary>
        /// checking if a specific visa exists in the DB
        /// </summary>
        /// <param name="p_ID"></param>
        /// <returns></returns>
        private bool checkVisaExists(int p_ID)
        {
            return DataAccessUtils.rowExists("SELECT visaID FROM seedsdb.visas WHERE visaID=@P_ID;", "@P_ID", p_ID.ToString());
        }

        /// <summary>
        /// updates the payments of the worker.
        /// </summary>
        /// <param name="p_id"></param>
        /// <param name="p_payment"></param>
        /// <param name="p_advanced"></param>
        private void updatePayment(int p_id, double p_payment, bool p_advanced)
        {
            if (!checkWorkerExists(p_id))
            {
                throw new ArgumentException("worker doesn't exists");
            }
            string paymentType = "postponedPay";
            if (p_advanced)
            {
                paymentType = "advancedPay";
            }
            MySqlCommand command = DataAccessUtils.commandBuilder("UPDATE seedsdb.payments SET "+paymentType+"=@P_PAYMENT WHERE workerId=@P_ID",
                "@P_PAYMENT", p_payment.ToString(), "@P_ID", p_id.ToString());
            DatabaseAccess.performDMLQuery(command);
        }
        #endregion
    }
}
