namespace seedsfromzion.GUI.InventoryForms
{
    partial class AddNewPlant
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.foreignName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.integerInput1 = new DevComponents.Editors.IntegerInput();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.comments = new System.Windows.Forms.TextBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.price = new DevComponents.Editors.DoubleInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.lifeTime = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeTime)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX1.Location = new System.Drawing.Point(22, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(60, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "שם  הצמח:";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX2.Location = new System.Drawing.Point(23, 52);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "שם  בלועזית:";
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX3.Location = new System.Drawing.Point(24, 82);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "איכות הצמח:";
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX4.Location = new System.Drawing.Point(25, 112);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(153, 25);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "מספר יחידות ליחידת משקל:";
            // 
            // foreignName
            // 
            // 
            // 
            // 
            this.foreignName.Border.Class = "TextBoxBorder";
            this.foreignName.Location = new System.Drawing.Point(104, 54);
            this.foreignName.Name = "foreignName";
            this.foreignName.Size = new System.Drawing.Size(133, 20);
            this.foreignName.TabIndex = 5;
            // 
            // name
            // 
            // 
            // 
            // 
            this.name.Border.Class = "TextBoxBorder";
            this.name.Location = new System.Drawing.Point(104, 24);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(133, 20);
            this.name.TabIndex = 6;
            // 
            // integerInput1
            // 
            // 
            // 
            // 
            this.integerInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput1.Location = new System.Drawing.Point(172, 117);
            this.integerInput1.MinValue = 0;
            this.integerInput1.Name = "integerInput1";
            this.integerInput1.Size = new System.Drawing.Size(65, 20);
            this.integerInput1.TabIndex = 7;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(172, 83);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(65, 20);
            this.comboBoxEx1.TabIndex = 8;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.LightCyan;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonX1.Image = global::seedsfromzion.Properties.Resources.addOrderIcon;
            this.buttonX1.Location = new System.Drawing.Point(25, 310);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(85, 28);
            this.buttonX1.TabIndex = 9;
            this.buttonX1.Text = "הוסף צמח";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX5.Location = new System.Drawing.Point(24, 230);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(45, 23);
            this.labelX5.TabIndex = 10;
            this.labelX5.Text = "הערות:";
            // 
            // comments
            // 
            this.comments.Location = new System.Drawing.Point(72, 232);
            this.comments.MaximumSize = new System.Drawing.Size(420, 80);
            this.comments.Multiline = true;
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(417, 72);
            this.comments.TabIndex = 11;
            // 
            // labelX6
            // 
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX6.Location = new System.Drawing.Point(23, 144);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(109, 23);
            this.labelX6.TabIndex = 12;
            this.labelX6.Text = "מחיר ליחידת משקל:";
            // 
            // price
            // 
            // 
            // 
            // 
            this.price.BackgroundStyle.Class = "DateTimeInputBackground";
            this.price.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.price.Increment = 1;
            this.price.Location = new System.Drawing.Point(173, 146);
            this.price.MinValue = 0;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(64, 20);
            this.price.TabIndex = 13;
            // 
            // labelX7
            // 
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX7.Location = new System.Drawing.Point(26, 174);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(113, 23);
            this.labelX7.TabIndex = 14;
            this.labelX7.Text = "אורך חיים בחודשים:";
            // 
            // lifeTime
            // 
            // 
            // 
            // 
            this.lifeTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.lifeTime.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.lifeTime.Increment = 1;
            this.lifeTime.Location = new System.Drawing.Point(174, 176);
            this.lifeTime.MinValue = 0;
            this.lifeTime.Name = "lifeTime";
            this.lifeTime.Size = new System.Drawing.Size(63, 20);
            this.lifeTime.TabIndex = 15;
            // 
            // AddNewPlant
            // 
            this.ClientSize = new System.Drawing.Size(694, 350);
            this.Controls.Add(this.lifeTime);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.price);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.comments);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.integerInput1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.foreignName);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "AddNewPlant";
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX foreignName;
        private DevComponents.DotNetBar.Controls.TextBoxX name;
        private DevComponents.Editors.IntegerInput integerInput1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.TextBox comments;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.DoubleInput price;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.Editors.DoubleInput lifeTime;
    }
}
