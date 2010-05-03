using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using seedsfromzion.DataAccess;
using seedsfromzion.Managers;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
namespace seedsfromzion.GUI
{
    public partial class SettingsPanel : DevComponents.DotNetBar.Office2007Form
    {
        public delegate void ChangedSettingHandler();
        public event ChangedSettingHandler settingsChanged;
        private Dictionary<int, String> dict;
        public SettingsPanel()
        {
            InitializeComponent();
            initializeFavoritesGrids();
            initializeNotificationsData();
        }
        private void initializeNotificationsData()
        {
            checkBoxX1.Checked = true;
            checkBoxX2.Checked = true;
            checkBoxX3.Checked = true;
            checkBoxX1.CheckedChanged += new EventHandler(checkBoxX1_CheckedChanged);
            checkBoxX2.CheckedChanged += new EventHandler(checkBoxX2_CheckedChanged);
            checkBoxX3.CheckedChanged += new EventHandler(checkBoxX3_CheckedChanged);
            integerInput1.Value = ConfigFile.getInstance.VisaExpireDays;
            integerInput2.Value=ConfigFile.getInstance.VisaFreq;
            integerInput3.Value=ConfigFile.getInstance.MinUnitsInStorage;
            integerInput4.Value=ConfigFile.getInstance.UnitsFreq;
            integerInput5.Value=ConfigFile.getInstance.OrderDueDate;
            integerInput6.Value = ConfigFile.getInstance.OrderFreq;
            if (integerInput1.Value == -1)
            {
                checkBoxX1.Checked = false;
      
            }
            if (integerInput3.Value == -1)
            {
                checkBoxX2.Checked = false;
            }
            if (integerInput5.Value == -1)
            {
                checkBoxX3.Checked = false;
            }

        }

        void checkBoxX3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxX3.Checked == true)
            {
                integerInput5.MinValue = 1;
                integerInput6.MinValue = 1;
            }
            else
            {
                integerInput5.MinValue = -1;
                integerInput6.MinValue = -1;
                integerInput5.Value = -1;
                integerInput6.Value = -1;
            }
        }

        void checkBoxX2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxX2.Checked == true)
            {
                integerInput3.MinValue = 1;
                integerInput4.MinValue = 1;
            }
            else
            {
                integerInput3.MinValue = -1;
                integerInput4.MinValue = -1;
                integerInput3.Value = -1;
                integerInput4.Value = -1;
            }
        }

        void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxX1.Checked == true)
            {
                integerInput1.MinValue = 1;
                integerInput2.MinValue = 1;
            }
            else
            {
                integerInput1.MinValue = -1;
                integerInput2.MinValue = -1;
                integerInput1.Value = -1;
                integerInput2.Value = -1;
            }
        }

        private void initializeFavoritesGrids()
        {
            
            MySqlCommand command = new MySqlCommand("SELECT plantId,name,type FROM seedsdb.planttypes");
            DataTable db = DataAccess.DatabaseAccess.getResultSetFromDb(command);
            dataGridViewX1.DataSource = db;
            dataGridViewX1.Columns["name"].HeaderText = "שם הצמח";
            dataGridViewX1.Columns["type"].HeaderText = "סוג הצמח";
            dataGridViewX1.Columns["plantId"].Visible = false;
            dict = new Dictionary<int,string>();
            foreach (DataRow row in db.Rows)
	        {
                string name = (string)row["name"];
                string type = (string)row["type"];
		        dict.Add(((int)(UInt32)row["plantId"]),String.Format(name + " מסוג " + type));
	        }
            StringCollection favorites = ConfigFile.getInstance.Favorites;
            foreach (string plant in favorites)
            {
                string res;
                dict.TryGetValue(Int32.Parse(plant),out res);
                dataGridViewX2.Rows.Add(res,(string)plant);
            }



        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewSelectedRowCollection selectedRows = dataGridViewX1.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                
                int plantId =  (int)((UInt32)row.Cells["plantId"].Value);
                string name = (string)row.Cells["name"].Value;
                string type = (string)row.Cells["type"].Value;
                try
                {
                    string plantNameType=String.Format(name + " מסוג " + type);
                    AdminManager.addToFavorites(plantId.ToString() );
                    dataGridViewX2.Rows.Add(plantNameType ,plantId.ToString());


                }
                catch (PlantAlreadyInFavorites ex)
                {
                    MessageBox.Show(String.Format(name + " מסוג " + type + "כבר נמצא במועדפים"));
                }


            }
            dataGridViewX2.Refresh();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
             System.Windows.Forms.DataGridViewSelectedRowCollection selectedRows = dataGridViewX2.SelectedRows;
             foreach (DataGridViewRow row in selectedRows)
             {
                 string name = (string)row.Cells[0].Value;
                 string plantId = (string)row.Cells[1].Value;
                 AdminManager.removeFromFavorites(plantId);
                 dict.Remove((int)(UInt32.Parse(plantId)));
                 dataGridViewX2.Rows.Remove(row);
             }
             dataGridViewX2.Refresh();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (checkBoxX1.Checked==true)
            {
                ConfigFile.getInstance.VisaExpireDays=integerInput1.Value;
                ConfigFile.getInstance.VisaFreq= integerInput2.Value;
            }
            else
            {
                ConfigFile.getInstance.VisaExpireDays=-1;
                ConfigFile.getInstance.VisaFreq= -1;
            }
            if (checkBoxX2.Checked == true)
            {
                ConfigFile.getInstance.MinUnitsInStorage = integerInput3.Value;
                ConfigFile.getInstance.UnitsFreq = integerInput4.Value;

            }
            else
            {
                ConfigFile.getInstance.MinUnitsInStorage = -1;
                ConfigFile.getInstance.UnitsFreq = -1;
            }
            if (checkBoxX3.Checked == true)
            {
                ConfigFile.getInstance.OrderDueDate = integerInput5.Value;
                ConfigFile.getInstance.OrderFreq= integerInput6.Value;

            }
            else
            {
                ConfigFile.getInstance.OrderDueDate = -1;
                ConfigFile.getInstance.OrderFreq = -1;
            }
            settingsChanged();
            this.Close();


        }

        private void SettingsPanel_Load(object sender, EventArgs e)
        {
            //initializeNotificationsData();
        }


    }
}
