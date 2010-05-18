namespace seedsfromzion.GUI.OrdersForms
{
    partial class OrdersMainForm
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
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.storageGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.orderGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.porderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStorageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.doubleInput1 = new DevComponents.Editors.DoubleInput();
            this.buttonOrder = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.nameBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.phoneBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.emailBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.idBox = new DevComponents.Editors.IntegerInput();
            this.dateTimeInput = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.removeButton = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.storageGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Location = new System.Drawing.Point(149, 26);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(153, 20);
            this.textBoxX1.TabIndex = 0;
            this.textBoxX1.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(50, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(93, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "סנן לפי שם צמח:";
            // 
            // storageGrid
            // 
            this.storageGrid.AllowUserToAddRows = false;
            this.storageGrid.AllowUserToDeleteRows = false;
            this.storageGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.storageGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storageGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.type,
            this.storageId,
            this.units});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.storageGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.storageGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.storageGrid.Location = new System.Drawing.Point(50, 52);
            this.storageGrid.MultiSelect = false;
            this.storageGrid.Name = "storageGrid";
            this.storageGrid.ReadOnly = true;
            this.storageGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.storageGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.storageGrid.Size = new System.Drawing.Size(451, 100);
            this.storageGrid.TabIndex = 2;
            this.storageGrid.SelectionChanged += new System.EventHandler(this.storageGrid_SelectionChanged);
            this.storageGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.storageGrid_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "שם הצמח";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "סוג";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // storageId
            // 
            this.storageId.HeaderText = "מספר מחסן";
            this.storageId.Name = "storageId";
            this.storageId.ReadOnly = true;
            // 
            // units
            // 
            this.units.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.units.HeaderText = "יחידות";
            this.units.Name = "units";
            this.units.ReadOnly = true;
            // 
            // addButton
            // 
            this.addButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.addButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.addButton.Image = global::seedsfromzion.Properties.Resources.addOrderIcon;
            this.addButton.Location = new System.Drawing.Point(274, 163);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(28, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX2.Location = new System.Drawing.Point(50, 196);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(93, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "פריטים בהזמנה:";
            // 
            // orderGrid
            // 
            this.orderGrid.AllowUserToAddRows = false;
            this.orderGrid.AllowUserToDeleteRows = false;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.porderId,
            this.orderName,
            this.orderType,
            this.orderStorageId,
            this.orderUnits});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.orderGrid.Location = new System.Drawing.Point(50, 225);
            this.orderGrid.MultiSelect = false;
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.ReadOnly = true;
            this.orderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderGrid.Size = new System.Drawing.Size(451, 150);
            this.orderGrid.TabIndex = 5;
            // 
            // porderId
            // 
            this.porderId.HeaderText = "Column1";
            this.porderId.Name = "porderId";
            this.porderId.ReadOnly = true;
            this.porderId.Visible = false;
            // 
            // orderName
            // 
            this.orderName.HeaderText = "שם הצמח";
            this.orderName.Name = "orderName";
            this.orderName.ReadOnly = true;
            this.orderName.Width = 108;
            // 
            // orderType
            // 
            this.orderType.HeaderText = "סוג";
            this.orderType.Name = "orderType";
            this.orderType.ReadOnly = true;
            // 
            // orderStorageId
            // 
            this.orderStorageId.HeaderText = "מספר המחסן";
            this.orderStorageId.Name = "orderStorageId";
            this.orderStorageId.ReadOnly = true;
            // 
            // orderUnits
            // 
            this.orderUnits.HeaderText = "יחידות";
            this.orderUnits.Name = "orderUnits";
            this.orderUnits.ReadOnly = true;
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX3.Location = new System.Drawing.Point(51, 163);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(92, 18);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "יחידות להוספה:";
            // 
            // doubleInput1
            // 
            // 
            // 
            // 
            this.doubleInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInput1.Increment = 1;
            this.doubleInput1.Location = new System.Drawing.Point(178, 161);
            this.doubleInput1.Name = "doubleInput1";
            this.doubleInput1.ShowUpDown = true;
            this.doubleInput1.Size = new System.Drawing.Size(80, 20);
            this.doubleInput1.TabIndex = 7;
            // 
            // buttonOrder
            // 
            this.buttonOrder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOrder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonOrder.Location = new System.Drawing.Point(546, 343);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonOrder.TabIndex = 8;
            this.buttonOrder.Text = "בצע הזמנה";
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX4.Location = new System.Drawing.Point(547, 22);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "פרטי המזמין:";
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX5.Location = new System.Drawing.Point(546, 91);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(28, 23);
            this.labelX5.TabIndex = 10;
            this.labelX5.Text = "שם:";
            // 
            // labelX6
            // 
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX6.Location = new System.Drawing.Point(544, 120);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 11;
            this.labelX6.Text = "מספר טלפון:";
            // 
            // labelX7
            // 
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX7.Location = new System.Drawing.Point(546, 149);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 12;
            this.labelX7.Text = "E-Mail:";
            // 
            // nameBox
            // 
            // 
            // 
            // 
            this.nameBox.Border.Class = "TextBoxBorder";
            this.nameBox.Location = new System.Drawing.Point(617, 94);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(119, 20);
            this.nameBox.TabIndex = 13;
            // 
            // phoneBoxX
            // 
            // 
            // 
            // 
            this.phoneBoxX.Border.Class = "TextBoxBorder";
            this.phoneBoxX.Location = new System.Drawing.Point(617, 123);
            this.phoneBoxX.Name = "phoneBoxX";
            this.phoneBoxX.Size = new System.Drawing.Size(119, 20);
            this.phoneBoxX.TabIndex = 15;
            // 
            // emailBoxX
            // 
            // 
            // 
            // 
            this.emailBoxX.Border.Class = "TextBoxBorder";
            this.emailBoxX.Location = new System.Drawing.Point(617, 149);
            this.emailBoxX.Name = "emailBoxX";
            this.emailBoxX.Size = new System.Drawing.Size(119, 20);
            this.emailBoxX.TabIndex = 16;
            // 
            // labelX8
            // 
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX8.Location = new System.Drawing.Point(554, 63);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(49, 23);
            this.labelX8.TabIndex = 17;
            this.labelX8.Text = "ח.פ\\ת.ז:";
            // 
            // idBox
            // 
            // 
            // 
            // 
            this.idBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.idBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.idBox.Location = new System.Drawing.Point(618, 65);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(118, 20);
            this.idBox.TabIndex = 18;
            // 
            // dateTimeInput
            // 
            // 
            // 
            // 
            this.dateTimeInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput.ButtonDropDown.Visible = true;
            this.dateTimeInput.Location = new System.Drawing.Point(617, 196);
            // 
            // 
            // 
            this.dateTimeInput.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateTimeInput.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput.MonthCalendar.DisplayMonth = new System.DateTime(2010, 5, 1, 0, 0, 0, 0);
            this.dateTimeInput.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput.Name = "dateTimeInput";
            this.dateTimeInput.Size = new System.Drawing.Size(119, 20);
            this.dateTimeInput.TabIndex = 19;
            // 
            // labelX9
            // 
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX9.Location = new System.Drawing.Point(530, 196);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(81, 25);
            this.labelX9.TabIndex = 20;
            this.labelX9.Text = "תאריך אספקה";
            // 
            // removeButton
            // 
            this.removeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.removeButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.removeButton.DisabledImage = global::seedsfromzion.Properties.Resources.delete40_Layer_1;
            this.removeButton.Image = global::seedsfromzion.Properties.Resources.delete40_Layer_1;
            this.removeButton.Location = new System.Drawing.Point(507, 252);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(43, 43);
            this.removeButton.TabIndex = 21;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // OrdersMainForm
            // 
            this.ClientSize = new System.Drawing.Size(755, 378);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.dateTimeInput);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.emailBoxX);
            this.Controls.Add(this.phoneBoxX);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.doubleInput1);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.orderGrid);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.storageGrid);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxX1);
            this.DoubleBuffered = true;
            this.Name = "OrdersMainForm";
            this.Load += new System.EventHandler(this.OrdersMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storageGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX storageGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn units;
        private DevComponents.DotNetBar.ButtonX addButton;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX orderGrid;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DoubleInput doubleInput1;
        private DevComponents.DotNetBar.ButtonX buttonOrder;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX nameBox;
        private DevComponents.DotNetBar.Controls.TextBoxX phoneBoxX;
        private DevComponents.DotNetBar.Controls.TextBoxX emailBoxX;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.Editors.IntegerInput idBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.ButtonX removeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn porderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStorageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderUnits;
    }
}
