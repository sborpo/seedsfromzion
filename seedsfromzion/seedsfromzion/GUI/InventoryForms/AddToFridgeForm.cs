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
            plantInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            
        }

        private void initPlantsTable()
        {
            InventoryManager manager = new InventoryManager();
            plantsTable=manager.getPlantsTable();
        }

        private void plantInput_TextChanged(object sender, EventArgs e)
        {
            typeCombo.Items.Clear();
            plantInput.AutoCompleteCustomSource.Clear();
            if (plantInput.Text.Equals(String.Empty))
            {
                actEmptyTextBox();
                return;
            }
            DataRow[] filteredRows = plantsTable.Select("name LIKE '" + plantInput.Text + "%'");
            if ((filteredRows==null) || (filteredRows.Length == 0))
            {
                return;
            }
            string[] arr = new string[filteredRows.Length];
            for (int i = 0; i < filteredRows.Length; i++)
            {
                arr[i] =(string)((string)(filteredRows[i]["name"])).Clone();
                
            }
            plantInput.AutoCompleteCustomSource.AddRange(arr);
            
            

        }

        private void actEmptyTextBox()
        {
            
        }

        private void typeCombo_Click(object sender, EventArgs e)
        {
            typeCombo.Items.Clear();
            DataRow[] filteredRows = plantsTable.Select("name='"+plantInput.Text+ "'");
            for (int i = 0; i < filteredRows.Length; i++)
            {
                typeCombo.Items.Add((string)filteredRows[i]["type"]);
            }
        }


    }
}
