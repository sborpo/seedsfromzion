using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using seedsfromzion.DataAccess;
using seedsfromzion.Managers;

namespace seedsfromzion.GUI
{
    public partial class seedsFromZion : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public delegate void displayNotification(String title, String text);
        public displayNotification displayFunc;
        Routines routine;
        private Notification notification;

        public seedsFromZion()
        {
            InitializeComponent();
            notification = new Notification(Screen.GetWorkingArea(this));
            displayFunc = new displayNotification(notification.showNotification);
            routine = new Routines(this);
            routine.checkNotifications();
        }

        private void SeedsFromZion_Load(object sender, EventArgs e)
        {
            
        }

        private void dotNetBarManager1_MouseEnter(object sender, EventArgs e)
        {
            // Sync Status-bar with the item tooltip...
            BaseItem item = sender as BaseItem;
            if (item == null)
            {
                return;
            }
            
            statusLabel.Text = item.Tooltip;
        }

        private void dotNetBarManager1_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = statusBar.Text;
            //statusLabel.Text = "";
        }

        private void findPlantButton_Click(object sender, EventArgs e)
        {
            InheritedForm findPlantMDIChild = new InheritedForm();
            // Set the Parent Form of the Child window.
            findPlantMDIChild.MdiParent = this;
            // Display the new form.
            //findPlantMDIChild.Dock = DockStyle.Fill;
            findPlantMDIChild.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            routine.abortChecking();
            this.Close();
        }
    }
}
