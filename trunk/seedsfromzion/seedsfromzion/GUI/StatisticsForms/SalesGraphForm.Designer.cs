namespace seedsfromzion.GUI.StatisticsForms
{
    partial class SalesGraphFrom
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
            this.components = new System.ComponentModel.Container();
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
            this.isChosenTypeCHBX = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.plantNameLabel = new DevComponents.DotNetBar.LabelX();
            this.planrTypeLabel = new DevComponents.DotNetBar.LabelX();
            this.sowTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.salesGraphControl = new ZedGraph.ZedGraphControl();
            this.graphicSettingsPanel.SuspendLayout();
            this.dateChoisePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tillDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate)).BeginInit();
            this.plantChoisePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.sowTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.graphicSettingsPanel.Controls.Add(this.plantChoisePanel);
            this.graphicSettingsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.graphicSettingsPanel.IsShadowEnabled = true;
            this.graphicSettingsPanel.Location = new System.Drawing.Point(518, 5);
            this.graphicSettingsPanel.Name = "graphicSettingsPanel";
            this.graphicSettingsPanel.ShowFocusRectangle = true;
            this.graphicSettingsPanel.Size = new System.Drawing.Size(505, 566);
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
            this.graphicSettingsPanel.TabIndex = 6;
            this.graphicSettingsPanel.Text = "הגדרות הגרף המכירות";
            // 
            // showGraphButton
            // 
            this.showGraphButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showGraphButton.CanvasColor = System.Drawing.SystemColors.Control;
            this.showGraphButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showGraphButton.Location = new System.Drawing.Point(297, 379);
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
            this.showGraphButton.Click += new System.EventHandler(this.showGraphButton_Click);
            // 
            // dateChoisePanel
            // 
            this.dateChoisePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateChoisePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.dateChoisePanel.Controls.Add(this.tableLayoutPanel2);
            this.dateChoisePanel.Location = new System.Drawing.Point(41, 206);
            this.dateChoisePanel.Name = "dateChoisePanel";
            this.dateChoisePanel.Size = new System.Drawing.Size(408, 142);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(408, 142);
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
            this.tillDate.Location = new System.Drawing.Point(47, 93);
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
            this.tillDate.Size = new System.Drawing.Size(192, 26);
            this.tillDate.TabIndex = 13;
            this.tillDate.WatermarkEnabled = false;
            // 
            // tillDateLabel
            // 
            this.tillDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tillDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.tillDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tillDateLabel.ForeColor = System.Drawing.Color.Black;
            this.tillDateLabel.Location = new System.Drawing.Point(261, 94);
            this.tillDateLabel.Name = "tillDateLabel";
            this.tillDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tillDateLabel.Size = new System.Drawing.Size(144, 25);
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
            this.fromDate.Location = new System.Drawing.Point(47, 22);
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
            this.fromDate.Size = new System.Drawing.Size(192, 26);
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
            this.fromDateLabel.Location = new System.Drawing.Point(261, 23);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromDateLabel.Size = new System.Drawing.Size(144, 25);
            this.fromDateLabel.TabIndex = 9;
            this.fromDateLabel.Text = "מתאריך:";
            this.fromDateLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // plantChoisePanel
            // 
            this.plantChoisePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.plantChoisePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.plantChoisePanel.Controls.Add(this.tableLayoutPanel1);
            this.plantChoisePanel.Location = new System.Drawing.Point(41, 29);
            this.plantChoisePanel.Name = "plantChoisePanel";
            this.plantChoisePanel.Size = new System.Drawing.Size(408, 142);
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
            this.plantChoisePanel.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.0854F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.9146F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.plantNameTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.plantTypeDropBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.isChosenTypeCHBX, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.plantNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.planrTypeLabel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 142);
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
            this.plantNameTextBox.Location = new System.Drawing.Point(48, 22);
            this.plantNameTextBox.Name = "plantNameTextBox";
            this.plantNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plantNameTextBox.Size = new System.Drawing.Size(189, 26);
            this.plantNameTextBox.TabIndex = 17;
            this.plantNameTextBox.WatermarkText = "הכנס סוג של הצמח";
            this.plantNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.plantNameTextBox_KeyPress);
            this.plantNameTextBox.TextChanged += new System.EventHandler(this.plantNameTextBox_TextChanged);
            // 
            // plantTypeDropBox
            // 
            this.plantTypeDropBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.plantTypeDropBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.plantTypeDropBox.DisplayMember = "Text";
            this.plantTypeDropBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.plantTypeDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plantTypeDropBox.FormattingEnabled = true;
            this.plantTypeDropBox.ItemHeight = 20;
            this.plantTypeDropBox.Location = new System.Drawing.Point(48, 92);
            this.plantTypeDropBox.Name = "plantTypeDropBox";
            this.plantTypeDropBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plantTypeDropBox.Size = new System.Drawing.Size(189, 26);
            this.plantTypeDropBox.TabIndex = 18;
            this.plantTypeDropBox.WatermarkText = "בחר סוג הצמח";
            this.plantTypeDropBox.DropDown += new System.EventHandler(this.plantTypeDropBox_TextChanged);
            // 
            // isChosenTypeCHBX
            // 
            this.isChosenTypeCHBX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.isChosenTypeCHBX.BackColor = System.Drawing.Color.Transparent;
            this.isChosenTypeCHBX.Checked = true;
            this.isChosenTypeCHBX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isChosenTypeCHBX.CheckValue = "Y";
            this.isChosenTypeCHBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.isChosenTypeCHBX.Location = new System.Drawing.Point(383, 74);
            this.isChosenTypeCHBX.Name = "isChosenTypeCHBX";
            this.isChosenTypeCHBX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.isChosenTypeCHBX.Size = new System.Drawing.Size(22, 65);
            this.isChosenTypeCHBX.TabIndex = 12;
            this.isChosenTypeCHBX.Text = " ";
            this.isChosenTypeCHBX.CheckedChanged += new System.EventHandler(this.isChosenTypeCHBX_CheckedChanged);
            // 
            // plantNameLabel
            // 
            this.plantNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.plantNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.plantNameLabel.BackgroundStyle.BorderBottomWidth = 1;
            this.plantNameLabel.BackgroundStyle.BorderLeftWidth = 1;
            this.plantNameLabel.BackgroundStyle.BorderRightWidth = 1;
            this.plantNameLabel.BackgroundStyle.BorderTopWidth = 1;
            this.plantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plantNameLabel.ForeColor = System.Drawing.Color.Black;
            this.plantNameLabel.Location = new System.Drawing.Point(258, 23);
            this.plantNameLabel.Name = "plantNameLabel";
            this.plantNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plantNameLabel.Size = new System.Drawing.Size(119, 25);
            this.plantNameLabel.TabIndex = 7;
            this.plantNameLabel.Text = "  שם הצמח:";
            this.plantNameLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // planrTypeLabel
            // 
            this.planrTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.planrTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.planrTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.planrTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.planrTypeLabel.Location = new System.Drawing.Point(258, 93);
            this.planrTypeLabel.Name = "planrTypeLabel";
            this.planrTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.planrTypeLabel.Size = new System.Drawing.Size(119, 26);
            this.planrTypeLabel.TabIndex = 8;
            this.planrTypeLabel.Text = "  סוג הצמח:";
            this.planrTypeLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // sowTableLayoutPanel
            // 
            this.sowTableLayoutPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sowTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.sowTableLayoutPanel.ColumnCount = 2;
            this.sowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sowTableLayoutPanel.Controls.Add(this.graphicSettingsPanel, 0, 0);
            this.sowTableLayoutPanel.Controls.Add(this.salesGraphControl, 0, 0);
            this.sowTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sowTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.sowTableLayoutPanel.Name = "sowTableLayoutPanel";
            this.sowTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sowTableLayoutPanel.RowCount = 1;
            this.sowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sowTableLayoutPanel.Size = new System.Drawing.Size(1028, 576);
            this.sowTableLayoutPanel.TabIndex = 2;
            // 
            // salesGraphControl
            // 
            this.salesGraphControl.AutoSize = true;
            this.salesGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesGraphControl.Location = new System.Drawing.Point(6, 6);
            this.salesGraphControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salesGraphControl.Name = "salesGraphControl";
            this.salesGraphControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.salesGraphControl.ScrollGrace = 0;
            this.salesGraphControl.ScrollMaxX = 0;
            this.salesGraphControl.ScrollMaxY = 0;
            this.salesGraphControl.ScrollMaxY2 = 0;
            this.salesGraphControl.ScrollMinX = 0;
            this.salesGraphControl.ScrollMinY = 0;
            this.salesGraphControl.ScrollMinY2 = 0;
            this.salesGraphControl.Size = new System.Drawing.Size(503, 564);
            this.salesGraphControl.TabIndex = 4;
            // 
            // SalesGraphFrom
            // 
            this.ClientSize = new System.Drawing.Size(1028, 576);
            this.Controls.Add(this.sowTableLayoutPanel);
            this.DoubleBuffered = true;
            this.Name = "SalesGraphFrom";
            this.Text = "SalesGraphFrom";
            this.Load += new System.EventHandler(this.SalesGraphFrom_Load);
            this.graphicSettingsPanel.ResumeLayout(false);
            this.dateChoisePanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tillDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate)).EndInit();
            this.plantChoisePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.sowTableLayoutPanel.ResumeLayout(false);
            this.sowTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel graphicSettingsPanel;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel showGraphButton;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel dateChoisePanel;
        private DevComponents.DotNetBar.LabelX tillDateLabel;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput fromDate;
        private DevComponents.DotNetBar.LabelX fromDateLabel;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel plantChoisePanel;
        private System.Windows.Forms.TableLayoutPanel sowTableLayoutPanel;
        private ZedGraph.ZedGraphControl salesGraphControl;
        private DevComponents.DotNetBar.LabelX planrTypeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.LabelX plantNameLabel;
        private DevComponents.DotNetBar.Controls.CheckBoxX isChosenTypeCHBX;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx plantTypeDropBox;
        private DevComponents.DotNetBar.Controls.TextBoxX plantNameTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput tillDate;


    }
}
