using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using seedsfromzion.DataStructures;
using seedsfromzion.Managers;
using seedsfromzion.GUI.InventoryForms;

namespace seedsfromzion.GUI.OrdersForms
{
    public partial class SearchOrderForm : seedsfromzion.GUI.BaseForm
    {
        DataTable Orders;
        OrderInfo m_selectedOrder;
        ClientInfo m_selectedClient;
        bool loading;
        public SearchOrderForm()
        {
            InitializeComponent();
            Orders = new DataTable();
            Orders.Clear();
            orderGrid.Rows.Clear();
            orderGrid.Refresh();
            detailsGrid.Rows.Clear();
            Orders.Columns.Add("orderId");
            Orders.Columns.Add("clientId");
            Orders.Columns.Add("orderDate");
            Orders.Columns.Add("dueDate");
            refreshOrderTable();
            
        }

        /// <summary>
        /// Sets the orders table
        /// </summary>
        public void refreshOrderTable()
        {
            //TODO: should be a function in manager, do not access to DB from GUI
            //Table : id , name , type, storageId, units, location
            MySqlCommand command = new MySqlCommand("SELECT Orders.orderId AS orderId ,Orders.clientId AS clientId , Orders.orderDate As orderDate , Orders.dueDate AS dueDate FROM seedsdb.orders Orders");
            Orders = DataAccess.DatabaseAccess.getResultSetFromDb(command);
            displayAllOrders();


        }
        /// <summary>
        /// The user typed a order id to filter
        /// the method filters the orders Grid View according to the 
        /// id
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
            DataRow[] filteredRows = Orders.Select("orderId LIKE '" + textBoxX1.Text + "%'");
            refreshOrdersView(filteredRows);

        }
        /// <summary>
        /// handles the situation that the filter box is empty
        /// </summary>
        private void actEmptyTextBox()
        {
            displayAllOrders();
        }

        /// <summary>
        /// Displays the whole storage in the StorageGridView
        /// </summary>
        private void displayAllOrders()
        {
            DataRow[] rows = new DataRow[Orders.Rows.Count];
            for (int i = 0; i < Orders.Rows.Count; i++)
            {
                rows[i] = Orders.Rows[i];
            }
            refreshOrdersView(rows);
        }

        /// <summary>
        /// Refreshes the storageGridView
        /// </summary>
        /// <param name="filteredRows"></param>
        private void refreshOrdersView(DataRow[] filteredRows)
        {
            loading = true;
            orderGrid.Rows.Clear();
            foreach (DataRow row in filteredRows)
            {
                orderGrid.Rows.Add(row["orderId"], row["clientId"], row["orderDate"], row["dueDate"]);
            }
            orderGrid.Refresh();
            loading = false;
        }
        private void orderGrid_SelectionChanged(object sender, EventArgs e)
        {

            System.Windows.Forms.DataGridViewSelectedRowCollection selectedRows = orderGrid.SelectedRows;

            if (selectedRows.Count == 0)
            {
                return;
            }
            OrderManager orderManager = new OrderManager();
            System.UInt32 orderId = (System.UInt32)selectedRows[0].Cells["orderId"].Value;
            System.UInt32 clientId = (System.UInt32)selectedRows[0].Cells["clientId"].Value;
            m_selectedOrder = orderManager.findOrder((int)orderId, (int)clientId);//(double)selectedRows[0].Cells["units"].Value;
            m_selectedClient = orderManager.findClient((int)clientId);
            displayOrder(m_selectedOrder);
        }

        private void displayOrder(OrderInfo order)
        {
            InventoryManager invManager = new InventoryManager();
            int length = order.plantId.Length;
            detailsGrid.Rows.Clear();
            for (int i = 0; i < length; i++)
            {
                DataRow row = invManager.findPlantById(order.plantId[i].ToString());
                detailsGrid.Rows.Add((string)row["name"], order.units[i]);
            }
            detailsGrid.Refresh();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewSelectedRowCollection selectedRows = orderGrid.SelectedRows;

            if (selectedRows.Count == 0)
            {
                new ErrorWindow("לא נבחרה הזמנה לביטול").Show();
                return;
            }
            //TODO: print confiramtion window!!

            OrderManager orderManager = new OrderManager();
            System.UInt32 orderId = (System.UInt32)selectedRows[0].Cells["orderId"].Value;
            System.UInt32 clientId = (System.UInt32)selectedRows[0].Cells["clientId"].Value;
            //canceling the order:
            orderManager.cancelOrder((int)orderId, (int)clientId);
            //refreshing the view:
            detailsGrid.Rows.Clear();
            detailsGrid.Refresh();
            refreshOrderTable();
            new SuccessWindow().Show();
            return;
        }

        private void editOrder_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewSelectedRowCollection selectedRows = orderGrid.SelectedRows;

            if (selectedRows.Count == 0)
            {
                new ErrorWindow("לא נבחרה הזמנה לעריכה").Show();
                return;
            }

            OrdersMainForm form = new OrdersMainForm(m_selectedOrder, m_selectedClient);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

    }
}
