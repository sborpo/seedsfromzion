using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using seedsfromzion.DataStructures;
using seedsfromzion.DataAccess;
using seedsfromzion.Managers;
using MySql.Data.MySqlClient;
using System.Data;

namespace seedsfromzion.Managers
{
    class OrderManager
    {
        static int lastOrderId = 1;
        
        #region Public Methods
        /// <summary>
        /// adding a new order to the database.
        /// in case the order already exists, or in case one of the parameters passed to
        /// the function is not leagel there will be no transaction.
        /// also in case the client dose not exist it will be added to the
        /// client database automaticly.
        /// this function asumes that all the amounts in the order are available
        /// in the inventory.
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
                //*******************
                //* TBD !!!!!!!!!!!!*
                //*******************
                //addClientInfo(clientInfo);
            }
            
            //adding the new order into the database:
            MySqlCommand[] addToOrdersFromStorage = new MySqlCommand[orderInfo.plantId.Length + 1];
            int i = 0;
            InventoryManager invManager = new InventoryManager();
            foreach (int p_id in orderInfo.plantId)
            {
             
                //checking that the plant id exist
                if (!(invManager.checkPlantExistsByID(p_id)))
                {
                    throw new ArgumentException("plantId " + p_id.ToString() + " dose not exist");
                }
                //checking that the storage id exists.
                if (!(invManager.checkStorageExistsByID(orderInfo.fromStorageId[i])))
                {
                    throw new ArgumentException("storage " + orderInfo.fromStorageId[i] + " dose not exist");
                }
             

                addToOrdersFromStorage[i] = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.ordersfromstorage " +
                     "VALUES(@P_ORDERID, @P_PLANTID, @P_STORAGEID, @P_UNITS)",
                     "@P_ORDERID", orderInfo.orderId.ToString(),
                     "@P_PLANTID", p_id.ToString(),
                     "@P_STORAGEID", orderInfo.fromStorageId[i],
                     "@P_UNITS", orderInfo.units[i].ToString());
                i++;
            }

            MySqlCommand addToOrders = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.orders" +
                                     " VALUES (@P_ORDERID,@P_CLIENTID,@P_ORDERDATE,@P_DUEDATE,@P_STATUS)",
                                     "@P_ORDERID", orderInfo.orderId.ToString(),
                                     "@P_CLIENTID", clientInfo.clientId.ToString(),
                                     "@P_ORDERDATE",  String.Format("{0:yyyy-M-d}",orderInfo.orderDate),
                                     "@P_DUEDATE",  String.Format("{0:yyyy-M-d}",orderInfo.dueDate),
                                     "@P_STATUS", orderInfo.status.ToString());
            
            //preforming the trasaction:
            addToOrdersFromStorage[orderInfo.plantId.Length] = addToOrders;
            DatabaseAccess.performDMLTransaction(addToOrdersFromStorage);
            //removing the amounts from the storage:

            removeAmountFromStorage(orderInfo);
        }

        public void removeAmountFromStorage(OrderInfo order)
        {
            InventoryManager invManager = new InventoryManager();
            int orderSize = order.plantId.Length;
            for (int i = 0; i < orderSize; i++)
            {
                invManager.removePlantUnits((int)order.plantId[i], order.fromStorageId[i], (double)order.units[i]);
            }
            
        }
        
        public void returnAmountToStorage(OrderInfo order)
        {
            InventoryManager invManager = new InventoryManager();
            int orderSize = order.plantId.Length;
            for (int i = 0; i < orderSize; i++)
            {
                invManager.returnPlantUnits((int)order.plantId[i], order.fromStorageId[i], (double)order.units[i]);
            }
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
                order.orderId = orderId;
                order.orderDate = ((DateTime)ordersResult.Rows[0]["orderDate"]).Date;
                order.dueDate = ((DateTime)ordersResult.Rows[0]["dueDate"]).Date;
                /*******************
                 * TBD!!!!!        *
                 *******************/
                order.status = '0';// (System.Char)ordersResult.Rows[0]["status"];
                order.plantId = new System.UInt32[orderFromStorageResult.Rows.Count];
                order.fromStorageId = new string[orderFromStorageResult.Rows.Count];
                order.units = new double[orderFromStorageResult.Rows.Count];

               
                for (int index = 0; index < orderFromStorageResult.Rows.Count; index++)
                {
                    order.plantId[index] = (System.UInt32)orderFromStorageResult.Rows[index]["plantId"];
                    order.fromStorageId[index] = ((System.UInt32)orderFromStorageResult.Rows[index]["storageId"]).ToString();
                    order.units[index] = (double)orderFromStorageResult.Rows[index]["units"];

                }

                
            }
            return order;
        }

       public void updateOrderInfo(int orderId,  OrderInfo orderInfo, ClientInfo clientInfo)
        {
            if ((checkClientExists(clientInfo.clientId)) && (checkOrderExists(orderInfo.orderId)))
            {
                OrderInfo tmpOrder = findOrder(orderId, clientInfo.clientId);
                try
                {
                    cancelOrder(orderId, clientInfo.clientId);
                    addOrder(clientInfo, orderInfo);
                }
                catch (Exception ex)
                {
                    //if we recieved a problem , rollback and throw execption to user
                    addOrder(clientInfo, tmpOrder);
                    throw ex;
                }
            }
        }

       public void cancelOrder(int orderId, int clientId)
       {
           if (!checkOrderExists(orderId))
           {
               throw new ArgumentException("order doesn't exists");
           }
        
           //returning the units into the storage:
           OrderInfo oldOrder = findOrder(orderId, clientId);
           returnAmountToStorage(oldOrder);

           MySqlCommand[] commandArray = new MySqlCommand[2];
           commandArray[0] = DataAccessUtils.commandBuilder("DELETE FROM seedsdb.orders WHERE orderId=@P_ORDERID",
                                                                "@P_ORDERID", orderId.ToString());
           commandArray[1] = DataAccessUtils.commandBuilder("DELETE FROM seedsdb.ordersfromstorage WHERE orderId=@P_ORDERID",
                                                                "@P_ORDERID", orderId.ToString());
           DatabaseAccess.performDMLTransaction(commandArray);
          
       }
       public int getNextOrderId()
       {
           
           //getting the maximum order id number:
           MySqlCommand orderFromStorageCommand = DataAccessUtils.commandBuilder("SELECT MAX(orderId) As max From seedsdb.orders");
           DataTable orderFromStorageResult = DatabaseAccess.getResultSetFromDb(orderFromStorageCommand);
           if (orderFromStorageResult.Rows.Count == 0)
           {
               return 1;
           }
           DataRow row = orderFromStorageResult.Rows[0];
           System.UInt32 incSize = 1;
           return (int)(((System.UInt32)row[0]) + incSize) ;
           
         
        }

        #endregion

        #region Private Methods

       /// <summary>
       /// is this method really needed???
       /// </summary>
       /// <param name="orderId"></param>
       /// <param name="plantId"></param>
       /// <param name="units"></param>
       /// <param name="fromStorageId"></param>
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
                                     "@P_ID", clientInfo.clientId.ToString(), 
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
        private bool checkOrderExists(int p_orderId)
        {
            return DataAccessUtils.rowExists("SELECT orderId FROM seedsdb.ordersfromstorage WHERE orderId=@p_orderId;", "@p_orderId", p_orderId.ToString());            
        }
        /// <summary>
        /// This method checks if the client id transferd to her already exists
        /// in the orders DataBase.
        /// </summary>
        /// <param name="p_clientId">The id that will be checked in the DataBase</param>
        /// <returns>boolean</returns>
        private bool checkClientExists(int p_clientId)
        {
            return DataAccessUtils.rowExists("SELECT id FROM seedsdb.clients WHERE id=@p_clientId;", "@p_clientId", p_clientId.ToString());            
        }
        #endregion
    }
}
