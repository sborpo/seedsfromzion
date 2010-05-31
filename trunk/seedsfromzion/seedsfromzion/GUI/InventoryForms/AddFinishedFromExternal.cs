using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using seedsfromzion.Managers;
using seedsfromzion.DataAccess;

namespace seedsfromzion.GUI.InventoryForms
{
    public partial class AddFinishedFromExternal : seedsfromzion.GUI.BaseForm
    {
        private DataTable plantsTable;
        private seedsFromZion mainForm;
        public AddFinishedFromExternal()
        {
            InitializeComponent();
            //set minimum value
            doubleInput1.MinValue = ConfigFile.MIN_VALUE;
            initPlantsTable();
           
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
            if (textBoxX1.Text.Equals(String.Empty))
            {
                dataGridViewX1.Rows.Clear();
                return;
            }
            InventoryUtils.FilterTable(plantsTable, dataGridViewX1, "name LIKE '" + textBoxX1.Text + "%'", "plantId", "name", "type");

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            InventoryManager manager = new InventoryManager();
            if ((dataGridViewX1.SelectedRows == null) || (dataGridViewX1.SelectedRows.Count == 0))
            {
                new ErrorWindow("לא נבחר צמח להוספה").Show();
                return;
            }
            if (storageLocation.Text.Equals(String.Empty))
            {
                new ErrorWindow("לא נבחר מיקום במחסן").Show();
                return;
            }
            int plantId = (int)(UInt32)(dataGridViewX1.SelectedRows[0].Cells[0].Value);
            manager.AddToFinishedStorageExternal(plantId, integerInput1.Value, doubleInput1.Value, storageLocation.Text);
            new SuccessWindow().Show();

        }

        private void AddFinishedFromExternal_Load(object sender, EventArgs e)
        {
            seedsFromZion mainForm = (seedsFromZion)this.MdiParent;
            mainForm.favoriteClicked += new seedsFromZion.favoriteClickedHandler(mainForm_favoriteClicked);
            this.mainForm = mainForm;
            this.FormClosing += new FormClosingEventHandler(AddFinishedFromExternal_FormClosing);
        }

        void AddFinishedFromExternal_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.favoriteClicked -= mainForm_favoriteClicked;
        }
    }
}
