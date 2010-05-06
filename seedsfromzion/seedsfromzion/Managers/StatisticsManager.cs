using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

using seedsfromzion.DataAccess;


namespace seedsfromzion.Managers
{
    class StatisticsManager
    {
        #region private methods
        #endregion

        #region public methods

        public static DataTable getSalesGraphValues()
        {
            Int32 plantId = 222;
            MySqlCommand command = 
                DataAccessUtils.commandBuilder("SELECT O.orderDate AS orderDate,SUM(OFS.units) AS units FROM seedsdb.orders O ,seedsdb.ordersfromstorage OFS WHERE O.orderId = OFS.orderId AND OFS.plantId = @PLANT_ID GROUP BY YEAR(orderDate),MONTH(orderDate)",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }
        
        #endregion

    }
}
