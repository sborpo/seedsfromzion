using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using seedsfromzion.Managers;
namespace seedsfromzion.GUI.InventoryForms
{
    public partial class SowSeedsForm : seedsfromzion.GUI.BaseForm
    {
        DataTable fridgeTable;
        public SowSeedsForm()
        {
            InitializeComponent();
            initFridgeTable();
        }

        private void initFridgeTable()
        {
            InventoryManager manager = new InventoryManager();
            fridgeTable = manager.getFridgeTable();
        }

        private void plantInput_TextChanged(object sender, EventArgs e)
        {
            if (plantInput.Text.Equals(String.Empty))
            {
                dataGridViewX1.Rows.Clear();
                return;
            }
            InventoryUtils.FilterTable(fridgeTable, dataGridViewX1, "name LIKE '" + plantInput.Text + "%'", "plantId", "name", "type","arrivingDate","units");
        }
    }
}
