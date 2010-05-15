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
        private DataTable types;

        public AddToFridgeForm()
        {
           
            InitializeComponent();
            initPlantsTable();

            
        }

        private void initPlantsTable()
        {
            InventoryManager manager = new InventoryManager();
            plantsTable=manager.getPlantsTable();
        }

        private void plantInput_TextChanged(object sender, EventArgs e)
        {

            dataGridViewX1.Rows.Clear();
            if (plantInput.Text.Equals(String.Empty))
            {
                actEmptyTextBox();
                return;
            }
            DataRow[] filteredRows = null;
            try
            {
                 filteredRows = plantsTable.Select("name LIKE '" + plantInput.Text + "%'");
            }
            catch (Exception ex)
            {
                //gets unauthorized escape characters
                return;
            }
            
            if ((filteredRows==null) || (filteredRows.Length == 0))
            {
                return;
            }
            for (int i = 0; i < filteredRows.Length; i++)
            {
                dataGridViewX1.Rows.Add(filteredRows[i]["plantId"], filteredRows[i]["name"], filteredRows[i]["type"]);
                
            }
            
            

        }

        private void actEmptyTextBox()
        {
            
        }



        private void buttonX1_Click(object sender, EventArgs e)
        {
            InventoryManager manager = new InventoryManager();
            if (dataGridViewX1.SelectedRows.Count == 0)
            {
                new ErrorWindow("לא נבחר צמח להוספה").Show();
            }
            int plantId = (int)(UInt32)(dataGridViewX1.SelectedRows[0].Cells[0].Value);
            try
            {
                manager.AddToFridge(plantId, dateTimeInput1.Value, units.Value, location.Text);
            }
            catch (InventoryManager.KeyException ex)
            {
                new ErrorWindow("לא ניתן להכניס את אותו הצמח באותו היום למקרר יותר מפעם אחת").Show();
            }
            new SuccessWindow().Show();
        }





    }
}
