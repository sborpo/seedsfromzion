namespace seedsfromzion.GUI.WorkerForms
{
    partial class PaymentsForm
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
            this.dataGrid_workers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.numericUpDowd_advancedPay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_postponedPay = new System.Windows.Forms.NumericUpDown();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateChoisePanel = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.btn_update = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_workers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowd_advancedPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_postponedPay)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.dateChoisePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_workers
            // 
            this.dataGrid_workers.AllowUserToAddRows = false;
            this.dataGrid_workers.AllowUserToDeleteRows = false;
            this.dataGrid_workers.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGrid_workers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_workers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_workers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGrid_workers.Location = new System.Drawing.Point(66, 24);
            this.dataGrid_workers.MultiSelect = false;
            this.dataGrid_workers.Name = "dataGrid_workers";
            this.dataGrid_workers.ReadOnly = true;
            this.dataGrid_workers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid_workers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_workers.Size = new System.Drawing.Size(386, 152);
            this.dataGrid_workers.TabIndex = 4;
            this.dataGrid_workers.SelectionChanged += new System.EventHandler(this.dataGrid_workers_SelectionChanged);
            // 
            // numericUpDowd_advancedPay
            // 
            this.numericUpDowd_advancedPay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDowd_advancedPay.DecimalPlaces = 1;
            this.numericUpDowd_advancedPay.Location = new System.Drawing.Point(3, 17);
            this.numericUpDowd_advancedPay.Name = "numericUpDowd_advancedPay";
            this.numericUpDowd_advancedPay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDowd_advancedPay.TabIndex = 5;
            // 
            // numericUpDown_postponedPay
            // 
            this.numericUpDown_postponedPay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDown_postponedPay.DecimalPlaces = 1;
            this.numericUpDown_postponedPay.Location = new System.Drawing.Point(3, 72);
            this.numericUpDown_postponedPay.Name = "numericUpDown_postponedPay";
            this.numericUpDown_postponedPay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_postponedPay.TabIndex = 6;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(171, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "מקדמה";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX2.Location = new System.Drawing.Point(171, 71);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "דחוי";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.74144F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.25855F));
            this.tableLayoutPanel1.Controls.Add(this.labelX1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_postponedPay, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDowd_advancedPay, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(261, 110);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // dateChoisePanel
            // 
            this.dateChoisePanel.AutoSize = true;
            this.dateChoisePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.dateChoisePanel.Controls.Add(this.tableLayoutPanel1);
            this.dateChoisePanel.Location = new System.Drawing.Point(470, 48);
            this.dateChoisePanel.Name = "dateChoisePanel";
            this.dateChoisePanel.Size = new System.Drawing.Size(261, 110);
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
            this.dateChoisePanel.TabIndex = 12;
            // 
            // btn_update
            // 
            this.btn_update.CanvasColor = System.Drawing.SystemColors.Control;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Location = new System.Drawing.Point(641, 174);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(87, 30);
            // 
            // 
            // 
            this.btn_update.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.btn_update.Style.BackColorGradientAngle = 90;
            this.btn_update.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.btn_update.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile;
            this.btn_update.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btn_update.Style.BorderBottomWidth = 1;
            this.btn_update.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.btn_update.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btn_update.Style.BorderLeftWidth = 1;
            this.btn_update.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btn_update.Style.BorderRightWidth = 1;
            this.btn_update.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btn_update.Style.BorderTopWidth = 1;
            this.btn_update.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.btn_update.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.btn_update.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            // 
            // 
            // 
            this.btn_update.StyleMouseDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.btn_update.StyleMouseDown.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btn_update.StyleMouseDown.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
            this.btn_update.StyleMouseDown.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.btn_update.StyleMouseDown.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
            // 
            // 
            // 
            this.btn_update.StyleMouseOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btn_update.StyleMouseOver.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.btn_update.StyleMouseOver.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
            this.btn_update.StyleMouseOver.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.btn_update.StyleMouseOver.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "עדכן";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // PaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 534);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dateChoisePanel);
            this.Controls.Add(this.dataGrid_workers);
            this.Name = "PaymentsForm";
            this.Text = "PaymentsForm";
            this.Load += new System.EventHandler(this.PaymentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_workers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowd_advancedPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_postponedPay)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.dateChoisePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGrid_workers;
        private System.Windows.Forms.NumericUpDown numericUpDowd_advancedPay;
        private System.Windows.Forms.NumericUpDown numericUpDown_postponedPay;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel dateChoisePanel;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel btn_update;
    }
}