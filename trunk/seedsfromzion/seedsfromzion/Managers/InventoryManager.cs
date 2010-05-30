using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using seedsfromzion.DataAccess;
using MySql.Data.MySqlClient;
using seedsfromzion.DataStructures;
using System.Data;
using System.IO;

namespace seedsfromzion.Managers
{

    public class InventoryManager
    {
        private const double epsilon = 0.01;
        public class KeyException : Exception { }

        #region Tables Getters

        public DataTable getSproutingNullable()
        {
            MySqlCommand command = new MySqlCommand("SELECT S.plantId, T.name , T.type ,S.arrivingDate,S.sowindDate,S.collectionDate FROM seedsdb.sproutedstats S,seedsdb.planttypes T WHERE sproutingPerc is NULL AND S.plantId=T.plantId");
            return DatabaseAccess.getResultSetFromDb(command);
        }

        public DataTable getFridgeTable()
        {
            MySqlCommand command = new MySqlCommand("SELECT P.plantId,P.name,P.type,F.arrivingDate,F.units,F.location  FROM seedsdb.fridge F, seedsdb.planttypes P WHERE P.plantId=F.plantId");
            return DatabaseAccess.getResultSetFromDb(command);

        }

        public DataTable getFullPlantsTable(string plantName)
        {
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT T.plantId,T.name, T.type , T.lifetime, T.price,P.foreignName,P.picture,P.comments,P.unitType,P.countInUnit FROM seedsdb.planttypes T, seedsdb.plants P WHERE P.name=T.name AND P.name=@Name", "@Name", plantName);
            return DatabaseAccess.getResultSetFromDb(command);
        }

        public DataTable getPlantsTable()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM seedsdb.planttypes");
            return DatabaseAccess.getResultSetFromDb(command);
        }

        public DataTable getFieldTable()
        {

            MySqlCommand command = new MySqlCommand("SELECT P.plantId,P.name,P.type,F.arrivingDate,F.sowingDate, F.units ,F.location FROM seedsdb.field F, seedsdb.planttypes P WHERE P.plantId=F.plantId");
            return DatabaseAccess.getResultSetFromDb(command);

        }

        public DataTable getFinishedStorageTable()
        {

            MySqlCommand command = new MySqlCommand("SELECT P.plantId,P.name,P.type,F.id,F.units, F.location FROM seedsdb.finishedstorage F, seedsdb.planttypes P WHERE P.plantId=F.plantId");
            return DatabaseAccess.getResultSetFromDb(command);

        }
        #endregion

        #region Plant Handlers

        #region Plant Finders

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
            plant.Picture = (result.Rows[0]["picture"] == null) ? "NULL" : (string)result.Rows[0]["picture"];
            plant.Comments = (string)result.Rows[0]["comments"];
            plant.UnitType = result.Rows[0]["unitType"].ToString();
            plant.CountInUnit = (int)Int32.Parse(result.Rows[0]["countInUnit"].ToString());
            return plant;
        }

        /// <summary>
        /// Finds plant according to the given name and type.
        /// </summary>
        /// <param name="p_name"></param>
        public int FindPlant(string p_name, char p_type)
        {
            return innerFindPlant(p_name, p_type.ToString());
        }

        /// <summary>
        /// Finds plant according to the given name and type.
        /// Overrloaded To Previous
        /// </summary>
        /// <param name="p_name"></param>
        /// <param name="p_type"></param>
        /// <returns></returns>
        public int FindPlant(string p_name, string p_type)
        {
            return innerFindPlant(p_name, p_type);
        }

        /// <summary>
        /// Private function which finds the plantId of a given plant
        /// name and a type. if it wasn't found return -1
        /// </summary>
        /// <param name="p_name"></param>
        /// <param name="p_type"></param>
        /// <returns></returns>
        private int innerFindPlant(string p_name, string p_type)
        {
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT plantId FROM seedsdb.PlantTypes WHERE name=@P_NAME AND type=@P_TYPE",
            "@P_NAME", p_name, "@P_TYPE", p_type.ToString());
            DataTable result = DatabaseAccess.getResultSetFromDb(command);

            if (result.Rows.Count == 0)
                return -1;

            int id = -1;
            try
            {
                Object ob = result.Rows[0]["plantId"];
                id = (int)Convert.ChangeType(ob, typeof(int)); ;
                return id;
            }
            catch (Exception ex)
            {
                Console.Beep();
            }

            return -1;

            return id;
        }

        public DataRow findPlantById(string plantId)
        {
            MySqlCommand command = new MySqlCommand("SELECT name ,type FROM seedsdb.planttypes WHERE plantId= " + plantId);
            DataTable res = DatabaseAccess.getResultSetFromDb(command);
            if (res.Rows.Count == 0)
            {
                return null;
            }
            return res.Rows[0];


        }

        #endregion 

        #region Plant Remove Handlers


        /// <summary>
        /// Checks whenever the plant exists in the Fridge,Field Or Finished Storage
        /// If yes , return true , otherwise returns false
        /// </summary>
        /// <param name="plantId"></param>
        /// <returns></returns>
        public bool IsPlantIsUsed(int plantId)
        {
            return DataAccessUtils.rowExists("SELECT plantId FROM seedsdb.fridge WHERE plantId=@Plant UNION SELECT plantId FROM seedsdb.field WHERE plantId=@Plant UNION SELECT plantId FROM seedsdb.finishedstorage WHERE plantId=@Plant UNION (SELECT OS.plantId FROM seedsdb.ordersfromstorage OS,seedsdb.orders O WHERE OS.orderId=O.orderId AND OS.plantId=@Plant AND O.status='0')", "@Plant", plantId.ToString());

        }

        /// <summary>
        /// Removes the given Plant from the system
        /// </summary>
        /// <param name="plantId"></param>
        /// <param name="name"></param>
        public void removePlant(int plantId, PlantInfo name)
        {
            MySqlCommand[] commands = new MySqlCommand[2];
            commands[0] = DataAccessUtils.commandBuilder("DELETE FROM seedsdb.planttypes WHERE plantId=@Plant", "@Plant", plantId.ToString());
            commands[1] = DataAccessUtils.commandBuilder("DELETE FROM seedsdb.plants WHERE NOT EXISTS (SELECT * FROM seedsdb.planttypes WHERE seedsdb.plants.name=seedsdb.planttypes.name)");
            DatabaseAccess.performDMLTransaction(commands);
            try
            {
                PlantInfo info = FindPlant(name.Name);
            }
            catch (ArgumentException ex)
            {
                //The Plant Doesn't Exists
                if (name.Picture != "NO_PICTURE")
                {
                    RemoveFromImages(name.Picture);
                }
            }
            
            
        }

        /// <summary>
        /// Removes the given plant image from the file system.
        /// if the image doesn't exists , does nothing
        /// </summary>
        /// <param name="name"></param>
        private void RemoveFromImages(string name)
        {
            string executionPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string imagesPath = executionPath + @"\" + ConfigFile.getInstance.ImagesPath + @"\" + name;
            try
            {
                File.Delete(imagesPath);
            }
            catch (Exception ex)
            {
                //there was no picture
            }

        }

#endregion

   
        public void AddPlant(PlantInfo planInfo, string type, double p_price, double p_lifetime)
        {
            MySqlCommand[] commands = new MySqlCommand[2];
            if (checkPlantExists(planInfo))
                throw new ArgumentException("Plant already exists");
            int newId = getNewPlantId();
            string pictureName = planInfo.Picture;
            string newPictureName = copyThePicture(pictureName, newId.ToString());

            commands[0] = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.Plants (name, foreignName, picture, comments, unitType, countInUnit) " +
                "VALUES(@P_NAME, @P_FOREIGN, @P_PIC, @P_COMMENTS,@P_UNIT_TYPE , @P_COUNT)",
                "@P_NAME", planInfo.Name,
                "@P_FOREIGN", planInfo.ForeignName,
                "@P_COMMENTS", planInfo.Comments,
                "@P_PIC", newPictureName,
                "@P_UNIT_TYPE", planInfo.UnitType.ToString(),
                "@P_COUNT", planInfo.CountInUnit.ToString());

            commands[1] = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.PlantTypes (type, name, lifetime, price, plantId) " +
                "VALUES(@P_TYPE, @P_NAME, @P_LIFETIME, @P_PRICE, @P_ID)",
                "@P_TYPE", type,
                "@P_NAME", planInfo.Name,
                "@P_LIFETIME", p_lifetime.ToString(),
                "@P_PRICE", p_price.ToString(),
                "@P_ID", newId.ToString());
            DatabaseAccess.performDMLTransaction(commands);
        }

        /// <summary>
        /// Updates a given plant name and type to the new properties 
        /// that was passed with the parameters
        /// </summary>
        /// <param name="info"></param>
        /// <param name="type"></param>
        /// <param name="price"></param>
        /// <param name="lifetime"></param>
        public void updatePlantDetails(PlantInfo planInfo,string oldPicture, string type, double price, double lifetime, out String pictureN)
        {
            MySqlCommand[] commands = new MySqlCommand[2];
            //Update the picture
            string pictureName = planInfo.Picture;
            string newPictureName = copyThePicture(pictureName, oldPicture);
            pictureN = newPictureName;
            //update the Plants Table
            commands[0] = DataAccessUtils.commandBuilder("UPDATE seedsdb.Plants SET  foreignName=@P_FOREIGN, picture=@P_PIC, comments=@P_COMMENTS, unitType=@P_UNIT_TYPE, countInUnit=@P_COUNT " +
                " WHERE name=@P_NAME",
                "@P_FOREIGN", planInfo.ForeignName,
                "@P_PIC", newPictureName,
                "@P_COMMENTS", planInfo.Comments,
                "@P_UNIT_TYPE", planInfo.UnitType.ToString(),
                "@P_COUNT", planInfo.CountInUnit.ToString(),
                "@P_NAME", planInfo.Name);
            //Update the Plant Types Table
            commands[1] = DataAccessUtils.commandBuilder("UPDATE seedsdb.PlantTypes SET  lifetime=@P_LIFETIME, price=@P_PRICE  " +
                " WHERE name=@P_NAME AND type=@P_TYPE",
                "@P_LIFETIME", lifetime.ToString(),
                "@P_PRICE", price.ToString(),
                "@P_NAME", planInfo.Name,
                "@P_TYPE", planInfo.UnitType.ToString());
            DatabaseAccess.performDMLTransaction(commands);

        }

        public void AddPlantType(string plantName, string plantType, double lifetime, double price)
        {
            PlantInfo info = new PlantInfo();
            info.Name = plantName;
            info.UnitType = plantType;
            if (checkPlantExists(info))
                throw new ArgumentException("Plant already exists");
            int newId = getNewPlantId();
            MySqlCommand command = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.PlantTypes (type, name, lifetime, price, plantId) " +
                "VALUES(@P_TYPE, @P_NAME, @P_LIFETIME, @P_PRICE, @P_ID)",
                "@P_TYPE", plantType,
                "@P_NAME", plantName,
                "@P_LIFETIME", lifetime.ToString(),
                "@P_PRICE", price.ToString(),
                "@P_ID", newId.ToString());
            DatabaseAccess.performDMLQuery(command);

        }

        private string copyThePicture(string pictureName, string newId)
        {
            if (pictureName == "NO_PICTURE")
            {
                return pictureName;
            }

            string executionPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string imagesPath = executionPath + @"\" + ConfigFile.getInstance.ImagesPath + @"\" + newId.ToString();
            File.Copy(pictureName, imagesPath, true);
            File.SetAttributes(imagesPath, FileAttributes.Normal);
            return newId.ToString();

        }

        public int getNewPlantId()
        {
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT COALESCE(MAX(plantId), 0) AS plantId FROM seedsdb.PlantTypes");
            DataTable result = DatabaseAccess.getResultSetFromDb(command);

            int newId = (int)Convert.ToInt32(result.Rows[0]["plantId"]) + 1;
            return newId;
        }

        #endregion

        #region Order Handlers
        /// <summary>
        /// remove units from the storage because of an order
        /// </summary>
        /// <param name="p_plantId"></param>
        /// <param name="p_storageId"></param>
        /// <param name="numOfUnits"></param>
        public void removePlantUnits(int p_plantId, string p_storageId, double numOfUnits)
        {
            // check if exists numOfUnits in storage
            MySqlCommand command = DataAccessUtils.commandBuilder("UPDATE seedsdb.finishedstorage" +
                " SET units= (units-@NUM_OF_UNITS) WHERE plantId=@P_PLANTID AND id=@P_STORAGEID",
                "@NUM_OF_UNITS", numOfUnits.ToString(),
                "@P_PLANTID", p_plantId.ToString(),
                "P_STORAGEID", p_storageId);
            DatabaseAccess.performDMLQuery(command);
        }
        /// <summary>
        /// returning the amount to the storage(because an order has been cancel
        /// </summary>
        /// <param name="p_plantId"></param>
        /// <param name="p_storageId"></param>
        /// <param name="numOfUnits"></param>
        public void returnPlantUnits(int p_plantId, string p_storageId, double numOfUnits)
        {
            // check if exists numOfUnits in storage
            MySqlCommand command = DataAccessUtils.commandBuilder("UPDATE seedsdb.finishedstorage" +
                " SET units= (units+@NUM_OF_UNITS) WHERE plantId=@P_PLANTID AND id=@P_STORAGEID",
                "@NUM_OF_UNITS", numOfUnits.ToString(),
                "@P_PLANTID", p_plantId.ToString(),
                "P_STORAGEID", p_storageId);
            DatabaseAccess.performDMLQuery(command);
        }
       
        #endregion

        #region Inventory Handlers

        public void SowSeeds(int p_id, DateTime p_arriveDate, DateTime p_sowingDate, double numOfUnits, string location)
        {
            numOfUnits = Math.Round(numOfUnits, 2);
            if (!checkPlantExistsByID(p_id))
                throw new ArgumentException("Plant doesn't exists");
            string arriveDate = String.Format("{0:yyyy-M-d}", p_arriveDate);
            string sowDate = String.Format("{0:yyyy-M-d}", p_sowingDate);
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
                            "SET units = round((units - " + numOfUnits.ToString() + "),2) WHERE plantId =@P_PLANTID AND arrivingDate = @ArriveDate",
                            "@P_PLANTID", p_id.ToString(),
                            "@ArriveDate", arriveDate);
            // Delete Plants with 0 units in the fridge (after update)
            commands[2] = new MySqlCommand("DELETE FROM seedsdb.Fridge WHERE units < " + epsilon.ToString());
            DatabaseAccess.performDMLTransaction(commands);


        }

        public void AddToFridge(int plantId, DateTime arriveDate, double units, string location)
        {
            units = Math.Round(units, 2);
            if (!checkPlantExistsByID(plantId))
                throw new ArgumentException("Plant doesn't exists");
            bool keyExists = DataAccessUtils.rowExists("SELECT * FROM seedsdb.fridge WHERE plantId=@PlantId AND arrivingDate=@ARRIVE", "@PlantId", plantId.ToString(), "@ARRIVE", String.Format("{0:yyyy-M-d}", arriveDate));
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

        public void CollectPlants(int pid, DateTime p_arriveDate, DateTime p_sowingDate, DateTime p_collectionDate, double units, double grown, int storageNum, string location, double sproute)
        {
            grown = Math.Round(grown, 2);
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
            commands[0] = FinishedStorageAddCommand(pid, storageNum, grown, location);
            commands[1] = DataAccessUtils.commandBuilder("UPDATE seedsdb.field " +
                            "SET units = round((units - " + units.ToString() + "),2) WHERE plantId =@P_PLANTID AND arrivingDate = @ArriveDate AND sowingDate=@SowingDate",
                            "@P_PLANTID", pid.ToString(),
                            "@ArriveDate", arriveDate,
                            "@SowingDate", sowDate);
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

        public void AddToFinishedStorageExternal(int pid, int storageNum, double units, string location)
        {
            units = Math.Round(units, 2);
            MySqlCommand command = FinishedStorageAddCommand(pid, storageNum, units, location);
            DataAccess.DatabaseAccess.performDMLQuery(command);
        }

        private MySqlCommand FinishedStorageAddCommand(int pid,int storageNum,double units,string location)
        {
            MySqlCommand command;
            if (DataAccessUtils.rowExists("SELECT * FROM seedsdb.finishedstorage WHERE plantId=@Plant AND id=@StorageId", "@Plant", pid.ToString(), "@StorageId", storageNum.ToString()))
            {
                command = DataAccessUtils.commandBuilder("UPDATE seedsdb.finishedstorage " +
                            "SET units = round((units + " + units.ToString() + "),2) WHERE plantId =@P_PLANTID AND id=@StorageId",
                            "@P_PLANTID", pid.ToString(),
                            "@StorageId", storageNum.ToString());
            }
            else
            {
                command = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.finishedstorage(plantId, id, units, location) " +
                              " VALUES (@PLANTID,@STORAGE,@UNITS,@LOCATION)",
                              "@PLANTID", pid.ToString(),
                              "@STORAGE", storageNum.ToString(),
                              "@UNITS", units.ToString(),
                              "@LOCATION", location);
            }
            return command;
        }

        public void UpdateSproutingPercentage(int pid, DateTime arrive, DateTime sow, DateTime collect, double sowing)
        {
            string arriveDate = String.Format("{0:yyyy-M-d}", arrive);
            string sowDate = String.Format("{0:yyyy-M-d}", sow);
            string collectDate = String.Format("{0:yyyy-M-d}", collect);
            MySqlCommand command = DataAccessUtils.commandBuilder("UPDATE seedsdb.sproutedstats SET sproutingPerc=@Perc WHERE plantId=@PID AND arrivingDate = @Arrive AND sowindDate=@Sow AND collectionDate = @Collect ", "@Perc", sowing.ToString(), "@PID", pid.ToString(), "@Arrive", arriveDate, "@Sow", sowDate, "@Collect", collectDate);
            DatabaseAccess.performDMLQuery(command);
        }

        #endregion

      
        /// <summary>
        /// checks if a specific plant exists in the DB
        /// </summary>
        /// <param name="p_name"></param>
        /// <returns></returns>
        public bool checkPlantExists(PlantInfo plantInfo)
        {
            return DataAccessUtils.rowExists("SELECT name FROM seedsdb.planttypes WHERE name=@P_NAME AND type=@P_TYPE", 
                "@P_NAME", plantInfo.Name,
                "@P_TYPE", plantInfo.UnitType.ToString());
        }
        /// <summary>
        /// check if plant exist in the DB by id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public bool checkPlantExistsByID(int p_id)
        {
            return DataAccessUtils.rowExists("SELECT plantId FROM seedsdb.planttypes WHERE plantId=@P_ID", "@P_ID", p_id.ToString());
        }
        /// <summary>
        /// check if a storage exist in the DB by id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public bool checkStorageExistsByID(string p_id)
        {
            return DataAccessUtils.rowExists("SELECT id FROM seedsdb.finishedstorage WHERE id=@P_ID", "@P_ID", p_id);
        }
     
       
     

       
    }
}