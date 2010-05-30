using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using seedsfromzion.Managers;
using System.Data;
using seedsfromzion.DataAccess;
using seedsfromzion.DataStructures;
using System.IO;

namespace seedsfromzion.GUI.InventoryForms
{
    public partial class FindPlant : seedsfromzion.GUI.BaseForm
    {
        public FindPlant()
        {
            InitializeComponent();
            initEnlargePiture();

           
            
        }

        private void initEnlargePiture()
        {
            pictureBox1.Cursor = Cursors.Hand;
            webBrowser1.Hide();
            closeImage.Hide();
        }

        void mainForm_deletePlantClicked()
        {
            if (dataGridViewX1.SelectedRows.Count == 0)
            {
                return;
            }
            int plantid = (int)(UInt32)(dataGridViewX1.SelectedRows[0].Cells["plantId"].Value);
            string name = (string)(dataGridViewX1.SelectedRows[0].Cells["name"].Value);
            InventoryManager manager = new InventoryManager();
            if (manager.IsPlantIsUsed(plantid))
            {
                new ErrorWindow("לא ניתן למחוק צמח אשר נמצא כעת בשימוש במערכת");
                return;
            }
            pictureBox1.Image.Dispose();
            PlantInfo plantinfo = manager.FindPlant(name);
            manager.removePlant(plantid, plantinfo);
           
            //remove the plant from the favorites
            ((seedsFromZion)this.MdiParent).removeFavoritePlant(plantid);
            new SuccessWindow().Show();
            actEmptyBox();
           


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
            if (table.Rows.Count == 0)
            {
                dataGridViewX1.DataSource = null;
                initPlantInfo();
                dataGridViewX1.Refresh();
                return;
            }
            dataGridViewX1.DataSource = table;
            
          //  T.plantId,T.name, T.type , T.lifetime, T.price,P.foreignName,P.picture,P.unitType,P.countInUnit,P.comments
            dataGridViewX1.Columns["plantId"].Visible = false;
            dataGridViewX1.Columns["name"].Visible = false;
            dataGridViewX1.Columns["type"].HeaderText = "סוג";
            dataGridViewX1.Columns["lifetime"].HeaderText = "טווח חיים בחודשים";
            dataGridViewX1.Columns["price"].HeaderText = "מחיר";
            dataGridViewX1.Columns["foreignName"].Visible = false;
            dataGridViewX1.Columns["picture"].Visible = false;
            dataGridViewX1.Columns["unitType"].Visible = false;
            dataGridViewX1.Columns["countInUnit"].Visible = false;
            dataGridViewX1.Columns["comments"].Visible = false;
            dataGridViewX1.Refresh();

            FillPlantProperties();



        }

        private void FillPlantProperties()
        {
            if (dataGridViewX1.SelectedRows.Count==0)
            {
                initPlantInfo();
                return;
            }
            foreign.Text = (string)dataGridViewX1.SelectedRows[0].Cells["foreignName"].Value;
            unitstype.Text = (string)dataGridViewX1.SelectedRows[0].Cells["unitType"].Value;
            string pictureName= (string)dataGridViewX1.SelectedRows[0].Cells["picture"].Value;
            integerInput1.Value = (int)Int32.Parse((string)dataGridViewX1.SelectedRows[0].Cells["countInUnit"].Value.ToString());
            int plantId=(int)Int32.Parse((string)dataGridViewX1.SelectedRows[0].Cells["plantId"].Value.ToString());
             string executionPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
             pictureBox1.Image = Properties.Resources.image_missing;
             if (pictureName != "NO_PICTURE")
             {
                 pictureBox1.Image = Image.FromFile(executionPath + @"\" + ConfigFile.getInstance.ImagesPath + @"\" + pictureName);
             }
             comments.Text = (string)dataGridViewX1.SelectedRows[0].Cells["comments"].Value;

        }

        private void actEmptyBox()
        {
            initPlantInfo();
            textBoxX1.Text = "";
            dataGridViewX1.DataSource = null;
            dataGridViewX1.Refresh();
        }

        private void initPlantInfo()
        {
            pictureBox1.Image = Properties.Resources.image_missing;
            pictureBox1.Refresh();
            foreign.Text = "";
            unitstype.Text = "";
            integerInput1.Value = 0;
            comments.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count==0)
            {
                return;
            }
            PlantInfo info = new PlantInfo();
            info.Name=textBoxX1.Text;
            info.ForeignName=foreign.Text;
            info.CountInUnit=integerInput1.Value;
            info.UnitType=unitstype.Text;
            info.Comments=comments.Text;
            info.Picture=(string)dataGridViewX1.SelectedRows[0].Cells["picture"].Value;
            string type=(string)dataGridViewX1.SelectedRows[0].Cells["type"].Value;
            double price=(double)dataGridViewX1.SelectedRows[0].Cells["price"].Value;
            double lifetime=(double)dataGridViewX1.SelectedRows[0].Cells["lifetime"].Value;


            AddNewPlant updateForm = new AddNewPlant(info, type, price, lifetime);
            updateForm.MdiParent = this.MdiParent;
            updateForm.Show();
            pictureBox1.Image.Dispose();
            this.Close();
            
        }

        private void FindPlant_Load(object sender, EventArgs e)
        {
            seedsFromZion mainForm = (seedsFromZion)this.MdiParent;
            mainForm.deletePlantClicked += new seedsFromZion.deletePlantClickedHandler(mainForm_deletePlantClicked);
        }

        private void closeImage_Click(object sender, EventArgs e)
        {

            string execPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fileName = execPath + @"\" + "Enlarge.html";
            
             if (File.Exists(fileName))
             {
                 File.Delete(fileName);
             }
             webBrowser1.Hide();
             closeImage.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count == 0)
            {
                return;
            }
            string pictureName = (string)dataGridViewX1.SelectedRows[0].Cells["picture"].Value;
            TextWriter tw = null;
            string execPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fileName = execPath+@"\"+"Enlarge.html";
            try
            {
                File.WriteAllText(fileName, "<html><img src=\"" + execPath + @"\" + ConfigFile.getInstance.ImagesPath + @"\" + pictureName + "\"></html>", Encoding.UTF8);
               
                
            }
            catch (Exception ex)
            {
               
            }
            EnableEnlarge(fileName);
        }

        private void EnableEnlarge(string fileName)
        {
            webBrowser1.Url = new Uri( fileName);
            webBrowser1.Update();
            webBrowser1.Show();
            closeImage.Show();

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void FindPlant_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
        }
    }
}
