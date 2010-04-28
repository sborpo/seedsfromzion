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
        public void AddWorker(string p_ID, string p_name)
        {
            if (checkWorkerExists(p_ID))
            {
                throw new ArgumentException("Worker already exists");
            }
            MySqlCommand command = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.workers (id, name, phone, comments) " + 
                "VALUES(@P_ID, @P_NAME, NULL, NULL)", "@P_ID", p_ID, "@P_NAME", p_name);
            DatabaseAccess.performDMLQuery(command);
        }

        public WorkerInfo FindWorker(string p_name)
        {
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT * From seedsdb.workers WHERE name=@P_NAME",
                "@P_NAME", p_name);
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            if (result.Rows.Count )
            {

            }
            
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// checking if a specific worker exists in the DB
        /// </summary>
        /// <param name="p_ID"></param>
        /// <returns></returns>
        private bool checkWorkerExists(string p_ID)
        {
            return DataAccessUtils.rowExists("SELECT id FROM seedsdb.workers WHERE id=@P_ID;", "@P_ID", p_ID);
        }
        #endregion
    }
}
