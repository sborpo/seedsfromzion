using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using seedsfromzion.DataAccess;
using ZedGraph;

namespace seedsfromzion.Managers
{
    class StatisticsManager
    {
        //#region private methods
        //#endregion

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
            int plantId = 222;//////////////////////CHANGE THIS TO THE PLANT ID FOUND
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT SP.sowindDate AS sowingDate, SP.sproutingPerc AS sproutingPerc FROM sproutedstats SP WHERE SP.plantId = @PLANT_ID",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        static public DataTable getGrowViaFridgeGraphValues()
        {
            int plantId = 222;//////////////////////CHANGE THIS TO THE PLANT ID FOUND
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT SP.sowindDate AS sowingDate, SP.sproutingPerc AS sproutingPerc FROM sproutedstats SP WHERE SP.plantId = @PLANT_ID",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        static public PointPairList buildPairListFromGraphData<X, Y>(DataTable dataTable, String xColumnName, String yColumnName)
        {
            PointPairList list = new PointPairList();
            try
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Object xValue = dataTable.Rows[i][xColumnName];
                    Y yValue = (Y)dataTable.Rows[i][yColumnName];
                    double doubleYvalue = (double)TypeDescriptor.GetConverter(typeof(Y)).ConvertTo(yValue, typeof(double));
                    if (typeof(X).Equals(typeof(DateTime)))
                    {
                        DateTime date = (DateTime)Convert.ChangeType(xValue, typeof(DateTime));
                        XDate xDate = new XDate(date);
                        list.Add((double)xDate, (double)doubleYvalue);
                    }
                    else
                    {
                        double doubleXvalue = (double)TypeDescriptor.GetConverter(typeof(X)).ConvertTo(xValue, typeof(double));
                        list.Add((double)doubleXvalue, (double)doubleYvalue);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Fuck");
            }

            return list;
        }

        #endregion

    }
}
