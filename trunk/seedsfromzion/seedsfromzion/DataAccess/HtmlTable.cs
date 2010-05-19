using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace seedsfromzion.DataAccess
{
    /// <summary>
    ///  This Html elements represnts a table in Html Document
    /// </summary>
    class HtmlTable : HtmlElem
    {
        /// <summary>
        /// The string which stores the Html representation of the table
        /// </summary>
        string myTable;

        /// <summary>
        /// Constructs an HtmlTable element from Data Table object. it parses
        /// the Data Table , and stores it in a string (html format)
        /// </summary>
        /// <param name="table"></param>
        public HtmlTable(DataTable table)
        {
            StringBuilder sb= new StringBuilder();
            sb.Append("<table class=\"maintable\"><thead><tr>");
            //print the columns headings into the string
            for (int i=table.Columns.Count-1; i>=0; i--)
            {
                sb.Append("<th>" + table.Columns[i].ColumnName + "</th>");
            }
            sb.Append("</tr></thead>");
            //go through the rows and print them into the string
            for (int i=table.Rows.Count-1; i>=0; i--)
            {
                sb.Append("<tr>");
                for (int j=table.Columns.Count-1; j>=0; j--)
                {
                    //value of each cell
                    sb.Append("<td>" + table.Rows[i][table.Columns[j]].ToString() + "</td>");
                }
                sb.Append("</tr>");
            }
            sb.Append("</table>");
            myTable = sb.ToString();

        }

        /// <summary>
        /// Returns a string which represent the table in html format
        /// </summary>
        /// <returns></returns>
        public override string  toString()
        {
            return String.Format("<div align={0}> {1}</div>",alignment,myTable);
        }
    }
}
