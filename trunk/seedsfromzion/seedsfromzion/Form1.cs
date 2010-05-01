using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using seedsfromzion.DataAccess;
using seedsfromzion.Managers;
using System.Threading;


namespace seedsfromzion
{
    public partial class Form1 : Form
    {
        public delegate void displayNotification(String title,String text);
        public displayNotification displayFunc;
        Routines routine ;
        private  Notification notification;
        public Form1()
        {

           DataAccess.DatabaseAccess.performDbBackup(@"c:\stam.sql");
            InitializeComponent();
            notification = new Notification(Screen.GetWorkingArea(this));
            displayFunc = new displayNotification(notification.showNotification);
            routine = new Routines(this);
               
            
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
             routine.checkNotifications();
             int x;
             routine.performAutomaticBackup();
           //routine.checkNotifications();
            DevComponents.DotNetBar.Da
           
           
            

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            routine.abortChecking();
        }
    }
}
