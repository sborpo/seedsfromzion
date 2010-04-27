using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using seedsfromzion.DataStructures;

namespace seedsfromzion.Managers
{
    class OrderManager
    {
        #region Public Methods

        public void addOrder(ClientInfo clientInfo, OrderInfo orderInfo)
        {
            if (checkClientExists(clientInfo.clientId))
            {
                //TODO: write to log, or throw an exception
                return;
            }
        }

        public OrderInfo findOrder(int orderId, int clientId) 
        {
            return;
        }

       public void updateOrderInfo(int orderId,  OrderInfo orderInfo, ClientInfo clientInfo)
        {
            return;
        }

       public void cancelOrder(int orderId)
       {
           return;
       }

        #endregion

        #region Private Methods

       private void addOrderInfo(int orderId, int[] plantId, double[] units, String[] fromStorageId)
       {
           return;
       }

       private void addClientInfo(int clientId, String phone, String email)
       {
           return;
       }

        private bool checkOrderExists(int orderId)
        {
            //TODO
            return false;
        }

        private bool checkClientExists(int clientId)
        {
           //TODO
           return false;
        }
        #endregion
    }
}
