using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using seedsfromzion.DataAccess;

namespace seedsfromzion.Managers
{
    public class WorkerManager
    {
        #region Public Methods

        public void AddWorker(int p_ID, string p_name) 
        {
            if (checkWorkerExists(p_ID))
            {
                throw new ArgumentException("Worker already exists");
            }

        }

        public void FindWorker(string p_name) { }

        #endregion

        #region Private Methods
        private bool checkWorkerExists(int p_ID)
        {
            return DataAccessUtils.rowExists("SELECT workerid FROM seedsdb.workers WHERE workerid=@P_ID;", p_ID);
        }
        #endregion
    }
}
