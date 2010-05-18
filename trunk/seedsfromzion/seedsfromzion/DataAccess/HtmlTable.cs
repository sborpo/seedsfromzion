using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace seedsfromzion.DataAccess
{
    class HtmlTable : HtmlElem
    {
        string myTable;
        public HtmlTable(DataTable table)
        {
            StringBuilder sb= new StringBuilder();
            sb.Append("<table class=\"maintable\"><thead><tr>");
            foreach (DataColumn col in table.Columns)
            {
                sb.Append("<th>"+col.ColumnName+"</th>");
            }
            sb.Append("</tr></thead>");
            foreach (DataRow row in table.Rows)
            {
                sb.Append("<tr>");
                foreach (DataColumn col in table.Columns)
                {
                    sb.Append("<td>" + row[col].ToString() + "</td>");
                }
                sb.Append("</tr>");
            }
            sb.Append("</table>");
            myTable = sb.ToString();

        }

        public override string  toString()
        {
            return String.Format("<div align={0}> {1}</div>",alignment,myTable);
        }
    }
}
