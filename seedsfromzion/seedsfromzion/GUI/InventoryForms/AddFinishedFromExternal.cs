using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace seedsfromzion.GUI.InventoryForms
{
    public partial class AddFinishedFromExternal : seedsfromzion.GUI.BaseForm
    {
        public AddFinishedFromExternal()
        {
            InitializeComponent();
            initPlantsTable();
            seedsFromZion mainForm = (seedsFromZion)this.MdiParent;
            mainForm.favoriteClicked += new seedsFromZion.favoriteClickedHandler(mainForm_favoriteClicked);
        }


        void mainForm_favoriteClicked(int plantId)
        {
            InventoryUtils.FilterTable(plantsTable, dataGridViewX1, "plantId =" + plantId.ToString(), "plantId", "name", "type");
        }


        private void initPlantsTable()
        {
            InventoryManager manager = new InventoryManager();
            plantsTable = manager.getPlantsTable();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            if (plantInput.Text.Equals(String.Empty))
            {
                dataGridViewX1.Rows.Clear();
                return;
            }
            InventoryUtils.FilterTable(plantsTable, dataGridViewX1, "name LIKE '" + plantInput.Text + "%'", "plantId", "name", "type");

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
