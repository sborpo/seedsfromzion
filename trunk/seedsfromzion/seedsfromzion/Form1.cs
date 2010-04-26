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
         

            InitializeComponent();
           
            if (components == null)
            {
                components = this.components = new System.ComponentModel.Container();
            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Notification heh = new Notification(this.components);
            heh.setIcon(this.Icon);
            heh.showNotification("MMM","asdasd");
            heh.showNotification("adqwqwF", "sisaf");
            heh.showNotification("aqRRRR", "zqqwrrqsssss");
           
            

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
