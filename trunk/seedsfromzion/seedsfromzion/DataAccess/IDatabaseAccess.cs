using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace seedsfromzion.DataAccess
{
    interface IDatabaseAccess
    {


        /// <summary>
        /// Performs a complete database restoration , using the given sql file backup.
        /// </summary>
        /// <param name="backupFile"></param>
        void restoreDb(string backupFile);

        /// <summary>
        /// Performs a complete database backup and saves it into the given 
        /// target directory
        /// </summary>
        /// <param name="targerDir"></param>
         void performDbBackup(string targerDir);

        /// <summary>
        /// performes a DML command on the database.
        /// information about defining MySqlCommand object can be found 
        /// here:
        /// http://www.csharp-station.com/Tutorials/AdoDotNet/Lesson06.aspx
        /// </summary>
        /// <param name="query"></param>
        void performDMLQuery(MySqlCommand query);

        /// <summary>
        /// performs a transcation of several commands,if one command
        /// fails then there is a rollback , otherwise commit.
        /// </summary>
        /// <param name="queries"></param>
         void performDMLTransaction(MySqlCommand[] queries);

        /// <summary>
        /// executes the given sql query and returns the answer in 
        /// a datatable.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
       DataTable getResultSetFromDb(MySqlCommand query);

        /// <summary>
        /// Used for retriving a single value from the database.
        /// executes the given sql query and returns the answer in 
        /// an Object which represent a scalar object.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        Object getScalarFromDb(MySqlCommand query);

        /// <summary>
        /// moves records older then the given date from the table WorkHours to the
        /// the same table which works on an archive engine.
        /// more information about Archive Engine:
        /// http://dev.mysql.com/tech-resources/articles/storage-engine.html
        /// </summary>
        /// <param name="startTime"></param>
        void optimizeDb(DateTime threshold);
    }
}
