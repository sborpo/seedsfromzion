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
        public PlantCollectionForm(seedsFromZion mainForm)
        {
            InitializeComponent();
            initFieldTable();
            mainForm.favoriteClicked += new seedsFromZion.favoriteClickedHandler(mainForm_favoriteClicked);
        }

        void mainForm_favoriteClicked(int plantId)
        {
            throw new NotImplementedException();
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

        private void buttonX1_Click(object sender, EventArgs e)
        {
            InventoryManager manager = new InventoryManager();
            if ((dataGridViewX1.SelectedRows == null) || (dataGridViewX1.SelectedRows.Count == 0))
            {
                new ErrorWindow("לא נבחר צמח מהשדה").Show();
                return;
            }
            if (textBoxX1.Text.Equals(String.Empty))
            {
                new ErrorWindow("יש להכניס את המיקום במחסן").Show();
                return;
            }
            DateTime arrive = (DateTime)dataGridViewX1.SelectedRows[0].Cells[3].Value;
            DateTime sow = (DateTime)dataGridViewX1.SelectedRows[0].Cells[4].Value;
            int plantId=(int)(UInt32)dataGridViewX1.SelectedRows[0].Cells[0].Value;
            try
            {
                manager.CollectPlants(plantId, arrive, sow, dateTimePicker1.Value, doubleInput2.Value, doubleInput3.Value, integerInput1.Value, textBoxX1.Text, doubleInput1.Value);
            }
            catch (InventoryManager.KeyException ex)
            {
                new ErrorWindow("צמח זה כבר הוכנס היום למחסן").Show();
                return;
            }
            initFieldTable();

            new SuccessWindow().Show();
        }
    }
}
