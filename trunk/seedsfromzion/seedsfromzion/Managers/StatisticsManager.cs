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
    /// <summary>
    /// This is a static manager which resposible for accordance in all of the statistics forms.
    /// Supply functions of database access - queries, statistics and helper funcions.
    /// </summary>
    class StatisticsManager
    {
        #region public fields
        /// <summary>
        /// This data table will contain plant names filtered with the first letter
        /// of the user input.
        /// </summary>
        static public DataTable plantNames = null;
        /// <summary>
        /// This data table will contain plant type for a specific plant name from
        /// user input.
        /// </summary>
        static public DataTable plantTypes = null;
        #endregion

        #region helper class

        /// <summary>
        /// This is a helper class, responsible for calculations of prediction algorythm.
        /// Is created per each date and changes the value as a new year value is arrived.
        /// </summary>
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

            /// <summary>
            /// Updates the value. The update is an average of values for the same date.
            /// </summary>
            /// <param name="value">The new year value.</param>
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
        
        #region prediction

        /// <summary>
        /// Predicts for dates. This is the encapsulation of the main prediction function.
        /// </summary>
        /// <param name="origArrDate">The orig arr date is the whole array with dates.</param>
        /// <param name="origArrVal">The orig arr val is the whole array with values.</param>
        /// <param name="fromDate">From date - the start date from user input.</param>
        /// <param name="tillDate">The till date - the end date from user input.</param>
        /// <param name="dateArr">The date arr - the referense to the output array with dates.</param>
        /// <param name="valuesArr">The values arr - the rreferense for the output array with values.</param>
        static public void predictForDates(Double[] origArrDate, Double[] origArrVal, DateTimeInput fromDate, DateTimeInput tillDate,
            ref Double[] dateArr, ref Double[] valuesArr)
        {
            if((tillDate.LockUpdateChecked && DateTime.Now.CompareTo(tillDate.Value) < 0))
            {
                makePrediction(origArrDate, origArrVal, fromDate, tillDate,ref dateArr, ref valuesArr);
            }
        }

        /// <summary>
        /// Makes the prediction. This is the main function of the prediction algorythm.
        /// Defines the floorDate and roofDate for the prediction and evaluates the prediction
        /// algorythm for these dates.
        /// </summary>
        /// <param name="origArrDate">The orig arr date is the whole array with dates.</param>
        /// <param name="origArrVal">The orig arr val is the whole array with values.</param>
        /// <param name="from">The start date from user input.</param>
        /// <param name="till">The end date from user input.</param>
        /// <param name="resultDates">The result dates - the referense to the output array with dates.</param>
        /// <param name="resultValues">The result values - the rreferense for the output array with values.</param>
        static private void makePrediction(Double[] origArrDate, Double[] origArrVal, DateTimeInput from, DateTimeInput till,
            ref Double[] resultDates, ref Double[] resultValues)
        {
            DateTime fromDate = from.Value;
            DateTime tillDate = till.Value;
            DateTime roofDate = DateTime.MinValue;
            DateTime floorDate = DateTime.Now.AddMonths(1);
            //if the till date is not specified - no prediction is made.
            if (!till.LockUpdateChecked)
            {
                return;
            }
            //else if the from date is specified
            else if (from.LockUpdateChecked)
            {   //and NOW is less then from date
                if (DateTime.Now.CompareTo(fromDate) < 0 )
                {   //floor date is the start date
                    floorDate = fromDate;
                }
            }
            //else - only till (end) date is specified
            else
            {   //if the till date equals NOW date
                if (DateTime.Now.Year.Equals(tillDate.Year) && DateTime.Now.Month.Equals(tillDate.Month))
                {   //the floor date is the NOW
                    floorDate = tillDate;
                }
            }
            //the roof date for prediction is the till date
            roofDate = tillDate;

            //if the roof date is less or equal to NOW date - no prediction is needed.
            if (roofDate.CompareTo(DateTime.Now) <= 0)
            {
                return;
            }

            //get all the dates to predict
            DateTime[] predictDates = getDatesToPredict(floorDate, roofDate);

            //building the all months history
            Dictionary<int, Dictionary<int, DateMean>> monthYearsHistory = buildMonthYearHistory(origArrDate, origArrVal);

            //set the return array size to be the sum of the past dates and prediction dates number
            int size = predictDates.Length + resultDates.Length;
            Double[] allDates = new Double[size];
            Double[] allValues = new Double[size];
            int success_pred = 0;
            for (int i = 0; i < size; i++)
            {
                //if we have reache the future dates
                if (i >= resultDates.Length)
                {
                    int pred_indx = i - resultDates.Length;
                    //process the prediction for the date
                    double pred_value = proccessPredictionForDate(predictDates[pred_indx], monthYearsHistory);
                    //only if the predicted value is legal (greater then zero)
                    //we accept the prediction
                    if (pred_value > 0)
                    {
                        int curr_indx = i - (pred_indx - success_pred);
                        allDates[curr_indx] = predictDates[pred_indx].ToOADate();
                        allValues[curr_indx] = pred_value;
                        success_pred++;
                    }
                }
                //else - we just copy the arrays 
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

        /// <summary>
        /// Proccesses the prediction for date. Is the function that actually calculates the predicted value.
        /// </summary>
        /// <param name="date">The date for which we predict the value.</param>
        /// <param name="monthYearsHistory">The month years history - the whole history with
        /// average values for the same year and month.</param>
        /// <returns></returns>
        static private double proccessPredictionForDate(DateTime date, Dictionary<int, Dictionary<int, DateMean>> monthYearsHistory)
        {
            int month = date.Month;
            double pred_value = 0;

            Dictionary<int, DateMean> dataForMonth;

            //if the month of the date is in the histoty
            if (monthYearsHistory.ContainsKey(month))
            {
                //get the data for the specific month
                monthYearsHistory.TryGetValue(month, out dataForMonth);
                //get the number of years in history for that month
                int year_num = dataForMonth.Count;
                //calculate the weight (the sum of the year numbers)
                int sum = (1+year_num)*year_num/2;
                //for each year
                for (int i = 0; i < year_num; i++ )
                {   //get the value of that year
                    double value = dataForMonth.ElementAt(i).Value.getValue();
                    //add to the predicted value the weighted value of the specific year
                    pred_value += value * (year_num - i) / sum;
                }
            }
            //else - no data in history for that month
            else
            {
                pred_value = -1;
            }

            return pred_value;
        }

        /// <summary>
        /// Builds the month year history. Actually goes over all the history and acumulates the data for each year+month,
        /// while averaging the values with the same pair of year+month.
        /// </summary>
        /// <param name="resultDates">The result dates - all of the dates.</param>
        /// <param name="resultValues">The result values - all of the values.</param>
        /// <returns></returns>
        static private Dictionary<int, Dictionary<int, DateMean>> buildMonthYearHistory(Double[] resultDates, Double[] resultValues)
        {
            Dictionary<int, Dictionary<int, DateMean>> monthYearsHistory = new Dictionary<int, Dictionary<int, DateMean>>();
            Dictionary<int, DateMean> yearsValues;
            DateMean theDateMeanVal;
            //foreach date
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
                //get the DateMean object for the month
                monthYearsHistory.TryGetValue(month,out yearsValues); 
                //if the specific year is not yet in the history of month
                if (!yearsValues.ContainsKey(year))
                {
                    DateMean dateMean = new DateMean(year);
                    //add the year for this month
                    yearsValues.Add(year, dateMean);
                }
                //get the year object for month
                yearsValues.TryGetValue(year, out theDateMeanVal);
                //update the value for the specific year and month
                theDateMeanVal.updateValue(value);

            }

            return monthYearsHistory;
        }

        /// <summary>
        /// Gets the dates to predict by the from date and till date.
        /// </summary>
        /// <param name="fromDate">From date.</param>
        /// <param name="toDate">To (end) date.</param>
        /// <returns></returns>
        static private DateTime[] getDatesToPredict(DateTime fromDate, DateTime toDate)
        {
            List<DateTime> predictMonths = new List<DateTime>();
            //set the current date to start from the from date
            DateTime currDate = fromDate;
            //if the dates are in the wrong order - nothing to compute
            if (fromDate.CompareTo(toDate) > 0)
            {
                return predictMonths.ToArray();
            }
            //add the current date to the predicted month
            predictMonths.Add(currDate);
            //while the year and the month are not equal to the till (end) date
            while (!(currDate.Year.Equals(toDate.Year) && currDate.Month.Equals(toDate.Month)))
            {
                //add one month
                currDate = currDate.AddMonths(1);
                //add the new prediction date
                predictMonths.Add(currDate);  
            }

            return predictMonths.ToArray();
        }

        #endregion

        #region helper functions
        /// <summary>
        /// Filters the dates and corresponding values, according to the dates inputs from user.
        /// </summary>
        /// <param name="dateArr">The date array, all the dates.</param>
        /// <param name="valArr">The values array, all the values.</param>
        /// <param name="fromDate">From date - input of the user.</param>
        /// <param name="tillDate">The till date - input from the user.</param>
        /// <param name="resultDates">The result dates - return array of filtered dates.</param>
        /// <param name="resultValues">The result values - return array of filtered values.</param>
        static public void filterDates(Double[] dateArr, Double[] valArr, DateTimeInput fromDate, DateTimeInput tillDate,
            out Double[] resultDates, out Double[] resultValues)
        {
            resultDates = (Double[])dateArr.Clone();
            resultValues = (Double[])valArr.Clone();
            //if the both - from date and the till date were not specified - nothing to filter
            if (!fromDate.LockUpdateChecked && !tillDate.LockUpdateChecked)
            {
                return;
            }
            //if no dates - nothing to filter
            if (dateArr.Length.Equals(0))
            {
                return;
            }
            DateTime from = fromDate.Value;
            DateTime till = tillDate.Value;

            ArrayList list = new ArrayList();
            //for each date
            for (int i = 0; i < dateArr.Length; i++)
            {
                DateTime date = DateTime.FromOADate(dateArr[i]);
                //if both of the dates were specified
                if (fromDate.LockUpdateChecked && tillDate.LockUpdateChecked)
                {   //add the date only if it is between the specified dated 
                    if (date.CompareTo(from) >= 0 && date.CompareTo(till) <= 0)
                    {
                        list.Add(i);
                    }
                }
                //else if only from date was specified
                else if (fromDate.LockUpdateChecked)
                {   //add the date only if it greater then the from date
                    if (date.CompareTo(from) >= 0)
                    {
                        list.Add(i);
                    }
                }
                //else - only till date was specified
                else
                {   //add the date only if it is less then till date
                    if (date.CompareTo(till) <= 0)
                    {
                        list.Add(i);
                    }
                }
            }

            //copy the filtered dates to the output arrays
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

        /// <summary>
        /// Resets the graph pane. Clears the pane.
        /// </summary>
        /// <param name="pane">The pane.</param>
        static public void resetGraphPane(GraphPane pane)
        {
            pane.CurveList.Clear();
            pane.GraphObjList.Clear();
        }

        /// <summary>
        /// Inits the plant names. Is used in autocomplete to get the relevant plant names.
        /// </summary>
        /// <param name="likeName">Name of the like.</param>
        /// <returns></returns>
        static public DataRow[] initPlantNames(string likeName)
        {
            DataRow[] rows = null;
            if (likeName.Equals(""))
            {
                plantNames = null;
                return null;
            }
            //if plant names area already loaded
            if (plantNames != null)
            {
                rows = plantNames.Select("name LIKE '" + likeName + "%'");
                //check if the current name is in the loaded names
                if (rows.Length > 0)
                {   //return the selected names
                    return rows;
                }
            }
            //else - load the names starting from the likeName
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT T.name AS name FROM seedsdb.plants T WHERE name LIKE '" + likeName + "%'");
            plantNames = DatabaseAccess.getResultSetFromDb(command);
            rows = plantNames.Select();
            return (rows.Length > 0) ? rows : null;
        }

        /// <summary>
        /// Inits the plant types. Is used in autocomplete of types.
        /// </summary>
        /// <param name="name">The plant name.</param>
        static public void initPlantTypes(string name)
        {
            //just load the types for a specific plant names
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT T.type AS type FROM seedsdb.planttypes T WHERE name = @NAME",
                "@NAME",
                name);
            plantTypes = DatabaseAccess.getResultSetFromDb(command);
        }

        /// <summary>
        /// Rotates the bar lables. Just a helper to see the values horizontaly
        /// </summary>
        /// <param name="pane">The pane.</param>
        static public void rotateBarLables(GraphPane pane)
        {
            Scale sc = pane.YAxis.Scale;
            foreach (Object ob in pane.GraphObjList)
            {
                if (typeof(TextObj).Equals(ob.GetType()))
                {
                    TextObj textObj = ob as TextObj;
                    textObj.FontSpec.Angle = 0;
                    textObj.Location.AlignH = AlignH.Center;
                    textObj.Location.AlignV = AlignV.Bottom;
                }
            }
        }

        /// <summary>
        /// Sorts the correlated data in the two arrays.
        /// </summary>
        /// <param name="dateArr">The date arr.</param>
        /// <param name="valArr">The val arr.</param>
        static public void sortData(ref Double[] dateArr, ref Double[] valArr)
        {
            if (dateArr.Length > 0)
            {
                Array.Sort(dateArr, valArr);
            }
        }
        #endregion

        #region statistics methods

        /// <summary>
        /// Gets the plant name by plant id from the database.
        /// </summary>
        /// <param name="plantId">The plant id.</param>
        /// <returns></returns>
        static public string getNameById(int plantId)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT PT.name AS name FROM seedsdb.planttypes PT WHERE PT.plantId = @PLANT_ID",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            string plantName = (string)result.Rows[0][0];
            return plantName;
        }

        /// <summary>
        /// Gets the plant type by plant id.
        /// </summary>
        /// <param name="plantId">The plant id.</param>
        /// <returns></returns>
        static public string getTypeById(int plantId)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT PT.type AS type FROM seedsdb.planttypes PT WHERE PT.plantId = @PLANT_ID",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            string plantType = (string)result.Rows[0][0];
            return plantType;
        }

        /// <summary>
        /// Gets the sales graph values by plant id. Summarize the values by date (month+year).
        /// </summary>
        /// <param name="plantId">The plant id.</param>
        /// <returns></returns>
        static public DataTable getSalesGraphValues(int plantId)
        {
            MySqlCommand command = 
                DataAccessUtils.commandBuilder("SELECT O.orderDate AS orderDate,SUM(OFS.units) AS units FROM seedsdb.orders O ,seedsdb.ordersfromstorage OFS WHERE O.orderId = OFS.orderId AND OFS.plantId = @PLANT_ID GROUP BY YEAR(orderDate),MONTH(orderDate)",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        /// <summary>
        /// Gets the sales graph values by plant name. Summarize by year+month.
        /// </summary>
        /// <param name="plantName">Name of the plant.</param>
        /// <returns></returns>
        static public DataTable getSalesGraphValues(string plantName)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT O.orderDate AS orderDate,SUM(OFS.units) AS units FROM seedsdb.orders O ,seedsdb.ordersfromstorage OFS WHERE O.orderId = OFS.orderId AND OFS.plantId IN (SELECT PT.plantId FROM planttypes PT WHERE PT.name = @PLANT_NAME) GROUP BY YEAR(orderDate),MONTH(orderDate)",
                                                "@PLANT_NAME", plantName);
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        /// <summary>
        /// Gets the grow via sow graph values by plant id. 
        /// Makes average through whole month (at the specific year).
        /// </summary>
        /// <param name="plantId">The plant id.</param>
        /// <returns></returns>
        static public DataTable getGrowViaSowGraphValues(int plantId)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT SP.sowindDate AS sowingDate, SUM(SP.sproutingPerc)/COUNT(*) AS sproutingPerc FROM sproutedstats SP WHERE sproutingPerc IS NOT NULL AND SP.plantId = @PLANT_ID GROUP BY sowingDate",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        /// <summary>
        /// Gets the grow via sow graph values by plant name.
        /// Makes average through whole month (at the specific year).
        /// </summary>
        /// <param name="plantName">Name of the plant.</param>
        /// <returns></returns>
        static public DataTable getGrowViaSowGraphValues(string plantName)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT SP.sowindDate AS sowingDate, SUM(SP.sproutingPerc)/COUNT(*) AS sproutingPerc FROM sproutedstats SP WHERE sproutingPerc IS NOT NULL AND SP.plantId IN (SELECT PT.plantId FROM planttypes PT WHERE PT.name = @PLANT_NAME) GROUP BY sowingDate",
                                                "@PLANT_NAME", plantName);
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        /// <summary>
        /// Gets the grow via type graph values by plant name.
        /// Makes average through whole month (at the specific year).
        /// </summary>
        /// <param name="plantName">Name of the plant.</param>
        /// <returns></returns>
        static public DataTable getGrowViaTypeGraphValues(string plantName)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT PT.type AS type, SUM(SPS.sproutingPerc)/COUNT(*) AS sproutingPerc FROM planttypes PT, sproutedstats SPS WHERE sproutingPerc IS NOT NULL AND PT.name = @PLANT_NAME AND PT.plantId = SPS.plantId GROUP BY type",
                                                "@PLANT_NAME", plantName);
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        /// <summary>
        /// Gets the grow via fridge graph values by plant id.
        /// Makes average through whole month (at the specific year).
        /// </summary>
        /// <param name="plantId">The plant id.</param>
        /// <returns></returns>
        static public DataTable getGrowViaFridgeGraphValues(int plantId)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT DATEDIFF(SPS.`sowindDate`, SPS.`arrivingDate`) AS fridgeTime, SUM(SPS.sproutingPerc)/COUNT(*) AS sproutingPerc FROM  sproutedstats SPS WHERE sproutingPerc IS NOT NULL AND SPS.plantId = @PLANT_ID GROUP BY fridgeTime",
                                                "@PLANT_ID", plantId.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }

        /// <summary>
        /// Gets the grow via fridge graph values by plant name.
        /// Makes average through whole month (at the specific year).
        /// </summary>
        /// <param name="plantName">Name of the plant.</param>
        /// <returns></returns>
        static public DataTable getGrowViaFridgeGraphValues(string plantName)
        {
            MySqlCommand command =
                DataAccessUtils.commandBuilder("SELECT DATEDIFF(SPS.`sowindDate`, SPS.`arrivingDate`) AS fridgeTime, SUM(SPS.sproutingPerc)/COUNT(*) AS sproutingPerc FROM  sproutedstats SPS WHERE sproutingPerc IS NOT NULL AND SPS.plantId IN (SELECT PT.plantId FROM planttypes PT WHERE PT.name = @PLANT_NAME)  GROUP BY fridgeTime",
                                                "@PLANT_NAME", plantName);
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            return result;
        }


        /// <summary>
        /// Builds the array of specific (S) type from graph data.
        /// </summary>
        /// <typeparam name="T">Source type</typeparam>
        /// <typeparam name="S">Destination type</typeparam>
        /// <param name="dataRowArr">The data row arr.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        static public S[] buildArrayFromGraphData<T, S>(DataRow[] dataRowArr, String columnName)
        {
            S[] array = new S[dataRowArr.Length];
            for (int i = 0; i < dataRowArr.Length; i++)
            {
                Object value = dataRowArr[i][columnName];
                //if the actual type is DateTime - convert through the XDate
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

        /// <summary>
        /// Builds the array from graph data. The encapsulation for the overloaded function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="S"></typeparam>
        /// <param name="dataTable">The data table.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        static public S[] buildArrayFromGraphData<T,S>(DataTable dataTable, String columnName)
        {
            return buildArrayFromGraphData<T,S>(dataTable.Select(), columnName);
        }

        #endregion

    }
}
