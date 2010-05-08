using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using seedsfromzion.Managers;
using MySql.Data.MySqlClient;

namespace seedsfromzion.GUI.OrdersForms
{
    public partial class OrdersMainForm : seedsfromzion.GUI.BaseForm
    {
        DataTable Storage;
        DataTable Order;
        bool loading;
        public OrdersMainForm()
        {
            loading = true;
            InitializeComponent();
            refreshStorageTable();
            doubleInput1.MinValue = 0;
            loading = false;
        }

        /// <summary>
        /// Sets the storage table
        /// </summary>
        public void refreshStorageTable()
        {
            //TODO: should be a function in manager, do not access to DB from GUI
            //Table : id , name , type, storageId, units, location
            MySqlCommand command = new MySqlCommand("SELECT Plant.plantId AS id ,Plant.name AS name , Plant.type As type , Storage.id AS storageId, Storage.units AS units,Storage.location AS location FROM seedsdb.finishedstorage Storage, seedsdb.planttypes Plant WHERE Storage.plantId=Plant.plantId");
            Storage = DataAccess.DatabaseAccess.getResultSetFromDb(command);
            displayAllStorage();
            
        }

        /// <summary>
        /// The user typed a plant name to filter
        /// the method filters the storage Grid View according to the 
        /// name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxX1.Text.Equals(String.Empty))
            {
                actEmptyTextBox();
                return;
            }
            DataRow[] filteredRows = Storage.Select("name LIKE '" + textBoxX1.Text + "%'");
            refreshStorageView(filteredRows);

        }

        /// <summary>
        /// handles the situation that the filter box is empty
        /// </summary>
        private void actEmptyTextBox()
        {
            displayAllStorage();
        }

        /// <summary>
        /// Displays the whole storage in the StorageGridView
        /// </summary>
        private void displayAllStorage()
        {
            DataRow[] rows = new DataRow[Storage.Rows.Count];
            for (int i = 0; i < Storage.Rows.Count; i++)
            {
                rows[i] = Storage.Rows[i];
            }
            refreshStorageView(rows);
        }

        /// <summary>
        /// Refreshes the storageGridView
        /// </summary>
        /// <param name="filteredRows"></param>
        private void refreshStorageView(DataRow[] filteredRows)
        {
            loading = true;
            storageGrid.Rows.Clear();
            foreach (DataRow row in filteredRows)
            {
                storageGrid.Rows.Add(row["id"],row["name"], row["type"], row["storageId"], row["units"]);
            }
            storageGrid.Refresh();
            loading = false;
        }

        private void OrdersMainForm_Load(object sender, EventArgs e)
        {

        }

      

        private void addButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewSelectedRowCollection selectedRows = storageGrid.SelectedRows;
            //checking that a row was selected:
            if (selectedRows.Count == 0)
            {
                new ErrorWindow("לא נבחר צמח להוספה להזמנה").Show();
                return;
            }
            //retrieving the amount to be added to the order:
            double amount = doubleInput1.Value;
            double rowUnits = (double)selectedRows[0].Cells["units"].Value;
            //checking that there is enough amount in storage:
            if ( rowUnits < amount)
            {
                new ErrorWindow("אין מספיק כמות במלאי להוספה להזמנה").Show();
                return;
            }
            //TODO:: adding the new item to the order

        }

        private void storageGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //System.Windows.Forms.DataGridViewSelectedRowCollection selectedRows = storageGrid.SelectedRows;
            //doubleInput1.MaxValue = (double)selectedRows[0].Cells["units"].Value; 
        }

        private void storageGrid_SelectionChanged(object sender, EventArgs e)
        {
           
            System.Windows.Forms.DataGridViewSelectedRowCollection selectedRows = storageGrid.SelectedRows;
            if (selectedRows.Count == 0)
            {
                return;
            }
            doubleInput1.MaxValue = (double)selectedRows[0].Cells["units"].Value; 
        }
    }
}
