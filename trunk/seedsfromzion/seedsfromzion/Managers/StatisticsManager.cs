using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Collections;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using DevComponents.Editors.DateTimeAdv;
using seedsfromzion.DataAccess;
using ZedGraph;

namespace seedsfromzion.Managers
{
    class StatisticsManager
    {
        #region public fields
        static public DataTable plantNames;
        static public DataTable plantTypes;
        //static public Dictionary<string,string> plantTypes = new Dictionary<string,string>()
        //{   
        //    {"a","סוג א"},
        //    {"b","סוג ב"},
        //    {"c","סוג ג"}
        //}; 
        #endregion

        #region public global methods

        static public void initPlantNames()
        {
            //plantNames = getWholeColumnFromTable("plants", "name");
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT T.name AS name FROM seedsdb.plants T ");
            plantNames = DatabaseAccess.getResultSetFromDb(command);
        }

        static public void initPlantTypes()
        {
            //plantTypes = getWholeColumnFromTable("planttypes", "type");
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT T.name AS name, T.type AS type FROM seedsdb.planttypes T ");
            plantTypes = DatabaseAccess.getResultSetFromDb(command);
        }

        //static public DataTable getWholeColumnFromTable(string tableName, string columnName)
        //{
        //    MySqlCommand command =
        //        DataAccessUtils.commandBuilder("SELECT T.@COLUMN_NAME1 AS @COLUMN_NAME2 FROM seedsdb.@TABLE_NAME T ",
        //                                        "@COLUMN_NAME1", columnName, "@COLUMN_NAME2", columnName, "@TABLE_NAME", tableName);
        //    DataTable result = DatabaseAccess.getResultSetFromDb(command);
        //    return result;
        //}
        static public void rotateBarLables(GraphPane pane)
        {
            Scale sc = pane.YAxis.Scale;
            //Double offset = (sc.Max - sc.Min) * 0.5;
            foreach(Object ob in pane.GraphObjList)
            {
                if(typeof(TextObj).Equals(ob.GetType()))
                {
                    TextObj textObj = ob as TextObj;
                    textObj.FontSpec.Angle = 0;
                    //textObj.Location.Y += offset;
                    textObj.Location.AlignH = AlignH.Center;
                    textObj.Location.AlignV = AlignV.Bottom;
                }
            }
        }

        static public void filterDates(ref Double[] dateArr,ref Double[] valArr, DateTimeInput fromDate, DateTimeInput tillDate)
        {
            if (!fromDate.LockUpdateChecked && !tillDate.LockUpdateChecked)
            {
                return;
            }
            DateTime from = fromDate.Value;
            DateTime till = tillDate.Value;
            Double[] resultDates = new Double[dateArr.Length];
            Double[] resultValues = new Double[dateArr.Length];
            ArrayList list = new ArrayList();
            for (int i = 0; i < dateArr.Length; i++)
            {
                DateTime date = DateTime.FromOADate(dateArr[i]);
                if (date.CompareTo(from) >= 0)
                {
                    if (tillDate.LockUpdateChecked)
                    {
                        if (date.CompareTo(till) <= 0)
                        {
                            list.Add(i);
                        }
                    }
                    else 
                    {
                        list.Add(i);
                    }
                }
            }

            int[] indexes = (int[])list.ToArray(typeof(int));
            for (int i = 0; i < indexes.Length; i++)
            {
                resultDates[i] = dateArr[indexes[i]];
                resultValues[i] = valArr[indexes[i]];
            }

            Array.Resize<double>(ref resultDates, list.Count);
            Array.Resize<double>(ref resultValues, list.Count);
            dateArr = resultDates;
            valArr = resultValues;
            
        }

        static public void sortData(ref Double[] dateArr, ref Double[] valArr)
        {
            Double[] resultDates = dateArr;
            Double[] resultValues = valArr;
            
            Array.Sort(dateArr,valArr);
        }

        static public string getNameById(int plantId)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT PT.name AS name FROM seedsdb.planttypes PT WHERE PT.plantId = @PLANT_ID",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            string plantName = (string)result.Rows[0][0];
            return plantName;
        }

        static public string getTypeById(int plantId)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT PT.type AS type FROM seedsdb.planttypes PT WHERE PT.plantId = @PLANT_ID",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            string plantType = (string)result.Rows[0][0];
            return plantType;
        }
        #endregion


        #region statistics methods
        static public DataTable getSalesGraphValues(int plantId)
        {
            MySqlCommand command = 
                DataAccessUtils.commandBuilder("SELECT O.orderDate AS orderDate,SUM(OFS.units) AS units FROM seedsdb.orders O ,seedsdb.ordersfromstorage OFS WHERE O.orderId = OFS.orderId AND OFS.plantId = @PLANT_ID GROUP BY YEAR(orderDate),MONTH(orderDate)",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        static public DataTable getSalesGraphValues(string plantName)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT O.orderDate AS orderDate,SUM(OFS.units) AS units FROM seedsdb.orders O ,seedsdb.ordersfromstorage OFS WHERE O.orderId = OFS.orderId AND OFS.plantId IN (SELECT PT.plantId FROM planttypes PT WHERE PT.name = @PLANT_NAME) GROUP BY YEAR(orderDate),MONTH(orderDate)",
                                                "@PLANT_NAME", plantName);
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        static public DataTable getGrowViaSowGraphValues(int plantId)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT SP.sowindDate AS sowingDate, SP.sproutingPerc AS sproutingPerc FROM sproutedstats SP WHERE SP.plantId = @PLANT_ID",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        static public DataTable getGrowViaSowGraphValues(string plantName)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT SP.sowindDate AS sowingDate, SP.sproutingPerc AS sproutingPerc FROM sproutedstats SP WHERE SP.plantId IN (SELECT PT.plantId FROM planttypes PT WHERE PT.name = @PLANT_NAME)",
                                                "@PLANT_NAME", plantName);
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        static public DataTable getGrowViaTypeGraphValues(string plantName)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT PT.type AS type, SUM(SPS.sproutingPerc)/COUNT(*) AS sproutingPerc FROM planttypes PT, sproutedstats SPS WHERE PT.name = @PLANT_NAME AND PT.plantId = SPS.plantId GROUP BY type",
                                                "@PLANT_NAME", plantName);
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        static public DataTable getGrowViaFridgeGraphValues(int plantId)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT DATEDIFF(SPS.`sowindDate`, SPS.`arrivingDate`) AS fridgeTime, SPS.sproutingPerc AS sproutingPerc FROM  sproutedstats SPS WHERE SPS.plantId = @PLANT_ID",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        static public DataTable getGrowViaFridgeGraphValues(string plantName)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT DATEDIFF(SPS.`sowindDate`, SPS.`arrivingDate`) AS fridgeTime, SPS.sproutingPerc AS sproutingPerc FROM  sproutedstats SPS WHERE SPS.plantId IN (SELECT PT.plantId FROM planttypes PT WHERE PT.name = @PLANT_NAME)",
                                                "@PLANT_NAME", plantName);
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }


        static public S[] buildArrayFromGraphData<T, S>(DataRow[] dataRowArr, String columnName)
        {
            S[] array = new S[dataRowArr.Length];
            for (int i = 0; i < dataRowArr.Length; i++)
            {
                Object value = dataRowArr[i][columnName];

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
            

            return array;
        }

        static public S[] buildArrayFromGraphData<T,S>(DataTable dataTable, String columnName)
        {
            return buildArrayFromGraphData<T,S>(dataTable.Select(), columnName);
        }

        #endregion

    }
}
