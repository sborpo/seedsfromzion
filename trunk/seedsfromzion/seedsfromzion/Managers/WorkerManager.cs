using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using seedsfromzion.DataAccess;
using MySql.Data.MySqlClient;

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
        }

        public void FindWorker(string p_name) { }

        #endregion

        #region Private Methods
        private bool checkWorkerExists(int p_ID)
        {
            return DataAccessUtils.rowExists("SELECT id FROM seedsdb.workers WHERE id=@P_ID;", "@P_ID", p_ID.ToString());
        }
        #endregion
    }
}
