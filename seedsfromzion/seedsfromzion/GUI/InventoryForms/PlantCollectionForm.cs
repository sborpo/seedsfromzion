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
    public partial class PlantCollectionForm : seedsfromzion.GUI.BaseForm
    {

        DataTable fieldTable;
        public PlantCollectionForm()
        {
            InitializeComponent();
            initFieldTable();
        }

        private void initFieldTable()
        {
            InventoryManager manager = new InventoryManager();
            fieldTable = manager.getFieldTable();
            textBoxX1_TextChanged(null, null);
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxX1.Text.Equals(String.Empty))
            {
                dataGridViewX1.Rows.Clear();
                return;
            }
            InventoryUtils.FilterTable(fieldTable, dataGridViewX1, "name LIKE '" + textBoxX1.Text + "%'", "plantId", "name", "type", "arrivingDate","sowingDate", "units");
        }

        private void dataGridViewX1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count == 0)
            {
                return;
            }
            double units = (double)dataGridViewX1.SelectedRows[0].Cells[5].Value;
            doubleInput2.MaxValue = units;
            doubleInput2.Value = units;
        }
    }
}
