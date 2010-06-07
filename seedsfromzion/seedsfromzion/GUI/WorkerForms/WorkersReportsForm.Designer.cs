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
            this.graphicSettingsPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_allWorkers)).BeginInit();
            this.graphicSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(340, 54);
            this.labelX5.Margin = new System.Windows.Forms.Padding(5);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(100, 35);
            this.labelX5.TabIndex = 7;
            this.labelX5.Text = "סגנון הדו\"ח:";
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 20;
            this.comboBoxEx1.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.comboBoxEx1.Location = new System.Drawing.Point(165, 61);
            this.comboBoxEx1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(165, 26);
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
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_save.Location = new System.Drawing.Point(175, 295);
            this.btn_save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 35);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "שמור";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(340, 9);
            this.labelX1.Margin = new System.Windows.Forms.Padding(5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 35);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "סוג הדו\"ח:";
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "כל העובדים",
            "עובד ספציפי"});
            this.comboBox_type.Location = new System.Drawing.Point(165, 12);
            this.comboBox_type.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(165, 28);
            this.comboBox_type.TabIndex = 10;
            this.comboBox_type.Text = "כל העובדים";
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM/ yyyy";
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(36, 12);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(119, 26);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_allWorkers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_allWorkers.Enabled = false;
            this.dataGrid_allWorkers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGrid_allWorkers.Location = new System.Drawing.Point(36, 117);
            this.dataGrid_allWorkers.Margin = new System.Windows.Forms.Padding(5);
            this.dataGrid_allWorkers.MultiSelect = false;
            this.dataGrid_allWorkers.Name = "dataGrid_allWorkers";
            this.dataGrid_allWorkers.ReadOnly = true;
            this.dataGrid_allWorkers.RowTemplate.Height = 24;
            this.dataGrid_allWorkers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid_allWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_allWorkers.Size = new System.Drawing.Size(404, 168);
            this.dataGrid_allWorkers.TabIndex = 12;
            // 
            // graphicSettingsPanel
            // 
            this.graphicSettingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.graphicSettingsPanel.CanvasColor = System.Drawing.SystemColors.ActiveCaption;
            this.graphicSettingsPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.graphicSettingsPanel.Controls.Add(this.btn_save);
            this.graphicSettingsPanel.Controls.Add(this.dataGrid_allWorkers);
            this.graphicSettingsPanel.Controls.Add(this.comboBox_type);
            this.graphicSettingsPanel.Controls.Add(this.dateTimePicker);
            this.graphicSettingsPanel.Controls.Add(this.comboBoxEx1);
            this.graphicSettingsPanel.Controls.Add(this.labelX5);
            this.graphicSettingsPanel.Controls.Add(this.labelX1);
            this.graphicSettingsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.graphicSettingsPanel.IsShadowEnabled = true;
            this.graphicSettingsPanel.Location = new System.Drawing.Point(27, 5);
            this.graphicSettingsPanel.Name = "graphicSettingsPanel";
            this.graphicSettingsPanel.ShowFocusRectangle = true;
            this.graphicSettingsPanel.Size = new System.Drawing.Size(483, 377);
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
            this.graphicSettingsPanel.TabIndex = 17;
            this.graphicSettingsPanel.Text = "הוספת עובד חדש";
            // 
            // WorkersReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 398);
            this.Controls.Add(this.graphicSettingsPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "WorkersReportsForm";
            this.Text = "WorkerReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_allWorkers)).EndInit();
            this.graphicSettingsPanel.ResumeLayout(false);
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
        private DevComponents.DotNetBar.Controls.GroupPanel graphicSettingsPanel;
    }
}