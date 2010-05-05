namespace seedsfromzion.GUI.WorkerForms
{
    partial class AddWorkerForm
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
            this.textBox_ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.textBox_firstName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_lastName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btn_addWorker = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            // 
            // 
            // 
            this.textBox_ID.Border.Class = "TextBoxBorder";
            this.textBox_ID.Location = new System.Drawing.Point(209, 50);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(137, 20);
            this.textBox_ID.TabIndex = 0;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(114, 50);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "תעודת זהות:";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(114, 88);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "שם פרטי:";
            // 
            // textBox_firstName
            // 
            // 
            // 
            // 
            this.textBox_firstName.Border.Class = "TextBoxBorder";
            this.textBox_firstName.Location = new System.Drawing.Point(209, 88);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(137, 20);
            this.textBox_firstName.TabIndex = 3;
            // 
            // textBox_lastName
            // 
            // 
            // 
            // 
            this.textBox_lastName.Border.Class = "TextBoxBorder";
            this.textBox_lastName.Location = new System.Drawing.Point(209, 127);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(137, 20);
            this.textBox_lastName.TabIndex = 4;
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(114, 127);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "שם משפחה:";
            // 
            // btn_addWorker
            // 
            this.btn_addWorker.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addWorker.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addWorker.Location = new System.Drawing.Point(353, 181);
            this.btn_addWorker.Name = "btn_addWorker";
            this.btn_addWorker.Size = new System.Drawing.Size(75, 23);
            this.btn_addWorker.TabIndex = 6;
            this.btn_addWorker.Text = "הוסף";
            this.btn_addWorker.Click += new System.EventHandler(this.btn_addWorker_Click);
            // 
            // AddWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 354);
            this.Controls.Add(this.btn_addWorker);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBox_ID);
            this.DoubleBuffered = true;
            this.Name = "AddWorkerForm";
            this.Text = "AddWorkerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBox_ID;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_firstName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_lastName;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btn_addWorker;
    }
}