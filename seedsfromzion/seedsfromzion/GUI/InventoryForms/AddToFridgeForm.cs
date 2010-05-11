using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using seedsfromzion.Managers;

namespace seedsfromzion.GUI.InventoryForms
{
    public partial class AddToFridgeForm : seedsfromzion.GUI.BaseForm
    {
        private DataTable plantsTable;

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
            AutoCompleteStringCollection collection= new AutoCompleteStringCollection();
            if (plantInput.Text.Equals(String.Empty))
            {
                actEmptyTextBox();
                return;
            }
            DataRow[] filteredRows = plantsTable.Select("name LIKE '" + plantInput.Text + "%'");
            for (int i = 0; i < filteredRows.Length; i++)
            {
                collection.Add((string)filteredRows[i]["name"]);
            }
            plantInput.AutoCompleteCustomSource = collection;
            typeCombo.Items.Clear();

        }

        private void actEmptyTextBox()
        {
            throw new NotImplementedException();
        }

        private void typeCombo_Click(object sender, EventArgs e)
        {
            if (plantInput.Text.Equals(String.Empty))
            {
                typeCombo.Items.Clear();
                return;
            }
            DataRow[] filteredRows = plantsTable.Select("name='"+plantInput.Text+ "'");
            for (int i = 0; i < filteredRows.Length; i++)
            {
                typeCombo.Items.Add((string)filteredRows[i]["type"]);
            }
        }


    }
}
