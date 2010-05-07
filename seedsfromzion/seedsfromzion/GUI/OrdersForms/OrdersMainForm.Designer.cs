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
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStorageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.doubleInput1 = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.storageGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput1)).BeginInit();
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
            this.addButton.Location = new System.Drawing.Point(226, 163);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(28, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(50, 196);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "פריטים בהזמנה:";
            // 
            // orderGrid
            // 
            this.orderGrid.AllowUserToAddRows = false;
            this.orderGrid.AllowUserToDeleteRows = false;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
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
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.ReadOnly = true;
            this.orderGrid.Size = new System.Drawing.Size(451, 150);
            this.orderGrid.TabIndex = 5;
            // 
            // orderId
            // 
            this.orderId.HeaderText = "Column1";
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            this.orderId.Visible = false;
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
            this.labelX3.Location = new System.Drawing.Point(51, 163);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(74, 18);
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
            this.doubleInput1.Location = new System.Drawing.Point(131, 163);
            this.doubleInput1.Name = "doubleInput1";
            this.doubleInput1.ShowUpDown = true;
            this.doubleInput1.Size = new System.Drawing.Size(80, 20);
            this.doubleInput1.TabIndex = 7;
            // 
            // OrdersMainForm
            // 
            this.ClientSize = new System.Drawing.Size(519, 378);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStorageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderUnits;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DoubleInput doubleInput1;
    }
}
