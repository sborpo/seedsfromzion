using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using seedsfromzion.DataAccess;
using MySql.Data.MySqlClient;
using seedsfromzion.DataStructures;
using System.Data; 

namespace seedsfromzion.Managers
{
    public class InventoryManager
    {
        #region Public Methods

        /// <summary>
        /// Add new plant to the Plants table in the DB.
        /// </summary>
        /// <param name="p_name"></param>
        /// <param name="p_type"></param>
        /// <param name="p_pic"></param>
        /// <param name="p_price"></param>
        /// <param name="p_lifetime"></param>
        public void AddPlant(string p_name, string p_type, string p_pic, int p_price, int p_lifetime)
        {
            MySqlCommand[] commands = new MySqlCommand[2];
            if (checkPlantExists(p_name))
                throw new ArgumentException("Plant already exists");
            commands[0] = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.Plants (name, foreignName, pic, comments, unitType, countInUnit) " +
                "VALUES(@P_NAME, NULL, @P_PIC, NULL, NULL, NULL)", "@P_NAME", p_name, "@P_PIC", p_pic);
            commands[1] = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.PlantTypes (type, name, lifetime, price, plantId) " +
                "VALUES(@P_TYPE, @P_NAME, @P_LIFETIME, P_PRICE, NULL)", "@P_TYPE", p_type, "@P_NAME", p_name, "@P_LIFETIME", p_lifetime.ToString(), "@P_PRICE", p_price.ToString());
            DatabaseAccess.performDMLTransaction(commands);
        }

        /// <summary>
        /// Finds plant according to the given name.
        /// </summary>
        /// <param name="p_name"></param>
        public PlantInfo FindPlant(string p_name)
        {
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT * FROM seedsdb.Plants WHERE name=@P_NAME",
                "@P_NAME", p_name);
            DataTable result = DatabaseAccess.getResultSetFromDb(command);

            if (result.Rows.Count == 0)
                throw new ArgumentException("Plant doesn't exists");

            PlantInfo plant = new PlantInfo();

            plant.Name = (string)result.Rows[0]["name"];
            plant.ForeignName = (string)result.Rows[0]["foreignName"];
            plant.Picture = (string)result.Rows[0]["picture"];
            plant.Comments = (string)result.Rows[0]["comments"];
            plant.UnitType = (char)result.Rows[0]["unitType"];
            plant.CountInUnit = (int)result.Rows[0]["countInUnit"];
            return plant;
        }

        /// <summary>
        /// Finds plant according to the given name and type.
        /// </summary>
        /// <param name="p_name"></param>
        public int FindPlant(string p_name, char p_type)
        {
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT plantId FROM seedsdb.PlantTypes WHERE name=@P_NAME AND type=@P_TYPE",
                "@P_NAME", p_name, "@P_TYPE", p_type.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);

            if (result.Rows.Count == 0)
                return null;

            int id = (int)result.Rows[0]["plantId"];

            return id;
        }

        /// <summary>
        /// Adds units to a specific plant.
        /// </summary>
        /// <param name="p_name"></param>
        /// <param name="numOfUnits"></param>
        public void AddPlantUnits(string p_name, int numOfUnits)
        {
            MySqlCommand command = DataAccessUtils.commandBuilder("UPDATE seedsdb.Plants" +
                "SET countInUnit = countInUnit + @NUM_OF_UNITS WHERE name=@P_NAME",
                "@NUM_OF_UNITS", numOfUnits.ToString(),
                "@P_NAME", p_name);
            DatabaseAccess.performDMLQuery(command);
        }

        /// <summary>
        /// Removes units from a specific plant.
        /// </summary>
        /// <param name="p_name"></param>
        /// <param name="numOfUnits"></param>
        public void RemovePlantUnits(string p_name, int numOfUnits)
        {
            MySqlCommand command = DataAccessUtils.commandBuilder("UPDATE seedsdb.Plants" +
                "SET countInUnit = countInUnit - @NUM_OF_UNITS WHERE name=@P_NAME",
                "@NUM_OF_UNITS", numOfUnits.ToString(),
                "@P_NAME", p_name);
            DatabaseAccess.performDMLQuery(command);
        }

        /*public void AddSproutingPercentage(int p_id, DateTime p_arriveDate, DateTime sowDate, DateTime collectDate, int percentage)
        {
            int p_id = FindPlant(p_name, p_type);
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT * From seedsdb.Fridge WHERE id=@P_ID ORDER BY arrivingDate",
                "@P_ID", p_id);
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            MySqlCommand command = DataAccessUtils.commandBuilder("UPDATE seedsdb.SproutedStats WHERE id=@P_ID ORDER BY arrivingDate",
                "@P_ID", p_id);
			
        }*/

        public void AddToFridge(int p_id, DateTime p_arriveDate, int numOfUnits, string location)
        {
            if (!checkPlantExistsByID(p_id))
                throw new ArgumentException("Plant doesn't exists");
            MySqlCommand command = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.Fridge (plantId, arrivingDate, units, locationInFridge)" +
                "VALUES(@P_PLANTID,@P_ARRIVEDATE,@P_NUMOFUNITS,@P_LOCATION)",
                "@P_PLANTID", p_id.ToString(),
                "@P_ARRIVEDATE", String.Format("{0:yyyy-M-d}", p_arriveDate),
                "@P_NUMPFUNITS", numOfUnits.ToString(),
                "@P_LOCATION", location);
            DatabaseAccess.performDMLQuery(command);
        }
        #endregion

        /// <summary>
        /// checks if a specific plant exists in the DB
        /// </summary>
        /// <param name="p_name"></param>
        /// <returns></returns>
        private bool checkPlantExists(string p_name)
        {
            return DataAccessUtils.rowExists("SELECT name FROM seedsdb.Plants WHERE name=@P_NAME;", "@P_NAME", p_name);
        }

        private bool checkPlantExistsByID(int p_id)
        {
            return DataAccessUtils.rowExists("SELECT plantId FROM seedsdb.PlantTypes WHERE plantId=@P_ID", "@P_ID", p_id.ToString());
        }
    }
}
