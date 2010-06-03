﻿using System;
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

        #region helper class

        private class DateMean
        {
            double value;
            int count;
            int year;

            public DateMean(int year)
            {
                count = 0;
                this.year = year;
                this.value = 0;
            }

            public void updateValue(double value)
            {
                int saved_count = count;
                count++;
                this.value = (this.value * saved_count + value) / count;
            }

            public double getValue()
            {
                return this.value;
            }
        }

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

        static public void filterDates(Double[] dateArr, Double[] valArr, DateTimeInput fromDate, DateTimeInput tillDate,
            out Double[] resultDates, out Double[] resultValues)
        {
            resultDates = new Double[dateArr.Length];
            resultValues = new Double[dateArr.Length];
            if (!fromDate.LockUpdateChecked && !tillDate.LockUpdateChecked)
            {
                return;
            }
            if (dateArr.Length.Equals(0))
            {
                return;
            }
            DateTime from = fromDate.Value;
            DateTime till = tillDate.Value;
            
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

            //resize the arrays to fit data
            Array.Resize<double>(ref resultDates, list.Count);
            Array.Resize<double>(ref resultValues, list.Count);

        }

        #region prediction

        static public void predictForDates(Double[] origArrDate, Double[] origArrVal, DateTimeInput fromDate, DateTimeInput tillDate,
            ref Double[] dateArr, ref Double[] valuesArr)
        {
            if ((fromDate.LockUpdateChecked && DateTime.Now.CompareTo(tillDate.Value) < 0 ) || (tillDate.LockUpdateChecked && DateTime.Now.CompareTo(fromDate.Value) < 0))
            {
                makePrediction(origArrDate, origArrVal, fromDate, tillDate,ref dateArr, ref valuesArr);
            }
        }

        static private void makePrediction(Double[] origArrDate, Double[] origArrVal, DateTimeInput from, DateTimeInput till,
            ref Double[] resultDates, ref Double[] resultValues)
        {
            DateTime fromDate = from.Value;
            DateTime tillDate = till.Value;
            DateTime roofDate = DateTime.MinValue;
            DateTime floorDate = DateTime.Now.AddMonths(1);
            if (!till.LockUpdateChecked)
            {
                return;
            }
            else if (from.LockUpdateChecked)
            {
                if(DateTime.Now.Year.CompareTo(floorDate.Year) < 0 ||
                   (DateTime.Now.Year.Equals(floorDate.Year) && DateTime.Now.Month.CompareTo(floorDate.Month) < 0) )
                {
                    floorDate = fromDate;
                }
            }
            roofDate = tillDate;

            if (roofDate.CompareTo(DateTime.Now) <= 0)
            {
                return;
            }
            DateTime[] predictDates = getDatesToPredict(floorDate, roofDate);

            Dictionary<int, Dictionary<int, DateMean>> monthYearsHistory = buildMonthYearHistory(origArrDate, origArrVal);

            int size = predictDates.Length + resultDates.Length;
            Double[] allDates = new Double[size];
            Double[] allValues = new Double[size];
            int success_pred = 0;
            for (int i = 0; i < size; i++)
            {
                if (i >= resultDates.Length)
                {
                    int pred_indx = i - resultDates.Length;
                    double pred_value = proccessPredictionForDate(predictDates[pred_indx], monthYearsHistory);
                    if (pred_value > 0)
                    {
                        int curr_indx = i - (pred_indx - success_pred);
                        allDates[curr_indx] = predictDates[pred_indx].ToOADate();
                        allValues[curr_indx] = pred_value;
                        success_pred++;
                    }
                }
                else
                {
                    allDates[i] = resultDates[i];
                    allValues[i] = resultValues[i];
                }
            }
            //resize the arrays to fit data
            int new_size = resultDates.Length + success_pred;
            Array.Resize<double>(ref allDates, new_size);
            Array.Resize<double>(ref allValues, new_size);

            resultDates = allDates;
            resultValues= allValues;

        }

        static private double proccessPredictionForDate(DateTime date, Dictionary<int, Dictionary<int, DateMean>> monthYearsHistory)
        {
            int month = date.Month;
            double pred_value = 0;

            Dictionary<int, DateMean> dataForMonth;

            if (monthYearsHistory.ContainsKey(month))
            {
                monthYearsHistory.TryGetValue(month, out dataForMonth);
                int year_num = dataForMonth.Count;
                int sum = (1+year_num)*year_num/2;

                for (int i = 0; i < year_num; i++ )
                {
                    double value = dataForMonth.ElementAt(i).Value.getValue();
                    pred_value += value * (year_num - i) / sum;
                }
            }
            else
            {
                pred_value = -1;
            }

            return pred_value;
        }

        static private Dictionary<int, Dictionary<int, DateMean>> buildMonthYearHistory(Double[] resultDates, Double[] resultValues)
        {
            Dictionary<int, Dictionary<int, DateMean>> monthYearsHistory = new Dictionary<int, Dictionary<int, DateMean>>();
            Dictionary<int, DateMean> yearsValues;
            DateMean theDateMeanVal;
            for (int i = 0; i < resultDates.Length; i++)
            {
                DateTime date = DateTime.FromOADate(resultDates[i]);
                int month = date.Month;
                int year = date.Year;
                double value = resultValues[i];
                
                //create the key if not exists
                if (!monthYearsHistory.ContainsKey(month))
                {
                    Dictionary<int, DateMean> newDict = new Dictionary<int, DateMean>();
                    monthYearsHistory.Add(month, newDict);
                }

                monthYearsHistory.TryGetValue(month,out yearsValues); 

                if (!yearsValues.ContainsKey(year))
                {
                    DateMean dateMean = new DateMean(year);
                    yearsValues.Add(year, dateMean);
                }

                yearsValues.TryGetValue(year, out theDateMeanVal);

                theDateMeanVal.updateValue(value);

            }

            return monthYearsHistory;
        }

        static private DateTime[] getDatesToPredict(DateTime fromDate, DateTime toDate)
        {
            List<DateTime> predictMonths = new List<DateTime>();
            DateTime currDate = fromDate;

            predictMonths.Add(currDate);
            while (!(currDate.Year.Equals(toDate.Year) && currDate.Month.Equals(toDate.Month)))
            {
                currDate = currDate.AddMonths(1);
                predictMonths.Add(currDate);  
            }

            return predictMonths.ToArray();
        }

        #endregion

        static public void sortData(ref Double[] dateArr, ref Double[] valArr)
        {
            if (dateArr.Length > 0)
            {
                Array.Sort(dateArr, valArr);
            }
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
                DataAccessUtils.commandBuilder("SELECT SP.sowindDate AS sowingDate, SP.sproutingPerc AS sproutingPerc FROM sproutedstats SP WHERE sproutingPerc IS NOT NULL AND SP.plantId = @PLANT_ID",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        static public DataTable getGrowViaSowGraphValues(string plantName)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT SP.sowindDate AS sowingDate, SP.sproutingPerc AS sproutingPerc FROM sproutedstats SP WHERE sproutingPerc IS NOT NULL AND SP.plantId IN (SELECT PT.plantId FROM planttypes PT WHERE PT.name = @PLANT_NAME)",
                                                "@PLANT_NAME", plantName);
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        static public DataTable getGrowViaTypeGraphValues(string plantName)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT PT.type AS type, SUM(SPS.sproutingPerc)/COUNT(*) AS sproutingPerc FROM planttypes PT, sproutedstats SPS WHERE sproutingPerc IS NOT NULL AND PT.name = @PLANT_NAME AND PT.plantId = SPS.plantId GROUP BY type",
                                                "@PLANT_NAME", plantName);
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        static public DataTable getGrowViaFridgeGraphValues(int plantId)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT DATEDIFF(SPS.`sowindDate`, SPS.`arrivingDate`) AS fridgeTime, SPS.sproutingPerc AS sproutingPerc FROM  sproutedstats SPS WHERE sproutingPerc IS NOT NULL AND SPS.plantId = @PLANT_ID",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        static public DataTable getGrowViaFridgeGraphValues(string plantName)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT DATEDIFF(SPS.`sowindDate`, SPS.`arrivingDate`) AS fridgeTime, SPS.sproutingPerc AS sproutingPerc FROM  sproutedstats SPS WHERE sproutingPerc IS NOT NULL AND SPS.plantId IN (SELECT PT.plantId FROM planttypes PT WHERE PT.name = @PLANT_NAME)",
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
