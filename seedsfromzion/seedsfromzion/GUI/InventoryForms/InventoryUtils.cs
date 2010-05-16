using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevComponents.DotNetBar.Controls;

namespace seedsfromzion.GUI.InventoryForms
{
    public static class InventoryUtils
    {
        public static void FilterTable(DataTable dataTable,DataGridViewX dataGrid,string filterExp,params string [] columnsNames)
        {

            dataGrid.Rows.Clear();
            DataRow[] filteredRows = null;
            try
            {
                filteredRows = dataTable.Select(filterExp);
            }
            catch (Exception ex)
            {
                //gets unauthorized escape characters
                return;
            }

            if ((filteredRows == null) || (filteredRows.Length == 0))
            {
                return;
            }
            for (int i = 0; i < filteredRows.Length; i++)
            {
                object[] row = new object[columnsNames.Length];
                for (int j = 0; j < columnsNames.Length; j++)
                {
                    row[j]=filteredRows[i][columnsNames[j]];
                }
                dataGrid.Rows.Add(row);
            }
        }
    }
}
