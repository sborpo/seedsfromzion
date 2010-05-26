using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using seedsfromzion.Managers;
using seedsfromzion.DataStructures;
using seedsfromzion.DataAccess;
namespace seedsfromzion.GUI.InventoryForms
{
    public partial class AddNewPlant : seedsfromzion.GUI.BaseForm
    {
        private class IllegalParams : Exception { }

        private string picture = "NO_PICTURE";

        public AddNewPlant(PlantInfo info,string type,double priceArg,double lifeTimeArg )
        {
            InitializeComponent();
            name.Text=info.Name;
            name.ReadOnly = true;
            foreignName.Text = info.ForeignName;
            integerInput1.Value = info.CountInUnit;
            price.Value = priceArg;
            lifeTime.Value = lifeTimeArg;
            comments.Text = info.Comments;
            comboBoxEx1.Text = type;
            comboBoxEx1.Enabled = false;
            addPlantTypePanel.Visible = false;
            buttonX1.Text = "ערוך צמח";
            buttonX1.Click -= new EventHandler(buttonX1_Click);
            buttonX1.Click += new EventHandler(updateClick);
            string executionPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string pictureName = info.Picture;
            if (pictureName != "NO_PICTURE")
            {
                pictureBox1.Image = Image.FromFile(executionPath + @"\" + ConfigFile.getInstance.ImagesPath + @"\" + pictureName);
                picture = pictureName;
            }
            addPlantPanel.Text = "עדכון צמח";
            
            

            
            

        }
        public AddNewPlant()
        {
            InitializeComponent();

            comboBoxEx1.Items.Add("א");
            comboBoxEx1.Items.Add("ב");
            comboBoxEx1.Items.Add("ג");
            typeType.Items.Add("א");
            typeType.Items.Add("ב");
            typeType.Items.Add("ג");


        }


        private void updateClick(object sender, EventArgs e)
        {
            InventoryManager invMgr = new InventoryManager();
            PlantInfo plantInfo = new PlantInfo();
            try
            {
                checkPlantParams();
            }
            catch (IllegalParams ex)
            {
                return;
            }
            plantInfo.Name = name.Text;
            plantInfo.ForeignName = foreignName.Text;
            plantInfo.UnitType = comboBoxEx1.SelectedItem.ToString();
            plantInfo.CountInUnit = integerInput1.Value;
            plantInfo.Comments = comments.Text;
            plantInfo.Picture = picture;
            invMgr.AddPlant(plantInfo, price.Value, lifeTime.Value);
            new SuccessWindow().Show();

        }

        private void checkPlantParams()
        {
            if (name.Text == "")
            {
                new ErrorWindow("לא הוזן שם לצמח").Show();
                throw new IllegalParams();
            }
            if (foreignName.Text == "")
            {
                new ErrorWindow("לא הוזן שם לועזי לצמח").Show();
                throw new IllegalParams();
            }
            if (comboBoxEx1.SelectedItem == null)
            {
                new ErrorWindow("לא הוזן איכות לצמח").Show();
                throw new IllegalParams();
            }
            if (integerInput1.Value == 0)
            {
                new ErrorWindow("לא הוזן שם מספר יחידות ליחידת משקל").Show();
                throw new IllegalParams();
            }
            if (price.Value == 0.0)
            {
                new ErrorWindow("לא הוזן מחיר ליחידת משקל").Show();
                throw new IllegalParams();
            }
            if (lifeTime.Value == 0.0)
            {
                new ErrorWindow("לא הוזן אורך חיים בחודשים").Show();
                throw new IllegalParams();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            InventoryManager invMgr = new InventoryManager();
            PlantInfo plantInfo = new PlantInfo();
            try
            {
                checkPlantParams();
            }
            catch (IllegalParams ex)
            {
                return;
            }
            plantInfo.Name          = name.Text;
            plantInfo.ForeignName   = foreignName.Text;
            plantInfo.UnitType      = comboBoxEx1.SelectedItem.ToString();
            plantInfo.CountInUnit   = integerInput1.Value;
            plantInfo.Comments      = comments.Text;
            plantInfo.Picture = picture;

            try
            {
                invMgr.AddPlant(plantInfo, price.Value, lifeTime.Value);
                new SuccessWindow().Show();
                ClearFields();
            }
            catch (ArgumentException ex)
            {
                new ErrorWindow("הצמח כבר קיים במערכת").Show();
                return;
            }
        }

        private void ClearFields()
        {
            name.Text                   = "";
            foreignName.Text            = "";
            comboBoxEx1.SelectedItem    = null;
            integerInput1.Value         = 0;
            price.Value                 = 0.0;
            lifeTime.Value              = 0.0;
            comments.Text               ="";
            //refreshing the view:
            name.Refresh();
            foreignName.Refresh();
            comboBoxEx1.Refresh();
            integerInput1.Refresh();
            price.Refresh();
            lifeTime.Refresh();
            comments.Refresh();
            
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            if (dig.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dig.FileName);
                picture = dig.FileName;
            }
           
        }

        private void price_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                verifyPlantTypeParams();
            }
            catch (IllegalParams ex)
            {
                return;
            }
            InventoryManager manager = new InventoryManager();
            PlantInfo info ;
            try
            {
                info = manager.FindPlant(typePlantName.Text);
            }
            catch (ArgumentException ex)
            {
                new ErrorWindow("שם הצמח אינו נמצא במערכת , לכן לא ניתן להוסיף" + "\n" + "לו סוג כלשהו").Show();
                return;
            }
            try
            {
                manager.AddPlantType(typePlantName.Text, typeType.SelectedItem.ToString(), typeLife.Value, typePrice.Value);
            }
            catch (ArgumentException ex)
            {
                new ErrorWindow("שם הצמח והסוג הזה כבר נמצאים במערכת").Show();
                return;
            }
            new SuccessWindow().Show();

            



        }

        private void verifyPlantTypeParams()
        {
            if (typePlantName.Text == "")
            {
                new ErrorWindow("לא הוזן שם לצמח").Show();
                throw new IllegalParams();
            }
            if (typeType.SelectedItem == null)
            {
                new ErrorWindow("לא הוזן איכות לצמח").Show();
                throw new IllegalParams();
            }
            if (typePrice.Value == 0.0)
            {
                new ErrorWindow("לא הוזן מחיר ליחידת משקל").Show();
                throw new IllegalParams();
            }
            if (typeLife.Value == 0.0)
            {
                new ErrorWindow("לא הוזן אורך חיים בחודשים").Show();
                throw new IllegalParams();
            }

           
        }
    }
}
