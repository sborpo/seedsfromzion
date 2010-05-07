﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using seedsfromzion.DataAccess;
using seedsfromzion.Managers;
using seedsfromzion.GUI.WorkerForms;
using seedsfromzion.GUI.StatisticsForms;
using seedsfromzion.GUI.OrdersForms;

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
        }

        #region global functions

        private void SeedsFromZion_Load(object sender, EventArgs e)
        {
            notification = new Notification(Screen.GetWorkingArea(this));
            displayFunc = new displayNotification(notification.showNotification);
            initRoutines();
        }

        private void systemControl_SelectedRibbonTabChanged(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void seedsFromZion_FormClosing(object sender, FormClosingEventArgs e)
        {
            routine.abortChecking();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }

        #endregion

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsPanel settings = new SettingsPanel();
            settings.settingsChanged += new SettingsPanel.ChangedSettingHandler(settings_settingsChanged);
            settings.systemSettingsChanged += new SettingsPanel.ChangedSettingHandler(settings_systemSettingsChanged);
            settings.Show();
        }

        void settings_systemSettingsChanged()
        {
            settings_settingsChanged();
        }

        void settings_settingsChanged()
        {
            routine.abortChecking();
            initRoutines();
        }

        private void initRoutines()
        {
            routine = new Routines(this);
            routine.checkNotifications();
        }

        private void createBackUpButton_Click(object sender, EventArgs e)
        {
            routine.abortChecking();
            SaveFileDialog chooseBackupPath = new SaveFileDialog();
            chooseBackupPath.InitialDirectory = @"c:\";
           chooseBackupPath.Filter = "Zip File (*.zip) |*.zip";
           if (chooseBackupPath.ShowDialog() == DialogResult.OK)
           {
               SystemManager.performBackup(chooseBackupPath.FileName);
               MessageBox.Show("גיבוי הסתיים בהצלחה");
           }
           initRoutines();

        }

        private void loadBackUpButton_Click(object sender, EventArgs e)
        {
            routine.abortChecking();
            OpenFileDialog restoreDialog = new OpenFileDialog();
            if (restoreDialog.ShowDialog()==DialogResult.OK)
            {
                SystemManager.performSystemRestore(restoreDialog.FileName);
            }
            initRoutines();


        }


        #region inventory

        private void findPlantButton_Click(object sender, EventArgs e)
        {
            InheritedForm findPlantMDIChild = new InheritedForm();
            // Set the Parent Form of the Child window.
            findPlantMDIChild.MdiParent = this;
            // Display the new form.
            //findPlantMDIChild.Dock = DockStyle.Fill;
            findPlantMDIChild.Show();
        }

        private void addPlantButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region statistics
        private void salesGraphButton_Click(object sender, EventArgs e)
        {
            SalesGraphFrom salesGraphMDIChild = new SalesGraphFrom();
            // Set the Parent Form of the Child window.
            salesGraphMDIChild.MdiParent = this;
            // Display the new form.
            salesGraphMDIChild.Show(); 
            
        }

        private void percViaSowDate_Click(object sender, EventArgs e)
        {
            GrowViaSowingDateGraph sowGraphMDIChild = new GrowViaSowingDateGraph();
            // Set the Parent Form of the Child window.
            sowGraphMDIChild.MdiParent = this;
            // Display the new form.
            sowGraphMDIChild.Show();
        }
        #endregion

        private void printButton_Click(object sender, EventArgs e)
        {

        }


        #region workers
        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            SystemUsersManager system = new SystemUsersManager();
            system.Show();
        }

        private void addWorkerButton_Click(object sender, EventArgs e)
        {

            AddWorkerForm form = new AddWorkerForm();
            form.MdiParent = this;
            form.Show();
        }
        #endregion

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            OrdersMainForm form = new OrdersMainForm();
            form.MdiParent = this;
            form.Show();

        }
    }
}