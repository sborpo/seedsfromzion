namespace seedsfromzion.GUI
{
    partial class SafeMode
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
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(92, 92);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(231, 49);
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "לחץ כאן על מנת לטעון קובץ גיבוי מערכת";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(74, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(388, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "קרתה שגיאת מערכת חמורה , אנא נסה להפעיל את המערכת שנית";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(49, 41);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(397, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "במקרה וחלון זה מופיע שוב , אנא שחזרת את המערכת על ידי לחיצת הכפתור";
            // 
            // SafeMode
            // 
            this.ClientSize = new System.Drawing.Size(412, 195);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.buttonX1);
            this.Name = "SafeMode";
            this.Text = "SafeMode";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}