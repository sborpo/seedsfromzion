using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using seedsfromzion.Managers;
using seedsfromzion.GUI;

namespace seedsfromzion.GUI.InventoryForms
{
    public partial class AddToFridgeForm : seedsfromzion.GUI.BaseForm
    {
        private DataTable plantsTable;

        public AddToFridgeForm(seedsFromZion mainForm)
        {
           
            InitializeComponent();
            initPlantsTable();
            mainForm.favoriteClicked += new seedsFromZion.favoriteClickedHandler(mainForm_favoriteClicked);

            
        }

        void mainForm_favoriteClicked(int plantId)
        {
            InventoryUtils.FilterTable(plantsTable, dataGridViewX1, "plantId =" + plantId.ToString(), "plantId", "name", "type");
        }


        private void initPlantsTable()
        {
            InventoryManager manager = new InventoryManager();
            plantsTable=manager.getPlantsTable();
        }

        private void plantInput_TextChanged(object sender, EventArgs e)
        {
            if (plantInput.Text.Equals(String.Empty))
            {
                dataGridViewX1.Rows.Clear();
                return;
            }
            InventoryUtils.FilterTable(plantsTable, dataGridViewX1, "name LIKE '" + plantInput.Text + "%'", "plantId", "name", "type");
        }

        private void actEmptyTextBox()
        {
            
        }



        private void buttonX1_Click(object sender, EventArgs e)
        {
            InventoryManager manager = new InventoryManager();
            if ((dataGridViewX1.SelectedRows==null) || (dataGridViewX1.SelectedRows.Count == 0))
            {
                new ErrorWindow("לא נבחר צמח להוספה").Show();
                return;
            }
            if (location.Text.Equals(String.Empty))
            {
                new ErrorWindow("לא נבחר מיקום במקרר").Show();
                return;
            }
            int plantId = (int)(UInt32)(dataGridViewX1.SelectedRows[0].Cells[0].Value);
            try
            {
                manager.AddToFridge(plantId, dateTimePicker1.Value, Math.Round(units.Value,2), location.Text);
            }
            catch (InventoryManager.KeyException ex)
            {
                new ErrorWindow("לא ניתן להכניס את אותו הצמח באותו היום למקרר יותר מפעם אחת").Show();
                return;
            }
            new SuccessWindow().Show();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }





    }
}
