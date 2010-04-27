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

        public bool addOrder(ClientInfo clientInfo, OrderInfo orderInfo)
        {
            //checking that the client exists
            if (!checkClientExists(clientInfo.clientId))
            {
                return false;
            }
            //checking that here is no other order in the DB with the same orderId
            if (checkOrderExists(orderInfo.orderId))
            {
                return false;
            }
            //adding the new order into the database:
            //TODO: add the new order to the database

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
