using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevComponents.DotNetBar.Controls;

namespace seedsfromzion.GUI.InventoryForms
{
    /// <summary>
    /// This class is an auxilary class for the inventory GUI models.
    /// </summary>
    public static class InventoryUtils
    {
        /// <summary>
        /// This method gives a filtration option. It recieves a dataTable 
        /// which should be filtered , the dataGridView where the result will be
        /// displayed , a filter expression which according to it , the datatable rows
        /// will be filtered , and the column name that should be presented on the Grid
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="dataGrid"></param>
        /// <param name="filterExp"></param>
        /// <param name="columnsNames"></param>
        public static void FilterTable(DataTable dataTable,DataGridViewX dataGrid,string filterExp,params string [] columnsNames)
        {
            //first clear the rows of the grid
            dataGrid.Rows.Clear();
            DataRow[] filteredRows = null;
            try
            {
                //filter the datatable and get the filtered rows
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
            //add the rows to the gridView according to the given column name
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
