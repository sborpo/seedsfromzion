using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Collections;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using seedsfromzion.DataAccess;
using ZedGraph;

namespace seedsfromzion.Managers
{
    class StatisticsManager
    {
        #region public fields
        static public Dictionary<string,string> plantTypes = new Dictionary<string,string>()
        {   
            {"a","סוג א"},
            {"b","סוג ב"},
            {"c","סוג ג"}
        }; 
        #endregion

        #region public methods

        static public DataTable getSalesGraphValues()
        {
            int plantId = 222;//////////////////////CHANGE THIS TO THE PLANT ID FOUND
            MySqlCommand command = 
                DataAccessUtils.commandBuilder("SELECT O.orderDate AS orderDate,SUM(OFS.units) AS units FROM seedsdb.orders O ,seedsdb.ordersfromstorage OFS WHERE O.orderId = OFS.orderId AND OFS.plantId = @PLANT_ID GROUP BY YEAR(orderDate),MONTH(orderDate)",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        static public DataTable getGrowViaSowGraphValues()
        {
            int plantId = 222;//////////////////////CHANGE THIS TO THE PLANT ID FOUND
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT SP.sowindDate AS sowingDate, SP.sproutingPerc AS sproutingPerc FROM sproutedstats SP WHERE SP.plantId = @PLANT_ID",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        static public DataTable getGrowViaTypeGraphValues()
        {
            string plantName = "Kalonit";//////////////////////CHANGE THIS TO THE PLANT ID FOUND
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT PT.type AS type, SUM(SPS.sproutingPerc)/COUNT(*) AS sproutingPerc FROM planttypes PT, sproutedstats SPS WHERE PT.name = @PLANT_NAME AND PT.plantId = SPS.plantId GROUP BY type",
                                                "@PLANT_NAME", plantName);
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        static public DataTable getGrowViaFridgeGraphValues()
        {
            int plantId = 222;//////////////////////CHANGE THIS TO THE PLANT ID FOUND
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT DATEDIFF(SPS.`sowindDate`, SPS.`arrivingDate`) AS fridgeTime, SPS.sproutingPerc AS sproutingPerc FROM  sproutedstats SPS WHERE SPS.plantId = @PLANT_ID",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }


        static public S[] buildArrayFromGraphData<T,S>(DataTable dataTable, String columnName)
        {
            S[] array = new S[dataTable.Rows.Count];
            try
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Object value = dataTable.Rows[i][columnName];
                    
                    if (typeof(T).Equals(typeof(DateTime)))
                    {
                        DateTime date = (DateTime)Convert.ChangeType(value, typeof(DateTime));
                        XDate xDate = new XDate(date);
                        array[i] = (S)Convert.ChangeType((double)xDate, typeof(S));
                    }
                    else
                    {
                       array[i] = (S)Convert.ChangeType(value, typeof(S)); ;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Fuck");
            }

            return array;
        }
        
        #endregion

    }
}
