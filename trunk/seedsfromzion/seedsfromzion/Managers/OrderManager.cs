using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seedsfromzion.Managers
{
    class OrderManager
    {
        #region Public Methods

        public void AddOrder(int p_ID, string p_name)
        {
            if (checkWorkerExists(p_ID))
            {
                //TODO: write to log, or throw an exception
                return;
            }
        }

        public void FindWorker(string p_name) { }

        #endregion

        #region Private Methods
        private bool checkWorkerExists(int p_ID)
        {
            //TODO
            return false;
        }
        #endregion
    }
}
