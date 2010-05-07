namespace seedsfromzion.GUI.WorkerForms
{
    partial class FindWorkerForm
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBox_ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_find = new DevComponents.DotNetBar.ButtonX();
            this.dataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(49, 45);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(40, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "ת.ז:";
            // 
            // textBox_ID
            // 
            // 
            // 
            // 
            this.textBox_ID.Border.Class = "TextBoxBorder";
            this.textBox_ID.Location = new System.Drawing.Point(95, 45);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(113, 20);
            this.textBox_ID.TabIndex = 1;
            // 
            // btn_find
            // 
            this.btn_find.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_find.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_find.Location = new System.Drawing.Point(371, 45);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 23);
            this.btn_find.TabIndex = 2;
            this.btn_find.Text = "מצא";
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView.Location = new System.Drawing.Point(49, 141);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(397, 202);
            this.dataGridView.TabIndex = 3;
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Location = new System.Drawing.Point(488, 131);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(100, 20);
            this.textBoxX1.TabIndex = 4;
            // 
            // FindWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 369);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.labelX1);
            this.Name = "FindWorkerForm";
            this.Text = "חפש עובד";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_ID;
        private DevComponents.DotNetBar.ButtonX btn_find;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
    }
}