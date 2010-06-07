namespace seedsfromzion.GUI.WorkerForms
{
    partial class WorkDaysForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridWorkers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.dataGridView_hours = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dateTime_start = new System.Windows.Forms.DateTimePicker();
            this.dateTime_end = new System.Windows.Forms.DateTimePicker();
            this.btn_update_hours = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hours)).BeginInit();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridWorkers
            // 
            this.dataGridWorkers.AllowUserToAddRows = false;
            this.dataGridWorkers.AllowUserToDeleteRows = false;
            this.dataGridWorkers.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridWorkers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridWorkers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridWorkers.Location = new System.Drawing.Point(55, 57);
            this.dataGridWorkers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridWorkers.Name = "dataGridWorkers";
            this.dataGridWorkers.ReadOnly = true;
            this.dataGridWorkers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWorkers.Size = new System.Drawing.Size(552, 295);
            this.dataGridWorkers.TabIndex = 6;
            this.dataGridWorkers.SelectionChanged += new System.EventHandler(this.dataGridWorkers_SelectionChanged);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(660, 57);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthCalendar.TabIndex = 8;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dataGridView_hours
            // 
            this.dataGridView_hours.AllowUserToAddRows = false;
            this.dataGridView_hours.AllowUserToDeleteRows = false;
            this.dataGridView_hours.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_hours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_hours.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_hours.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView_hours.Location = new System.Drawing.Point(23, 10);
            this.dataGridView_hours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_hours.Name = "dataGridView_hours";
            this.dataGridView_hours.ReadOnly = true;
            this.dataGridView_hours.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_hours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_hours.Size = new System.Drawing.Size(209, 95);
            this.dataGridView_hours.TabIndex = 9;
            // 
            // dateTime_start
            // 
            this.dateTime_start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime_start.Location = new System.Drawing.Point(177, 391);
            this.dateTime_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTime_start.Name = "dateTime_start";
            this.dateTime_start.RightToLeftLayout = true;
            this.dateTime_start.ShowUpDown = true;
            this.dateTime_start.Size = new System.Drawing.Size(265, 22);
            this.dateTime_start.TabIndex = 10;
            this.dateTime_start.Value = new System.DateTime(2010, 5, 22, 8, 0, 0, 0);
            // 
            // dateTime_end
            // 
            this.dateTime_end.AllowDrop = true;
            this.dateTime_end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime_end.Location = new System.Drawing.Point(177, 423);
            this.dateTime_end.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTime_end.Name = "dateTime_end";
            this.dateTime_end.RightToLeftLayout = true;
            this.dateTime_end.ShowUpDown = true;
            this.dateTime_end.Size = new System.Drawing.Size(265, 22);
            this.dateTime_end.TabIndex = 11;
            this.dateTime_end.Value = new System.DateTime(2010, 5, 22, 16, 0, 0, 0);
            // 
            // btn_update_hours
            // 
            this.btn_update_hours.CanvasColor = System.Drawing.SystemColors.Control;
            this.btn_update_hours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_update_hours.Location = new System.Drawing.Point(487, 472);
            this.btn_update_hours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update_hours.Name = "btn_update_hours";
            this.btn_update_hours.Size = new System.Drawing.Size(120, 31);
            // 
            // 
            // 
            this.btn_update_hours.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.btn_update_hours.Style.BackColorGradientAngle = 90;
            this.btn_update_hours.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.btn_update_hours.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile;
            this.btn_update_hours.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btn_update_hours.Style.BorderBottomWidth = 1;
            this.btn_update_hours.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.btn_update_hours.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btn_update_hours.Style.BorderLeftWidth = 1;
            this.btn_update_hours.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btn_update_hours.Style.BorderRightWidth = 1;
            this.btn_update_hours.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btn_update_hours.Style.BorderTopWidth = 1;
            this.btn_update_hours.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.btn_update_hours.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.btn_update_hours.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            // 
            // 
            // 
            this.btn_update_hours.StyleMouseDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.btn_update_hours.StyleMouseDown.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btn_update_hours.StyleMouseDown.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
            this.btn_update_hours.StyleMouseDown.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.btn_update_hours.StyleMouseDown.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
            // 
            // 
            // 
            this.btn_update_hours.StyleMouseOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btn_update_hours.StyleMouseOver.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.btn_update_hours.StyleMouseOver.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
            this.btn_update_hours.StyleMouseOver.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.btn_update_hours.StyleMouseOver.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.btn_update_hours.TabIndex = 13;
            this.btn_update_hours.Text = "עדכן";
            this.btn_update_hours.Click += new System.EventHandler(this.btn_update_hours_Click);
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.dataGridView_hours);
            this.groupPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupPanel3.Location = new System.Drawing.Point(660, 284);
            this.groupPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(260, 143);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel3.TabIndex = 14;
            this.groupPanel3.Text = "שעות עבודה";
            // 
            // WorkDaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 598);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.btn_update_hours);
            this.Controls.Add(this.dateTime_end);
            this.Controls.Add(this.dateTime_start);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.dataGridWorkers);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WorkDaysForm";
            this.Text = "WorkDaysForm";
            this.Load += new System.EventHandler(this.WorkDaysForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hours)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridWorkers;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView_hours;
        private System.Windows.Forms.DateTimePicker dateTime_start;
        private System.Windows.Forms.DateTimePicker dateTime_end;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel btn_update_hours;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
    }
}