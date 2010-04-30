using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using seedsfromzion.DataAccess;
using MySql.Data.MySqlClient;
using seedsfromzion.DataStructures;
using System.Data;

namespace seedsfromzion.Managers
{
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
            if (checkWorkerExists(p_ID))
            {
                throw new ArgumentException("Worker already exists");
            }
            MySqlCommand command = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.workers (id, name, phone, comments) " +
                "VALUES(@P_ID, @P_NAME, NULL, NULL)", "@P_ID", p_ID.ToString(), "@P_NAME", p_name);
            DatabaseAccess.performDMLQuery(command);
        }

        public WorkerInfo FindWorker(string p_name)
        {
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT * From seedsdb.workers WHERE name=@P_NAME",
                "@P_NAME", p_name);
            DataTable result = DatabaseAccess.getResultSetFromDb(command);

            WorkerInfo worker = new WorkerInfo();
            if (result.Rows.Count == 1)
            {
                worker.ID = (string)result.Rows[0]["id"];
                worker.Name = (string)result.Rows[0]["name"];
                worker.Phone = (string)result.Rows[0]["phone"];
                worker.Comments = (string)result.Rows[0]["comments"];
                return worker;
            }
            /// TODO: consider what to do whan exists more than one worker with the same name.
            return worker;
        }

        /// <summary>
        /// removes a worker from the data base.
        /// </summary>
        /// <param name="p_id"></param>
        public void RemoveWorker(int p_id)
        {
            if (!checkWorkerExists(p_id))
            {
                throw new ArgumentException("worker doesn't exists");
            }
            MySqlCommand command = DataAccessUtils.commandBuilder("DELETE FROM seedsdb.workers WHERE id=@P_ID", "@P_ID",
                p_id.ToString());
            DatabaseAccess.performDMLQuery(command);
            ///TODO: consider to remove the worker from all the tabels of the DB, or not delete it at all.
        }

        public void GenerateWorkerReport(int p_id) { } 
        #endregion general worker table handling

        #region hours
        public void AddWorkerHours(int[] p_id, DateTime p_date, string p_startTime, string p_endTime) { }
        public void UpdateWorkerHours(int[] p_id, DateTime p_date, string p_startTime, string p_endTime) { }
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
            return DataAccessUtils.rowExists("SELECT id FROM seedsdb.visas WHERE visaID=@P_ID;", "@P_ID", p_ID.ToString());
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
            MySqlCommand command = DataAccessUtils.commandBuilder("UPDATE seedsdb.payments SET "+paymentType+"=@P_PAYMENT WHERE id=@PID",
                "@P_PAYMENT", p_payment.ToString(), "@P_ID", p_id.ToString());
            DatabaseAccess.performDMLQuery(command);
        }
        #endregion
    }
}
