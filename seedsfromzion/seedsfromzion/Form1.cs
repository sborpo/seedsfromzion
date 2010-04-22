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
            db.performDbBackup("c:/hahasads");
            InitializeComponent();
        }
    }
}
