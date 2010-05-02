using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using seedsfromzion.DataAccess;
using System.Data;
using MySql.Data.MySqlClient;
namespace seedsfromzion.GUI
{
    public partial class SettingsPanel : DevComponents.DotNetBar.Office2007Form
    {
        public SettingsPanel()
        {
            InitializeComponent();
            MySqlCommand command= new MySqlCommand("SELECT name,type FROM seedsdb.planttypes");
            DataTable db = DataAccess.DatabaseAccess.getResultSetFromDb(command);
            dataGridViewX1.DataSource = db;
            dataGridViewX1.Columns["name"].HeaderText = "שם הצמח";
            dataGridViewX1.Columns["type"].HeaderText = "סוג הצמח";


        }
    }
}
