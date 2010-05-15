namespace seedsfromzion.GUI.WorkerForms
{
    partial class VisasGeneralForm
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
            this.dataGridVisas = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_addVisa = new DevComponents.DotNetBar.ButtonX();
            this.dataGrid_workers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_workers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVisas
            // 
            this.dataGridVisas.AllowUserToAddRows = false;
            this.dataGridVisas.AllowUserToDeleteRows = false;
            this.dataGridVisas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridVisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVisas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVisas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridVisas.Location = new System.Drawing.Point(52, 48);
            this.dataGridVisas.MultiSelect = false;
            this.dataGridVisas.Name = "dataGridVisas";
            this.dataGridVisas.ReadOnly = true;
            this.dataGridVisas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridVisas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVisas.Size = new System.Drawing.Size(369, 152);
            this.dataGridVisas.TabIndex = 0;
            // 
            // btn_addVisa
            // 
            this.btn_addVisa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addVisa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addVisa.Image = global::seedsfromzion.Properties.Resources.addOrderIcon;
            this.btn_addVisa.Location = new System.Drawing.Point(439, 164);
            this.btn_addVisa.Name = "btn_addVisa";
            this.btn_addVisa.Size = new System.Drawing.Size(41, 36);
            this.btn_addVisa.TabIndex = 1;
            this.btn_addVisa.Click += new System.EventHandler(this.btn_addVisa_Click);
            // 
            // dataGrid_workers
            // 
            this.dataGrid_workers.AllowUserToAddRows = false;
            this.dataGrid_workers.AllowUserToDeleteRows = false;
            this.dataGrid_workers.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGrid_workers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_workers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_workers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGrid_workers.Location = new System.Drawing.Point(52, 266);
            this.dataGrid_workers.MultiSelect = false;
            this.dataGrid_workers.Name = "dataGrid_workers";
            this.dataGrid_workers.ReadOnly = true;
            this.dataGrid_workers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid_workers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_workers.Size = new System.Drawing.Size(369, 152);
            this.dataGrid_workers.TabIndex = 2;
            // 
            // VisasGeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 515);
            this.Controls.Add(this.dataGrid_workers);
            this.Controls.Add(this.btn_addVisa);
            this.Controls.Add(this.dataGridVisas);
            this.Name = "VisasGeneralForm";
            this.Text = "VisasGeneralForm";
            this.Load += new System.EventHandler(this.VisasGeneralForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_workers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridVisas;
        private DevComponents.DotNetBar.ButtonX btn_addVisa;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGrid_workers;
    }
}