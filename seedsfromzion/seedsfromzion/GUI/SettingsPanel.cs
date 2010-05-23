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
        public event ChangedSettingHandler systemSettingsChanged;
        private Dictionary<int, String> dict;
        public SettingsPanel()
        {
            InitializeComponent();
            initializeFavoritesGrids();
            initializeNotificationsData();
          
        }
        private void initializeNotificationsData()
        {
            visaOnOff.Checked = true;
            inventOnOff.Checked = true;
            clientsOnOff.Checked = true;
           
            visaDayesInput.Value = ConfigFile.getInstance.VisaExpireDays;
            visaFreqInput.Value=ConfigFile.getInstance.VisaFreq;
            inventInput.Value=ConfigFile.getInstance.MinUnitsInStorage;
            inventFreqInput.Value=ConfigFile.getInstance.UnitsFreq;
            clientDaysInput.Value=ConfigFile.getInstance.OrderDueDate;
            clientFreqInput.Value = ConfigFile.getInstance.OrderFreq;
            setCheckedInitArgs(visaDayesInput, visaFreqInput, visaOnOff);
            setCheckedInitArgs(inventInput, inventFreqInput, inventOnOff);
            setCheckedInitArgs(clientDaysInput, clientFreqInput, clientsOnOff);
            visaOnOff.CheckedChanged += new EventHandler(checkBoxX1_CheckedChanged);
            inventOnOff.CheckedChanged += new EventHandler(checkBoxX2_CheckedChanged);
            clientsOnOff.CheckedChanged += new EventHandler(checkBoxX3_CheckedChanged);

        }

        private void setCheckedInitArgs(DevComponents.Editors.IntegerInput input1,DevComponents.Editors.IntegerInput input2,DevComponents.DotNetBar.Controls.CheckBoxX checkBox)
        {
            if (input1.Value == -1)
            {
                checkBox.Checked = false;
                input1.MaxValue = -1;
                input2.MaxValue = -1;

            }
            else
            {
                input1.MinValue = 1;
                input2.MinValue = 1;
            }
        }

        void checkBoxX3_CheckedChanged(object sender, EventArgs e)
        {
            inputSetterCheckBoxChanged(clientsOnOff, clientDaysInput, clientFreqInput);
        }

        void checkBoxX2_CheckedChanged(object sender, EventArgs e)
        {
            inputSetterCheckBoxChanged(inventOnOff, inventInput, inventFreqInput);
        }

        void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {
            inputSetterCheckBoxChanged(visaOnOff, visaDayesInput, visaFreqInput);
        }

        private void inputSetterCheckBoxChanged(DevComponents.DotNetBar.Controls.CheckBoxX checkBox, DevComponents.Editors.IntegerInput input,DevComponents.Editors.IntegerInput input2)
        {
            if (checkBox.Checked == true)
            {
                input.MaxValue = Int32.MaxValue;
                input2.MaxValue = Int32.MaxValue;
                input.Value = 1;
                input2.Value = 1;
                input.MinValue = 1;
                input2.MinValue = 1;
            }
            else
            {
                input.MinValue = -1;
                input2.MinValue = -1;
                input.MaxValue = -1;
                input2.MaxValue = -1;
                input.Value = -1;
                input2.Value = -1;
            }

        }

        private void initializeFavoritesGrids()
        {
            
            MySqlCommand command = new MySqlCommand("SELECT plantId,name,type FROM seedsdb.planttypes");
            DataTable db = DataAccess.DatabaseAccess.getResultSetFromDb(command);
            systemPlantGrid.DataSource = db;
            systemPlantGrid.Columns["name"].HeaderText = "שם הצמח";
            systemPlantGrid.Columns["type"].HeaderText = "סוג הצמח";
            systemPlantGrid.Columns["plantId"].Visible = false;
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
                favoritesGrid.Rows.Add(res,(string)plant);
            }



        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewSelectedRowCollection selectedRows = systemPlantGrid.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                
                int plantId =  (int)((UInt32)row.Cells["plantId"].Value);
                string name = (string)row.Cells["name"].Value;
                string type = (string)row.Cells["type"].Value;
                try
                {
                    string plantNameType=String.Format(name + " מסוג " + type);
                    AdminManager.addToFavorites(plantId.ToString() );
                    favoritesGrid.Rows.Add(plantNameType ,plantId.ToString());


                }
                catch (PlantAlreadyInFavorites ex)
                {
                 //Do nothing , it will not add it.  
                }


            }
            favoritesGrid.Refresh();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
             System.Windows.Forms.DataGridViewSelectedRowCollection selectedRows = favoritesGrid.SelectedRows;
             foreach (DataGridViewRow row in selectedRows)
             {
                 string name = (string)row.Cells[0].Value;
                 string plantId = (string)row.Cells[1].Value;
                 AdminManager.removeFromFavorites(plantId);
                 dict.Remove((int)(UInt32.Parse(plantId)));
                 favoritesGrid.Rows.Remove(row);
             }
             favoritesGrid.Refresh();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
           
            ConfigFile.getInstance.VisaExpireDays=visaDayesInput.Value;
            ConfigFile.getInstance.VisaFreq= visaFreqInput.Value;
            ConfigFile.getInstance.MinUnitsInStorage = inventInput.Value;
            ConfigFile.getInstance.UnitsFreq = inventFreqInput.Value;      
            ConfigFile.getInstance.OrderDueDate = clientDaysInput.Value;
            ConfigFile.getInstance.OrderFreq= clientFreqInput.Value;
            settingsChanged();
            this.Close();


        }

        private void SettingsPanel_Load(object sender, EventArgs e)
        {
            sql.Text = ConfigFile.getInstance.MySqlPath;
            images.Text = ConfigFile.getInstance.ImagesPath;
            backups.Text = ConfigFile.getInstance.BackupPath;
            automaticBackupFreq.Value = ConfigFile.getInstance.BackupFrequency;
            optimizeFreq.Value = ConfigFile.getInstance.OptimizingFrequency;
            emailUsername.Text = ConfigFile.getInstance.EmailUsername;
            emailPass.Text = ConfigFile.getInstance.EmailPassword;
        }

        private void textBoxX1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dig= new FolderBrowserDialog();
            if (dig.ShowDialog() == DialogResult.OK)
            {
                sql.Text = dig.SelectedPath;
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            ConfigFile.getInstance.MySqlPath = sql.Text;
            ConfigFile.getInstance.ImagesPath=images.Text ;
            ConfigFile.getInstance.BackupPath=  backups.Text ;
            ConfigFile.getInstance.BackupFrequency =automaticBackupFreq.Value ;
            ConfigFile.getInstance.OptimizingFrequency =optimizeFreq.Value ;
            ConfigFile.getInstance.EmailUsername = emailUsername.Text;
            ConfigFile.getInstance.EmailPassword = emailPass.Text;
            systemSettingsChanged();
            this.Close();
        }

   


    }
}
