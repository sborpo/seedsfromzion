namespace seedsfromzion.GUI.WorkerForms
{
    partial class AddVisaForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tillDateLabel = new DevComponents.DotNetBar.LabelX();
            this.tillDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.textBox_ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_contact = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimeInput = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btn_Add = new DevComponents.DotNetBar.ButtonX();
            this.btn_cancel = new DevComponents.DotNetBar.ButtonX();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tillDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.80282F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.19718F));
            this.tableLayoutPanel1.Controls.Add(this.labelX2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelX3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_ID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_contact, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimeInput, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 141);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Location = new System.Drawing.Point(238, 97);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(114, 41);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "תאריך תפוגה:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.33504F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.66496F));
            this.tableLayoutPanel2.Controls.Add(this.tillDateLabel, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tillDateLabel
            // 
            this.tillDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tillDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.tillDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tillDateLabel.ForeColor = System.Drawing.Color.Black;
            this.tillDateLabel.Location = new System.Drawing.Point(121, 37);
            this.tillDateLabel.Name = "tillDateLabel";
            this.tillDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tillDateLabel.Size = new System.Drawing.Size(76, 25);
            this.tillDateLabel.TabIndex = 8;
            this.tillDateLabel.Text = "עד תאריך:";
            this.tillDateLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tillDate
            // 
            this.tillDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // 
            // 
            this.tillDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.tillDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.tillDate.ButtonDropDown.Visible = true;
            this.tillDate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Right;
            this.tillDate.Location = new System.Drawing.Point(254, 82);
            // 
            // 
            // 
            this.tillDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.tillDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.tillDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.tillDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.tillDate.MonthCalendar.DisplayMonth = new System.DateTime(2010, 5, 1, 0, 0, 0, 0);
            this.tillDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.tillDate.MonthCalendar.MaxSelectionCount = 1;
            this.tillDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.tillDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.tillDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.tillDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.tillDate.MonthCalendar.TodayButtonVisible = true;
            this.tillDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.tillDate.Name = "tillDate";
            this.tillDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tillDate.Size = new System.Drawing.Size(192, 20);
            this.tillDate.TabIndex = 7;
            // 
            // labelX2
            // 
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX2.Location = new System.Drawing.Point(238, 50);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(114, 41);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "איש קשר:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX3.Location = new System.Drawing.Point(238, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(114, 41);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "מספר מזהה:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // textBox_ID
            // 
            // 
            // 
            // 
            this.textBox_ID.Border.Class = "TextBoxBorder";
            this.textBox_ID.Location = new System.Drawing.Point(83, 3);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(149, 20);
            this.textBox_ID.TabIndex = 3;
            // 
            // textBox_contact
            // 
            // 
            // 
            // 
            this.textBox_contact.Border.Class = "TextBoxBorder";
            this.textBox_contact.Location = new System.Drawing.Point(83, 50);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(149, 20);
            this.textBox_contact.TabIndex = 4;
            // 
            // dateTimeInput
            // 
            // 
            // 
            // 
            this.dateTimeInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput.ButtonDropDown.Visible = true;
            this.dateTimeInput.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Right;
            this.dateTimeInput.Location = new System.Drawing.Point(83, 97);
            // 
            // 
            // 
            this.dateTimeInput.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateTimeInput.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput.MonthCalendar.DisplayMonth = new System.DateTime(2010, 5, 1, 0, 0, 0, 0);
            this.dateTimeInput.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput.Name = "dateTimeInput";
            this.dateTimeInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimeInput.Size = new System.Drawing.Size(149, 20);
            this.dateTimeInput.TabIndex = 5;
            // 
            // btn_Add
            // 
            this.btn_Add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Add.Location = new System.Drawing.Point(330, 213);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(49, 35);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "הוסף";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancel.Location = new System.Drawing.Point(262, 213);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(46, 35);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "בטל";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // AddVisaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 294);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "AddVisaForm";
            this.Text = "AddVisaForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tillDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.LabelX tillDateLabel;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput tillDate;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_ID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_contact;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput;
        private DevComponents.DotNetBar.ButtonX btn_Add;
        private DevComponents.DotNetBar.ButtonX btn_cancel;
    }
}