using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using seedsfromzion.DataStructures;
using seedsfromzion.DataAccess;
using MySql.Data.MySqlClient;
using System.Data;

namespace seedsfromzion.Managers
{
    class OrderManager
    {
        #region Public Methods
        /// <summary>
        /// adding a new order to the database.
        /// in case the order already exists, or in case one of the parameters passed to
        /// the function is not leagel there will be no transaction.
        /// also in case the client dose not exist it will be added to the
        /// client database automaticly.
        /// </summary>
        /// <param name="clientInfo">the information of the buyer</param>
        /// <param name="orderInfo">the order information</param>
        public void addOrder(ClientInfo clientInfo, OrderInfo orderInfo)
        {
            //checking that here is no other order in the DB with the same orderId
            if (checkOrderExists(orderInfo.orderId))
            {
                throw new ArgumentException("Order already exists");
            }
            //checking that if client exists
            if (!checkClientExists(clientInfo.clientId))
            {
                //in case it dose not exist, adding it to the clients DataBase
                addClientInfo(clientInfo);
            }
            
            //adding the new order into the database:
            MySqlCommand[] addToOrdersFromStorage = new MySqlCommand[orderInfo.plantId.Length];
            int i = 0;
            foreach (string p_id in orderInfo.plantId)
            {
                //TODO: check that the plant id exist - Roee
                //TODO: check that the storage id exists.
                addToOrdersFromStorage[i] = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.ordersfromstorage " +
                     "VALUES(@P_ORDERID, @P_PLANTID, @P_STORAGEID, @P_UNITS)",
                     "@P_ORDERID", orderInfo.orderId,
                     "@P_PLANTID", p_id,
                     "@P_STORAGEID", orderInfo.fromStorageId[i],
                     "@P_UNITS", orderInfo.units[i].ToString());
                i++;
            }

            MySqlCommand addToOrders = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.orders" +
                                     " VALUES (@P_ORDERID,@P_CLIENTID,@P_ORDERDATE,@P_DUEDATE,@P_STATUS)",
                                     "@P_ORDERID", orderInfo.orderId,
                                     "@P_CLIENTID", clientInfo.clientId,
                                     "@P_ORDERDATE",  String.Format("{0:yyyy-M-d}",orderInfo.orderDate),
                                     "@P_DUEDATE",  String.Format("{0:yyyy-M-d}",orderInfo.dueDate),
                                     "@P_STATUS", orderInfo.status.ToString());
            
            //preforming the trasaction:
            DatabaseAccess.performDMLTransaction(addToOrdersFromStorage);
            DatabaseAccess.performDMLQuery(addToOrders);

        }

        public OrderInfo findOrder(int orderId, int clientId) 
        {
            //getting the information from the storage DataBase:
            MySqlCommand orderFromStorageCommand = DataAccessUtils.commandBuilder("SELECT * From seedsdb.ordersfromstorage WHERE orderId=@P_ORDERID",
                "@P_ORDERID", orderId.ToString());
            DataTable orderFromStorageResult = DatabaseAccess.getResultSetFromDb(orderFromStorageCommand);
            
            //getting the information from the orders DataBase:
            MySqlCommand ordersCommand = DataAccessUtils.commandBuilder("SELECT * From seedsdb.orders WHERE orderId=@P_ORDERID AND clientId=@P_CLIENTID",
               "@P_ORDERID", orderId.ToString(),
               "@P_CLIENTID", clientId.ToString());
            DataTable ordersResult = DatabaseAccess.getResultSetFromDb(ordersCommand);

            OrderInfo order = new OrderInfo();
            if ((orderFromStorageResult.Rows.Count >= 1) && (ordersResult.Rows.Count >= 1))
            {
                order.orderId = orderId.ToString();
                order.orderDate = DateTime.Parse((string)ordersResult.Rows[0]["orderDate"]).Date;
                order.dueDate = DateTime.Parse((string)ordersResult.Rows[0]["dueDate"]).Date;
                order.status = (char)ordersResult.Rows[0]["status"];
                order.plantId = new string[orderFromStorageResult.Rows.Count];
                order.fromStorageId = new string[orderFromStorageResult.Rows.Count];
                order.units = new double[orderFromStorageResult.Rows.Count];

               
                for (int index = 0; index < orderFromStorageResult.Rows.Count; index++)
                {
                    order.plantId[index] = (string)orderFromStorageResult.Rows[index]["plantId"];
                    order.fromStorageId[index] = (string)orderFromStorageResult.Rows[index]["fromStorageId"];
                    order.units[index] = (double)orderFromStorageResult.Rows[index]["units"];

                }

                
            }
            return order;
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
        /// <summary>
        /// This method adds a new client to the clients DataBase.
        /// this method asumes that the client dose not exist already in the DataBase
        /// </summary>
        /// <param name="clientInfo">The details of the client the will be added to the DataBase</param>
       private void addClientInfo(ClientInfo clientInfo)
       {
           MySqlCommand command = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.clients" +
                                     " VALUES (@P_ID,@PNAME,@P_PHONE,@P_EMAIL)", 
                                     "@P_ID", clientInfo.clientId, 
                                     "@P_NAME", clientInfo.name, 
                                     "@P_PHONE", clientInfo.phoneNumber, 
                                     "@P_EMAIL", clientInfo.email);
                                                                 
                                                                 
                                                                 
            DatabaseAccess.performDMLQuery(command);

           
       }
        /// <summary>
        /// This method checks if the order id transferd to her already exists
        /// in the orders DataBase.
        /// </summary>
        /// <param name="p_orderId">The id that will be checked in the DataBase</param>
        /// <returns>boolean</returns>
        private bool checkOrderExists(string p_orderId)
        {
            return DataAccessUtils.rowExists("SELECT id FROM seedsdb.ordersfromstorage WHERE orderId=@p_orderId;", "@p_orderId", p_orderId);            
        }
        /// <summary>
        /// This method checks if the client id transferd to her already exists
        /// in the orders DataBase.
        /// </summary>
        /// <param name="p_clientId">The id that will be checked in the DataBase</param>
        /// <returns>boolean</returns>
        private bool checkClientExists(string p_clientId)
        {
            return DataAccessUtils.rowExists("SELECT id FROM seedsdb.ordersfromstorage WHERE clientId=@p_clientId;", "@p_clientId", p_clientId);            
        }
        #endregion
    }
}
