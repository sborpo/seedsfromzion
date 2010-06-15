namespace seedsfromzion.GUI
{
    partial class DialogBox
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
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.text = new DevComponents.DotNetBar.LabelX();
            this.yesButton = new DevComponents.DotNetBar.ButtonX();
            this.NoButton = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = global::seedsfromzion.Properties.Resources.questionMark;
            this.reflectionImage1.Location = new System.Drawing.Point(415, 12);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(69, 104);
            this.reflectionImage1.TabIndex = 0;
            this.reflectionImage1.Click += new System.EventHandler(this.reflectionImage1_Click);
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.text.Location = new System.Drawing.Point(41, 36);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(368, 23);
            this.text.TabIndex = 1;
            this.text.Text = "האם הינך בטוח שברצונך לבצע פעולה זו?";
            // 
            // yesButton
            // 
            this.yesButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.yesButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.yesButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.yesButton.Location = new System.Drawing.Point(117, 97);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(83, 32);
            this.yesButton.TabIndex = 2;
            this.yesButton.Text = "כן";
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.NoButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.NoButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.NoButton.Location = new System.Drawing.Point(270, 97);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(81, 32);
            this.NoButton.TabIndex = 3;
            this.NoButton.Text = "לא";
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // DialogBox
            // 
            this.ClientSize = new System.Drawing.Size(486, 141);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.text);
            this.Controls.Add(this.reflectionImage1);
            this.DoubleBuffered = true;
            this.Name = "DialogBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "התראה";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.LabelX text;
        private DevComponents.DotNetBar.ButtonX yesButton;
        private DevComponents.DotNetBar.ButtonX NoButton;
    }
}