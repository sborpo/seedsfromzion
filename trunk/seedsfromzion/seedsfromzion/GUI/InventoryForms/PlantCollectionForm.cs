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
    public partial class PlantCollectionForm : seedsfromzion.GUI.BaseForm
    {
        seedsFromZion mainForm;
        DataTable fieldTable;
        public PlantCollectionForm(seedsFromZion mainForm)
        {
            InitializeComponent();
            doubleInput2.MinValue = ConfigFile.MIN_VALUE;
            doubleInput3.MinValue = ConfigFile.MIN_VALUE;
            initFieldTable();
            mainForm.favoriteClicked += new seedsFromZion.favoriteClickedHandler(mainForm_favoriteClicked);
        }

        void mainForm_favoriteClicked(int plantId)
        {
            InventoryUtils.FilterTable(fieldTable, dataGridViewX1, "plantId = "+plantId.ToString(), "plantId", "name", "type", "arrivingDate", "sowingDate", "units");
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
            if (textBoxX2.Text.Equals(String.Empty))
            {
                new ErrorWindow("יש להכניס את המיקום במחסן").Show();
                return;
            }
            DateTime arrive = (DateTime)dataGridViewX1.SelectedRows[0].Cells[3].Value;
            DateTime sow = (DateTime)dataGridViewX1.SelectedRows[0].Cells[4].Value;
            if (arrive.CompareTo(dateTimePicker1.Value) > 0)
            {
                new ErrorWindow("יש להכניס תאריך איסוף המאוחר יותר מתאריך" + "\n" + "הזריעה").Show();
                return;
            }
            int plantId=(int)(UInt32)dataGridViewX1.SelectedRows[0].Cells[0].Value;
            try
            {
                manager.CollectPlants(plantId, arrive, sow, dateTimePicker1.Value, doubleInput2.Value, doubleInput3.Value, integerInput1.Value, textBoxX2.Text, doubleInput1.Value);
            }
            catch (InventoryManager.KeyException ex)
            {
                new ErrorWindow("צמח זה כבר הוכנס היום למחסן").Show();
                return;
            }
            initFieldTable();

            new SuccessWindow().Show();
        }

        private void PlantCollectionForm_Load(object sender, EventArgs e)
        {
            mainForm = (seedsFromZion)this.MdiParent;
            this.FormClosing += new FormClosingEventHandler(PlantCollectionForm_FormClosing);
        }

        void PlantCollectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.favoriteClicked -= mainForm_favoriteClicked;
        }

        private void removePlantButton_Click(object sender, EventArgs e)
        {
            DialogBox dialog = new DialogBox();
            if ((dataGridViewX1.SelectedRows.Count == 0) || ((dialog.ShowDialog() != DialogResult.OK)))
            {
                return;
            }
            DateTime arrive = (DateTime)dataGridViewX1.SelectedRows[0].Cells[3].Value;
            DateTime sow = (DateTime)dataGridViewX1.SelectedRows[0].Cells[4].Value;
            int plantId = (int)(UInt32)dataGridViewX1.SelectedRows[0].Cells[0].Value;
            InventoryManager manager = new InventoryManager();
            //remove the plant from the database
            manager.removePlantFromField(plantId, arrive, sow);
            //remove the plant from the grid view
            dataGridViewX1.Rows.Remove(dataGridViewX1.SelectedRows[0]);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
