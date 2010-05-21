namespace seedsfromzion.GUI.OrdersForms
{
    partial class SearchOrderForm
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.orderGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.detailsGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.editOrder = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX1.Location = new System.Drawing.Point(30, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(82, 31);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "מספר הזמנה:";
            // 
            // orderGrid
            // 
            this.orderGrid.AllowUserToAddRows = false;
            this.orderGrid.AllowUserToDeleteRows = false;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.clientId,
            this.orderDate,
            this.dueDate});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.orderGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.orderGrid.Location = new System.Drawing.Point(30, 81);
            this.orderGrid.MultiSelect = false;
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.ReadOnly = true;
            this.orderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderGrid.Size = new System.Drawing.Size(443, 238);
            this.orderGrid.TabIndex = 2;
            this.orderGrid.SelectionChanged += new System.EventHandler(this.orderGrid_SelectionChanged);
            // 
            // orderId
            // 
            this.orderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderId.HeaderText = "מספר הזמנה";
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            // 
            // clientId
            // 
            this.clientId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientId.HeaderText = "מספר לקוח";
            this.clientId.Name = "clientId";
            this.clientId.ReadOnly = true;
            // 
            // orderDate
            // 
            this.orderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderDate.HeaderText = "תאריך הזמנה";
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            // 
            // dueDate
            // 
            this.dueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dueDate.HeaderText = "תאריך אספקה";
            this.dueDate.Name = "dueDate";
            this.dueDate.ReadOnly = true;
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Location = new System.Drawing.Point(104, 29);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(127, 20);
            this.textBoxX1.TabIndex = 3;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX2.Location = new System.Drawing.Point(483, 30);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(78, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "תיאור ההזמנה";
            // 
            // detailsGrid
            // 
            this.detailsGrid.AllowUserToAddRows = false;
            this.detailsGrid.AllowUserToDeleteRows = false;
            this.detailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.units});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detailsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.detailsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.detailsGrid.Location = new System.Drawing.Point(541, 81);
            this.detailsGrid.MultiSelect = false;
            this.detailsGrid.Name = "detailsGrid";
            this.detailsGrid.ReadOnly = true;
            this.detailsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detailsGrid.Size = new System.Drawing.Size(244, 397);
            this.detailsGrid.TabIndex = 5;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "שם הפריט";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // units
            // 
            this.units.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.units.HeaderText = "יחידות";
            this.units.Name = "units";
            this.units.ReadOnly = true;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonX1.Image = global::seedsfromzion.Properties.Resources.delete40_Layer_1;
            this.buttonX1.Location = new System.Drawing.Point(31, 364);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(102, 37);
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "בטל הזמנה";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // editOrder
            // 
            this.editOrder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.editOrder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.editOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.editOrder.Location = new System.Drawing.Point(541, 484);
            this.editOrder.Name = "editOrder";
            this.editOrder.Size = new System.Drawing.Size(91, 28);
            this.editOrder.TabIndex = 7;
            this.editOrder.Text = "ערוך הזמנה";
            this.editOrder.Click += new System.EventHandler(this.editOrder_Click);
            // 
            // SearchOrderForm
            // 
            this.ClientSize = new System.Drawing.Size(798, 517);
            this.Controls.Add(this.editOrder);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.detailsGrid);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.orderGrid);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "SearchOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX orderGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX detailsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn units;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX editOrder;
    }
}
