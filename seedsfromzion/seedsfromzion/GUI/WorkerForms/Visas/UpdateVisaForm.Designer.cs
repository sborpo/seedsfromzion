﻿namespace seedsfromzion.GUI.WorkerForms
{
    partial class UpdateVisaForm
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBox_ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_contact = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimeInput = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btn_Add = new DevComponents.DotNetBar.ButtonX();
            this.btn_cancel = new DevComponents.DotNetBar.ButtonX();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.53489F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.46511F));
            this.tableLayoutPanel1.Controls.Add(this.labelX2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelX3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_ID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_contact, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimeInput, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 169);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX2.Location = new System.Drawing.Point(226, 53);
            this.labelX2.Margin = new System.Windows.Forms.Padding(5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(133, 38);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "איש קשר:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX3.Location = new System.Drawing.Point(226, 5);
            this.labelX3.Margin = new System.Windows.Forms.Padding(5);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(133, 38);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "מספר מזהה:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX1.Location = new System.Drawing.Point(226, 101);
            this.labelX1.Margin = new System.Windows.Forms.Padding(5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(133, 63);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "תאריך תפוגה:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.textBox_ID.Border.Class = "TextBoxBorder";
            this.textBox_ID.Enabled = false;
            this.textBox_ID.Location = new System.Drawing.Point(28, 11);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(188, 26);
            this.textBox_ID.TabIndex = 3;
            // 
            // textBox_contact
            // 
            this.textBox_contact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.textBox_contact.Border.Class = "TextBoxBorder";
            this.textBox_contact.Location = new System.Drawing.Point(28, 59);
            this.textBox_contact.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(188, 26);
            this.textBox_contact.TabIndex = 4;
            // 
            // dateTimeInput
            // 
            this.dateTimeInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.dateTimeInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput.ButtonDropDown.Visible = true;
            this.dateTimeInput.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Right;
            this.dateTimeInput.Location = new System.Drawing.Point(28, 119);
            this.dateTimeInput.Margin = new System.Windows.Forms.Padding(5);
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
            this.dateTimeInput.Size = new System.Drawing.Size(188, 26);
            this.dateTimeInput.TabIndex = 5;
            // 
            // btn_Add
            // 
            this.btn_Add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Add.Location = new System.Drawing.Point(230, 188);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(81, 54);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "עדכן";
            this.btn_Add.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_cancel.Location = new System.Drawing.Point(75, 188);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(76, 54);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "בטל";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // UpdateVisaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(373, 247);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateVisaForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "עדכן אשרה";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_ID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_contact;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput;
        private DevComponents.DotNetBar.ButtonX btn_Add;
        private DevComponents.DotNetBar.ButtonX btn_cancel;
    }
}