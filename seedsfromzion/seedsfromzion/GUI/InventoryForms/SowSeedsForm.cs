using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using seedsfromzion.Managers;
using seedsfromzion.GUI;
using seedsfromzion.DataAccess;
namespace seedsfromzion.GUI.InventoryForms
{
    public partial class SowSeedsForm : seedsfromzion.GUI.BaseForm
    {
        seedsFromZion mainForm;
        DataTable fridgeTable;
        public SowSeedsForm(seedsFromZion mainForm)
        {
            InitializeComponent();
            //setting the minimum value
            doubleInput1.MinValue = ConfigFile.MIN_VALUE;
            initFridgeTable();
            mainForm.favoriteClicked += new seedsFromZion.favoriteClickedHandler(mainForm_favoriteClicked);
        }

        void mainForm_favoriteClicked(int plantId)
        {
            InventoryUtils.FilterTable(fridgeTable, dataGridViewX1, "plantId = "+ plantId.ToString(), "plantId", "name", "type", "arrivingDate", "units","location");
        }

        private void initFridgeTable()
        {
            InventoryManager manager = new InventoryManager();
            fridgeTable = manager.getFridgeTable();
            plantInput_TextChanged(null, null);
        }

        private void plantInput_TextChanged(object sender, EventArgs e)
        {
            if (plantInput.Text.Equals(String.Empty))
            {
                dataGridViewX1.Rows.Clear();
                return;
            }
            InventoryUtils.FilterTable(fridgeTable, dataGridViewX1, "name LIKE '" + plantInput.Text + "%'", "plantId", "name", "type","arrivingDate","units","location");
        }

        private void dataGridViewX1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count == 0)
            {
                return;
            }
            double units = (double)dataGridViewX1.SelectedRows[0].Cells[4].Value;
            doubleInput1.MaxValue = units;
            doubleInput1.Value = units;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            InventoryManager manager = new InventoryManager();
            if ((dataGridViewX1.SelectedRows == null) || (dataGridViewX1.SelectedRows.Count == 0))
            {
                new ErrorWindow("לא נבחר צמח מהמקרר").Show();
                return;
            }
            
            if (textBoxX1.Text.Equals(String.Empty))
            {
                new ErrorWindow("יש להכניס את המיקום בשדה").Show();
                return;
            }
            if (((DateTime)dataGridViewX1.SelectedRows[0].Cells[3].Value).CompareTo(dateTimePicker1.Value)>0)
            {
                new ErrorWindow("יש להכניס תאריך זריעה המאוחר יותר מתאריך"+"\n"+"ההכנסה למקרר").Show();
                return;
            }
            try
            {
                manager.SowSeeds((int)(UInt32)dataGridViewX1.SelectedRows[0].Cells[0].Value, (DateTime)dataGridViewX1.SelectedRows[0].Cells[3].Value, dateTimePicker1.Value, doubleInput1.Value, textBoxX1.Text);
            }
            catch (InventoryManager.KeyException ex)
            {
                new ErrorWindow("לא ניתן לזרוע את אותו הצמח באותו היום יותר מפעם אחת").Show();
                return;
            }
            initFridgeTable();

            new SuccessWindow().Show();
        }

        private void SowSeedsForm_Load(object sender, EventArgs e)
        {
            mainForm = (seedsFromZion)this.MdiParent;
            this.FormClosing += new FormClosingEventHandler(SowSeedsForm_FormClosing);
        }

        void SowSeedsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.favoriteClicked -= mainForm_favoriteClicked;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count == 0)
            {
                return;
            }
            DateTime arrive = (DateTime)dataGridViewX1.SelectedRows[0].Cells[3].Value;
            int plantId = (int)(UInt32)dataGridViewX1.SelectedRows[0].Cells[0].Value;
            InventoryManager manager = new InventoryManager();
            //remove the plant from the database
            manager.removePlantFromFridge(plantId, arrive);
            //remove the plant from the grid view
            dataGridViewX1.Rows.Remove(dataGridViewX1.SelectedRows[0]);
        }
    }
}
