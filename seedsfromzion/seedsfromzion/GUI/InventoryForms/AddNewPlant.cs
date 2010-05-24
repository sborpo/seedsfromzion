using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using seedsfromzion.Managers;
using seedsfromzion.DataStructures;

namespace seedsfromzion.GUI.InventoryForms
{
    public partial class AddNewPlant : seedsfromzion.GUI.BaseForm
    {
        public AddNewPlant()
        {
            InitializeComponent();

            comboBoxEx1.Items.Add('א');
            comboBoxEx1.Items.Add('ב');
            comboBoxEx1.Items.Add('ג');

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            InventoryManager invMgr = new InventoryManager();
            PlantInfo plantInfo = new PlantInfo();
            if (name.Text == "")
            {
                new ErrorWindow("לא הוזן שם לצמח").Show();
                return;
            }
            if (foreignName.Text == "")
            {
                new ErrorWindow("לא הוזן שם לועזי לצמח").Show();
                return;
            }
            if (comboBoxEx1.SelectedItem == null)
            {
                new ErrorWindow("לא הוזן איכות לצמח").Show();
                return;
            }
            if (integerInput1.Value == 0)
            {
                new ErrorWindow("לא הוזן שם מספר יחידות ליחידת משקל").Show();
                return;
            }
            if (price.Value == 0.0)
            {
                new ErrorWindow("לא הוזן מחיר ליחידת משקל").Show();
                return;
            }
            if (lifeTime.Value == 0.0)
            {
                new ErrorWindow("לא הוזן אורך חיים בחודשים").Show();
                return;
            }
            plantInfo.Name          = name.Text;
            plantInfo.ForeignName   = foreignName.Text;
            plantInfo.UnitType      = (char)(comboBoxEx1.SelectedItem);
            plantInfo.CountInUnit   = integerInput1.Value;
            plantInfo.Comments      = comments.Text;
            try
            {
                invMgr.AddPlant(plantInfo, price.Value, lifeTime.Value);
                new SuccessWindow().Show();
                ClearFields();
            }
            catch (Exception ex)
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
    }
}
