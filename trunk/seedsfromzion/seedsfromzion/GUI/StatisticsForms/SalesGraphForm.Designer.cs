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
            this.salesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.salesGraphControl = new ZedGraph.ZedGraphControl();
            this.graphicSettingsPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.ribbonClientPanel2 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.tillDateLabel = new DevComponents.DotNetBar.LabelX();
            this.fromDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tillDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.plantChoisePanel = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.plantTypeDropText = new DevComponents.DotNetBar.Controls.TextBoxDropDown();
            this.planrTypeLabel = new DevComponents.DotNetBar.LabelX();
            this.plantNameLabel = new DevComponents.DotNetBar.LabelX();
            this.plantNameTextBox = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.salesTableLayoutPanel.SuspendLayout();
            this.graphicSettingsPanel.SuspendLayout();
            this.ribbonClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tillDate)).BeginInit();
            this.plantChoisePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesTableLayoutPanel
            // 
            this.salesTableLayoutPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.salesTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.salesTableLayoutPanel.ColumnCount = 2;
            this.salesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.05331F));
            this.salesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.94669F));
            this.salesTableLayoutPanel.Controls.Add(this.salesGraphControl, 0, 0);
            this.salesTableLayoutPanel.Controls.Add(this.graphicSettingsPanel, 1, 0);
            this.salesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.salesTableLayoutPanel.Name = "salesTableLayoutPanel";
            this.salesTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.salesTableLayoutPanel.RowCount = 1;
            this.salesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.salesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.salesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.salesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.salesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.salesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.salesTableLayoutPanel.Size = new System.Drawing.Size(1016, 534);
            this.salesTableLayoutPanel.TabIndex = 0;
            // 
            // salesGraphControl
            // 
            this.salesGraphControl.AutoSize = true;
            this.salesGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesGraphControl.Location = new System.Drawing.Point(7, 7);
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
            this.salesGraphControl.Size = new System.Drawing.Size(415, 520);
            this.salesGraphControl.TabIndex = 4;
            // 
            // graphicSettingsPanel
            // 
            this.graphicSettingsPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.graphicSettingsPanel.CanvasColor = System.Drawing.SystemColors.ActiveCaption;
            this.graphicSettingsPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.graphicSettingsPanel.Controls.Add(this.ribbonClientPanel2);
            this.graphicSettingsPanel.Controls.Add(this.ribbonClientPanel1);
            this.graphicSettingsPanel.Controls.Add(this.plantChoisePanel);
            this.graphicSettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicSettingsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.graphicSettingsPanel.IsShadowEnabled = true;
            this.graphicSettingsPanel.Location = new System.Drawing.Point(432, 6);
            this.graphicSettingsPanel.Name = "graphicSettingsPanel";
            this.graphicSettingsPanel.ShowFocusRectangle = true;
            this.graphicSettingsPanel.Size = new System.Drawing.Size(578, 522);
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
            this.graphicSettingsPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.graphicSettingsPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.graphicSettingsPanel.TabIndex = 5;
            this.graphicSettingsPanel.Text = "הגדרות הגרף המכירות";
            // 
            // ribbonClientPanel2
            // 
            this.ribbonClientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbonClientPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ribbonClientPanel2.Location = new System.Drawing.Point(346, 395);
            this.ribbonClientPanel2.Name = "ribbonClientPanel2";
            this.ribbonClientPanel2.Size = new System.Drawing.Size(196, 54);
            // 
            // 
            // 
            this.ribbonClientPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.ribbonClientPanel2.Style.BackColorGradientAngle = 90;
            this.ribbonClientPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.ribbonClientPanel2.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile;
            this.ribbonClientPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonClientPanel2.Style.BorderBottomWidth = 1;
            this.ribbonClientPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.ribbonClientPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonClientPanel2.Style.BorderLeftWidth = 1;
            this.ribbonClientPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonClientPanel2.Style.BorderRightWidth = 1;
            this.ribbonClientPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonClientPanel2.Style.BorderTopWidth = 1;
            this.ribbonClientPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonClientPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            // 
            // 
            // 
            this.ribbonClientPanel2.StyleMouseDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.ribbonClientPanel2.StyleMouseDown.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ribbonClientPanel2.StyleMouseDown.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
            this.ribbonClientPanel2.StyleMouseDown.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonClientPanel2.StyleMouseDown.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
            // 
            // 
            // 
            this.ribbonClientPanel2.StyleMouseOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ribbonClientPanel2.StyleMouseOver.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.ribbonClientPanel2.StyleMouseOver.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
            this.ribbonClientPanel2.StyleMouseOver.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonClientPanel2.StyleMouseOver.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.ribbonClientPanel2.TabIndex = 12;
            this.ribbonClientPanel2.Text = "הצג גרף";
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.tillDateLabel);
            this.ribbonClientPanel1.Controls.Add(this.fromDate);
            this.ribbonClientPanel1.Controls.Add(this.labelX1);
            this.ribbonClientPanel1.Controls.Add(this.tillDate);
            this.ribbonClientPanel1.Location = new System.Drawing.Point(28, 211);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(514, 138);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.ribbonClientPanel1.Style.BackColorGradientAngle = 90;
            this.ribbonClientPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.ribbonClientPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonClientPanel1.Style.BorderBottomWidth = 1;
            this.ribbonClientPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ribbonClientPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonClientPanel1.Style.BorderLeftWidth = 1;
            this.ribbonClientPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonClientPanel1.Style.BorderRightWidth = 1;
            this.ribbonClientPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonClientPanel1.Style.BorderTopWidth = 1;
            this.ribbonClientPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonClientPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.ribbonClientPanel1.TabIndex = 11;
            // 
            // tillDateLabel
            // 
            this.tillDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tillDateLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tillDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tillDateLabel.ForeColor = System.Drawing.Color.Black;
            this.tillDateLabel.Location = new System.Drawing.Point(20, 30);
            this.tillDateLabel.Name = "tillDateLabel";
            this.tillDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tillDateLabel.Size = new System.Drawing.Size(194, 25);
            this.tillDateLabel.TabIndex = 8;
            this.tillDateLabel.Text = "עד תאריך:";
            this.tillDateLabel.TextAlignment = System.Drawing.StringAlignment.Center;
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
            this.fromDate.Location = new System.Drawing.Point(292, 77);
            // 
            // 
            // 
            this.fromDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.fromDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.fromDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.fromDate.MonthCalendar.DisplayMonth = new System.DateTime(2010, 5, 1, 0, 0, 0, 0);
            this.fromDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.fromDate.MonthCalendar.MaxSelectionCount = 1;
            this.fromDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.fromDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.fromDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.fromDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.fromDate.MonthCalendar.TodayButtonVisible = true;
            this.fromDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.fromDate.Name = "fromDate";
            this.fromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromDate.Size = new System.Drawing.Size(194, 28);
            this.fromDate.TabIndex = 6;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(292, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(194, 25);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "מתאריך:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
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
            this.tillDate.Location = new System.Drawing.Point(20, 77);
            // 
            // 
            // 
            this.tillDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.tillDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.tillDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.tillDate.MonthCalendar.DisplayMonth = new System.DateTime(2010, 5, 1, 0, 0, 0, 0);
            this.tillDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.tillDate.MonthCalendar.MaxSelectionCount = 1;
            this.tillDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.tillDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.tillDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.tillDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.tillDate.MonthCalendar.TodayButtonVisible = true;
            this.tillDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.tillDate.Name = "tillDate";
            this.tillDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tillDate.Size = new System.Drawing.Size(194, 28);
            this.tillDate.TabIndex = 7;
            // 
            // plantChoisePanel
            // 
            this.plantChoisePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plantChoisePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.plantChoisePanel.Controls.Add(this.plantTypeDropText);
            this.plantChoisePanel.Controls.Add(this.planrTypeLabel);
            this.plantChoisePanel.Controls.Add(this.plantNameLabel);
            this.plantChoisePanel.Controls.Add(this.plantNameTextBox);
            this.plantChoisePanel.Location = new System.Drawing.Point(28, 32);
            this.plantChoisePanel.Name = "plantChoisePanel";
            this.plantChoisePanel.Size = new System.Drawing.Size(514, 155);
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
            this.plantChoisePanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.plantChoisePanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.plantChoisePanel.TabIndex = 10;
            // 
            // plantTypeDropText
            // 
            this.plantTypeDropText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plantTypeDropText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.plantTypeDropText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            // 
            // 
            // 
            this.plantTypeDropText.BackgroundStyle.Class = "TextBoxBorder";
            this.plantTypeDropText.ButtonDropDown.Visible = true;
            this.plantTypeDropText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.plantTypeDropText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plantTypeDropText.Location = new System.Drawing.Point(14, 94);
            this.plantTypeDropText.Name = "plantTypeDropText";
            this.plantTypeDropText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plantTypeDropText.Size = new System.Drawing.Size(226, 25);
            this.plantTypeDropText.TabIndex = 9;
            this.plantTypeDropText.Text = "";
            this.plantTypeDropText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.plantTypeDropText.WatermarkText = "הכנס סוג של צמח";
            // 
            // planrTypeLabel
            // 
            this.planrTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.planrTypeLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.planrTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.planrTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.planrTypeLabel.Location = new System.Drawing.Point(276, 93);
            this.planrTypeLabel.Name = "planrTypeLabel";
            this.planrTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.planrTypeLabel.Size = new System.Drawing.Size(226, 25);
            this.planrTypeLabel.TabIndex = 8;
            this.planrTypeLabel.Text = "  סוג הצמח:";
            // 
            // plantNameLabel
            // 
            this.plantNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plantNameLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // 
            // 
            this.plantNameLabel.BackgroundStyle.BorderBottomWidth = 1;
            this.plantNameLabel.BackgroundStyle.BorderLeftWidth = 1;
            this.plantNameLabel.BackgroundStyle.BorderRightWidth = 1;
            this.plantNameLabel.BackgroundStyle.BorderTopWidth = 1;
            this.plantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plantNameLabel.ForeColor = System.Drawing.Color.Black;
            this.plantNameLabel.Location = new System.Drawing.Point(273, 34);
            this.plantNameLabel.Name = "plantNameLabel";
            this.plantNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plantNameLabel.Size = new System.Drawing.Size(226, 25);
            this.plantNameLabel.TabIndex = 7;
            this.plantNameLabel.Text = "  שם הצמח:";
            // 
            // plantNameTextBox
            // 
            this.plantNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.plantNameTextBox.BackgroundStyle.Class = "TextBoxBorder";
            this.plantNameTextBox.ButtonClear.Visible = true;
            this.plantNameTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.plantNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plantNameTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.plantNameTextBox.Location = new System.Drawing.Point(14, 34);
            this.plantNameTextBox.Name = "plantNameTextBox";
            this.plantNameTextBox.PromptChar = '|';
            this.plantNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plantNameTextBox.Size = new System.Drawing.Size(226, 25);
            this.plantNameTextBox.TabIndex = 6;
            this.plantNameTextBox.Text = "";
            this.plantNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.plantNameTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.plantNameTextBox.WatermarkText = "     הכנס שם של צמח";
            // 
            // SalesGraphFrom
            // 
            this.ClientSize = new System.Drawing.Size(1016, 534);
            this.Controls.Add(this.salesTableLayoutPanel);
            this.DoubleBuffered = true;
            this.Name = "SalesGraphFrom";
            this.Text = "SalesGraphFrom";
            this.Load += new System.EventHandler(this.SalesGraphFrom_Load);
            this.salesTableLayoutPanel.ResumeLayout(false);
            this.salesTableLayoutPanel.PerformLayout();
            this.graphicSettingsPanel.ResumeLayout(false);
            this.ribbonClientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tillDate)).EndInit();
            this.plantChoisePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel salesTableLayoutPanel;
        private ZedGraph.ZedGraphControl salesGraphControl;
        private DevComponents.DotNetBar.Controls.GroupPanel graphicSettingsPanel;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput fromDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput tillDate;
        private DevComponents.DotNetBar.LabelX tillDateLabel;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel plantChoisePanel;
        private DevComponents.DotNetBar.Controls.TextBoxDropDown plantTypeDropText;
        private DevComponents.DotNetBar.LabelX planrTypeLabel;
        private DevComponents.DotNetBar.LabelX plantNameLabel;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv plantNameTextBox;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel2;

    }
}
