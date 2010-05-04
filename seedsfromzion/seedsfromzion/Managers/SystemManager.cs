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
    public enum UserType { ADMIN, ORDINARY ,NoOne};

    public static class SystemManager
    {
        private static UserType logedIn;

        static SystemManager()
        {
            logedIn = UserType.NoOne;
        }

        public static UserType LogedUserType
        {
            get
            {
                return logedIn;
            }
        }

        public static bool logIn(string username, string password)
        {
           
            UserType uType=checkUser (username, password);
            if (uType.Equals(UserType.NoOne))
            {
                return false;
            }
            logedIn = uType;
            return true;
        }

        public static void disconnect()
        {
            logedIn = UserType.NoOne;
        }

        public static UserType checkUser(string username, string password)
        {
           string pass = hashPassword(password);
           MySqlCommand command= DataAccessUtils.commandBuilder("SELECT type FROM seedsdb.users WHERE username=@Username AND password=@Pass;", "@Username", username, "@Pass", pass);
           DataTable res = DatabaseAccess.getResultSetFromDb(command);
           if (res.Rows.Count == 0)
             return  UserType.NoOne;
          string c = (string)res.Rows[0]["type"];
           UserType r =(c.Equals("A")) ? UserType.ADMIN : UserType.ORDINARY;
           return r;
        }


        public static string hashPassword(string userPass)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            byte[] bytePass=encoding.GetBytes(userPass);
            SHA1 shaAlgorithm = new SHA1CryptoServiceProvider();
            byte [] answer = shaAlgorithm.ComputeHash(bytePass);
            return encoding.GetString(answer);    
        }

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
            string executionPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            LinkedList<String> dirsAndFiles = new LinkedList<string>();
            DataAccess.DatabaseAccess.performDbBackup(executionPath + @"\" + "databaseBackup.sql");
            Zipper zipFile = new Zipper();
            zipFile.addZipFolder(ConfigFile.getInstance.ImagesPath);
            zipFile.addZipFolder("Database");
            zipFile.addDirFilesToDirectory(executionPath + @"\" + ConfigFile.getInstance.ImagesPath, ConfigFile.getInstance.ImagesPath);
            zipFile.addFile(executionPath + @"\" + "databaseBackup.sql", "Database");
            zipFile.zip(destination);
            File.Delete("databaseBackup.sql");
        }

        public  static  void performSystemRestore(string bakupfile)
        {
            string executionPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            DirectoryInfo info =Directory.CreateDirectory(executionPath+@"\Temp");
            Zipper.extract(bakupfile, info.FullName);
            string databaseFile=info.FullName + @"\Database\databaseBackup.sql";
            string imagesPath = info.FullName + @"\Images";
            foreach (string file in Directory.GetFiles(imagesPath))
            {
                string fileName = Path.GetFileName(file);
                File.Copy(file,executionPath+@"\"+ConfigFile.getInstance.ImagesPath+@"\"+fileName,true);
            }
            DataAccess.DatabaseAccess.restoreDb(databaseFile);
            info.Delete(true);


        }
    }
}
