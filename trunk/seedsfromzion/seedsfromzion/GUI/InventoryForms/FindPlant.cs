using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using seedsfromzion.Managers;
using System.Data;

namespace seedsfromzion.GUI.InventoryForms
{
    public partial class FindPlant : seedsfromzion.GUI.BaseForm
    {
        public FindPlant()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (textBoxX1.Text == "")
            {
                actEmptyBox();
                return;
            }
            InventoryManager manager = new InventoryManager();
            DataTable table=manager.getFullPlantsTable(textBoxX1.Text);
            dataGridViewX1.DataSource = table;
          //  T.plantId,T.name, T.type , T.lifetime, T.price,P.foreignName,P.picture,P.unitType,P.countInUnit,P.comments
            dataGridViewX1.Columns["plantId"].Visible = false;
            dataGridViewX1.Columns["name"].Visible = false;
            dataGridViewX1.Columns["type"].HeaderText = "סוג";
            dataGridViewX1.Columns["lifetime"].HeaderText = "טווח חיים בחודשים";
            dataGridViewX1.Columns["price"].HeaderText = "מחיר";
            dataGridViewX1.Columns["foreignName"].HeaderText = "שם לועזי";
            dataGridViewX1.Columns["picture"].Visible = false;
            dataGridViewX1.Columns["unitType"].HeaderText = "סוג היחידות";
            dataGridViewX1.Columns["countInUnit"].HeaderText = "כמות ביחידת משקל";
            dataGridViewX1.Columns["comments"].Visible = false;
            dataGridViewX1.Refresh();



        }

        private void actEmptyBox()
        {
            pictureBox1.Image = Properties.Resources.image_missing;
            dataGridViewX1.Rows.Clear();
            dataGridViewX1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
