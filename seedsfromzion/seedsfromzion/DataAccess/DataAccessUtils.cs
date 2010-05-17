using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace seedsfromzion.DataAccess
{
    /// <summary>
    /// This class is an auxilary class for constructing queries.
    /// </summary>
    public class DataAccessUtils
    {
        /// <summary>
        /// An helper function which gets a query , where query's parameters
        /// contains the @ symbol.  
        /// </summary>
        /// <param name="query">a string query where it's parameters are with @ symbol</param>
        /// <param name="paramsValues">a string array with even size , which contains parameter-value couples
        /// in this format:s
        /// @param1, value1, @param2 ,value2,......
        /// </param>
        /// <returns></returns>
        public static  MySqlCommand commandBuilder(String query,params string[] paramsValues)
        {
            //if the array length is not even , so there is no match between
            //parameters names and values
            if (paramsValues.Length%2!=0)
            {
                return null;
            }
            MySqlCommand command= new MySqlCommand(query);
            for (int i=0; i<paramsValues.Length-1; i+=2)
            {
                  //sets the parameters to the command
                  MySqlParameter parameter = new MySqlParameter();
                  parameter.ParameterName=paramsValues[i];
                  parameter.Value=paramsValues[i+1];
                  command.Parameters.Add(parameter);
            }
            return command;
        }

        /// <summary>
        /// returns true if query's execution returned any row , otherwise returns false
        /// </summary>
        /// <param name="query"></param>
        /// <param name="paramValues"></param>
        /// <returns></returns>
        public static bool rowExists(string query, params string[] paramValues)
        {
            MySqlCommand command = commandBuilder(query, paramValues);
            DataTable res = DatabaseAccess.getResultSetFromDb(command);
            if (res.Rows.Count != 0)
                return true;
            return false;
        }
    }
}
