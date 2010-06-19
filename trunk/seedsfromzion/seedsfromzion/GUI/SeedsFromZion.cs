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
using System.Threading;
using System.Drawing.Printing;  //For "PrintDocument" Class

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
        PrintDocument PrintDoc1;
        seedsfromzion.GUI.Printing.CoolPrintPreviewDialog PPDlg1;
        
        //PrintForm printForm1 = new PrintForm();
        
        #endregion

        #region global functions
        public seedsFromZion()
        {
            InitializeComponent();
            

        }

        public void closeOpenedWindows()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void SetParent(Form form, Form parent)
        {
            closeOpenedWindows();
            form.MdiParent = parent;
        }

        #region Favorites Managment
        /// <summary>
        /// this method initializes the favorites in the star button
        /// according to the config file.
        /// </summary>
        private void initFavorites()
        {
            FavoritesHasher hasher = new FavoritesHasher();
            StringCollection collection = ConfigFile.getInstance.Favorites;
            for (int i = 0; i < collection.Count; i++)
			{
                String name = hasher.hashPlantId(collection[i]);
                if (name == null)
                {
                    continue;
                }
                addToFavoritesButtons(collection[i], name);
            }
          
        }

        /// <summary>
        /// This method adds a given plant to the favorites buttons
        /// and adds an handler to this button
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public void addToFavoritesButtons(string id, string name)
        {
            ButtonItem item = new ButtonItem(id, name);
            item.Click += new EventHandler(seedsFromZion_Click);
            this.favoritesButtonMini.SubItems.Add(item);

        }

        /// <summary>
        /// Favorites Item Clicked Handler , triggers this function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void seedsFromZion_Click(object sender, EventArgs e)
        {
            //cast to the Button Item
            ButtonItem clickedButton = sender as ButtonItem;
            if (favoriteClicked != null)
            {
                //shoot the event that the favorite plant was clicked with
                //it's plantId (stored in clickedButton.Name)
                favoriteClicked(Convert.ToInt32(clickedButton.Name));
            }
        }

        /// <summary>
        /// Removes the given plant from the favorites
        /// </summary>
        /// <param name="plantId"></param>
        public void removeFavoritePlant(int plantId)
        {
            //remove from the buttons of the favorites
            SubItemsCollection collection = this.favoritesButtonMini.SubItems;
            if (!collection.Contains(plantId.ToString()))
            {
                return;
            }
            collection.RemoveAt(collection.IndexOf(plantId.ToString()));
            //remove from the favorites file
            StringCollection favorites = ConfigFile.getInstance.Favorites;
            favorites.Remove(plantId.ToString());
            ConfigFile.getInstance.Favorites = favorites;
        }
        #endregion

        #region LogIn Managment
        /// <summary>
        /// unlocks the Main Form
        /// </summary>
        public void Enable()
        {
            this.Enabled = true;
           
        }
        /// <summary>
        /// Locks the Main Form
        /// </summary>
        public void Disable()
        {
            this.Enabled = false;
           
        }

        public void loggedIn()
        {
            initRoutines();
        }

        /// <summary>
        /// This method change hides\reaveles the buttons of LogOut and Login
        /// alternaly according to the login status
        /// </summary>
        public bool DisplayLogOut
        {
            set
            {
                if (value == true)
                {
                    //identificationButton.Visible = false;
                    disconnectButton.Visible = true;

                }
                else
                {
                   // identificationButton.Visible = true;
                    disconnectButton.Visible = false;
                }
            }
            
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

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            closeOpenedWindows();
            routine.abortChecking();
            new UserAuthentication(this).Show();
        }
        #endregion

        private void SeedsFromZion_Load(object sender, EventArgs e)
        {
            new UserAuthentication(this).Show();
            notification = new Notification(Screen.GetWorkingArea(this));
            displayFunc = new displayNotification(notification.showNotification);
            initFavorites();
        
            PrintDoc1 = new PrintDocument();
            PrintDoc1.PrintPage += PDoc_PrintPage;          
        }

        private void initRoutines()
        {
            routine = new Routines(this);
            routine.checkNotifications();
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
            if (routine != null)
            {
                routine.abortChecking();
            }
            MessageWindow win = new MessageWindow();
            if (Routines.shouldPerformAutomaticBackup())
            {
                win.setText("מבצע גיבוי אוטומטי");
                win.Show();
                Thread.Sleep(3000);
                Routines.performAutomaticBackup();
                
                
            }
            if (Routines.shouldPerformOptimization())
            {
                win.setText("מבצע אופטימיזציה ");
                win.Show();
                Thread.Sleep(3000);
                Routines.performDbOptimization();
            }
            win.Close();
           
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
            SettingsPanel settings = new SettingsPanel(this);
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
            if (routine != null)
            {
                routine.abortChecking();
            }
            initRoutines();
        }

       

        private void createBackUpButton_Click(object sender, EventArgs e)
        {
            if (routine != null)
            {
                routine.abortChecking();
            }
            SaveFileDialog chooseBackupPath = new SaveFileDialog();
            chooseBackupPath.InitialDirectory = @"c:\";
           chooseBackupPath.Filter = "Zip File (*.zip) |*.zip";
           if (chooseBackupPath.ShowDialog() == DialogResult.OK)
           {
               SystemManager.performBackup(chooseBackupPath.FileName);
               new SuccessWindow().Show();
           }
           initRoutines();

        }

        private void loadBackUpButton_Click(object sender, EventArgs e)
        {
            if (routine != null)
            {
                routine.abortChecking();
            }
            OpenFileDialog restoreDialog = new OpenFileDialog();
            if (restoreDialog.ShowDialog()==DialogResult.OK)
            {
                SystemManager.performSystemRestore(restoreDialog.FileName);
            }
            initRoutines();
        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            SystemUsersManager system = new SystemUsersManager();
            system.Show();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printButtonMini_Click(sender, e);
        }

        #endregion

        #region inventory

        #region Delete Plant Handler
        public delegate void deletePlantClickedHandler();
        public event deletePlantClickedHandler deletePlantClicked;
        private void removePlantButton_Click(object sender, EventArgs e)
        {
            if (deletePlantClicked != null)
            {
                deletePlantClicked();
            }
        }
        #endregion

        #region Plant Manipulation

        private void findPlantButton_Click(object sender, EventArgs e)
        {
            FindPlant findPlantMDIChild = new FindPlant();
            // Set the Parent Form of the Child window.
            SetParent(findPlantMDIChild, this);
            // Display the new form.
            //findPlantMDIChild.Dock = DockStyle.Fill;
            findPlantMDIChild.Show();

        }

        private void addPlantButton_Click(object sender, EventArgs e)
        {
            AddNewPlant form = new AddNewPlant();
            SetParent(form, this);
            form.Show();
        }
        #endregion

        #region Storage And Report
        private void addToFridgeButton_Click(object sender, EventArgs e)
        {

            AddToFridgeForm form = new AddToFridgeForm(this);
            SetParent(form, this);
            form.Show();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            AddFinishedFromExternal form = new AddFinishedFromExternal();
            SetParent(form, this);
            form.Show();
        }

        private void seedPlantButton_Click(object sender, EventArgs e)
        {

            SowSeedsForm form = new SowSeedsForm(this);
            SetParent(form, this);
            form.Show();

        }

        private void collectPlantsbutton_Click(object sender, EventArgs e)
        {
            PlantCollectionForm form = new PlantCollectionForm(this);
            SetParent(form, this);
            form.Show();
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            UpdateSproutingForm form = new UpdateSproutingForm();
            SetParent(form, this);
            form.Show();
        }

        private void InventoryReports_Click(object sender, EventArgs e)
        {
            InventoryReports form = new InventoryReports();
            SetParent(form, this);
            form.Show();

        }
        #endregion

       


        #endregion

        #region statistics
        private void salesGraphButton_Click(object sender, EventArgs e)
        {
            SalesGraphFrom salesGraphMDIChild = new SalesGraphFrom(this);
            // Set the Parent Form of the Child window.
            SetParent(salesGraphMDIChild, this);
            // Display the new form.
            salesGraphMDIChild.Show(); 
            
        }

        private void percViaSowDate_Click(object sender, EventArgs e)
        {
            GrowViaSowingDateForm sowGraphMDIChild = new GrowViaSowingDateForm(this);
            // Set the Parent Form of the Child window.
            SetParent(sowGraphMDIChild, this);
            // Display the new form.
            sowGraphMDIChild.Show();
        }

        private void percViaSeedType_Click(object sender, EventArgs e)
        {
            GrowViaPlantTypeForm typeGraphMDIChild = new GrowViaPlantTypeForm(this);
            // Set the Parent Form of the Child window.
            SetParent(typeGraphMDIChild, this);
            // Display the new form.
            typeGraphMDIChild.Show();
        }

        private void percViaTimeInFridge_Click(object sender, EventArgs e)
        {
            GrowViaFridgeTimeForm fridgeGraphMDIChild = new GrowViaFridgeTimeForm(this);
            // Set the Parent Form of the Child window.
            SetParent(fridgeGraphMDIChild, this);
            // Display the new form.
            fridgeGraphMDIChild.Show();
            
        }


        #endregion

        #region tiny menu
        
        private void printButtonMini_Click(object sender, EventArgs e)
        {// When PrintPreview Button Clicks   
            if (this.ActiveMdiChild == null)
            {
                return;
            }

            PPDlg1 = new seedsfromzion.GUI.Printing.CoolPrintPreviewDialog();

            PPDlg1.ShowIcon = false;
            PrintDoc1.OriginAtMargins = false; //To set or Get the Position of a Graphic Object            

            PrintDoc1.PrinterSettings = new PrinterSettings();
            PrintDoc1.DefaultPageSettings.Landscape = true;

            PPDlg1.Document = PrintDoc1;

            PPDlg1.ShowDialog(this);
        }
                
        #endregion


        #region workers

        /// <summary>
        /// Handles the Click event of the addWorkerButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void addWorkerButton_Click(object sender, EventArgs e)
        {

            AddWorkerForm form = new AddWorkerForm();
            SetParent(form, this);
            form.Show();
        }

        /// <summary>
        /// Handles the Click event of the findWorkersButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void findWorkersButton_Click(object sender, EventArgs e)
        {
            
            FindWorkerForm form = new FindWorkerForm();
            SetParent(form, this);
            form.Show();   
        }

        /// <summary>
        /// Handles the Click event of the addUpdateVisaButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void addUpdateVisaButton_Click(object sender, EventArgs e)
        {
            VisasGeneralForm form = new VisasGeneralForm();
            SetParent(form, this);
            form.Show();
        }

        /// <summary>
        /// Handles the Click event of the paymentButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void paymentButton_Click(object sender, EventArgs e)
        {
            PaymentsForm form = new PaymentsForm();
            SetParent(form, this);
            form.Show();
        }

        /// <summary>
        /// Handles the Click event of the addWorkerHoursButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void addWorkerHoursButton_Click(object sender, EventArgs e)
        {
            WorkDaysForm form = new WorkDaysForm();
            SetParent(form, this);
            form.Show();
        }



        /// <summary>
        /// Handles the Click event of the reportButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void reportButton_Click(object sender, EventArgs e)
        {
            WorkersReportsForm form = new WorkersReportsForm();
            SetParent(form, this);
            form.Show();
        }

        #region removing worker

        public delegate void deleteWorkerClickedHandler();

        /// <summary>
        /// Occurs when [delete worker clicked].
        /// </summary>
        public event deleteWorkerClickedHandler deleteWorkerClicked;

        /// <summary>
        /// Handles the Click event of the removeWorkerButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void removeWorkerButton_Click(object sender, EventArgs e)
        {
            if (deleteWorkerClicked!=null)
            {
                deleteWorkerClicked();
            }
        }
        #endregion
        #endregion

        #region orders
        private void addOrderButton_Click(object sender, EventArgs e)
        {
            OrdersMainForm form = new OrdersMainForm();
            SetParent(form, this);
            form.Show();

        }

        private void findOrderButton_Click(object sender, EventArgs e)
        {
            SearchOrderForm form = new SearchOrderForm();
            SetParent(form, this);
            form.Show();
        }

        #region Delete Order Handler
        public delegate void deleteOrderClickedHandler();
        public event deleteOrderClickedHandler deleteOrderClicked;
        private void removeOrderButton_Click(object sender, EventArgs e)
        {
            if (deleteOrderClicked != null)
            {
                deleteOrderClicked();
            }
        }
        #endregion
        #endregion

        #region printing
        
        private void PDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.ActiveMdiChild.DrawToBitmap(bmp, this.ClientRectangle);
            e.Graphics.DrawImage(bmp, 0, 0, PrintDoc1.DefaultPageSettings.Bounds.Width, PrintDoc1.DefaultPageSettings.Bounds.Height);
        }
        
        #endregion




    }
}
