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
        public OrdersMainForm()
        {
            InitializeComponent();
        }

        public void refreshStorageTable()
        {
            //Table : id , name , type, storageId, units, location
            MySqlCommand command = new MySqlCommand("SELECT Plant.plantId AS id ,Plant.name AS name , Plant.type As type , Storage.id AS storageId, Storage.units AS units,Storage.location AS location FROM seedsdb.finishedstorage Storage, seedsdb.planttypes Plant WHERE Storage.plantId=Plant.plantId");
            Storage = DataAccess.DatabaseAccess.getResultSetFromDb(command);
            DataRow[] rows = new DataRow[Storage.Rows.Count];
            for (int i = 0; i < Storage.Rows.Count; i++)
            {
                rows[i] = Storage.Rows[i];
            }
            refreshStorageView(rows);
            
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            DataRow [] filteredRows=Storage.Select("name='" + textBoxX1.Text + "'");
            refreshStorageView(filteredRows);

        }

        private void refreshStorageView(DataRow[] filteredRows)
        {
            storageGrid.Rows.Clear();
            foreach (DataRow row in filteredRows)
            {
                storageGrid.Rows.Add(row["name"], row["type"], row["storageId"], row["units"]);
            }
            storageGrid.Refresh();
        }
    }
}
