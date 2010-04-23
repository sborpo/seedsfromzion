using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using seedsfromzion.Backup;
using MySql.Data;
using MySql.Data.MySqlClient;
using seedsfromzion.DataAccess;


namespace seedsfromzion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //check 2
            ConfigFile config = ConfigFile.getInstance;
            string str=config.ConnectionString;
            str = config.MySqlPath;
            IDatabaseAccess db = new DatabaseAccess();
            DateTime date= new DateTime(2040,3,8);
            db.optimizeDb(date);
            InitializeComponent();
            
        }
    }
}
