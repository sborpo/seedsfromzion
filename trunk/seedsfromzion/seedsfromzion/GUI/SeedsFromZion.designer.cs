namespace seedsfromzion.GUI
{
    partial class seedsFromZion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seedsFromZion));
            this.systemControl = new DevComponents.DotNetBar.RibbonControl();
            this.statisticsPanel = new DevComponents.DotNetBar.RibbonPanel();
            this.graphsStatisticsBar = new DevComponents.DotNetBar.RibbonBar();
            this.percentageGraphButton = new DevComponents.DotNetBar.ButtonItem();
            this.percViaSowDate = new DevComponents.DotNetBar.ButtonItem();
            this.percViaSeedType = new DevComponents.DotNetBar.ButtonItem();
            this.percViaTimeInFridge = new DevComponents.DotNetBar.ButtonItem();
            this.salesGraphButton = new DevComponents.DotNetBar.ButtonItem();
            this.workersPanel = new DevComponents.DotNetBar.RibbonPanel();
            this.paymentWorkersBar = new DevComponents.DotNetBar.RibbonBar();
            this.paymentButton = new DevComponents.DotNetBar.ButtonItem();
            this.visaWorkersBar = new DevComponents.DotNetBar.RibbonBar();
            this.addUpdateVisaButton = new DevComponents.DotNetBar.ButtonItem();
            this.generalWorkersBar = new DevComponents.DotNetBar.RibbonBar();
            this.findWorkersButton = new DevComponents.DotNetBar.ButtonItem();
            this.addWorkerButton = new DevComponents.DotNetBar.ButtonItem();
            this.removeWorkerButton = new DevComponents.DotNetBar.ButtonItem();
            this.reportWorkersBar = new DevComponents.DotNetBar.RibbonBar();
            this.reportButton = new DevComponents.DotNetBar.ButtonItem();
            this.addWorkerHoursButton = new DevComponents.DotNetBar.ButtonItem();
            this.inventoryPanel = new DevComponents.DotNetBar.RibbonPanel();
            this.ordersInventoryBar = new DevComponents.DotNetBar.RibbonBar();
            this.findOrderButton = new DevComponents.DotNetBar.ButtonItem();
            this.addOrderButton = new DevComponents.DotNetBar.ButtonItem();
            this.removeOrderButton = new DevComponents.DotNetBar.ButtonItem();
            this.operationsInventoryBar = new DevComponents.DotNetBar.RibbonBar();
            this.addToFridgeButton = new DevComponents.DotNetBar.ButtonItem();
            this.seedPlantButton = new DevComponents.DotNetBar.ButtonItem();
            this.collectPlantsbutton = new DevComponents.DotNetBar.ButtonItem();
            this.generalInventoryBar = new DevComponents.DotNetBar.RibbonBar();
            this.findPlantButton = new DevComponents.DotNetBar.ButtonItem();
            this.addPlantButton = new DevComponents.DotNetBar.ButtonItem();
            this.removePlantButton = new DevComponents.DotNetBar.ButtonItem();
            this.inventoryTab = new DevComponents.DotNetBar.RibbonTabItem();
            this.workersTab = new DevComponents.DotNetBar.RibbonTabItem();
            this.statisticsTab = new DevComponents.DotNetBar.RibbonTabItem();
            this.systemStartButton = new DevComponents.DotNetBar.Office2007StartButton();
            this.sytemMenu = new DevComponents.DotNetBar.ItemContainer();
            this.systemButtonContainer = new DevComponents.DotNetBar.ItemContainer();
            this.systemButtons = new DevComponents.DotNetBar.ItemContainer();
            this.identificationButton = new DevComponents.DotNetBar.ButtonItem();
            this.addNewUserButton = new DevComponents.DotNetBar.ButtonItem();
            this.addNewUserButton1 = new DevComponents.DotNetBar.ButtonItem();
            this.removeUserButton = new DevComponents.DotNetBar.ButtonItem();
            this.systemMngButton = new DevComponents.DotNetBar.ButtonItem();
            this.loadBackUpButton = new DevComponents.DotNetBar.ButtonItem();
            this.createBackUpButton = new DevComponents.DotNetBar.ButtonItem();
            this.settingsButton = new DevComponents.DotNetBar.ButtonItem();
            this.saveButton = new DevComponents.DotNetBar.ButtonItem();
            this.printButton = new DevComponents.DotNetBar.ButtonItem();
            this.exitButton = new DevComponents.DotNetBar.ButtonItem();
            this.saveButtonMini = new DevComponents.DotNetBar.ButtonItem();
            this.favoritesButtonMini = new DevComponents.DotNetBar.ButtonItem();
            this.printButtonMini = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.dockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            this.statusBar = new DevComponents.DotNetBar.Bar();
            this.statusLabel = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.systemControl.SuspendLayout();
            this.statisticsPanel.SuspendLayout();
            this.workersPanel.SuspendLayout();
            this.inventoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBar)).BeginInit();
            this.SuspendLayout();
            // 
            // systemControl
            // 
            this.systemControl.CaptionVisible = true;
            this.systemControl.Controls.Add(this.statisticsPanel);
            this.systemControl.Controls.Add(this.workersPanel);
            this.systemControl.Controls.Add(this.inventoryPanel);
            this.systemControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.systemControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemControl.ForeColor = System.Drawing.Color.Black;
            this.systemControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.inventoryTab,
            this.workersTab,
            this.statisticsTab});
            this.systemControl.KeyTipsFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemControl.Location = new System.Drawing.Point(4, 1);
            this.systemControl.Name = "systemControl";
            this.systemControl.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass;
            this.systemControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.systemControl.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.systemStartButton,
            this.saveButtonMini,
            this.favoritesButtonMini,
            this.printButtonMini,
            this.qatCustomizeItem1});
            this.systemControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.systemControl.Size = new System.Drawing.Size(1001, 166);
            this.systemControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.systemControl.TabGroupHeight = 14;
            this.systemControl.TabIndex = 0;
            this.systemControl.Text = "systemControl";
            this.systemControl.SelectedRibbonTabChanged += new System.EventHandler(this.systemControl_SelectedRibbonTabChanged);
            // 
            // statisticsPanel
            // 
            this.statisticsPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.statisticsPanel.Controls.Add(this.graphsStatisticsBar);
            this.statisticsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticsPanel.Location = new System.Drawing.Point(0, 61);
            this.statisticsPanel.Name = "statisticsPanel";
            this.statisticsPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.statisticsPanel.Size = new System.Drawing.Size(1001, 103);
            this.statisticsPanel.TabIndex = 3;
            // 
            // graphsStatisticsBar
            // 
            this.graphsStatisticsBar.AutoOverflowEnabled = true;
            this.graphsStatisticsBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.graphsStatisticsBar.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.graphsStatisticsBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.percentageGraphButton,
            this.salesGraphButton});
            this.graphsStatisticsBar.Location = new System.Drawing.Point(3, 0);
            this.graphsStatisticsBar.Name = "graphsStatisticsBar";
            this.graphsStatisticsBar.ResizeOrderIndex = 1;
            this.graphsStatisticsBar.Size = new System.Drawing.Size(157, 100);
            this.graphsStatisticsBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.graphsStatisticsBar.TabIndex = 4;
            this.graphsStatisticsBar.Text = "גרפים סטטיסטיים";
            this.graphsStatisticsBar.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // percentageGraphButton
            // 
            this.percentageGraphButton.Image = ((System.Drawing.Image)(resources.GetObject("percentageGraphButton.Image")));
            this.percentageGraphButton.ImagePaddingHorizontal = 8;
            this.percentageGraphButton.Name = "percentageGraphButton";
            this.percentageGraphButton.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.percViaSowDate,
            this.percViaSeedType,
            this.percViaTimeInFridge});
            this.percentageGraphButton.SubItemsExpandWidth = 14;
            this.percentageGraphButton.Tooltip = "בחירת גרף של אחוזי הנביטה";
            this.percentageGraphButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.percentageGraphButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // percViaSowDate
            // 
            this.percViaSowDate.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.percViaSowDate.Image = ((System.Drawing.Image)(resources.GetObject("percViaSowDate.Image")));
            this.percViaSowDate.ImagePaddingHorizontal = 8;
            this.percViaSowDate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.percViaSowDate.Name = "percViaSowDate";
            this.percViaSowDate.SubItemsExpandWidth = 14;
            this.percViaSowDate.Text = "אחוזי נביטה לפי תאריך הזריע";
            this.percViaSowDate.Tooltip = "הצגת גרף אחוזי נביטה לפי תאריך הזריע";
            this.percViaSowDate.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.percViaSowDate.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // percViaSeedType
            // 
            this.percViaSeedType.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.percViaSeedType.Image = ((System.Drawing.Image)(resources.GetObject("percViaSeedType.Image")));
            this.percViaSeedType.ImagePaddingHorizontal = 8;
            this.percViaSeedType.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.percViaSeedType.Name = "percViaSeedType";
            this.percViaSeedType.SubItemsExpandWidth = 14;
            this.percViaSeedType.Text = "אחוזי נביטה לפי סוג הזרעים";
            this.percViaSeedType.Tooltip = "הצגת גרף אחוזי נביטה לפי סוג הזרעים";
            this.percViaSeedType.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.percViaSeedType.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // percViaTimeInFridge
            // 
            this.percViaTimeInFridge.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.percViaTimeInFridge.Image = ((System.Drawing.Image)(resources.GetObject("percViaTimeInFridge.Image")));
            this.percViaTimeInFridge.ImagePaddingHorizontal = 8;
            this.percViaTimeInFridge.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.percViaTimeInFridge.Name = "percViaTimeInFridge";
            this.percViaTimeInFridge.SubItemsExpandWidth = 14;
            this.percViaTimeInFridge.Text = "אחוזי נביטה לפי זמן שהיה במקרר";
            this.percViaTimeInFridge.Tooltip = "הצגת גרף אחוזי נביטה לפי זמן שהיה במקרר";
            this.percViaTimeInFridge.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.percViaTimeInFridge.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // salesGraphButton
            // 
            this.salesGraphButton.Image = ((System.Drawing.Image)(resources.GetObject("salesGraphButton.Image")));
            this.salesGraphButton.ImagePaddingHorizontal = 8;
            this.salesGraphButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.salesGraphButton.Name = "salesGraphButton";
            this.salesGraphButton.SubItemsExpandWidth = 14;
            this.salesGraphButton.Tooltip = "בחירת גרף מכירות";
            this.salesGraphButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.salesGraphButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            this.salesGraphButton.Click += new System.EventHandler(this.salesGraphButton_Click);
            // 
            // workersPanel
            // 
            this.workersPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.workersPanel.Controls.Add(this.paymentWorkersBar);
            this.workersPanel.Controls.Add(this.visaWorkersBar);
            this.workersPanel.Controls.Add(this.generalWorkersBar);
            this.workersPanel.Controls.Add(this.reportWorkersBar);
            this.workersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workersPanel.Location = new System.Drawing.Point(0, 61);
            this.workersPanel.Name = "workersPanel";
            this.workersPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.workersPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.workersPanel.ShowFocusRectangle = true;
            this.workersPanel.Size = new System.Drawing.Size(1001, 103);
            this.workersPanel.TabIndex = 2;
            this.workersPanel.Visible = false;
            // 
            // paymentWorkersBar
            // 
            this.paymentWorkersBar.AutoOverflowEnabled = true;
            this.paymentWorkersBar.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.paymentWorkersBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.paymentButton});
            this.paymentWorkersBar.Location = new System.Drawing.Point(314, 0);
            this.paymentWorkersBar.Name = "paymentWorkersBar";
            this.paymentWorkersBar.Size = new System.Drawing.Size(99, 100);
            this.paymentWorkersBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.paymentWorkersBar.TabIndex = 4;
            this.paymentWorkersBar.Text = "תשלומים";
            this.paymentWorkersBar.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // paymentButton
            // 
            this.paymentButton.Image = ((System.Drawing.Image)(resources.GetObject("paymentButton.Image")));
            this.paymentButton.ImagePaddingHorizontal = 8;
            this.paymentButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.SubItemsExpandWidth = 14;
            this.paymentButton.Tooltip = "ניהול משכורות...";
            this.paymentButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.paymentButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // visaWorkersBar
            // 
            this.visaWorkersBar.AutoOverflowEnabled = true;
            this.visaWorkersBar.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.visaWorkersBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.addUpdateVisaButton});
            this.visaWorkersBar.Location = new System.Drawing.Point(417, 0);
            this.visaWorkersBar.Name = "visaWorkersBar";
            this.visaWorkersBar.Size = new System.Drawing.Size(113, 100);
            this.visaWorkersBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.visaWorkersBar.TabIndex = 3;
            this.visaWorkersBar.Text = "אשרות כניסה";
            this.visaWorkersBar.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // addUpdateVisaButton
            // 
            this.addUpdateVisaButton.Image = ((System.Drawing.Image)(resources.GetObject("addUpdateVisaButton.Image")));
            this.addUpdateVisaButton.ImagePaddingHorizontal = 8;
            this.addUpdateVisaButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.addUpdateVisaButton.Name = "addUpdateVisaButton";
            this.addUpdateVisaButton.SubItemsExpandWidth = 14;
            this.addUpdateVisaButton.Tooltip = "הוספת\\עדכון אשרות כניסה...";
            this.addUpdateVisaButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.addUpdateVisaButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // generalWorkersBar
            // 
            this.generalWorkersBar.AutoOverflowEnabled = true;
            this.generalWorkersBar.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.generalWorkersBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.findWorkersButton,
            this.addWorkerButton,
            this.removeWorkerButton});
            this.generalWorkersBar.Location = new System.Drawing.Point(3, 0);
            this.generalWorkersBar.Name = "generalWorkersBar";
            this.generalWorkersBar.ResizeOrderIndex = 1;
            this.generalWorkersBar.Size = new System.Drawing.Size(178, 100);
            this.generalWorkersBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.generalWorkersBar.TabIndex = 3;
            this.generalWorkersBar.Text = "כללי";
            this.generalWorkersBar.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // findWorkersButton
            // 
            this.findWorkersButton.Image = ((System.Drawing.Image)(resources.GetObject("findWorkersButton.Image")));
            this.findWorkersButton.ImagePaddingHorizontal = 8;
            this.findWorkersButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.findWorkersButton.Name = "findWorkersButton";
            this.findWorkersButton.SubItemsExpandWidth = 14;
            this.findWorkersButton.Tooltip = "חיפוש עובדים...";
            this.findWorkersButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.findWorkersButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // addWorkerButton
            // 
            this.addWorkerButton.Image = ((System.Drawing.Image)(resources.GetObject("addWorkerButton.Image")));
            this.addWorkerButton.ImagePaddingHorizontal = 8;
            this.addWorkerButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.addWorkerButton.Name = "addWorkerButton";
            this.addWorkerButton.SubItemsExpandWidth = 14;
            this.addWorkerButton.Tooltip = "הוספת עובד חדש...";
            this.addWorkerButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.addWorkerButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            this.addWorkerButton.Click += new System.EventHandler(this.addWorkerButton_Click);
            // 
            // removeWorkerButton
            // 
            this.removeWorkerButton.Image = ((System.Drawing.Image)(resources.GetObject("removeWorkerButton.Image")));
            this.removeWorkerButton.ImagePaddingHorizontal = 8;
            this.removeWorkerButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.removeWorkerButton.Name = "removeWorkerButton";
            this.removeWorkerButton.SubItemsExpandWidth = 14;
            this.removeWorkerButton.Tooltip = "מחיקת עובד...";
            this.removeWorkerButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.removeWorkerButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // reportWorkersBar
            // 
            this.reportWorkersBar.AutoOverflowEnabled = true;
            this.reportWorkersBar.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.reportWorkersBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.reportButton,
            this.addWorkerHoursButton});
            this.reportWorkersBar.Location = new System.Drawing.Point(185, 0);
            this.reportWorkersBar.Name = "reportWorkersBar";
            this.reportWorkersBar.Size = new System.Drawing.Size(125, 100);
            this.reportWorkersBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.reportWorkersBar.TabIndex = 2;
            this.reportWorkersBar.Text = "דו\"חות ודיווחים";
            this.reportWorkersBar.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // reportButton
            // 
            this.reportButton.Image = ((System.Drawing.Image)(resources.GetObject("reportButton.Image")));
            this.reportButton.ImagePaddingHorizontal = 8;
            this.reportButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.reportButton.Name = "reportButton";
            this.reportButton.SubItemsExpandWidth = 14;
            this.reportButton.Tooltip = "ליצור דו\"ח...";
            this.reportButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.reportButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // addWorkerHoursButton
            // 
            this.addWorkerHoursButton.Image = ((System.Drawing.Image)(resources.GetObject("addWorkerHoursButton.Image")));
            this.addWorkerHoursButton.ImagePaddingHorizontal = 8;
            this.addWorkerHoursButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.addWorkerHoursButton.Name = "addWorkerHoursButton";
            this.addWorkerHoursButton.SubItemsExpandWidth = 14;
            this.addWorkerHoursButton.Tooltip = "דיווח\\עדכון שעות עבודה...";
            this.addWorkerHoursButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.addWorkerHoursButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // inventoryPanel
            // 
            this.inventoryPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.inventoryPanel.Controls.Add(this.ordersInventoryBar);
            this.inventoryPanel.Controls.Add(this.operationsInventoryBar);
            this.inventoryPanel.Controls.Add(this.generalInventoryBar);
            this.inventoryPanel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.inventoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryPanel.Location = new System.Drawing.Point(0, 61);
            this.inventoryPanel.Name = "inventoryPanel";
            this.inventoryPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.inventoryPanel.Size = new System.Drawing.Size(1001, 103);
            this.inventoryPanel.TabIndex = 1;
            this.inventoryPanel.Visible = false;
            // 
            // ordersInventoryBar
            // 
            this.ordersInventoryBar.AutoOverflowEnabled = true;
            this.ordersInventoryBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.ordersInventoryBar.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.ordersInventoryBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.findOrderButton,
            this.addOrderButton,
            this.removeOrderButton});
            this.ordersInventoryBar.Location = new System.Drawing.Point(376, 0);
            this.ordersInventoryBar.Name = "ordersInventoryBar";
            this.ordersInventoryBar.ResizeOrderIndex = 1;
            this.ordersInventoryBar.Size = new System.Drawing.Size(195, 100);
            this.ordersInventoryBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ordersInventoryBar.TabIndex = 6;
            this.ordersInventoryBar.Text = "מנהל בהזמנות";
            this.ordersInventoryBar.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // findOrderButton
            // 
            this.findOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("findOrderButton.Image")));
            this.findOrderButton.ImagePaddingHorizontal = 8;
            this.findOrderButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.findOrderButton.Name = "findOrderButton";
            this.findOrderButton.SubItemsExpandWidth = 14;
            this.findOrderButton.Tooltip = "חיפוש הזמנה...";
            this.findOrderButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.findOrderButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // addOrderButton
            // 
            this.addOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("addOrderButton.Image")));
            this.addOrderButton.ImagePaddingHorizontal = 8;
            this.addOrderButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.SubItemsExpandWidth = 14;
            this.addOrderButton.Tooltip = "הוספת הזמנה חדשה...";
            this.addOrderButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.addOrderButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // removeOrderButton
            // 
            this.removeOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("removeOrderButton.Image")));
            this.removeOrderButton.ImagePaddingHorizontal = 8;
            this.removeOrderButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.removeOrderButton.Name = "removeOrderButton";
            this.removeOrderButton.SubItemsExpandWidth = 14;
            this.removeOrderButton.Tooltip = "לבטל הזמנה...";
            this.removeOrderButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.removeOrderButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // operationsInventoryBar
            // 
            this.operationsInventoryBar.AutoOverflowEnabled = true;
            this.operationsInventoryBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.operationsInventoryBar.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.operationsInventoryBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.addToFridgeButton,
            this.seedPlantButton,
            this.collectPlantsbutton});
            this.operationsInventoryBar.Location = new System.Drawing.Point(181, 0);
            this.operationsInventoryBar.Name = "operationsInventoryBar";
            this.operationsInventoryBar.ResizeOrderIndex = 1;
            this.operationsInventoryBar.Size = new System.Drawing.Size(195, 100);
            this.operationsInventoryBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.operationsInventoryBar.TabIndex = 5;
            this.operationsInventoryBar.Text = "פעלות";
            this.operationsInventoryBar.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // addToFridgeButton
            // 
            this.addToFridgeButton.Image = ((System.Drawing.Image)(resources.GetObject("addToFridgeButton.Image")));
            this.addToFridgeButton.ImagePaddingHorizontal = 8;
            this.addToFridgeButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.addToFridgeButton.Name = "addToFridgeButton";
            this.addToFridgeButton.SubItemsExpandWidth = 14;
            this.addToFridgeButton.Tooltip = "הוספת זרעים חדשים למקרר...";
            this.addToFridgeButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.addToFridgeButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // seedPlantButton
            // 
            this.seedPlantButton.Image = ((System.Drawing.Image)(resources.GetObject("seedPlantButton.Image")));
            this.seedPlantButton.ImagePaddingHorizontal = 8;
            this.seedPlantButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.seedPlantButton.Name = "seedPlantButton";
            this.seedPlantButton.SubItemsExpandWidth = 14;
            this.seedPlantButton.Tooltip = "זריעת צמחים...";
            this.seedPlantButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.seedPlantButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // collectPlantsbutton
            // 
            this.collectPlantsbutton.Image = ((System.Drawing.Image)(resources.GetObject("collectPlantsbutton.Image")));
            this.collectPlantsbutton.ImagePaddingHorizontal = 8;
            this.collectPlantsbutton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.collectPlantsbutton.Name = "collectPlantsbutton";
            this.collectPlantsbutton.SubItemsExpandWidth = 14;
            this.collectPlantsbutton.Tooltip = "איסוף צמחים...";
            this.collectPlantsbutton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.collectPlantsbutton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // generalInventoryBar
            // 
            this.generalInventoryBar.AutoOverflowEnabled = true;
            this.generalInventoryBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.generalInventoryBar.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.generalInventoryBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.findPlantButton,
            this.addPlantButton,
            this.removePlantButton});
            this.generalInventoryBar.Location = new System.Drawing.Point(3, 0);
            this.generalInventoryBar.Name = "generalInventoryBar";
            this.generalInventoryBar.ResizeOrderIndex = 1;
            this.generalInventoryBar.Size = new System.Drawing.Size(178, 100);
            this.generalInventoryBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.generalInventoryBar.TabIndex = 4;
            this.generalInventoryBar.Text = "כללי";
            this.generalInventoryBar.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // findPlantButton
            // 
            this.findPlantButton.Image = ((System.Drawing.Image)(resources.GetObject("findPlantButton.Image")));
            this.findPlantButton.ImagePaddingHorizontal = 8;
            this.findPlantButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.findPlantButton.Name = "findPlantButton";
            this.findPlantButton.SubItemsExpandWidth = 14;
            this.findPlantButton.Tooltip = "חיפוש צמח...";
            this.findPlantButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.findPlantButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            this.findPlantButton.Click += new System.EventHandler(this.findPlantButton_Click);
            // 
            // addPlantButton
            // 
            this.addPlantButton.Image = ((System.Drawing.Image)(resources.GetObject("addPlantButton.Image")));
            this.addPlantButton.ImagePaddingHorizontal = 8;
            this.addPlantButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.addPlantButton.Name = "addPlantButton";
            this.addPlantButton.SubItemsExpandWidth = 14;
            this.addPlantButton.Tooltip = "הוספת צמח חדש...";
            this.addPlantButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.addPlantButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            this.addPlantButton.Click += new System.EventHandler(this.addPlantButton_Click);
            // 
            // removePlantButton
            // 
            this.removePlantButton.Image = ((System.Drawing.Image)(resources.GetObject("removePlantButton.Image")));
            this.removePlantButton.ImagePaddingHorizontal = 8;
            this.removePlantButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.removePlantButton.Name = "removePlantButton";
            this.removePlantButton.SubItemsExpandWidth = 14;
            this.removePlantButton.Tooltip = "מחיקת צמח...";
            this.removePlantButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.removePlantButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // inventoryTab
            // 
            this.inventoryTab.ImagePaddingHorizontal = 8;
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Panel = this.inventoryPanel;
            this.inventoryTab.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.inventoryTab.Text = "מלאי";
            this.inventoryTab.Tooltip = " מודול המלאי        Ctrl+N";
            this.inventoryTab.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.inventoryTab.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // workersTab
            // 
            this.workersTab.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Default;
            this.workersTab.ImagePaddingHorizontal = 8;
            this.workersTab.Name = "workersTab";
            this.workersTab.Panel = this.workersPanel;
            this.workersTab.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlG);
            this.workersTab.Text = "עובדים";
            this.workersTab.Tooltip = " מודול העובדים       Ctrl+G";
            this.workersTab.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.workersTab.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // statisticsTab
            // 
            this.statisticsTab.Checked = true;
            this.statisticsTab.ImagePaddingHorizontal = 8;
            this.statisticsTab.Name = "statisticsTab";
            this.statisticsTab.Panel = this.statisticsPanel;
            this.statisticsTab.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.statisticsTab.Text = "סטטיסטיקות";
            this.statisticsTab.Tooltip = " מודול סטטיסטי       Ctrl+X";
            this.statisticsTab.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.statisticsTab.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // systemStartButton
            // 
            this.systemStartButton.AutoExpandOnClick = true;
            this.systemStartButton.CanCustomize = false;
            this.systemStartButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.systemStartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.systemStartButton.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.systemStartButton.Image = ((System.Drawing.Image)(resources.GetObject("systemStartButton.Image")));
            this.systemStartButton.ImagePaddingHorizontal = 2;
            this.systemStartButton.ImagePaddingVertical = 2;
            this.systemStartButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.systemStartButton.Name = "systemStartButton";
            this.systemStartButton.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.Fade;
            this.systemStartButton.PressedImage = ((System.Drawing.Image)(resources.GetObject("systemStartButton.PressedImage")));
            this.systemStartButton.ShowSubItems = false;
            this.systemStartButton.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.sytemMenu});
            this.systemStartButton.Text = "&System";
            this.systemStartButton.Tooltip = "מערכת";
            this.systemStartButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.systemStartButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // sytemMenu
            // 
            // 
            // 
            // 
            this.sytemMenu.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.sytemMenu.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.sytemMenu.Name = "sytemMenu";
            this.sytemMenu.ResizeItemsToFit = false;
            this.sytemMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.systemButtonContainer});
            // 
            // systemButtonContainer
            // 
            // 
            // 
            // 
            this.systemButtonContainer.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.systemButtonContainer.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.systemButtonContainer.ItemSpacing = 0;
            this.systemButtonContainer.Name = "systemButtonContainer";
            this.systemButtonContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.systemButtons});
            this.systemButtonContainer.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.systemButtonContainer.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // systemButtons
            // 
            // 
            // 
            // 
            this.systemButtons.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.systemButtons.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.systemButtons.MinimumSize = new System.Drawing.Size(120, 0);
            this.systemButtons.Name = "systemButtons";
            this.systemButtons.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.identificationButton,
            this.addNewUserButton,
            this.systemMngButton,
            this.saveButton,
            this.printButton,
            this.exitButton});
            // 
            // identificationButton
            // 
            this.identificationButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.identificationButton.Image = ((System.Drawing.Image)(resources.GetObject("identificationButton.Image")));
            this.identificationButton.ImagePaddingHorizontal = 20;
            this.identificationButton.Name = "identificationButton";
            this.identificationButton.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE);
            this.identificationButton.SubItemsExpandWidth = 24;
            this.identificationButton.Text = "כניסה למערכת...";
            this.identificationButton.Tooltip = "כניסה למערכת...   Ctrl+E";
            this.identificationButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.identificationButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // addNewUserButton
            // 
            this.addNewUserButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.addNewUserButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewUserButton.Image")));
            this.addNewUserButton.ImagePaddingHorizontal = 20;
            this.addNewUserButton.Name = "addNewUserButton";
            this.addNewUserButton.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.addNewUserButton.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.addNewUserButton1,
            this.removeUserButton});
            this.addNewUserButton.SubItemsExpandWidth = 24;
            this.addNewUserButton.Text = "ניהול משתמשים";
            this.addNewUserButton.Tooltip = "ניהול משתמשים   Ctrl+Shift+C";
            this.addNewUserButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.addNewUserButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            this.addNewUserButton.Click += new System.EventHandler(this.addNewUserButton_Click);
            // 
            // addNewUserButton1
            // 
            this.addNewUserButton1.Image = ((System.Drawing.Image)(resources.GetObject("addNewUserButton1.Image")));
            this.addNewUserButton1.ImagePaddingHorizontal = 8;
            this.addNewUserButton1.Name = "addNewUserButton1";
            this.addNewUserButton1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.addNewUserButton1.Text = "הוסף משתמש חדש...";
            this.addNewUserButton1.Tooltip = "הוסף משתמש חדש...   Ctrl+A";
            this.addNewUserButton1.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.addNewUserButton1.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // removeUserButton
            // 
            this.removeUserButton.Image = ((System.Drawing.Image)(resources.GetObject("removeUserButton.Image")));
            this.removeUserButton.ImagePaddingHorizontal = 8;
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD);
            this.removeUserButton.Text = "מחק משתמש...";
            this.removeUserButton.Tooltip = "מחק משתמש...   Ctrl+A";
            this.removeUserButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.removeUserButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // systemMngButton
            // 
            this.systemMngButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.systemMngButton.Image = global::seedsfromzion.Properties.Resources.emd438_Layer_1;
            this.systemMngButton.ImagePaddingHorizontal = 20;
            this.systemMngButton.Name = "systemMngButton";
            this.systemMngButton.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlShiftS);
            this.systemMngButton.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.loadBackUpButton,
            this.createBackUpButton,
            this.settingsButton});
            this.systemMngButton.SubItemsExpandWidth = 24;
            this.systemMngButton.Text = "ניהול המערכת";
            this.systemMngButton.Tooltip = "ניהול המערכת      Ctrl+Shift+S";
            this.systemMngButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.systemMngButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // loadBackUpButton
            // 
            this.loadBackUpButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.loadBackUpButton.Image = ((System.Drawing.Image)(resources.GetObject("loadBackUpButton.Image")));
            this.loadBackUpButton.ImagePaddingHorizontal = 8;
            this.loadBackUpButton.Name = "loadBackUpButton";
            this.loadBackUpButton.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL);
            this.loadBackUpButton.SubItemsExpandWidth = 24;
            this.loadBackUpButton.Text = "לטעון גיבוי...";
            this.loadBackUpButton.Tooltip = "לטעון גיבוי...   Ctrl+O";
            this.loadBackUpButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.loadBackUpButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            this.loadBackUpButton.Click += new System.EventHandler(this.loadBackUpButton_Click);
            // 
            // createBackUpButton
            // 
            this.createBackUpButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.createBackUpButton.Image = ((System.Drawing.Image)(resources.GetObject("createBackUpButton.Image")));
            this.createBackUpButton.ImagePaddingHorizontal = 20;
            this.createBackUpButton.Name = "createBackUpButton";
            this.createBackUpButton.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlB);
            this.createBackUpButton.SubItemsExpandWidth = 24;
            this.createBackUpButton.Text = "לעשות גיבוי...";
            this.createBackUpButton.Tooltip = "לעשות גיבוי...   Ctrl+S";
            this.createBackUpButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.createBackUpButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            this.createBackUpButton.Click += new System.EventHandler(this.createBackUpButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImagePaddingHorizontal = 20;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlT);
            this.settingsButton.SubItemsExpandWidth = 24;
            this.settingsButton.Text = "הגדרות...";
            this.settingsButton.Tooltip = "הגדרות...   Ctrl+T";
            this.settingsButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.settingsButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.saveButton.Image = global::seedsfromzion.Properties.Resources.Save;
            this.saveButton.ImagePaddingHorizontal = 20;
            this.saveButton.Name = "saveButton";
            this.saveButton.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.saveButton.SubItemsExpandWidth = 24;
            this.saveButton.Text = "שמור מסך...";
            this.saveButton.Tooltip = "שמור מסך...   Ctrl+S";
            this.saveButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.saveButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // printButton
            // 
            this.printButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.printButton.Image = global::seedsfromzion.Properties.Resources.Printer42_Layer_1;
            this.printButton.ImagePaddingHorizontal = 20;
            this.printButton.Name = "printButton";
            this.printButton.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP);
            this.printButton.SubItemsExpandWidth = 24;
            this.printButton.Text = "הדפסה...";
            this.printButton.Tooltip = "הדפסה...   Ctrl+P";
            this.printButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.printButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BeginGroup = true;
            this.exitButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.exitButton.Image = global::seedsfromzion.Properties.Resources.delete40_Layer_1;
            this.exitButton.ImagePaddingHorizontal = 20;
            this.exitButton.Name = "exitButton";
            this.exitButton.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlQ);
            this.exitButton.SubItemsExpandWidth = 24;
            this.exitButton.Text = "יציאה";
            this.exitButton.Tooltip = "יציאה   Ctrl+Q";
            this.exitButton.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.exitButton.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveButtonMini
            // 
            this.saveButtonMini.Image = ((System.Drawing.Image)(resources.GetObject("saveButtonMini.Image")));
            this.saveButtonMini.ImagePaddingHorizontal = 8;
            this.saveButtonMini.Name = "saveButtonMini";
            this.saveButtonMini.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.saveButtonMini.Tooltip = "שמור מסך...";
            this.saveButtonMini.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.saveButtonMini.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // favoritesButtonMini
            // 
            this.favoritesButtonMini.Image = ((System.Drawing.Image)(resources.GetObject("favoritesButtonMini.Image")));
            this.favoritesButtonMini.ImagePaddingHorizontal = 8;
            this.favoritesButtonMini.Name = "favoritesButtonMini";
            this.favoritesButtonMini.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlF);
            this.favoritesButtonMini.Tooltip = "מועדפים...";
            this.favoritesButtonMini.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.favoritesButtonMini.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // printButtonMini
            // 
            this.printButtonMini.Image = ((System.Drawing.Image)(resources.GetObject("printButtonMini.Image")));
            this.printButtonMini.ImagePaddingHorizontal = 8;
            this.printButtonMini.Name = "printButtonMini";
            this.printButtonMini.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP);
            this.printButtonMini.Tooltip = "הדפס...";
            this.printButtonMini.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.printButtonMini.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            this.qatCustomizeItem1.PersonalizedMenus = DevComponents.DotNetBar.ePersonalizedMenus.DisplayOnClick;
            this.qatCustomizeItem1.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.Fade;
            // 
            // dockContainerItem1
            // 
            this.dockContainerItem1.Name = "dockContainerItem1";
            this.dockContainerItem1.Text = "dockContainerItem1";
            // 
            // statusBar
            // 
            this.statusBar.AccessibleDescription = "DotNetBar Bar (statusBar)";
            this.statusBar.AccessibleName = "DotNetBar Bar";
            this.statusBar.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle;
            this.statusBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(4, 580);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1001, 23);
            this.statusBar.Stretch = true;
            this.statusBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.statusBar.TabIndex = 1;
            this.statusBar.TabStop = false;
            this.statusBar.Tag = "";
            this.statusBar.Text = "ברוך הבאה למערכת SeedsFromZion !";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Text = "ברוך הבאה למערכת SeedsFromZion !";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = true;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // seedsFromZion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1009, 605);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.systemControl);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "seedsFromZion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "SeedsFromZion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SeedsFromZion_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.seedsFromZion_FormClosing);
            this.systemControl.ResumeLayout(false);
            this.systemControl.PerformLayout();
            this.statisticsPanel.ResumeLayout(false);
            this.workersPanel.ResumeLayout(false);
            this.inventoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl systemControl;
        private DevComponents.DotNetBar.RibbonPanel inventoryPanel;
        private DevComponents.DotNetBar.RibbonPanel workersPanel;
        private DevComponents.DotNetBar.RibbonTabItem inventoryTab;
        private DevComponents.DotNetBar.RibbonTabItem workersTab;
        private DevComponents.DotNetBar.Office2007StartButton systemStartButton;
        private DevComponents.DotNetBar.ItemContainer sytemMenu;
        private DevComponents.DotNetBar.ItemContainer systemButtonContainer;
        private DevComponents.DotNetBar.ItemContainer systemButtons;
        private DevComponents.DotNetBar.ButtonItem printButton;
        private DevComponents.DotNetBar.ButtonItem exitButton;
        private DevComponents.DotNetBar.ButtonItem printButtonMini;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.ButtonItem identificationButton;
        private DevComponents.DotNetBar.ButtonItem addNewUserButton;
        private DevComponents.DotNetBar.RibbonPanel statisticsPanel;
        private DevComponents.DotNetBar.RibbonTabItem statisticsTab;
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
        private DevComponents.DotNetBar.ButtonItem addNewUserButton1;
        private DevComponents.DotNetBar.ButtonItem systemMngButton;
        private DevComponents.DotNetBar.ButtonItem loadBackUpButton;
        private DevComponents.DotNetBar.ButtonItem createBackUpButton;
        private DevComponents.DotNetBar.ButtonItem removeUserButton;
        private DevComponents.DotNetBar.ButtonItem settingsButton;
        private DevComponents.DotNetBar.ButtonItem saveButtonMini;
        private DevComponents.DotNetBar.ButtonItem favoritesButtonMini;
        private DevComponents.DotNetBar.ButtonItem saveButton;
        private DevComponents.DotNetBar.Bar statusBar;
        private DevComponents.DotNetBar.LabelItem statusLabel;
        private DevComponents.DotNetBar.RibbonBar generalWorkersBar;
        private DevComponents.DotNetBar.ButtonItem findWorkersButton;
        private DevComponents.DotNetBar.ButtonItem addWorkerButton;
        private DevComponents.DotNetBar.ButtonItem removeWorkerButton;
        private DevComponents.DotNetBar.RibbonBar reportWorkersBar;
        private DevComponents.DotNetBar.ButtonItem reportButton;
        private DevComponents.DotNetBar.RibbonBar visaWorkersBar;
        private DevComponents.DotNetBar.ButtonItem addWorkerHoursButton;
        private DevComponents.DotNetBar.ButtonItem addUpdateVisaButton;
        private DevComponents.DotNetBar.RibbonBar paymentWorkersBar;
        private DevComponents.DotNetBar.ButtonItem paymentButton;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.RibbonBar generalInventoryBar;
        private DevComponents.DotNetBar.ButtonItem findPlantButton;
        private DevComponents.DotNetBar.ButtonItem addPlantButton;
        private DevComponents.DotNetBar.ButtonItem removePlantButton;
        private DevComponents.DotNetBar.RibbonBar operationsInventoryBar;
        private DevComponents.DotNetBar.ButtonItem addToFridgeButton;
        private DevComponents.DotNetBar.ButtonItem seedPlantButton;
        private DevComponents.DotNetBar.ButtonItem collectPlantsbutton;
        private DevComponents.DotNetBar.RibbonBar ordersInventoryBar;
        private DevComponents.DotNetBar.ButtonItem findOrderButton;
        private DevComponents.DotNetBar.ButtonItem addOrderButton;
        private DevComponents.DotNetBar.ButtonItem removeOrderButton;
        private DevComponents.DotNetBar.RibbonBar graphsStatisticsBar;
        private DevComponents.DotNetBar.ButtonItem percentageGraphButton;
        private DevComponents.DotNetBar.ButtonItem salesGraphButton;
        private DevComponents.DotNetBar.ButtonItem percViaSowDate;
        private DevComponents.DotNetBar.ButtonItem percViaSeedType;
        private DevComponents.DotNetBar.ButtonItem percViaTimeInFridge;
    }
}