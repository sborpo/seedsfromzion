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
            this.textBox_firstName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_lastName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.dateChoisePanel = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_comments = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.textBox_phone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_find = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.graphicSettingsPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.dateChoisePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.graphicSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            // 
            // 
            // 
            this.textBox_ID.Border.Class = "TextBoxBorder";
            this.textBox_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ID.Location = new System.Drawing.Point(4, 4);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(213, 28);
            this.textBox_ID.TabIndex = 0;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            // 
            // textBox_firstName
            // 
            // 
            // 
            // 
            this.textBox_firstName.Border.Class = "TextBoxBorder";
            this.textBox_firstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_firstName.Location = new System.Drawing.Point(4, 42);
            this.textBox_firstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(213, 28);
            this.textBox_firstName.TabIndex = 3;
            // 
            // textBox_lastName
            // 
            // 
            // 
            // 
            this.textBox_lastName.Border.Class = "TextBoxBorder";
            this.textBox_lastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_lastName.Location = new System.Drawing.Point(4, 81);
            this.textBox_lastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(213, 28);
            this.textBox_lastName.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.74144F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.25855F));
            this.tableLayoutPanel1.Controls.Add(this.labelX5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelX6, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelX5
            // 
            this.labelX5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX5.Location = new System.Drawing.Point(3, 58);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(65, 23);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "שם משפחה:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX6
            // 
            this.labelX6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(3, 3);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(65, 14);
            this.labelX6.TabIndex = 7;
            this.labelX6.Text = "ת.ז:";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX7
            // 
            this.labelX7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX7.Location = new System.Drawing.Point(342, 224);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 8;
            this.labelX7.Text = "שם פרטי:";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dateChoisePanel
            // 
            this.dateChoisePanel.AutoSize = true;
            this.dateChoisePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.dateChoisePanel.Controls.Add(this.tableLayoutPanel2);
            this.dateChoisePanel.Location = new System.Drawing.Point(86, 22);
            this.dateChoisePanel.Margin = new System.Windows.Forms.Padding(4);
            this.dateChoisePanel.Name = "dateChoisePanel";
            this.dateChoisePanel.Size = new System.Drawing.Size(343, 226);
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
            this.dateChoisePanel.TabIndex = 14;
            this.dateChoisePanel.Text = "הוספת עובד";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.74144F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.25855F));
            this.tableLayoutPanel2.Controls.Add(this.textBox_comments, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelX4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelX8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelX9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelX10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox_ID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_lastName, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox_firstName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelX11, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox_phone, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.20635F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.79365F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(343, 226);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // textBox_comments
            // 
            // 
            // 
            // 
            this.textBox_comments.Border.Class = "TextBoxBorder";
            this.textBox_comments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_comments.Location = new System.Drawing.Point(4, 177);
            this.textBox_comments.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_comments.Name = "textBox_comments";
            this.textBox_comments.Size = new System.Drawing.Size(213, 28);
            this.textBox_comments.TabIndex = 14;
            // 
            // labelX4
            // 
            this.labelX4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX4.Location = new System.Drawing.Point(225, 135);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(100, 28);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "טלפון:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX8
            // 
            this.labelX8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX8.Location = new System.Drawing.Point(225, 87);
            this.labelX8.Margin = new System.Windows.Forms.Padding(4);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(100, 28);
            this.labelX8.TabIndex = 9;
            this.labelX8.Text = "שם משפחה:";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX9
            // 
            this.labelX9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(225, 5);
            this.labelX9.Margin = new System.Windows.Forms.Padding(4);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(100, 28);
            this.labelX9.TabIndex = 7;
            this.labelX9.Text = "ת.ז:";
            this.labelX9.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX10
            // 
            this.labelX10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX10.Location = new System.Drawing.Point(225, 43);
            this.labelX10.Margin = new System.Windows.Forms.Padding(4);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(100, 28);
            this.labelX10.TabIndex = 8;
            this.labelX10.Text = "שם פרטי:";
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX11
            // 
            this.labelX11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX11.Location = new System.Drawing.Point(225, 185);
            this.labelX11.Margin = new System.Windows.Forms.Padding(4);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(100, 28);
            this.labelX11.TabIndex = 11;
            this.labelX11.Text = "הערות:";
            this.labelX11.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // textBox_phone
            // 
            // 
            // 
            // 
            this.textBox_phone.Border.Class = "TextBoxBorder";
            this.textBox_phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_phone.Location = new System.Drawing.Point(4, 129);
            this.textBox_phone.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(213, 28);
            this.textBox_phone.TabIndex = 13;
            // 
            // btn_find
            // 
            this.btn_find.CanvasColor = System.Drawing.SystemColors.Control;
            this.btn_find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_find.Location = new System.Drawing.Point(313, 284);
            this.btn_find.Margin = new System.Windows.Forms.Padding(4);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(116, 37);
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
            this.btn_find.TabIndex = 15;
            this.btn_find.Text = "הוסף";
            this.btn_find.Click += new System.EventHandler(this.btn_addWorker_Click);
            // 
            // graphicSettingsPanel
            // 
            this.graphicSettingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.graphicSettingsPanel.CanvasColor = System.Drawing.SystemColors.ActiveCaption;
            this.graphicSettingsPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.graphicSettingsPanel.Controls.Add(this.btn_find);
            this.graphicSettingsPanel.Controls.Add(this.dateChoisePanel);
            this.graphicSettingsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.graphicSettingsPanel.IsShadowEnabled = true;
            this.graphicSettingsPanel.Location = new System.Drawing.Point(12, 12);
            this.graphicSettingsPanel.Name = "graphicSettingsPanel";
            this.graphicSettingsPanel.ShowFocusRectangle = true;
            this.graphicSettingsPanel.Size = new System.Drawing.Size(512, 371);
            // 
            // 
            // 
            this.graphicSettingsPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.graphicSettingsPanel.Style.BackColorGradientAngle = 90;
            this.graphicSettingsPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.graphicSettingsPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.graphicSettingsPanel.Style.BorderBottomWidth = 1;
            this.graphicSettingsPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.graphicSettingsPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.graphicSettingsPanel.Style.BorderLeftWidth = 1;
            this.graphicSettingsPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.graphicSettingsPanel.Style.BorderRightWidth = 1;
            this.graphicSettingsPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.graphicSettingsPanel.Style.BorderTopWidth = 1;
            this.graphicSettingsPanel.Style.CornerDiameter = 4;
            this.graphicSettingsPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.graphicSettingsPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.graphicSettingsPanel.Style.TextColor = System.Drawing.Color.Navy;
            this.graphicSettingsPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.graphicSettingsPanel.TabIndex = 16;
            this.graphicSettingsPanel.Text = "הוספת עובד חדש";
            // 
            // AddWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 413);
            this.Controls.Add(this.graphicSettingsPanel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddWorkerForm";
            this.Text = "הוספת עובד חדש";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.dateChoisePanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.graphicSettingsPanel.ResumeLayout(false);
            this.graphicSettingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBox_ID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_firstName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_lastName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel dateChoisePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_comments;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_phone;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel btn_find;
        private DevComponents.DotNetBar.Controls.GroupPanel graphicSettingsPanel;
    }
}