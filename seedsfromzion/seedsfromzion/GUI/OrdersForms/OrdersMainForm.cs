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
            Order = new DataTable();
            Order.Clear();
            Order.Columns.Add("orderId");
            Order.Columns.Add("orderName");
            Order.Columns.Add("orderType");
            Order.Columns.Add("orderStorageId");
            Order.Columns.Add("orderUnits");
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
            System.Windows.Forms.DataGridViewRowCollection orderRows = orderGrid.Rows;
            
            //checking that the item is not already in the order:
            System.UInt32 pid = (System.UInt32)selectedRows[0].Cells["id"].Value;
            for (int i = 0; i < Order.Rows.Count; i++)
            {
                DataRow row = Order.Rows[i];
                
                if (pid.ToString().Equals(row["orderId"].ToString()))
                {
                    new ErrorWindow("הפריט הנבחר קיים כבר בהזמנה").Show();
                    return;
                }
            }
                   
            //adding the new item to the order view:
            string pname = (string)selectedRows[0].Cells["name"].Value;
            string ptype = (string)selectedRows[0].Cells["type"].Value;
            System.UInt32 pstorageId = (System.UInt32)selectedRows[0].Cells["storageId"].Value;
            orderGrid.Rows.Add(pid, pname, ptype, pstorageId, amount);
            orderGrid.Refresh();
            //adding the new item to the order
            Order.Rows.Add(pid, pname, ptype, pstorageId, amount);
            //refreshing the storage view:
            refreshStorageTable();
            

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

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if(Order.Rows.Count == 0)                
            {
                new ErrorWindow("לא נבחר אף פריט להזמנה").Show();
                return;
            }
            if(idBox.Value == 0)                
            {
                new ErrorWindow("נא לעדכן ח.פ\\ת.ז של המזמין").Show();
                return;
            }
            if(nameBox.Text == "")                
            {
                new ErrorWindow("נא לעדכן את השם של המזמין").Show();
                return;
            }
            if(phoneBoxX.Text == "")                
            {
                new ErrorWindow("נא לעדכן את הטלפון של המזמין").Show();
                return;
            }
            if(emailBoxX.Text == "")                
            {
                new ErrorWindow("נא לעדכן את האי-מייל של המזמין").Show();
                return;
            }
            if(dateTimeInput.IsEmpty == true)                
            {
                new ErrorWindow("נא לעדכן את תאריך האספקה").Show();
                return;
            }
            DataStructures.ClientInfo clientInfo = new seedsfromzion.DataStructures.ClientInfo();
            DataStructures.OrderInfo orderInfo = new seedsfromzion.DataStructures.OrderInfo();
            //setting the client info:
            clientInfo.clientId         = idBox.Value ;
            clientInfo.name             = nameBox.Text;
            clientInfo.phoneNumber      = phoneBoxX.Text;
            clientInfo.email            = emailBoxX.Text;
            //setting the order info:
            orderInfo.dueDate           = dateTimeInput.Value;
            orderInfo.orderDate         = DateTime.Today;
            orderInfo.status            = '0';
            orderInfo.plantId           = new int[Order.Rows.Count];
            orderInfo.fromStorageId     = new string[Order.Rows.Count];
            orderInfo.units             = new double[Order.Rows.Count];
            //TODO:: orderInfo.orderId = Managers.OrderManager.getNextOrderId();
            for (int i = 0; i < Order.Rows.Count; i++)
            {
                orderInfo.plantId[i] = (int)Order.Rows[i][0];
                orderInfo.fromStorageId[i] = (string)Order.Rows[i][3];
                orderInfo.units[i] = (double)Order.Rows[i][4];
            }
            //TODO: addorder

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewSelectedRowCollection selectedRows = orderGrid.SelectedRows;
            //checking that a row was selected:
            if (selectedRows.Count == 0)
            {
                new ErrorWindow("לא נבחר צמח להסרה").Show();
                return;
            }
            System.UInt32 pid = (System.UInt32)selectedRows[0].Cells[0].Value;            
            string pname = (string)selectedRows[0].Cells[1].Value;
            string ptype = (string)selectedRows[0].Cells[2].Value;
            System.UInt32 pstorageId = (System.UInt32)selectedRows[0].Cells[3].Value;
            double rowUnits = (double)selectedRows[0].Cells[4].Value;
            
            orderGrid.Rows.Remove(selectedRows[0]);
            orderGrid.Refresh();
            //TODO:: removing the item from the order
            DataTable row = new DataTable();
            row.Columns.Add("orderId");
            row.Columns.Add("orderName");
            row.Columns.Add("orderType");
            row.Columns.Add("orderStorageId");
            row.Columns.Add("orderUnits");
            row.Rows.Add(pid, pname, pstorageId, rowUnits);

            /*row[0][1] = pname;
            row[0][2] = ptype;
            row[0][3] = pstorageId;
            row[0][4] = rowUnits;*/
            Order.Rows.Remove(row.Rows[0]);
            
        }
    }
}
