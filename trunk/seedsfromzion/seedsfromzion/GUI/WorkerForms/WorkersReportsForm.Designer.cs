namespace seedsfromzion.GUI.WorkerForms
{
    partial class WorkersReportsForm
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
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGrid_allWorkers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_allWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(30, 122);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 7;
            this.labelX5.Text = "סגנון הדו\"ח";
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.comboBoxEx1.Location = new System.Drawing.Point(111, 125);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(121, 20);
            this.comboBoxEx1.TabIndex = 6;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "צבעוני";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "שחור לבן";
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Location = new System.Drawing.Point(157, 171);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "שמור";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(30, 72);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "סוג הדו\"ח";
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "כל העובדים",
            "עובד ספציפי"});
            this.comboBox_type.Location = new System.Drawing.Point(111, 74);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(121, 21);
            this.comboBox_type.TabIndex = 10;
            this.comboBox_type.Text = "כל העובדים";
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM/ yyyy";
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(247, 75);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker.TabIndex = 11;
            // 
            // dataGrid_allWorkers
            // 
            this.dataGrid_allWorkers.AllowUserToAddRows = false;
            this.dataGrid_allWorkers.AllowUserToDeleteRows = false;
            this.dataGrid_allWorkers.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGrid_allWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_allWorkers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_allWorkers.Enabled = false;
            this.dataGrid_allWorkers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGrid_allWorkers.Location = new System.Drawing.Point(358, 36);
            this.dataGrid_allWorkers.MultiSelect = false;
            this.dataGrid_allWorkers.Name = "dataGrid_allWorkers";
            this.dataGrid_allWorkers.ReadOnly = true;
            this.dataGrid_allWorkers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid_allWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_allWorkers.Size = new System.Drawing.Size(242, 109);
            this.dataGrid_allWorkers.TabIndex = 12;
            // 
            // WorkersReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 399);
            this.Controls.Add(this.dataGrid_allWorkers);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.btn_save);
            this.Name = "WorkersReportsForm";
            this.Text = "WorkerReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_allWorkers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGrid_allWorkers;
    }
}