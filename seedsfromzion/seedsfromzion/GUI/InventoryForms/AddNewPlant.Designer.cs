﻿namespace seedsfromzion.GUI.InventoryForms
{
    partial class AddNewPlant
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.foreignName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.integerInput1 = new DevComponents.Editors.IntegerInput();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.comments = new System.Windows.Forms.TextBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.price = new DevComponents.Editors.DoubleInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.lifeTime = new DevComponents.Editors.DoubleInput();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.addPlantPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.plantUnitType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.addPlantTypePanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.autoCompleteList = new System.Windows.Forms.ListBox();
            this.typeType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.typeLife = new DevComponents.Editors.DoubleInput();
            this.typePrice = new DevComponents.Editors.DoubleInput();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.quality = new DevComponents.DotNetBar.LabelX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.typePlantName = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.addPlantPanel.SuspendLayout();
            this.addPlantTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX1.Location = new System.Drawing.Point(437, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(115, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "שם  הצמח:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX2.Location = new System.Drawing.Point(437, 46);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(115, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "שם  בלועזית:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX3.Location = new System.Drawing.Point(412, 112);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(140, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "איכות הצמח:";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX4.Location = new System.Drawing.Point(362, 81);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(190, 25);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "מספר יחידות ליחידת משקל:";
            // 
            // foreignName
            // 
            // 
            // 
            // 
            this.foreignName.Border.Class = "TextBoxBorder";
            this.foreignName.Location = new System.Drawing.Point(217, 48);
            this.foreignName.Name = "foreignName";
            this.foreignName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.foreignName.Size = new System.Drawing.Size(139, 26);
            this.foreignName.TabIndex = 5;
            // 
            // name
            // 
            // 
            // 
            // 
            this.name.Border.Class = "TextBoxBorder";
            this.name.Location = new System.Drawing.Point(217, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(139, 26);
            this.name.TabIndex = 6;
            // 
            // integerInput1
            // 
            // 
            // 
            // 
            this.integerInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput1.Location = new System.Drawing.Point(256, 82);
            this.integerInput1.MinValue = 0;
            this.integerInput1.Name = "integerInput1";
            this.integerInput1.Size = new System.Drawing.Size(100, 26);
            this.integerInput1.TabIndex = 7;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 20;
            this.comboBoxEx1.Location = new System.Drawing.Point(256, 111);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(100, 26);
            this.comboBoxEx1.TabIndex = 8;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.LightCyan;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonX1.Image = global::seedsfromzion.Properties.Resources.addOrderIcon;
            this.buttonX1.Location = new System.Drawing.Point(256, 313);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(100, 50);
            this.buttonX1.TabIndex = 9;
            this.buttonX1.Text = "הוסף צמח";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX5.Location = new System.Drawing.Point(344, 234);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(208, 23);
            this.labelX5.TabIndex = 10;
            this.labelX5.Text = "הערות:";
            // 
            // comments
            // 
            this.comments.Location = new System.Drawing.Point(24, 235);
            this.comments.MaximumSize = new System.Drawing.Size(420, 80);
            this.comments.Multiline = true;
            this.comments.Name = "comments";
            this.comments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.comments.Size = new System.Drawing.Size(332, 72);
            this.comments.TabIndex = 11;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX6.Location = new System.Drawing.Point(344, 141);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(208, 23);
            this.labelX6.TabIndex = 12;
            this.labelX6.Text = "מחיר ליחידת משקל:";
            // 
            // price
            // 
            // 
            // 
            // 
            this.price.BackgroundStyle.Class = "DateTimeInputBackground";
            this.price.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.price.Increment = 1;
            this.price.Location = new System.Drawing.Point(255, 138);
            this.price.MinValue = 0;
            this.price.Name = "price";
            this.price.ShowUpDown = true;
            this.price.Size = new System.Drawing.Size(101, 26);
            this.price.TabIndex = 13;
            this.price.ValueChanged += new System.EventHandler(this.price_ValueChanged);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX7.Location = new System.Drawing.Point(402, 170);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(150, 23);
            this.labelX7.TabIndex = 14;
            this.labelX7.Text = "אורך חיים בחודשים:";
            // 
            // lifeTime
            // 
            // 
            // 
            // 
            this.lifeTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.lifeTime.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.lifeTime.Increment = 1;
            this.lifeTime.Location = new System.Drawing.Point(255, 168);
            this.lifeTime.MinValue = 0;
            this.lifeTime.Name = "lifeTime";
            this.lifeTime.ShowUpDown = true;
            this.lifeTime.Size = new System.Drawing.Size(101, 26);
            this.lifeTime.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::seedsfromzion.Properties.Resources.image_missing;
            this.pictureBox1.Location = new System.Drawing.Point(43, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonX2.Location = new System.Drawing.Point(87, 182);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(87, 31);
            this.buttonX2.TabIndex = 17;
            this.buttonX2.Text = "בחר תמונה";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // addPlantPanel
            // 
            this.addPlantPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.addPlantPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.addPlantPanel.Controls.Add(this.plantUnitType);
            this.addPlantPanel.Controls.Add(this.labelX11);
            this.addPlantPanel.Controls.Add(this.buttonX2);
            this.addPlantPanel.Controls.Add(this.comments);
            this.addPlantPanel.Controls.Add(this.labelX1);
            this.addPlantPanel.Controls.Add(this.price);
            this.addPlantPanel.Controls.Add(this.pictureBox1);
            this.addPlantPanel.Controls.Add(this.labelX6);
            this.addPlantPanel.Controls.Add(this.labelX5);
            this.addPlantPanel.Controls.Add(this.labelX7);
            this.addPlantPanel.Controls.Add(this.labelX2);
            this.addPlantPanel.Controls.Add(this.labelX3);
            this.addPlantPanel.Controls.Add(this.comboBoxEx1);
            this.addPlantPanel.Controls.Add(this.buttonX1);
            this.addPlantPanel.Controls.Add(this.lifeTime);
            this.addPlantPanel.Controls.Add(this.labelX4);
            this.addPlantPanel.Controls.Add(this.foreignName);
            this.addPlantPanel.Controls.Add(this.name);
            this.addPlantPanel.Controls.Add(this.integerInput1);
            this.addPlantPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addPlantPanel.Location = new System.Drawing.Point(14, 12);
            this.addPlantPanel.Name = "addPlantPanel";
            this.addPlantPanel.Size = new System.Drawing.Size(591, 400);
            // 
            // 
            // 
            this.addPlantPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.addPlantPanel.Style.BackColorGradientAngle = 90;
            this.addPlantPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.addPlantPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.addPlantPanel.Style.BorderBottomWidth = 1;
            this.addPlantPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.addPlantPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.addPlantPanel.Style.BorderLeftWidth = 1;
            this.addPlantPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.addPlantPanel.Style.BorderRightWidth = 1;
            this.addPlantPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.addPlantPanel.Style.BorderTopWidth = 1;
            this.addPlantPanel.Style.CornerDiameter = 4;
            this.addPlantPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.addPlantPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.addPlantPanel.Style.TextColor = System.Drawing.Color.Navy;
            this.addPlantPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.addPlantPanel.TabIndex = 18;
            this.addPlantPanel.Text = "הוספת צמח";
            // 
            // plantUnitType
            // 
            // 
            // 
            // 
            this.plantUnitType.Border.Class = "TextBoxBorder";
            this.plantUnitType.Location = new System.Drawing.Point(217, 198);
            this.plantUnitType.Name = "plantUnitType";
            this.plantUnitType.Size = new System.Drawing.Size(139, 26);
            this.plantUnitType.TabIndex = 19;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX11.Location = new System.Drawing.Point(344, 197);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(208, 23);
            this.labelX11.TabIndex = 18;
            this.labelX11.Text = "סוג היחידות:";
            // 
            // addPlantTypePanel
            // 
            this.addPlantTypePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.addPlantTypePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.addPlantTypePanel.Controls.Add(this.autoCompleteList);
            this.addPlantTypePanel.Controls.Add(this.typeType);
            this.addPlantTypePanel.Controls.Add(this.typeLife);
            this.addPlantTypePanel.Controls.Add(this.typePrice);
            this.addPlantTypePanel.Controls.Add(this.labelX10);
            this.addPlantTypePanel.Controls.Add(this.labelX9);
            this.addPlantTypePanel.Controls.Add(this.quality);
            this.addPlantTypePanel.Controls.Add(this.buttonX3);
            this.addPlantTypePanel.Controls.Add(this.labelX8);
            this.addPlantTypePanel.Controls.Add(this.typePlantName);
            this.addPlantTypePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addPlantTypePanel.Location = new System.Drawing.Point(611, 12);
            this.addPlantTypePanel.Name = "addPlantTypePanel";
            this.addPlantTypePanel.Size = new System.Drawing.Size(371, 218);
            // 
            // 
            // 
            this.addPlantTypePanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.addPlantTypePanel.Style.BackColorGradientAngle = 90;
            this.addPlantTypePanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.addPlantTypePanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.addPlantTypePanel.Style.BorderBottomWidth = 1;
            this.addPlantTypePanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.addPlantTypePanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.addPlantTypePanel.Style.BorderLeftWidth = 1;
            this.addPlantTypePanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.addPlantTypePanel.Style.BorderRightWidth = 1;
            this.addPlantTypePanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.addPlantTypePanel.Style.BorderTopWidth = 1;
            this.addPlantTypePanel.Style.CornerDiameter = 4;
            this.addPlantTypePanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.addPlantTypePanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.addPlantTypePanel.Style.TextColor = System.Drawing.Color.Navy;
            this.addPlantTypePanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.addPlantTypePanel.TabIndex = 19;
            this.addPlantTypePanel.Text = "הוספת סוג צמח";
            // 
            // autoCompleteList
            // 
            this.autoCompleteList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoCompleteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.autoCompleteList.FormattingEnabled = true;
            this.autoCompleteList.ItemHeight = 20;
            this.autoCompleteList.Location = new System.Drawing.Point(28, 32);
            this.autoCompleteList.Name = "autoCompleteList";
            this.autoCompleteList.Size = new System.Drawing.Size(142, 82);
            this.autoCompleteList.TabIndex = 20;
            this.autoCompleteList.Visible = false;
            this.autoCompleteList.SelectedIndexChanged += new System.EventHandler(this.autoCompleteList_SelectedIndexChanged);
            // 
            // typeType
            // 
            this.typeType.DisplayMember = "Text";
            this.typeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeType.FormattingEnabled = true;
            this.typeType.ItemHeight = 20;
            this.typeType.Location = new System.Drawing.Point(28, 37);
            this.typeType.Name = "typeType";
            this.typeType.Size = new System.Drawing.Size(142, 26);
            this.typeType.TabIndex = 25;
            // 
            // typeLife
            // 
            // 
            // 
            // 
            this.typeLife.BackgroundStyle.Class = "DateTimeInputBackground";
            this.typeLife.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.typeLife.Increment = 1;
            this.typeLife.Location = new System.Drawing.Point(28, 98);
            this.typeLife.Name = "typeLife";
            this.typeLife.ShowUpDown = true;
            this.typeLife.Size = new System.Drawing.Size(142, 26);
            this.typeLife.TabIndex = 24;
            // 
            // typePrice
            // 
            // 
            // 
            // 
            this.typePrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.typePrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.typePrice.Increment = 1;
            this.typePrice.Location = new System.Drawing.Point(28, 69);
            this.typePrice.MinValue = 0;
            this.typePrice.Name = "typePrice";
            this.typePrice.ShowUpDown = true;
            this.typePrice.Size = new System.Drawing.Size(142, 26);
            this.typePrice.TabIndex = 23;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX10.Location = new System.Drawing.Point(182, 98);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(152, 23);
            this.labelX10.TabIndex = 21;
            this.labelX10.Text = "אורך חיים בחודשים";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX9.Location = new System.Drawing.Point(182, 69);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(152, 23);
            this.labelX9.TabIndex = 20;
            this.labelX9.Text = "מחיר ליחידת משקל:";
            // 
            // quality
            // 
            this.quality.BackColor = System.Drawing.Color.Transparent;
            this.quality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.quality.Location = new System.Drawing.Point(182, 40);
            this.quality.Name = "quality";
            this.quality.Size = new System.Drawing.Size(152, 23);
            this.quality.TabIndex = 19;
            this.quality.Text = "איכות הצמח:";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonX3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonX3.Image = global::seedsfromzion.Properties.Resources.addOrderIcon;
            this.buttonX3.Location = new System.Drawing.Point(122, 137);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(102, 50);
            this.buttonX3.TabIndex = 18;
            this.buttonX3.Text = "הוסף סוג צמח";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX8.Location = new System.Drawing.Point(182, 11);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(152, 23);
            this.labelX8.TabIndex = 17;
            this.labelX8.Text = "שם הצמח:";
            // 
            // typePlantName
            // 
            this.typePlantName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.typePlantName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.typePlantName.Border.Class = "TextBoxBorder";
            this.typePlantName.Location = new System.Drawing.Point(28, 8);
            this.typePlantName.Name = "typePlantName";
            this.typePlantName.Size = new System.Drawing.Size(142, 26);
            this.typePlantName.TabIndex = 16;
            this.typePlantName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.typePlantName_KeyPress);
            this.typePlantName.TextChanged += new System.EventHandler(this.typePlantName_TextChanged);
            // 
            // AddNewPlant
            // 
            this.ClientSize = new System.Drawing.Size(1012, 575);
            this.Controls.Add(this.addPlantTypePanel);
            this.Controls.Add(this.addPlantPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "AddNewPlant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewPlant_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.addPlantPanel.ResumeLayout(false);
            this.addPlantPanel.PerformLayout();
            this.addPlantTypePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typeLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typePrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX foreignName;
        private DevComponents.DotNetBar.Controls.TextBoxX name;
        private DevComponents.Editors.IntegerInput integerInput1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.TextBox comments;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.DoubleInput price;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.Editors.DoubleInput lifeTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.Controls.GroupPanel addPlantPanel;
        private DevComponents.DotNetBar.Controls.GroupPanel addPlantTypePanel;
        private DevComponents.DotNetBar.Controls.TextBoxX typePlantName;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX quality;
        private DevComponents.Editors.DoubleInput typeLife;
        private DevComponents.Editors.DoubleInput typePrice;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.ComboBoxEx typeType;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX plantUnitType;
        private System.Windows.Forms.ListBox autoCompleteList;
    }
}
