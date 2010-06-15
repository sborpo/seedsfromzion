namespace seedsfromzion.GUI.InventoryForms
{
    partial class FindPlant
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.comments = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.integerInput1 = new DevComponents.Editors.IntegerInput();
            this.unitstype = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.foreign = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.closeImage = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.autoCompleteList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(40, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "חיפוש צמח";
            // 
            // textBoxX1
            // 
            this.textBoxX1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxX1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX1.Location = new System.Drawing.Point(136, 12);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(299, 26);
            this.textBoxX1.TabIndex = 1;
            this.textBoxX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX1_KeyPress);
            this.textBoxX1.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonX1.Location = new System.Drawing.Point(459, 12);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 26);
            this.buttonX1.TabIndex = 2;
            this.buttonX1.Text = "חפש";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(29, 372);
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowTemplate.Height = 24;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(417, 128);
            this.dataGridViewX1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::seedsfromzion.Properties.Resources.image_missing;
            this.pictureBox1.Location = new System.Drawing.Point(22, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX2.Location = new System.Drawing.Point(606, 98);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(151, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "הערות:";
            // 
            // comments
            // 
            this.comments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comments.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.comments.Border.Class = "TextBoxBorder";
            this.comments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comments.Location = new System.Drawing.Point(313, 98);
            this.comments.Multiline = true;
            this.comments.Name = "comments";
            this.comments.ReadOnly = true;
            this.comments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.comments.Size = new System.Drawing.Size(267, 88);
            this.comments.TabIndex = 7;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.webBrowser1);
            this.groupPanel1.Controls.Add(this.integerInput1);
            this.groupPanel1.Controls.Add(this.unitstype);
            this.groupPanel1.Controls.Add(this.foreign);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.comments);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.pictureBox1);
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupPanel1.Location = new System.Drawing.Point(29, 53);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(813, 252);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColor = System.Drawing.Color.Navy;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 8;
            this.groupPanel1.Text = "פרטי הצמח";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(807, 225);
            this.webBrowser1.TabIndex = 10;
            // 
            // integerInput1
            // 
            this.integerInput1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.integerInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput1.Location = new System.Drawing.Point(493, 64);
            this.integerInput1.Name = "integerInput1";
            this.integerInput1.Size = new System.Drawing.Size(84, 26);
            this.integerInput1.TabIndex = 10;
            // 
            // unitstype
            // 
            this.unitstype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unitstype.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.unitstype.Border.Class = "TextBoxBorder";
            this.unitstype.ForeColor = System.Drawing.SystemColors.ControlText;
            this.unitstype.Location = new System.Drawing.Point(417, 37);
            this.unitstype.Name = "unitstype";
            this.unitstype.ReadOnly = true;
            this.unitstype.Size = new System.Drawing.Size(160, 26);
            this.unitstype.TabIndex = 9;
            // 
            // foreign
            // 
            this.foreign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.foreign.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.foreign.Border.Class = "TextBoxBorder";
            this.foreign.ForeColor = System.Drawing.SystemColors.ControlText;
            this.foreign.Location = new System.Drawing.Point(417, 11);
            this.foreign.Name = "foreign";
            this.foreign.ReadOnly = true;
            this.foreign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.foreign.Size = new System.Drawing.Size(160, 26);
            this.foreign.TabIndex = 8;
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX5.Location = new System.Drawing.Point(606, 69);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(151, 23);
            this.labelX5.TabIndex = 7;
            this.labelX5.Text = "כמות ביחידת משקל:";
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX4.Location = new System.Drawing.Point(606, 40);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(151, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "סוג היחידות:";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX3.Location = new System.Drawing.Point(606, 11);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(151, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "שם לועזי:";
            // 
            // closeImage
            // 
            this.closeImage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.closeImage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.closeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.closeImage.Location = new System.Drawing.Point(29, 321);
            this.closeImage.Name = "closeImage";
            this.closeImage.Size = new System.Drawing.Size(86, 33);
            this.closeImage.TabIndex = 11;
            this.closeImage.Text = "סגור תמונה";
            this.closeImage.Click += new System.EventHandler(this.closeImage_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX2.Location = new System.Drawing.Point(749, 321);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(90, 48);
            this.buttonX2.TabIndex = 9;
            this.buttonX2.Text = "ערוך";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // autoCompleteList
            // 
            this.autoCompleteList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoCompleteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.autoCompleteList.FormattingEnabled = true;
            this.autoCompleteList.ItemHeight = 20;
            this.autoCompleteList.Location = new System.Drawing.Point(137, 37);
            this.autoCompleteList.Name = "autoCompleteList";
            this.autoCompleteList.Size = new System.Drawing.Size(297, 102);
            this.autoCompleteList.TabIndex = 12;
            this.autoCompleteList.Visible = false;
            this.autoCompleteList.SelectedIndexChanged += new System.EventHandler(this.autoCompleteList_SelectedIndexChanged);
            // 
            // FindPlant
            // 
            this.ClientSize = new System.Drawing.Size(980, 592);
            this.Controls.Add(this.autoCompleteList);
            this.Controls.Add(this.closeImage);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "FindPlant";
            this.Load += new System.EventHandler(this.FindPlant_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindPlant_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX comments;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.IntegerInput integerInput1;
        private DevComponents.DotNetBar.Controls.TextBoxX unitstype;
        private DevComponents.DotNetBar.Controls.TextBoxX foreign;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private DevComponents.DotNetBar.ButtonX closeImage;
        private System.Windows.Forms.ListBox autoCompleteList;

    }
}
