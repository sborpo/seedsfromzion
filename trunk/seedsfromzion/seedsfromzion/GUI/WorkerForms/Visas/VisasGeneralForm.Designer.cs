namespace seedsfromzion.GUI.WorkerForms
{
    partial class VisasGeneralForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridVisas = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_addVisa = new DevComponents.DotNetBar.ButtonX();
            this.dataGrid_workers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGrid_allWorkers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_attachWorkerToVisa = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_editVisa = new DevComponents.DotNetBar.ButtonX();
            this.btn_deleteVisa = new DevComponents.DotNetBar.ButtonX();
            this.graphicSettingsPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.showGraphButton = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.dateChoisePanel = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tillDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tillDateLabel = new DevComponents.DotNetBar.LabelX();
            this.fromDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.fromDateLabel = new DevComponents.DotNetBar.LabelX();
            this.plantChoisePanel = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.plantNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.plantTypeDropBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_workers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_allWorkers)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.graphicSettingsPanel.SuspendLayout();
            this.dateChoisePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tillDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridVisas
            // 
            this.dataGridVisas.AllowUserToAddRows = false;
            this.dataGridVisas.AllowUserToDeleteRows = false;
            this.dataGridVisas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridVisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVisas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVisas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridVisas.Location = new System.Drawing.Point(19, 13);
            this.dataGridVisas.MultiSelect = false;
            this.dataGridVisas.Name = "dataGridVisas";
            this.dataGridVisas.ReadOnly = true;
            this.dataGridVisas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridVisas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVisas.Size = new System.Drawing.Size(410, 128);
            this.dataGridVisas.TabIndex = 0;
            // 
            // btn_addVisa
            // 
            this.btn_addVisa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addVisa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addVisa.Location = new System.Drawing.Point(141, 147);
            this.btn_addVisa.Name = "btn_addVisa";
            this.btn_addVisa.Size = new System.Drawing.Size(55, 36);
            this.btn_addVisa.TabIndex = 1;
            this.btn_addVisa.Text = "הוסף";
            this.btn_addVisa.Click += new System.EventHandler(this.btn_addVisa_Click);
            // 
            // dataGrid_workers
            // 
            this.dataGrid_workers.AllowUserToAddRows = false;
            this.dataGrid_workers.AllowUserToDeleteRows = false;
            this.dataGrid_workers.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGrid_workers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_workers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_workers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGrid_workers.Location = new System.Drawing.Point(15, 3);
            this.dataGrid_workers.MultiSelect = false;
            this.dataGrid_workers.Name = "dataGrid_workers";
            this.dataGrid_workers.ReadOnly = true;
            this.dataGrid_workers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid_workers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_workers.Size = new System.Drawing.Size(309, 162);
            this.dataGrid_workers.TabIndex = 2;
            // 
            // dataGrid_allWorkers
            // 
            this.dataGrid_allWorkers.AllowUserToAddRows = false;
            this.dataGrid_allWorkers.AllowUserToDeleteRows = false;
            this.dataGrid_allWorkers.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGrid_allWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_allWorkers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_allWorkers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGrid_allWorkers.Location = new System.Drawing.Point(18, 3);
            this.dataGrid_allWorkers.MultiSelect = false;
            this.dataGrid_allWorkers.Name = "dataGrid_allWorkers";
            this.dataGrid_allWorkers.ReadOnly = true;
            this.dataGrid_allWorkers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid_allWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_allWorkers.Size = new System.Drawing.Size(418, 142);
            this.dataGrid_allWorkers.TabIndex = 3;
            // 
            // btn_attachWorkerToVisa
            // 
            this.btn_attachWorkerToVisa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_attachWorkerToVisa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_attachWorkerToVisa.Location = new System.Drawing.Point(18, 151);
            this.btn_attachWorkerToVisa.Name = "btn_attachWorkerToVisa";
            this.btn_attachWorkerToVisa.Size = new System.Drawing.Size(124, 36);
            this.btn_attachWorkerToVisa.TabIndex = 4;
            this.btn_attachWorkerToVisa.Text = "אוסף עובד לויזה";
            this.btn_attachWorkerToVisa.Click += new System.EventHandler(this.btn_addWorkerToVisa_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btn_editVisa);
            this.groupPanel1.Controls.Add(this.btn_deleteVisa);
            this.groupPanel1.Controls.Add(this.dataGridVisas);
            this.groupPanel1.Controls.Add(this.btn_addVisa);
            this.groupPanel1.Location = new System.Drawing.Point(52, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(452, 211);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 7;
            this.groupPanel1.Text = "אשרות כניסה";
            // 
            // btn_editVisa
            // 
            this.btn_editVisa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_editVisa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_editVisa.Location = new System.Drawing.Point(80, 147);
            this.btn_editVisa.Name = "btn_editVisa";
            this.btn_editVisa.Size = new System.Drawing.Size(55, 36);
            this.btn_editVisa.TabIndex = 3;
            this.btn_editVisa.Text = "ערוך";
            this.btn_editVisa.Click += new System.EventHandler(this.btn_editVisa_Click);
            // 
            // btn_deleteVisa
            // 
            this.btn_deleteVisa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_deleteVisa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_deleteVisa.Location = new System.Drawing.Point(19, 147);
            this.btn_deleteVisa.Name = "btn_deleteVisa";
            this.btn_deleteVisa.Size = new System.Drawing.Size(55, 36);
            this.btn_deleteVisa.TabIndex = 2;
            this.btn_deleteVisa.Text = "מחק";
            this.btn_deleteVisa.Click += new System.EventHandler(this.btn_deleteVisa_Click);
            // 
            // graphicSettingsPanel
            // 
            this.graphicSettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.graphicSettingsPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.graphicSettingsPanel.CanvasColor = System.Drawing.SystemColors.ActiveCaption;
            this.graphicSettingsPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.graphicSettingsPanel.Controls.Add(this.showGraphButton);
            this.graphicSettingsPanel.Controls.Add(this.dateChoisePanel);
            this.graphicSettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.graphicSettingsPanel.Name = "graphicSettingsPanel";
            this.graphicSettingsPanel.Size = new System.Drawing.Size(200, 100);
            // 
            // 
            // 
            this.graphicSettingsPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.graphicSettingsPanel.Style.BackColorGradientAngle = 90;
            this.graphicSettingsPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.graphicSettingsPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.graphicSettingsPanel.Style.BorderBottomWidth = 1;
            this.graphicSettingsPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.graphicSettingsPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.graphicSettingsPanel.Style.BorderLeftWidth = 1;
            this.graphicSettingsPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.graphicSettingsPanel.Style.BorderRightWidth = 1;
            this.graphicSettingsPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.graphicSettingsPanel.Style.BorderTopWidth = 1;
            this.graphicSettingsPanel.Style.CornerDiameter = 4;
            this.graphicSettingsPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.graphicSettingsPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.graphicSettingsPanel.Style.TextColor = System.Drawing.Color.Navy;
            this.graphicSettingsPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.graphicSettingsPanel.TabIndex = 0;
            // 
            // showGraphButton
            // 
            this.showGraphButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showGraphButton.CanvasColor = System.Drawing.SystemColors.Control;
            this.showGraphButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showGraphButton.Location = new System.Drawing.Point(664, 382);
            this.showGraphButton.Name = "showGraphButton";
            this.showGraphButton.Size = new System.Drawing.Size(149, 54);
            // 
            // 
            // 
            this.showGraphButton.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.showGraphButton.Style.BackColorGradientAngle = 90;
            this.showGraphButton.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.showGraphButton.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile;
            this.showGraphButton.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.showGraphButton.Style.BorderBottomWidth = 1;
            this.showGraphButton.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.showGraphButton.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.showGraphButton.Style.BorderLeftWidth = 1;
            this.showGraphButton.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.showGraphButton.Style.BorderRightWidth = 1;
            this.showGraphButton.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.showGraphButton.Style.BorderTopWidth = 1;
            this.showGraphButton.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.showGraphButton.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.showGraphButton.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            // 
            // 
            // 
            this.showGraphButton.StyleMouseDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.showGraphButton.StyleMouseDown.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.showGraphButton.StyleMouseDown.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
            this.showGraphButton.StyleMouseDown.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.showGraphButton.StyleMouseDown.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
            // 
            // 
            // 
            this.showGraphButton.StyleMouseOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.showGraphButton.StyleMouseOver.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.showGraphButton.StyleMouseOver.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
            this.showGraphButton.StyleMouseOver.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.showGraphButton.StyleMouseOver.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.showGraphButton.TabIndex = 12;
            this.showGraphButton.Text = "הצג גרף";
            // 
            // dateChoisePanel
            // 
            this.dateChoisePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateChoisePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.dateChoisePanel.Controls.Add(this.tableLayoutPanel2);
            this.dateChoisePanel.Location = new System.Drawing.Point(41, 206);
            this.dateChoisePanel.Name = "dateChoisePanel";
            this.dateChoisePanel.Size = new System.Drawing.Size(772, 142);
            // 
            // 
            // 
            this.dateChoisePanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateChoisePanel.Style.BackColorGradientAngle = 90;
            this.dateChoisePanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateChoisePanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateChoisePanel.Style.BorderBottomWidth = 1;
            this.dateChoisePanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.dateChoisePanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateChoisePanel.Style.BorderLeftWidth = 1;
            this.dateChoisePanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateChoisePanel.Style.BorderRightWidth = 1;
            this.dateChoisePanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateChoisePanel.Style.BorderTopWidth = 1;
            this.dateChoisePanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.dateChoisePanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.dateChoisePanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.dateChoisePanel.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.33504F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.66496F));
            this.tableLayoutPanel2.Controls.Add(this.tillDate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tillDateLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.fromDate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.fromDateLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(772, 142);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tillDate
            // 
            this.tillDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // 
            // 
            this.tillDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.tillDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.tillDate.ButtonDropDown.Visible = true;
            this.tillDate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Right;
            this.tillDate.Location = new System.Drawing.Point(263, 96);
            // 
            // 
            // 
            this.tillDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.tillDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.tillDate.MonthCalendar.ClearButtonVisible = true;
            this.tillDate.MonthCalendar.Colors.DaysDividerBorderColors = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.tillDate.MonthCalendar.DayNames = new string[] {
        "א",
        "ב",
        "ג",
        "ד",
        "ה",
        "ו",
        "ש"};
            this.tillDate.MonthCalendar.DisplayMonth = new System.DateTime(2010, 5, 1, 0, 0, 0, 0);
            this.tillDate.MonthCalendar.GlobalName = "theCalendar";
            this.tillDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.tillDate.MonthCalendar.MaxSelectionCount = 1;
            this.tillDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.tillDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.tillDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.tillDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.tillDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.tillDate.MonthCalendar.TodayButtonVisible = true;
            this.tillDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.tillDate.Name = "tillDate";
            this.tillDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tillDate.ShowCheckBox = true;
            this.tillDate.Size = new System.Drawing.Size(192, 20);
            this.tillDate.TabIndex = 13;
            this.tillDate.WatermarkEnabled = false;
            // 
            // tillDateLabel
            // 
            this.tillDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tillDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.tillDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tillDateLabel.ForeColor = System.Drawing.Color.Black;
            this.tillDateLabel.Location = new System.Drawing.Point(626, 94);
            this.tillDateLabel.Name = "tillDateLabel";
            this.tillDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tillDateLabel.Size = new System.Drawing.Size(143, 25);
            this.tillDateLabel.TabIndex = 8;
            this.tillDateLabel.Text = "עד תאריך:";
            this.tillDateLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // fromDate
            // 
            this.fromDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // 
            // 
            this.fromDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.fromDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.fromDate.ButtonDropDown.Visible = true;
            this.fromDate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Right;
            this.fromDate.Location = new System.Drawing.Point(263, 25);
            // 
            // 
            // 
            this.fromDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.fromDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.fromDate.MonthCalendar.ClearButtonVisible = true;
            this.fromDate.MonthCalendar.Colors.DaysDividerBorderColors = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.fromDate.MonthCalendar.DayNames = new string[] {
        "א",
        "ב",
        "ג",
        "ד",
        "ה",
        "ו",
        "ש"};
            this.fromDate.MonthCalendar.DisplayMonth = new System.DateTime(2010, 5, 1, 0, 0, 0, 0);
            this.fromDate.MonthCalendar.GlobalName = "theCalendar";
            this.fromDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.fromDate.MonthCalendar.MaxSelectionCount = 1;
            this.fromDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.fromDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.fromDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.fromDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.fromDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.fromDate.MonthCalendar.TodayButtonVisible = true;
            this.fromDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.fromDate.Name = "fromDate";
            this.fromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromDate.ShowCheckBox = true;
            this.fromDate.Size = new System.Drawing.Size(192, 20);
            this.fromDate.TabIndex = 6;
            this.fromDate.WatermarkEnabled = false;
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fromDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.fromDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.fromDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromDateLabel.ForeColor = System.Drawing.Color.Black;
            this.fromDateLabel.Location = new System.Drawing.Point(626, 23);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromDateLabel.Size = new System.Drawing.Size(143, 25);
            this.fromDateLabel.TabIndex = 9;
            this.fromDateLabel.Text = "מתאריך:";
            this.fromDateLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // plantChoisePanel
            // 
            this.plantChoisePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.plantChoisePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.plantChoisePanel.Location = new System.Drawing.Point(0, 0);
            this.plantChoisePanel.Name = "plantChoisePanel";
            this.plantChoisePanel.Size = new System.Drawing.Size(200, 100);
            // 
            // 
            // 
            this.plantChoisePanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.plantChoisePanel.Style.BackColorGradientAngle = 90;
            this.plantChoisePanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.plantChoisePanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.plantChoisePanel.Style.BorderBottomWidth = 1;
            this.plantChoisePanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.plantChoisePanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.plantChoisePanel.Style.BorderLeftWidth = 1;
            this.plantChoisePanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.plantChoisePanel.Style.BorderRightWidth = 1;
            this.plantChoisePanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.plantChoisePanel.Style.BorderTopWidth = 1;
            this.plantChoisePanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.plantChoisePanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.plantChoisePanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.plantChoisePanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.0854F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.9146F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.plantNameTextBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // plantNameTextBox
            // 
            this.plantNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.plantNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.plantNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.plantNameTextBox.Border.Class = "TextBoxBorder";
            this.plantNameTextBox.Location = new System.Drawing.Point(3, 40);
            this.plantNameTextBox.Name = "plantNameTextBox";
            this.plantNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plantNameTextBox.Size = new System.Drawing.Size(103, 20);
            this.plantNameTextBox.TabIndex = 17;
            this.plantNameTextBox.WatermarkText = "הכנס סוג של הצמח";
            // 
            // plantTypeDropBox
            // 
            this.plantTypeDropBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.plantTypeDropBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.plantTypeDropBox.DisplayMember = "Text";
            this.plantTypeDropBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.plantTypeDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plantTypeDropBox.FormattingEnabled = true;
            this.plantTypeDropBox.ItemHeight = 14;
            this.plantTypeDropBox.Location = new System.Drawing.Point(310, 94);
            this.plantTypeDropBox.Name = "plantTypeDropBox";
            this.plantTypeDropBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plantTypeDropBox.Size = new System.Drawing.Size(189, 20);
            this.plantTypeDropBox.TabIndex = 18;
            this.plantTypeDropBox.WatermarkText = "בחר סוג הצמח";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.dataGrid_workers);
            this.groupPanel2.Location = new System.Drawing.Point(52, 229);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(344, 211);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 8;
            this.groupPanel2.Text = "עובדים השיכיים לויזה";
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.dataGrid_allWorkers);
            this.groupPanel3.Controls.Add(this.btn_attachWorkerToVisa);
            this.groupPanel3.Location = new System.Drawing.Point(414, 229);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(452, 211);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel3.TabIndex = 9;
            this.groupPanel3.Text = "כל העובדים";
            // 
            // VisasGeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 577);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Name = "VisasGeneralForm";
            this.Text = "VisasGeneralForm";
            this.Load += new System.EventHandler(this.VisasGeneralForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_workers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_allWorkers)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.graphicSettingsPanel.ResumeLayout(false);
            this.dateChoisePanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tillDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridVisas;
        private DevComponents.DotNetBar.ButtonX btn_addVisa;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGrid_workers;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGrid_allWorkers;
        private DevComponents.DotNetBar.ButtonX btn_attachWorkerToVisa;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel graphicSettingsPanel;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel showGraphButton;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel dateChoisePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput tillDate;
        private DevComponents.DotNetBar.LabelX tillDateLabel;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput fromDate;
        private DevComponents.DotNetBar.LabelX fromDateLabel;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel plantChoisePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX plantNameTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx plantTypeDropBox;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX btn_editVisa;
        private DevComponents.DotNetBar.ButtonX btn_deleteVisa;
    }
}