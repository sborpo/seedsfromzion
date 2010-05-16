using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using seedsfromzion.Managers;

namespace seedsfromzion.GUI.InventoryForms
{
    public partial class UpdateSproutingForm : seedsfromzion.GUI.BaseForm
    {
        DataTable sprouting;
        public UpdateSproutingForm()
        {
            InitializeComponent();
            initSproutingTable();
        }

        private void initSproutingTable()
        {
            InventoryManager manager = new InventoryManager();
            sprouting = manager.getSproutingNullable();
            
            dataGridViewX1.DataSource = sprouting;
            dataGridViewX1.Columns[0].Visible = false;
            dataGridViewX1.Columns[1].HeaderText = "שם הצמח";
            dataGridViewX1.Columns[2].HeaderText = "סוג";
            dataGridViewX1.Columns[3].HeaderText = "תאריך הגעה למקרר";
            dataGridViewX1.Columns[4].HeaderText = "תאריך זריעה";
            dataGridViewX1.Columns[5].HeaderText = "תאריך איסוף";
            dataGridViewX1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewX1.Refresh();



        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if ((dataGridViewX1.SelectedRows == null) || (dataGridViewX1.SelectedRows.Count == 0))
            {
                new ErrorWindow("לא נבחר איסוף לעדכון").Show();
                return;
            }
            int plantId = (int)(UInt32)dataGridViewX1.SelectedRows[0].Cells[0].Value;
            DateTime arrive =  (DateTime)dataGridViewX1.SelectedRows[0].Cells[3].Value;
            DateTime sow = (DateTime)dataGridViewX1.SelectedRows[0].Cells[4].Value;
            DateTime collect = (DateTime)dataGridViewX1.SelectedRows[0].Cells[5].Value;
            InventoryManager manager = new InventoryManager();
            manager.UpdateSproutingPercentage(plantId, arrive, sow, collect, doubleInput1.Value);
            initSproutingTable();
            new SuccessWindow().Show();

        }
    }
}
