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

        public void RemoveWorker(int p_id) { }

        public void GenerateWorkerReport(int p_id) { }

        #region hours
        public void AddWorkerHours(int[] p_id, DateTime p_date, string p_startTime, string p_endTime) { }
        public void UpdateWorkerHours(int[] p_id, DateTime p_date, string p_startTime, string p_endTime) { }
        #endregion hours

        #region visa
        public void AddVisa(string p_cisaInfo) { }
        public void AttachWorkerToVisa(int p_workerID, int p_visaId) { }
        public void UpdateVisa(int p_visaID, string p_visaInfo) { }
        #endregion visa

        #region payments
        public void UpdateAdvancePayment(int p_id, double p_payment) { }
        public void UpdatePostpondedPayment(int p_id, double p_payment) { }
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
        #endregion
    }
}
