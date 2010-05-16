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
        private const double epsilon = 0.01;
        public class KeyException : Exception { }
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

            int newId = getNewPlantId();

            commands[0] = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.Plants (name, foreignName, picture, comments, unitType, countInUnit) " +
                "VALUES(@P_NAME, NULL, @P_PIC, NULL, NULL, NULL)", "@P_NAME", p_name, "@P_PIC", p_pic);
            commands[1] = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.PlantTypes (type, name, lifetime, price, plantId) " +
                "VALUES(@P_TYPE, @P_NAME, @P_LIFETIME, @P_PRICE, @P_ID)",
                "@P_TYPE", p_type,
                "@P_NAME", p_name,
                "@P_LIFETIME", p_lifetime.ToString(),
                "@P_PRICE", p_price.ToString(),
                "@P_ID", newId.ToString());
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
                return -1;

            int id = (int)result.Rows[0]["plantId"];

            return id;
        }
        /*
        // why do I need this func? I have addToFridge() 
        /// <summary>
        /// Adds units of a specific plant to the fridge.
        /// </summary>
        /// <param name="p_id"></param>
        /// <param name="p_arriveDate"></param>
        /// <param name="numOfUnits"></param>
        /// <param name="location"></param>
        public void AddPlantUnitsToFridge(int p_id, DateTime p_arriveDate, int numOfUnits, string location)
        {
            if(!checkPlantExistsByID())
                throw new ArgumentException("Plant doesn't exists");

            MySqlCommand command = DataAccessUtils.commandBuilder("UPDATE seedsdb.Fridge" +
                "SET units = units + @NUM_OF_UNITS WHERE plantId=@P_ID",
                "@NUM_OF_UNITS", numOfUnits.ToString(),
                "@P_ID", p_id.ToString());
            DatabaseAccess.performDMLQuery(command);
        }
        */

        /* 
        // same as previous func..see note
        /// <summary>
        /// Removes units from a specific plant.
        /// </summary>
        /// <param name="p_name"></param>
        /// <param name="numOfUnits"></param>
        public void RemovePlantUnits(string p_name, int numOfUnits)
        {
            // check if exists numOfUnits in storage
            MySqlCommand command = DataAccessUtils.commandBuilder("UPDATE seedsdb.Plants" +
                "SET countInUnit = countInUnit - @NUM_OF_UNITS WHERE name=@P_NAME",
                "@NUM_OF_UNITS", numOfUnits.ToString(),
                "@P_NAME", p_name);
            DatabaseAccess.performDMLQuery(command);
        }
        */

        // bad implementation for sure
        /*public void AddSproutingPercentage(int p_id, DateTime p_arriveDate, DateTime sowDate, DateTime collectDate, int percentage)
        {
            int p_id = FindPlant(p_name, p_type);
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT * From seedsdb.Fridge WHERE id=@P_ID ORDER BY arrivingDate",
                "@P_ID", p_id);
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            MySqlCommand command = DataAccessUtils.commandBuilder("UPDATE seedsdb.SproutedStats WHERE id=@P_ID ORDER BY arrivingDate",
                "@P_ID", p_id);
			
        }*/
        /*
         // didn't check, but I think it's OK
        public void AddToFridge(int p_id, DateTime p_arriveDate, double numOfUnits, string location)
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
        */




        public void AddToFridge(int plantId, DateTime arriveDate, double units, string location)
        {
            if (!checkPlantExistsByID(plantId))
                throw new ArgumentException("Plant doesn't exists");
            bool keyExists=DataAccessUtils.rowExists("SELECT * FROM seedsdb.fridge WHERE plantId=@PlantId AND arrivingDate=@ARRIVE", "@PlantId", plantId.ToString(), "@ARRIVE", String.Format("{0:yyyy-M-d}", arriveDate));
            if (keyExists)
            {
                throw new KeyException();
            }
            MySqlCommand command = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.fridge (plantId, arrivingDate, units, location)" +
                            "VALUES (@Plant,@ARRIVEDATE,@UNITS,@LOCATION)",
                            "@Plant", plantId.ToString(),
                            "@ARRIVEDATE", String.Format("{0:yyyy-M-d}", arriveDate),
                            "@UNITS", units.ToString(),
                            "@LOCATION", location);
            DatabaseAccess.performDMLQuery(command);
        }


        public DataTable getSproutingNullable()
        {
            MySqlCommand command = new MySqlCommand("SELECT S.plantId, T.name , T.type ,S.arrivingDate,S.sowindDate,S.collectionDate FROM seedsdb.sproutedstats S,seedsdb.planttypes T WHERE sproutingPerc is NULL AND S.plantId=T.plantId");
            return DatabaseAccess.getResultSetFromDb(command); 
        }

        public void CollectPlants(int pid,DateTime p_arriveDate, DateTime p_sowingDate, DateTime p_collectionDate,double units,double grown , int storageNum,string location,double sproute)
        {
            if (!checkPlantExistsByID(pid))
                throw new ArgumentException("Plant doesn't exists");
            string arriveDate = String.Format("{0:yyyy-M-d}", p_arriveDate);
            string sowDate = String.Format("{0:yyyy-M-d}", p_sowingDate);
            string collectDate = String.Format("{0:yyyy-M-d}", p_collectionDate);
            if (DataAccessUtils.rowExists("SELECT * FROM seedsdb.sproutedstats WHERE plantId=@PID AND arrivingDate = @Arrive AND sowindDate=@Sow AND collectionDate = @Collect ", "@PID", pid.ToString(), "@Arrive", arriveDate, "@Sow", sowDate, "@Collect", collectDate))
            {
                throw new KeyException();
            }
            MySqlCommand[] commands = new MySqlCommand[4];
            if (DataAccessUtils.rowExists("SELECT * FROM seedsdb.finishedstorage WHERE plantId=@Plant AND id=@StorageId", "@Plant", pid.ToString(), "@StorageId", storageNum.ToString()))
            {
                commands[0] = DataAccessUtils.commandBuilder("UPDATE seedsdb.finishedstorage " +
                            "SET units = (units + " + grown.ToString() + ") WHERE plantId =@P_PLANTID AND id=@StorageId",
                            "@P_PLANTID", pid.ToString(),
                            "@StorageId", storageNum.ToString());
            }
            else
            {
                commands[0] = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.finishedstorage(plantId, id, units, location) " +
                              " VALUES (@PLANTID,@STORAGE,@UNITS,@LOCATION)",
                              "@PLANTID", pid.ToString(),
                              "@STORAGE", storageNum.ToString(),
                              "@UNITS", grown.ToString(),
                              "@LOCATION", location);
            }
            commands[1] = DataAccessUtils.commandBuilder("UPDATE seedsdb.field " +
                            "SET units = (units - " + units.ToString() + ") WHERE plantId =@P_PLANTID AND arrivingDate = @ArriveDate AND sowingDate=@SowingDate" ,
                            "@P_PLANTID", pid.ToString(),
                            "@ArriveDate", arriveDate,
                            "@SowingDate",sowDate);
            commands[2] = new MySqlCommand("DELETE FROM seedsdb.field WHERE units < " + epsilon.ToString());
            if (sproute < 0)
            {
                commands[3] = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.sproutedstats(plantId, arrivingDate, sowindDate, collectionDate,sproutingPerc) " +
                                  " VALUES (@PLANTID,@Arrive,@Sow,@Collect,@Sprout)",
                                  "@PLANTID", pid.ToString(),
                                  "@Arrive", arriveDate,
                                  "@Sow", sowDate,
                                  "@Collect", collectDate,
                                  "@Sprout", sproute.ToString());
            }
            else
            {
                commands[3] = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.sproutedstats(plantId, arrivingDate, sowindDate, collectionDate) " +
                                 " VALUES (@PLANTID,@Arrive,@Sow,@Collect)",
                                 "@PLANTID", pid.ToString(),
                                 "@Arrive", arriveDate,
                                 "@Sow", sowDate,
                                 "@Collect", collectDate);
            }
            DatabaseAccess.performDMLTransaction(commands);
        }

        public void UpdateSproutingPercentage(int pid, DateTime arrive, DateTime sow, DateTime collect, double sowing)
        {
            string arriveDate = String.Format("{0:yyyy-M-d}",arrive);
            string sowDate = String.Format("{0:yyyy-M-d}", sow);
            string collectDate = String.Format("{0:yyyy-M-d}", collect);
            MySqlCommand command = DataAccessUtils.commandBuilder("UPDATE seedsdb.sproutedstats SET sproutingPerc=@Perc WHERE plantId=@PID AND arrivingDate = @Arrive AND sowindDate=@Sow AND collectionDate = @Collect ","@Perc",sowing.ToString(), "@PID", pid.ToString(), "@Arrive", arriveDate, "@Sow", sowDate, "@Collect", collectDate);
            DatabaseAccess.performDMLQuery(command);
        }



        // need to check if it's OK, did it under pressure of time
        public void SowSeeds(int p_id, DateTime p_arriveDate, DateTime p_sowingDate, double numOfUnits, string location)
        {
            if (!checkPlantExistsByID(p_id))
                throw new ArgumentException("Plant doesn't exists");
            string arriveDate= String.Format("{0:yyyy-M-d}", p_arriveDate);
            string sowDate= String.Format("{0:yyyy-M-d}", p_sowingDate);
            if (DataAccessUtils.rowExists("SELECT * FROM seedsdb.field WHERE plantId=@PID AND arrivingDate = @ARRDATE AND sowingDate = @SOW", "@PID", p_id.ToString(), "@ARRDATE", arriveDate, "@SOW", sowDate))
            {
                throw new KeyException();
            }

            MySqlCommand[] commands = new MySqlCommand[3];

            // Insert plant units to field table
            commands[0] = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.field (plantId, arrivingDate, sowingDate, units, location) " +
                            "VALUES (@P_PLANTID,@P_ARRIVEDATE,@P_SOWINGDATE,@P_NUMOFUNITS,@P_LOCATION)",
                            "@P_PLANTID", p_id.ToString(),
                            "@P_ARRIVEDATE", arriveDate,
                            "@P_SOWINGDATE", sowDate,
                            "@P_NUMOFUNITS", numOfUnits.ToString(),
                            "@P_LOCATION", location);
            // Delete the current plant units from the fridge table
            commands[1] = DataAccessUtils.commandBuilder("UPDATE seedsdb.Fridge " +
                            "SET units = (units - "+numOfUnits.ToString()+") WHERE plantId =@P_PLANTID AND arrivingDate = @ArriveDate",
                            "@P_PLANTID", p_id.ToString(),
                            "@ArriveDate",arriveDate);
            // Delete Plants with 0 units in the fridge (after update)
            commands[2] = new MySqlCommand("DELETE FROM seedsdb.Fridge WHERE units < "+epsilon.ToString()); 
            DatabaseAccess.performDMLTransaction(commands);

            
        }







        public DataRow findPlantById(string plantId)
        {
            MySqlCommand command = new MySqlCommand("SELECT name ,type FROM seedsdb.planttypes WHERE plantId= "+plantId);
            DataTable res=DatabaseAccess.getResultSetFromDb(command);
            if (res.Rows.Count == 0)
            {
                return null;
            }
            return res.Rows[0];


        }

        public DataTable getFridgeTable()
        {
            MySqlCommand command = new MySqlCommand("SELECT P.plantId,P.name,P.type,F.arrivingDate,F.units,F.location  FROM seedsdb.fridge F, seedsdb.planttypes P WHERE P.plantId=F.plantId");
            return DatabaseAccess.getResultSetFromDb(command);

        }

        public DataTable getPlantsTable()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM seedsdb.planttypes");
            return DatabaseAccess.getResultSetFromDb(command);
        }

        public DataTable getFieldTable()
        {

            MySqlCommand command = new MySqlCommand("SELECT P.plantId,P.name,P.type,F.arrivingDate,F.sowingDate, F.units  FROM seedsdb.field F, seedsdb.planttypes P WHERE P.plantId=F.plantId");
            return DatabaseAccess.getResultSetFromDb(command);

        }

        /// <summary>
        /// checks if a specific plant exists in the DB
        /// </summary>
        /// <param name="p_name"></param>
        /// <returns></returns>
        public bool checkPlantExists(string p_name)
        {
            return DataAccessUtils.rowExists("SELECT name FROM seedsdb.Plants WHERE name=@P_NAME;", "@P_NAME", p_name);
        }

        public bool checkPlantExistsByID(int p_id)
        {
            return DataAccessUtils.rowExists("SELECT plantId FROM seedsdb.PlantTypes WHERE plantId=@P_ID", "@P_ID", p_id.ToString());
        }

        public int getNewPlantId()
        {
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT COALESCE(MAX(plantId), 0) AS plantId FROM seedsdb.PlantTypes");
            DataTable result = DatabaseAccess.getResultSetFromDb(command);

            int newId = (int)Convert.ToInt32(result.Rows[0]["plantId"]) + 1;
            return newId;
        }
        /*
        public void RemoveAmountFromStorage(int p_id, double units)
        {
            // check if there is enough units in storage
            if (!existsUnits(p_id, units))
                throw new ArgumentException("There isn't enough units in storage");

            // update the amount of units in storage
            MySqlCommand command = DataAccessUtils.commandBuilder("UPDATE seedsdb.FinishedStorage" +
            "SET units = units - @P_UNITS WHERE plantId = @P_ID",
            "@P_UNITS", units.ToString(),
            "@P_ID", p_id.ToString());
            DatabaseAccess.performDMLQuery(command);
        }

        public bool existsUnits(int p_id, double WantedUnits)
        {
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT units FROM seedsdb.FinishedStorage WHERE plantId = @P_ID");
            DataTable result = DatabaseAccess.getResultSetFromDb(command);
            double numOfExistUnits = (double)result.Rows[0]["units"];
            if (numOfExistUnits - WantedUnits >= 0)
                return true;
            return false;
        }
        */
        #endregion

       
    }
}