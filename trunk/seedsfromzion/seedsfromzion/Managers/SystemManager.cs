using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using seedsfromzion.DataAccess;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;
using System.IO;

namespace seedsfromzion.Managers
{
    /// <summary>
    /// Represents the user types which can be logged in 
    /// into the system
    /// NoOne represent that NoOne is logged in
    /// </summary>
    public enum UserType { ADMIN, ORDINARY ,NoOne};

    /// <summary>
    /// This class handles the system properties and routines. through
    /// this class maintenance operations can be done
    /// 
    /// </summary>
    public static class SystemManager
    {

        /// <summary>
        /// The current logged in user type
        /// </summary>
        private static UserType logedIn;

        static SystemManager()
        {
            logedIn = UserType.NoOne;
        }

        /// <summary>
        /// Gets the current logged in user type
        /// </summary>
        public static UserType LogedUserType
        {
            get
            {
                return logedIn;
            }
        }

        /// <summary>
        /// Performs a log in operation to the user. with the given username
        /// and password. (first conformes that the details are correct)
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool logIn(string username, string password)
        {
            //TODO: handle user login
            //check the user type  
            UserType uType=checkUser (username, password);
            //if the username or the password are incorrect
            if (uType.Equals(UserType.NoOne))
            {
                return false;
            }
            //all good , set the user to be loged in
            
            logedIn = uType;
             
            return true;
        }

        /// <summary>
        /// Disconnects the current loged in user from the system
        /// </summary>
        public static void disconnect()
        {
            logedIn = UserType.NoOne;
        }

        /// <summary>
        /// Returns the user type of the given username. if the password and the username
        /// doesn't match , return UserType.NoOne
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static UserType checkUser(string username, string password)
        {
           string pass = hashPassword(password);
            //check if there is a user with the given username and password
           MySqlCommand command= DataAccessUtils.commandBuilder("SELECT type FROM seedsdb.users WHERE username=@Username AND password=@Pass;", "@Username", username, "@Pass", pass);
           DataTable res = DatabaseAccess.getResultSetFromDb(command);
           if (res.Rows.Count == 0)
             return  UserType.NoOne;
          string c = (string)res.Rows[0]["type"];
           UserType r =(c.Equals("A")) ? UserType.ADMIN : UserType.ORDINARY;
           return r;
        }

        /// <summary>
        /// Hashes the given password to a new password with the SHA-1 crypto 
        /// hash function
        /// </summary>
        /// <param name="userPass"></param>
        /// <returns></returns>
        public static string hashPassword(string userPass)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            //get the bytes of the text
            byte[] bytePass=encoding.GetBytes(userPass);
            SHA1 shaAlgorithm = new SHA1CryptoServiceProvider();
            //hash the password
            byte [] answer = shaAlgorithm.ComputeHash(bytePass);
            //return hashed password as string
            return encoding.GetString(answer);    
        }

        /// <summary>
        /// Returns the usernames  of the system 
        /// </summary>
        /// <returns></returns>
        public static DataTable getUsers()
        {
            MySqlCommand command = new MySqlCommand("SELECT username FROM seedsdb.users ");
            return DataAccess.DatabaseAccess.getResultSetFromDb(command);
        }

        /// <summary>
        /// performs system backup to the given destination
        /// </summary>
        /// <param name="destination">the given destination zip file</param>
        public static void performBackup(String destination)
        {
            //get the systems path
            string executionPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            LinkedList<String> dirsAndFiles = new LinkedList<string>();
            //creath a database backup and save it in the current dir
            DataAccess.DatabaseAccess.performDbBackup(executionPath + @"\" + "databaseBackup.sql");
            Zipper zipFile = new Zipper();
            //create images folder in the zip archive
            zipFile.addZipFolder(ConfigFile.getInstance.ImagesPath);
            //create iDatabase folder in the zip archive
            zipFile.addZipFolder("Database");
            //add the images from the images path to the archive
            zipFile.addDirFilesToDirectory(executionPath + @"\" + ConfigFile.getInstance.ImagesPath, ConfigFile.getInstance.ImagesPath);
            //add the sql backup file to the archive
            zipFile.addFile(executionPath + @"\" + "databaseBackup.sql", "Database");
            //save the system backup archive
            zipFile.zip(destination);
            //delete the temporary database backup
            File.Delete("databaseBackup.sql");
        }

        /// <summary>
        /// Performs a full system restore.
        /// </summary>
        /// <param name="bakupfile"></param>
        public  static  void performSystemRestore(string bakupfile)
        {
            //get the systems path 
            string executionPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //create a temp directory , when the archive will be extracted to
            DirectoryInfo info =Directory.CreateDirectory(executionPath+@"\Temp");
            //extract the archive to the temp folder
            Zipper.extract(bakupfile, info.FullName);
            string databaseFile=info.FullName + @"\Database\databaseBackup.sql";
            string imagesPath = info.FullName + @"\Images";
            //copy the backup images to the images path (with overwrite)
            foreach (string file in Directory.GetFiles(imagesPath))
            {
                string fileName = Path.GetFileName(file);
                File.Copy(file,executionPath+@"\"+ConfigFile.getInstance.ImagesPath+@"\"+fileName,true);
            }
            //restore the database
            DataAccess.DatabaseAccess.restoreDb(databaseFile);
            //delete the Temp folder and whole the files in it
            info.Delete(true);


        }
    }
}
