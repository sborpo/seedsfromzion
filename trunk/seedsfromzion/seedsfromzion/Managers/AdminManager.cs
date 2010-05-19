using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using seedsfromzion.DataAccess;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;
using System.Collections.Specialized;
namespace seedsfromzion.Managers
{
    /// <summary>
    /// Thrown when the username is not found in the system
    /// </summary>
    public class UserNotFound : Exception
    {
    }

    /// <summary>
    /// Thrown when user tries to delete a username with
    /// admin type. System's specifications forbid it.
    /// </summary>
    public class CannotDeleteAdmin : Exception
    {
    }

    /// <summary>
    /// Thrown when a user tries to add a username that 
    /// is already exists in the system
    /// </summary>
    public class UserAlreadyExists : Exception
    {
    }

    /// <summary>
    /// Thrown when a user tries to add to the favorites an 
    /// already existed plant
    /// </summary>
    public class PlantAlreadyInFavorites : Exception
    {
    }

    /// <summary>
    /// Thrown when the given plant is not exists in the favorites
    /// </summary>
    public class PlantNotExistsInFavorites : Exception
    {
    }

    /// <summary>
    /// This class handles the administrator options in the system.
    /// </summary>
    public static class AdminManager
    {
        /// <summary>
        /// This method adds a new user to the system with the given username
        /// and password ( stored an hashed password via SHA-1 crypto algorithm)
        /// and user's type.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="type"></param>
        public static void addUser(string username, string password, UserType type)
        {
            //check that there is no such username in the system
            if (DataAccessUtils.rowExists("SELECT * FROM seedsdb.users WHERE username=@Username", "@Username", username))
            {
                throw new UserAlreadyExists();
            }
            char typeStr;
            switch (type)
            {
                case UserType.ADMIN: { typeStr = 'A'; break; }
                default: { typeStr = 'B'; break; }
            }
            //hash the password
            string hashedPass = SystemManager.hashPassword(password);
            //add the user to the database
            MySqlCommand command = DataAccessUtils.commandBuilder("INSERT INTO seedsdb.users VALUES(@Username,@Type,@pass);", "@Username", username, "@Type", typeStr.ToString(), "@pass", hashedPass);
            DataAccess.DatabaseAccess.performDMLQuery(command);
        }

        /// <summary>
        /// This method removes the given username from the database.
        /// </summary>
        /// <param name="username"></param>
        public static void removeUser(string username)
        {
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT * FROM seedsdb.users WHERE username=@Username", "@Username", username);
            DataTable res = DataAccess.DatabaseAccess.getResultSetFromDb(command);
            //check if the user exists
            if (res.Rows.Count == 0)
            { throw new UserNotFound(); }
            //check that Admin is not deleted
            if (((string)res.Rows[0]["type"]).Equals("A"))
            {
                throw new CannotDeleteAdmin();
            }
            //delete the user
            command = DataAccessUtils.commandBuilder("DELETE FROM seedsdb.users WHERE username=@Username", "@Username", username);
            DatabaseAccess.performDMLQuery(command);
        }

        /// <summary>
        /// This method changed the password of a given username to a new password.
        /// this method first confirms that the user's old password is correct.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="oldPass"></param>
        /// <param name="NewPass"></param>
        public static void changePassword(string username,string oldPass,string NewPass)
        {
            //check that the username exists with it's old password
            if (SystemManager.checkUser(username, oldPass).Equals(UserType.NoOne))
            {
                throw new UserNotFound();
            }
            //hash the new password
            String newPass=SystemManager.hashPassword(NewPass);
            //add the new password to the DB
            MySqlCommand command = DataAccessUtils.commandBuilder("UPDATE seedsdb.users SET password=@Pass WHERE username=@Username", "@Pass", newPass,"@Username",username);
            DataAccess.DatabaseAccess.performDMLQuery(command);
        }

        /// <summary>
        /// Adds a given plantId to the current plant favorites.
        /// </summary>
        /// <param name="plantId"></param>
        public static void addToFavorites(string plantId)
        {
            //get the plant id's string collection (favorites)
            StringCollection strCollection = ConfigFile.getInstance.Favorites;
            //check that the plant isn't currently exsist in the
            //favorites
            if (strCollection.Contains(plantId.ToString()))
            {
                throw new PlantAlreadyInFavorites();
            }
            //add the plant
            strCollection.Add(plantId.ToString());
            //update the favorites
            ConfigFile.getInstance.Favorites = strCollection;
           
        }

        /// <summary>
        /// removes the given plant id from the favorites
        /// </summary>
        /// <param name="plantId"></param>
        public static void removeFromFavorites(string plantId)
        {
            //get the favorites
            StringCollection strCollection = ConfigFile.getInstance.Favorites;
            //check that the plant exists in the collection
            if (!strCollection.Contains(plantId.ToString()))
            {
                throw new PlantNotExistsInFavorites();
            }
            //remove the plant
            strCollection.Remove(plantId.ToString());
            //update the favorites
            ConfigFile.getInstance.Favorites = strCollection;
        }




    }
}
