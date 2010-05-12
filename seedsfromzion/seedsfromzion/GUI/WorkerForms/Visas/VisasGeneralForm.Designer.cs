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
            this.dataGridVisas = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_addVisa = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVisas
            // 
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
            this.dataGridVisas.Name = "dataGridVisas";
            this.dataGridVisas.Size = new System.Drawing.Size(369, 152);
            this.dataGridVisas.TabIndex = 0;
            // 
            // btn_addVisa
            // 
            this.btn_addVisa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addVisa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addVisa.Image = global::seedsfromzion.Properties.Resources.addOrderIcon;
            this.btn_addVisa.Location = new System.Drawing.Point(380, 206);
            this.btn_addVisa.Name = "btn_addVisa";
            this.btn_addVisa.Size = new System.Drawing.Size(41, 36);
            this.btn_addVisa.TabIndex = 1;
            this.btn_addVisa.Click += new System.EventHandler(this.btn_addVisa_Click);
            // 
            // VisasGeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 332);
            this.Controls.Add(this.btn_addVisa);
            this.Controls.Add(this.dataGridVisas);
            this.DoubleBuffered = true;
            this.Name = "VisasGeneralForm";
            this.Text = "VisasGeneralForm";
            this.Load += new System.EventHandler(this.VisasGeneralForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridVisas;
        private DevComponents.DotNetBar.ButtonX btn_addVisa;
    }
}