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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridWorkers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.dataGridView_hours = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hours)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridWorkers
            // 
            this.dataGridWorkers.AllowUserToAddRows = false;
            this.dataGridWorkers.AllowUserToDeleteRows = false;
            this.dataGridWorkers.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridWorkers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridWorkers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridWorkers.Location = new System.Drawing.Point(41, 46);
            this.dataGridWorkers.Name = "dataGridWorkers";
            this.dataGridWorkers.ReadOnly = true;
            this.dataGridWorkers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWorkers.Size = new System.Drawing.Size(414, 240);
            this.dataGridWorkers.TabIndex = 6;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(495, 46);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_hours.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_hours.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView_hours.Location = new System.Drawing.Point(495, 238);
            this.dataGridView_hours.Name = "dataGridView_hours";
            this.dataGridView_hours.ReadOnly = true;
            this.dataGridView_hours.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_hours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_hours.Size = new System.Drawing.Size(157, 84);
            this.dataGridView_hours.TabIndex = 9;
            // 
            // WorkDaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 486);
            this.Controls.Add(this.dataGridView_hours);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.dataGridWorkers);
            this.Name = "WorkDaysForm";
            this.Text = "WorkDaysForm";
            this.Load += new System.EventHandler(this.WorkDaysForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridWorkers;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView_hours;
    }
}