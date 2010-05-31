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
            this.textBox_ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridWorkers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dateChoisePanel = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.textBox_firstName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_lastName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_find = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.btn_showAll = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkers)).BeginInit();
            this.dateChoisePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            this.textBox_ID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // 
            // 
            this.textBox_ID.Border.Class = "TextBoxBorder";
            this.textBox_ID.Location = new System.Drawing.Point(3, 10);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(162, 20);
            this.textBox_ID.TabIndex = 1;
            // 
            // dataGridWorkers
            // 
            this.dataGridWorkers.AllowUserToAddRows = false;
            this.dataGridWorkers.AllowUserToDeleteRows = false;
            this.dataGridWorkers.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridWorkers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridWorkers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridWorkers.Location = new System.Drawing.Point(49, 180);
            this.dataGridWorkers.MultiSelect = false;
            this.dataGridWorkers.Name = "dataGridWorkers";
            this.dataGridWorkers.ReadOnly = true;
            this.dataGridWorkers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWorkers.Size = new System.Drawing.Size(414, 240);
            this.dataGridWorkers.TabIndex = 5;
            // 
            // dateChoisePanel
            // 
            this.dateChoisePanel.AutoSize = true;
            this.dateChoisePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.dateChoisePanel.Controls.Add(this.tableLayoutPanel1);
            this.dateChoisePanel.Location = new System.Drawing.Point(49, 29);
            this.dateChoisePanel.Name = "dateChoisePanel";
            this.dateChoisePanel.Size = new System.Drawing.Size(261, 120);
            // 
            // 
            // 
            this.dateChoisePanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateChoisePanel.Style.BackColorGradientAngle = 90;
            this.dateChoisePanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateChoisePanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateChoisePanel.Style.BorderBottomWidth = 1;
            this.dateChoisePanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.dateChoisePanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateChoisePanel.Style.BorderLeftWidth = 1;
            this.dateChoisePanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateChoisePanel.Style.BorderRightWidth = 1;
            this.dateChoisePanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateChoisePanel.Style.BorderTopWidth = 1;
            this.dateChoisePanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.dateChoisePanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.dateChoisePanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.dateChoisePanel.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.74144F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.25855F));
            this.tableLayoutPanel1.Controls.Add(this.labelX1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelX2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_ID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_firstName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_lastName, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(261, 120);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX1.Location = new System.Drawing.Point(171, 88);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "שם משפחה:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(171, 8);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "ת.ז:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            this.labelX3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX3.Location = new System.Drawing.Point(171, 48);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "שם פרטי:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // 
            // 
            this.textBox_firstName.Border.Class = "TextBoxBorder";
            this.textBox_firstName.Location = new System.Drawing.Point(3, 50);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(162, 20);
            this.textBox_firstName.TabIndex = 10;
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // 
            // 
            this.textBox_lastName.Border.Class = "TextBoxBorder";
            this.textBox_lastName.Location = new System.Drawing.Point(3, 90);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(162, 20);
            this.textBox_lastName.TabIndex = 11;
            // 
            // btn_find
            // 
            this.btn_find.CanvasColor = System.Drawing.SystemColors.Control;
            this.btn_find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_find.Location = new System.Drawing.Point(341, 117);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(87, 30);
            // 
            // 
            // 
            this.btn_find.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.btn_find.Style.BackColorGradientAngle = 90;
            this.btn_find.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.btn_find.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile;
            this.btn_find.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btn_find.Style.BorderBottomWidth = 1;
            this.btn_find.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.btn_find.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btn_find.Style.BorderLeftWidth = 1;
            this.btn_find.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btn_find.Style.BorderRightWidth = 1;
            this.btn_find.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btn_find.Style.BorderTopWidth = 1;
            this.btn_find.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.btn_find.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.btn_find.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            // 
            // 
            // 
            this.btn_find.StyleMouseDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.btn_find.StyleMouseDown.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btn_find.StyleMouseDown.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
            this.btn_find.StyleMouseDown.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.btn_find.StyleMouseDown.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
            // 
            // 
            // 
            this.btn_find.StyleMouseOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btn_find.StyleMouseOver.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.btn_find.StyleMouseOver.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
            this.btn_find.StyleMouseOver.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.btn_find.StyleMouseOver.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.btn_find.TabIndex = 14;
            this.btn_find.Text = "מצא";
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_showAll
            // 
            this.btn_showAll.CanvasColor = System.Drawing.SystemColors.Control;
            this.btn_showAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showAll.Location = new System.Drawing.Point(457, 119);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(87, 30);
            // 
            // 
            // 
            this.btn_showAll.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.btn_showAll.Style.BackColorGradientAngle = 90;
            this.btn_showAll.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.btn_showAll.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile;
            this.btn_showAll.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btn_showAll.Style.BorderBottomWidth = 1;
            this.btn_showAll.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.btn_showAll.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btn_showAll.Style.BorderLeftWidth = 1;
            this.btn_showAll.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btn_showAll.Style.BorderRightWidth = 1;
            this.btn_showAll.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btn_showAll.Style.BorderTopWidth = 1;
            this.btn_showAll.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.btn_showAll.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.btn_showAll.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            // 
            // 
            // 
            this.btn_showAll.StyleMouseDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.btn_showAll.StyleMouseDown.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btn_showAll.StyleMouseDown.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
            this.btn_showAll.StyleMouseDown.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.btn_showAll.StyleMouseDown.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
            // 
            // 
            // 
            this.btn_showAll.StyleMouseOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btn_showAll.StyleMouseOver.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.btn_showAll.StyleMouseOver.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
            this.btn_showAll.StyleMouseOver.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.btn_showAll.StyleMouseOver.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.btn_showAll.TabIndex = 15;
            this.btn_showAll.Text = "הצג הכל";
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // FindWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 473);
            this.Controls.Add(this.btn_showAll);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.dateChoisePanel);
            this.Controls.Add(this.dataGridWorkers);
            this.DoubleBuffered = true;
            this.Name = "FindWorkerForm";
            this.Text = "חפש עובד";
            this.Load += new System.EventHandler(this.FindWorkerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkers)).EndInit();
            this.dateChoisePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBox_ID;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridWorkers;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel dateChoisePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_firstName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_lastName;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel btn_find;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel btn_showAll;
    }
}