namespace seedsfromzion.GUI.InventoryForms
{
    partial class AddToFridgeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.units = new DevComponents.Editors.DoubleInput();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.location = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.arriveLabel = new DevComponents.DotNetBar.LabelX();
            this.plantInput = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.units)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // units
            // 
            // 
            // 
            // 
            this.units.BackgroundStyle.Class = "DateTimeInputBackground";
            this.units.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.units.Dock = System.Windows.Forms.DockStyle.Top;
            this.units.Increment = 1;
            this.units.Location = new System.Drawing.Point(3, 45);
            this.units.MinValue = 0.01;
            this.units.Name = "units";
            this.units.ShowUpDown = true;
            this.units.Size = new System.Drawing.Size(209, 20);
            this.units.TabIndex = 0;
            this.units.Value = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.location, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelX3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelX2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.arriveLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.units, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 202);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 129);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // location
            // 
            // 
            // 
            // 
            this.location.Border.Class = "TextBoxBorder";
            this.location.Dock = System.Windows.Forms.DockStyle.Top;
            this.location.Location = new System.Drawing.Point(3, 85);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(209, 20);
            this.location.TabIndex = 2;
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(351, 85);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "מיקום במקרר";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(351, 45);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "יחידות";
            // 
            // arriveLabel
            // 
            this.arriveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arriveLabel.Location = new System.Drawing.Point(280, 3);
            this.arriveLabel.Name = "arriveLabel";
            this.arriveLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.arriveLabel.Size = new System.Drawing.Size(146, 23);
            this.arriveLabel.TabIndex = 3;
            this.arriveLabel.Text = "תאריך הכנסה למקרר";
            // 
            // plantInput
            // 
            this.plantInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.plantInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.plantInput.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.plantInput.Border.Class = "TextBoxBorder";
            this.plantInput.Location = new System.Drawing.Point(239, 11);
            this.plantInput.Name = "plantInput";
            this.plantInput.Size = new System.Drawing.Size(131, 20);
            this.plantInput.TabIndex = 2;
            this.plantInput.TextChanged += new System.EventHandler(this.plantInput_TextChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(376, 8);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(63, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "שם הצמח\r\n";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(203, 359);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "הוסף";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "מזהה";
            this.columnHeader1.Width.Absolute = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "סוג הצמח";
            this.columnHeader2.Width.Absolute = 150;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(10, 37);
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(429, 95);
            this.dataGridViewX1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "שם הצמח";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "סוג הצמח";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.plantInput);
            this.groupPanel1.Controls.Add(this.dataGridViewX1);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Location = new System.Drawing.Point(13, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(457, 159);
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
            this.groupPanel1.TabIndex = 8;
            this.groupPanel1.Text = "צמחים במערכת";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // AddToFridgeForm
            // 
            this.ClientSize = new System.Drawing.Size(592, 509);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddToFridgeForm";
            ((System.ComponentModel.ISupportInitialize)(this.units)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.DoubleInput units;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX location;
        private DevComponents.DotNetBar.LabelX arriveLabel;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX plantInput;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private DevComponents.AdvTree.ColumnHeader columnHeader2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
