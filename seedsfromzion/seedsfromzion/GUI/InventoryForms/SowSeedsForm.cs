﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using seedsfromzion.Managers;
using seedsfromzion.GUI;
namespace seedsfromzion.GUI.InventoryForms
{
    public partial class SowSeedsForm : seedsfromzion.GUI.BaseForm
    {
        DataTable fridgeTable;
        public SowSeedsForm()
        {
            InitializeComponent();
            initFridgeTable();
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
            InventoryUtils.FilterTable(fridgeTable, dataGridViewX1, "name LIKE '" + plantInput.Text + "%'", "plantId", "name", "type","arrivingDate","units");
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
            if (dataGridViewX1.SelectedRows.Count==0)
            {
                new ErrorWindow("לא נבחר צמח מהמקרר").Show();
                return;
            }
            if (textBoxX1.Text.Equals(String.Empty))
            {
                new ErrorWindow("יש להכניס את המיקום בשדה").Show();
                return;
            }
            try
            {
                manager.SowSeeds((int)(UInt32)dataGridViewX1.SelectedRows[0].Cells[0].Value, (DateTime)dataGridViewX1.SelectedRows[0].Cells[3].Value, monthCalendar1.SelectionStart, doubleInput1.Value, textBoxX1.Text);
            }
            catch (InventoryManager.KeyException ex)
            {
                new ErrorWindow("לא ניתן לזרוע את אותו הצמח באותו היום יותר מפעם אחת").Show();
                return;
            }
            initFridgeTable();

            new SuccessWindow().Show();
        }
    }
}
