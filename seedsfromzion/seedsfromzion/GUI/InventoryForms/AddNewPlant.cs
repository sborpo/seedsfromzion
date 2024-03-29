﻿using System;
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
        private string executionPath;
        private string prevoiusPicture;
        private int plantId;
        

        /// <summary>
        /// This c'tor of the class should give the option
        /// of Updating plant details. It gets the plant details
        /// through the arguments , and give an option to the user
        /// to update the plant's details
        /// </summary>
        /// <param name="info"></param>
        /// <param name="type"></param>
        /// <param name="priceArg"></param>
        /// <param name="lifeTimeArg"></param>
        public AddNewPlant(PlantInfo info,int plantident,string type,double priceArg,double lifeTimeArg )
        {
            InitializeComponent();
            plantId = plantident;
            executionPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            #region set the properties from the arguments
            name.Text=info.Name;
            foreignName.Text = info.ForeignName;
            integerInput1.Value = info.CountInUnit;
            price.Value = priceArg;
            lifeTime.Value = lifeTimeArg;
            comments.Text = info.Comments;
            plantUnitType.Text = info.UnitType;
            comboBoxEx1.Items.Add(type);
            comboBoxEx1.SelectedIndex = 0;
            prevoiusPicture = info.Picture;
            if (info.Picture != "NO_PICTURE")
            {
                pictureBox1.Image = Image.FromFile(executionPath + @"\" + ConfigFile.getInstance.ImagesPath + @"\" + info.Picture);
                picture = info.Picture;
            }
            #endregion
            #region set display properties to fit plant update
            name.ReadOnly = true;
            comboBoxEx1.Enabled = false;
            addPlantTypePanel.Visible = false;
            buttonX1.Text = "ערוך צמח";
            buttonX1.Click -= new EventHandler(buttonX1_Click);
            buttonX1.Click += new EventHandler(updateClick);
            
            addPlantPanel.Text = "עדכון צמח";
            #endregion
        }

        /// <summary>
        /// C'tor of the class
        /// </summary>
        public AddNewPlant()
        {
            InitializeComponent();
            comboBoxEx1.Items.Add("א");
            comboBoxEx1.Items.Add("ב");
            comboBoxEx1.Items.Add("ג");
            typeType.Items.Add("א");
            typeType.Items.Add("ב");
            typeType.Items.Add("ג");
            executionPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);


        }


        private void updateClick(object sender, EventArgs e)
        {
            InventoryManager invMgr = new InventoryManager();
            try
            {
                checkPlantParams();
            }
            catch (IllegalParams ex)
            {
                return;
            }
            PlantInfo plantInfo = plantInfoSetter();
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
            String Newpicture;
            invMgr.updatePlantDetails(plantInfo,plantId,prevoiusPicture, comboBoxEx1.Items[0].ToString(), price.Value, lifeTime.Value,out Newpicture);
            new SuccessWindow().Show();
            FindPlant form = new FindPlant();
            form.MdiParent = this.MdiParent;
            form.Show();
            this.Close();

        }

        private PlantInfo plantInfoSetter()
        {
            PlantInfo plantInfo = new PlantInfo();
            plantInfo.Name = name.Text;
            plantInfo.ForeignName = foreignName.Text;
            plantInfo.UnitType = plantUnitType.Text;
            plantInfo.CountInUnit = integerInput1.Value;
            plantInfo.Comments = comments.Text;
            plantInfo.Picture = picture;
            return plantInfo;

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
            if (plantUnitType.Text=="")
            {
                new ErrorWindow("לא הוזן סוג היחידות").Show();
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
           
            try
            {
                checkPlantParams();
            }
            catch (IllegalParams ex)
            {
                return;
            }
            PlantInfo plantInfo = plantInfoSetter();
            try
            {
                invMgr.AddPlant(plantInfo,comboBoxEx1.SelectedItem.ToString(), price.Value, lifeTime.Value);
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
            plantUnitType.Refresh();
            
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            if (dig.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Dispose();
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

        private void AddNewPlant_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dispose of the image when exiting the form
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
        }

        private void typePlantName_TextChanged(object sender, EventArgs e)
        {
            this.autoCompleteList.Visible = false;
            this.Redraw();
            DataRow[] rows = StatisticsManager.initPlantNames(this.typePlantName.Text);//NEW
            if (rows != null && rows.Length > 0)
            {
                String[] names = StatisticsManager.buildArrayFromGraphData<string, String>(rows, "name");
                this.autoCompleteList.Items.Clear();
                this.autoCompleteList.Items.AddRange(names);
                this.autoCompleteList.Visible = true;
            }
        }

        private void autoCompleteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.typePlantName.Text = (String)this.autoCompleteList.SelectedItem;
            this.autoCompleteList.Visible = false;
            this.Redraw();
        }

        private void typePlantName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back) || e.KeyChar.Equals((char)Keys.Delete)))
                e.Handled = true;
        }
    }
}
