using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using seedsfromzion.DataAccess;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Specialized;
namespace seedsfromzion.Managers
{
    public class UserNotFound : Exception
    {
    }

    public class CannotDeleteAdmin : Exception
    {
    }

    public class UserAlreadyExists : Exception
    {
    }
    public class PlantAlreadyInFavorites : Exception
    {
    }
    public class PlantNotExistsInFavorites : Exception
    {
    }
    public static class AdminManager
    {
      
        public static void addUser(string username, string password, UserType type)
        {
            if (DataAccessUtils.rowExists("SELECT * FROM seedsdb.users WHERE username=@Username", "@Username", username))
            {
                throw new UserAlreadyExists();
            }
            char typeStr;
            switch (type)
            {
                case UserType.ADMIN: typeStr = 'A'; break;
                default: typeStr = 'B'; break;
            }
            string hashedPass = SystemManager.hashPassword(password);
            MySqlCommand command = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.users VALUES(@Username,@Type,@pass);", "@Username", username, "@Type", typeStr.ToString(), "@pass", hashedPass);
            DataAccess.DatabaseAccess.performDMLQuery(command);
        }

        public static void removeUser(string username)
        {
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT * FROM seedsdb.users WHERE username=@Username", "@Username", username);
            DataTable res = DataAccess.DatabaseAccess.getResultSetFromDb(command);
            if (res.Rows.Count == 0)
            { throw new UserNotFound(); }
            if (((char)res.Rows[0]["type"]).Equals('A'))
            {
                throw new CannotDeleteAdmin();
            }
            command = DataAccessUtils.commandBuilder("DELETE FROM seedsdb.users WHERE username=@Username", "@Username", username);
            DatabaseAccess.performDMLQuery(command);
        }

        public static void addToFavorites(int plantId)
        {
            StringCollection strCollection = ConfigFile.getInstance.Favorites;
            if (strCollection.Contains(plantId.ToString()))
            {
                throw new PlantAlreadyInFavorites();
            }
            strCollection.Add(plantId.ToString());
            ConfigFile.getInstance.Favorites = strCollection;
           
        }

        public static void removeFromFavorites(int plantId)
        {
            StringCollection strCollection = ConfigFile.getInstance.Favorites;
            if (!strCollection.Contains(plantId.ToString()))
            {
                throw new PlantNotExistsInFavorites();
            }
            strCollection.Remove(plantId.ToString());
            ConfigFile.getInstance.Favorites = strCollection;
        }




    }
}
