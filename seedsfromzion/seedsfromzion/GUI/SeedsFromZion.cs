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
using seedsfromzion.GUI.WorkerForms;
using seedsfromzion.GUI.StatisticsForms;
using seedsfromzion.GUI.OrdersForms;
using seedsfromzion.GUI.InventoryForms;
using System.Collections.Specialized;

namespace seedsfromzion.GUI
{
    public partial class seedsFromZion : DevComponents.DotNetBar.Office2007RibbonForm
    {
        #region fields
        public delegate void displayNotification(String title, String text);
        public delegate void favoriteClickedHandler(int plantId);
        public event favoriteClickedHandler favoriteClicked;
        public displayNotification displayFunc;
        Routines routine;
        private Notification notification;
        #endregion

        #region global functions
        public seedsFromZion()
        {
            InitializeComponent();
            initFavorites();
        }

        private void initFavorites()
        {
            FavoritesHasher hasher = new FavoritesHasher();
            StringCollection collection = ConfigFile.getInstance.Favorites;
            ButtonItem[] items = new ButtonItem[collection.Count];
            for (int i = 0; i < collection.Count; i++)
			{
                items[i] = new ButtonItem(collection[i], hasher.hashPlantId(collection[i]));
                items[i].Click += new EventHandler(seedsFromZion_Click);
            }
            this.favoritesButtonMini.SubItems.AddRange(items);
        }

        void seedsFromZion_Click(object sender, EventArgs e)
        {
            ButtonItem clickedButton = sender as ButtonItem;
            if (favoriteClicked != null)
            {
                favoriteClicked(Convert.ToInt32(clickedButton.Name));
            }
        }

        

        public void Enable()
        {
            this.Enabled = true;
        }

        public void Disable()
        {
            this.Enabled = false;
        }

        public bool DisplayAdminOptions
        {
            set
            {
                if (value == false)
                {
                    addNewUserButton.Visible = false;
                    settingsButton.Visible = false;
                    loadBackUpButton.Visible = false;
                }
                else
                {
                    addNewUserButton.Visible = true ;
                    settingsButton.Visible = true;
                    loadBackUpButton.Visible = true;

                }
            }
        }

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

        #region system button functions
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

        private void printButton_Click(object sender, EventArgs e)
        {

        }

        #endregion

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
            GrowViaSowingDateForm sowGraphMDIChild = new GrowViaSowingDateForm();
            // Set the Parent Form of the Child window.
            sowGraphMDIChild.MdiParent = this;
            // Display the new form.
            sowGraphMDIChild.Show();
        }

        private void percViaSeedType_Click(object sender, EventArgs e)
        {
            GrowViaPlantTypeForm typeGraphMDIChild = new GrowViaPlantTypeForm();
            // Set the Parent Form of the Child window.
            typeGraphMDIChild.MdiParent = this;
            // Display the new form.
            typeGraphMDIChild.Show();
        }

        private void percViaTimeInFridge_Click(object sender, EventArgs e)
        {
            GrowViaFridgeTimeForm fridgeGraphMDIChild = new GrowViaFridgeTimeForm();
            // Set the Parent Form of the Child window.
            fridgeGraphMDIChild.MdiParent = this;
            // Display the new form.
            fridgeGraphMDIChild.Show();
        }


        #endregion

        #region tiny menu
        
        #endregion

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            SystemUsersManager system = new SystemUsersManager();
            system.Show();
        }

        #region workers

        private void addWorkerButton_Click(object sender, EventArgs e)
        {

            AddWorkerForm form = new AddWorkerForm();
            form.MdiParent = this;
            form.Show();
        }

        private void findWorkersButton_Click(object sender, EventArgs e)
        {
            FindWorkerForm form = new FindWorkerForm();
            form.MdiParent = this;
            form.Show();   
        }

        private void addUpdateVisaButton_Click(object sender, EventArgs e)
        {
            VisasGeneralForm form = new VisasGeneralForm();
            form.MdiParent = this;
            form.Show();
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            PaymentsForm form = new PaymentsForm();
            form.MdiParent = this;
            form.Show();
        }

        private void addWorkerHoursButton_Click(object sender, EventArgs e)
        {
            WorkDaysForm form = new WorkDaysForm();
            form.MdiParent = this;
            form.Show();
        }

        private void removeWorkerButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region orders
        private void addOrderButton_Click(object sender, EventArgs e)
        {
            OrdersMainForm form = new OrdersMainForm();
            form.MdiParent = this;
            form.Show();

        }
        #endregion

        private void systemControl_Click(object sender, EventArgs e)
        {

        }

        private void addToFridgeButton_Click(object sender, EventArgs e)
        {

            AddToFridgeForm form = new AddToFridgeForm(this);
            form.MdiParent = this;
            form.Show();
        }

        private void seedPlantButton_Click(object sender, EventArgs e)
        {
            SowSeedsForm form = new SowSeedsForm(this);
            form.MdiParent = this;
            form.Show();

        }

        private void collectPlantsbutton_Click(object sender, EventArgs e)
        {
            PlantCollectionForm form = new PlantCollectionForm(this);
            form.MdiParent = this;
            form.Show();
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            UpdateSproutingForm form = new UpdateSproutingForm();
            form.MdiParent = this;
            form.Show();
        }

        private void InventoryReports_Click(object sender, EventArgs e)
        {
            InventoryReports form = new InventoryReports();
            form.MdiParent = this;
            form.Show();

        }

        
    }
}
