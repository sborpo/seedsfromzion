namespace seedsfromzion.GUI.StatisticsForms
{
    partial class GrowViaSowingDateForm
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
            this.sowTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.graphicSettingsPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.showGraphButton = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.dateChoisePanel = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.tillDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tillDateLabel = new DevComponents.DotNetBar.LabelX();
            this.fromDateLabel = new DevComponents.DotNetBar.LabelX();
            this.fromDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.plantChoisePanel = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.autoCompleteList = new System.Windows.Forms.ListBox();
            this.plantTypeDropBox = new System.Windows.Forms.ComboBox();
            this.plantNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.planrTypeLabel = new DevComponents.DotNetBar.LabelX();
            this.plantNameLabel = new DevComponents.DotNetBar.LabelX();
            this.isChosenTypeCHBX = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.GrowViaSowGraphControl = new ZedGraph.ZedGraphControl();
            this.sowTableLayoutPanel.SuspendLayout();
            this.graphicSettingsPanel.SuspendLayout();
            this.dateChoisePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tillDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate)).BeginInit();
            this.plantChoisePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sowTableLayoutPanel
            // 
            this.sowTableLayoutPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sowTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.sowTableLayoutPanel.ColumnCount = 2;
            this.sowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sowTableLayoutPanel.Controls.Add(this.graphicSettingsPanel, 0, 0);
            this.sowTableLayoutPanel.Controls.Add(this.GrowViaSowGraphControl, 0, 0);
            this.sowTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sowTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.sowTableLayoutPanel.Name = "sowTableLayoutPanel";
            this.sowTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sowTableLayoutPanel.RowCount = 1;
            this.sowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sowTableLayoutPanel.Size = new System.Drawing.Size(942, 504);
            this.sowTableLayoutPanel.TabIndex = 1;
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
            this.graphicSettingsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.graphicSettingsPanel.IsShadowEnabled = true;
            this.graphicSettingsPanel.Location = new System.Drawing.Point(475, 5);
            this.graphicSettingsPanel.Name = "graphicSettingsPanel";
            this.graphicSettingsPanel.ShowFocusRectangle = true;
            this.graphicSettingsPanel.Size = new System.Drawing.Size(462, 494);
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
            this.graphicSettingsPanel.Text = "הגדרות גרף אחוזי הנביטה לפי תאריך הזריע";
            // 
            // showGraphButton
            // 
            this.showGraphButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showGraphButton.CanvasColor = System.Drawing.SystemColors.Control;
            this.showGraphButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showGraphButton.Location = new System.Drawing.Point(277, 388);
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
            this.showGraphButton.TabIndex = 15;
            this.showGraphButton.Text = "הצג גרף";
            this.showGraphButton.Click += new System.EventHandler(this.showGraphButton_Click);
            // 
            // dateChoisePanel
            // 
            this.dateChoisePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateChoisePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.dateChoisePanel.Controls.Add(this.tillDate);
            this.dateChoisePanel.Controls.Add(this.tillDateLabel);
            this.dateChoisePanel.Controls.Add(this.fromDateLabel);
            this.dateChoisePanel.Controls.Add(this.fromDate);
            this.dateChoisePanel.Location = new System.Drawing.Point(48, 208);
            this.dateChoisePanel.Name = "dateChoisePanel";
            this.dateChoisePanel.Size = new System.Drawing.Size(378, 142);
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
            this.dateChoisePanel.TabIndex = 14;
            // 
            // tillDate
            // 
            this.tillDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tillDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.tillDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.tillDate.ButtonDropDown.Visible = true;
            this.tillDate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Right;
            this.tillDate.Location = new System.Drawing.Point(35, 95);
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
            this.tillDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tillDate.ShowCheckBox = true;
            this.tillDate.Size = new System.Drawing.Size(192, 23);
            this.tillDate.TabIndex = 17;
            this.tillDate.WatermarkEnabled = false;
            // 
            // tillDateLabel
            // 
            this.tillDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tillDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.tillDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tillDateLabel.ForeColor = System.Drawing.Color.Black;
            this.tillDateLabel.Location = new System.Drawing.Point(241, 96);
            this.tillDateLabel.Name = "tillDateLabel";
            this.tillDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tillDateLabel.Size = new System.Drawing.Size(132, 25);
            this.tillDateLabel.TabIndex = 8;
            this.tillDateLabel.Text = "עד תאריך:";
            this.tillDateLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.fromDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.fromDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fromDateLabel.ForeColor = System.Drawing.Color.Black;
            this.fromDateLabel.Location = new System.Drawing.Point(241, 25);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromDateLabel.Size = new System.Drawing.Size(132, 25);
            this.fromDateLabel.TabIndex = 9;
            this.fromDateLabel.Text = "מתאריך:";
            this.fromDateLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // fromDate
            // 
            this.fromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.fromDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.fromDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.fromDate.ButtonDropDown.Visible = true;
            this.fromDate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Right;
            this.fromDate.Location = new System.Drawing.Point(35, 24);
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
            this.fromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fromDate.ShowCheckBox = true;
            this.fromDate.Size = new System.Drawing.Size(192, 23);
            this.fromDate.TabIndex = 16;
            this.fromDate.WatermarkEnabled = false;
            // 
            // plantChoisePanel
            // 
            this.plantChoisePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.plantChoisePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.plantChoisePanel.Controls.Add(this.autoCompleteList);
            this.plantChoisePanel.Controls.Add(this.plantTypeDropBox);
            this.plantChoisePanel.Controls.Add(this.plantNameTextBox);
            this.plantChoisePanel.Controls.Add(this.planrTypeLabel);
            this.plantChoisePanel.Controls.Add(this.plantNameLabel);
            this.plantChoisePanel.Controls.Add(this.isChosenTypeCHBX);
            this.plantChoisePanel.Location = new System.Drawing.Point(48, 29);
            this.plantChoisePanel.Name = "plantChoisePanel";
            this.plantChoisePanel.Size = new System.Drawing.Size(378, 142);
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
            this.plantChoisePanel.TabIndex = 13;
            // 
            // autoCompleteList
            // 
            this.autoCompleteList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoCompleteList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoCompleteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.autoCompleteList.FormattingEnabled = true;
            this.autoCompleteList.ItemHeight = 16;
            this.autoCompleteList.Location = new System.Drawing.Point(39, 41);
            this.autoCompleteList.Name = "autoCompleteList";
            this.autoCompleteList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.autoCompleteList.Size = new System.Drawing.Size(190, 82);
            this.autoCompleteList.TabIndex = 14;
            this.autoCompleteList.Visible = false;
            this.autoCompleteList.SelectedIndexChanged += new System.EventHandler(this.autoCompleteList_SelectedIndexChanged);
            // 
            // plantTypeDropBox
            // 
            this.plantTypeDropBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plantTypeDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plantTypeDropBox.FormattingEnabled = true;
            this.plantTypeDropBox.Location = new System.Drawing.Point(39, 92);
            this.plantTypeDropBox.Name = "plantTypeDropBox";
            this.plantTypeDropBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plantTypeDropBox.Size = new System.Drawing.Size(190, 24);
            this.plantTypeDropBox.TabIndex = 16;
            this.plantTypeDropBox.DropDown += new System.EventHandler(this.plantTypeDropBox_TextChanged);
            // 
            // plantNameTextBox
            // 
            this.plantNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plantNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.plantNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.plantNameTextBox.Border.Class = "TextBoxBorder";
            this.plantNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.plantNameTextBox.Location = new System.Drawing.Point(39, 19);
            this.plantNameTextBox.Name = "plantNameTextBox";
            this.plantNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plantNameTextBox.Size = new System.Drawing.Size(190, 23);
            this.plantNameTextBox.TabIndex = 19;
            this.plantNameTextBox.WatermarkText = "הכנס שם של הצמח";
            this.plantNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.plantNameTextBox_KeyPress);
            this.plantNameTextBox.TextChanged += new System.EventHandler(this.plantNameTextBox_TextChanged);
            // 
            // planrTypeLabel
            // 
            this.planrTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.planrTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.planrTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.planrTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.planrTypeLabel.Location = new System.Drawing.Point(241, 90);
            this.planrTypeLabel.Name = "planrTypeLabel";
            this.planrTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.planrTypeLabel.Size = new System.Drawing.Size(109, 26);
            this.planrTypeLabel.TabIndex = 8;
            this.planrTypeLabel.Text = "  סוג הצמח:";
            this.planrTypeLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // plantNameLabel
            // 
            this.plantNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plantNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.plantNameLabel.BackgroundStyle.BorderBottomWidth = 1;
            this.plantNameLabel.BackgroundStyle.BorderLeftWidth = 1;
            this.plantNameLabel.BackgroundStyle.BorderRightWidth = 1;
            this.plantNameLabel.BackgroundStyle.BorderTopWidth = 1;
            this.plantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.plantNameLabel.ForeColor = System.Drawing.Color.Black;
            this.plantNameLabel.Location = new System.Drawing.Point(241, 20);
            this.plantNameLabel.Name = "plantNameLabel";
            this.plantNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plantNameLabel.Size = new System.Drawing.Size(109, 25);
            this.plantNameLabel.TabIndex = 7;
            this.plantNameLabel.Text = "  שם הצמח:";
            this.plantNameLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // isChosenTypeCHBX
            // 
            this.isChosenTypeCHBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isChosenTypeCHBX.BackColor = System.Drawing.Color.Transparent;
            this.isChosenTypeCHBX.Checked = true;
            this.isChosenTypeCHBX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isChosenTypeCHBX.CheckValue = "Y";
            this.isChosenTypeCHBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.isChosenTypeCHBX.Location = new System.Drawing.Point(344, 71);
            this.isChosenTypeCHBX.Name = "isChosenTypeCHBX";
            this.isChosenTypeCHBX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.isChosenTypeCHBX.Size = new System.Drawing.Size(22, 65);
            this.isChosenTypeCHBX.TabIndex = 12;
            this.isChosenTypeCHBX.Text = " ";
            this.isChosenTypeCHBX.CheckedChanged += new System.EventHandler(this.isChosenTypeCHBX_CheckedChanged);
            // 
            // GrowViaSowGraphControl
            // 
            this.GrowViaSowGraphControl.AutoSize = true;
            this.GrowViaSowGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrowViaSowGraphControl.Location = new System.Drawing.Point(6, 6);
            this.GrowViaSowGraphControl.Margin = new System.Windows.Forms.Padding(4);
            this.GrowViaSowGraphControl.Name = "GrowViaSowGraphControl";
            this.GrowViaSowGraphControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrowViaSowGraphControl.ScrollGrace = 0;
            this.GrowViaSowGraphControl.ScrollMaxX = 0;
            this.GrowViaSowGraphControl.ScrollMaxY = 0;
            this.GrowViaSowGraphControl.ScrollMaxY2 = 0;
            this.GrowViaSowGraphControl.ScrollMinX = 0;
            this.GrowViaSowGraphControl.ScrollMinY = 0;
            this.GrowViaSowGraphControl.ScrollMinY2 = 0;
            this.GrowViaSowGraphControl.Size = new System.Drawing.Size(460, 492);
            this.GrowViaSowGraphControl.TabIndex = 4;
            // 
            // GrowViaSowingDateForm
            // 
            this.ClientSize = new System.Drawing.Size(942, 504);
            this.Controls.Add(this.sowTableLayoutPanel);
            this.Name = "GrowViaSowingDateForm";
            this.Text = "גרף אחוזי הנביטה לפי תאריך הזריע";
            this.Load += new System.EventHandler(this.GrowViaSowingDateGraph_Load);
            this.sowTableLayoutPanel.ResumeLayout(false);
            this.sowTableLayoutPanel.PerformLayout();
            this.graphicSettingsPanel.ResumeLayout(false);
            this.dateChoisePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tillDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate)).EndInit();
            this.plantChoisePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel sowTableLayoutPanel;
        private ZedGraph.ZedGraphControl GrowViaSowGraphControl;
        private DevComponents.DotNetBar.Controls.GroupPanel graphicSettingsPanel;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel showGraphButton;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel dateChoisePanel;
        private DevComponents.DotNetBar.LabelX tillDateLabel;
        private DevComponents.DotNetBar.LabelX fromDateLabel;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel plantChoisePanel;
        private DevComponents.DotNetBar.Controls.CheckBoxX isChosenTypeCHBX;
        private DevComponents.DotNetBar.LabelX plantNameLabel;
        private DevComponents.DotNetBar.LabelX planrTypeLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX plantNameTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput tillDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput fromDate;
        private System.Windows.Forms.ListBox autoCompleteList;
        private System.Windows.Forms.ComboBox plantTypeDropBox;
    }
}
