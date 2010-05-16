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
            for (int i=table.Columns.Count-1; i>=0; i--)
            {
                sb.Append("<th>" + table.Columns[i].ColumnName + "</th>");
            }
            sb.Append("</tr></thead>");
            for (int i=table.Rows.Count-1; i>=0; i--)
            {
                sb.Append("<tr>");
                for (int j=table.Columns.Count-1; j>=0; j--)
                {
                    sb.Append("<td>" + table.Rows[i][table.Columns[j]].ToString() + "</td>");
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
