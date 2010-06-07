namespace seedsfromzion.GUI.InventoryForms
{
    partial class UpdateSproutingForm
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
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.doubleInput1 = new DevComponents.Editors.DoubleInput();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.addPlantTypePanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput1)).BeginInit();
            this.addPlantTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(34, 15);
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowTemplate.Height = 24;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(544, 265);
            this.dataGridViewX1.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(484, 312);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(94, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "אחוז הנביטה:";
            // 
            // doubleInput1
            // 
            this.doubleInput1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.doubleInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInput1.Increment = 1;
            this.doubleInput1.Location = new System.Drawing.Point(379, 312);
            this.doubleInput1.MaxValue = 100;
            this.doubleInput1.MinValue = 0;
            this.doubleInput1.Name = "doubleInput1";
            this.doubleInput1.ShowUpDown = true;
            this.doubleInput1.Size = new System.Drawing.Size(80, 26);
            this.doubleInput1.TabIndex = 3;
            this.doubleInput1.Value = 50;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonX1.Location = new System.Drawing.Point(46, 297);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(86, 41);
            this.buttonX1.TabIndex = 4;
            this.buttonX1.Text = "עדכן";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // addPlantTypePanel
            // 
            this.addPlantTypePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.addPlantTypePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.addPlantTypePanel.Controls.Add(this.dataGridViewX1);
            this.addPlantTypePanel.Controls.Add(this.buttonX1);
            this.addPlantTypePanel.Controls.Add(this.labelX2);
            this.addPlantTypePanel.Controls.Add(this.doubleInput1);
            this.addPlantTypePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addPlantTypePanel.Location = new System.Drawing.Point(21, 12);
            this.addPlantTypePanel.Name = "addPlantTypePanel";
            this.addPlantTypePanel.Size = new System.Drawing.Size(622, 447);
            // 
            // 
            // 
            this.addPlantTypePanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.addPlantTypePanel.Style.BackColorGradientAngle = 90;
            this.addPlantTypePanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.addPlantTypePanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.addPlantTypePanel.Style.BorderBottomWidth = 1;
            this.addPlantTypePanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.addPlantTypePanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.addPlantTypePanel.Style.BorderLeftWidth = 1;
            this.addPlantTypePanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.addPlantTypePanel.Style.BorderRightWidth = 1;
            this.addPlantTypePanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.addPlantTypePanel.Style.BorderTopWidth = 1;
            this.addPlantTypePanel.Style.CornerDiameter = 4;
            this.addPlantTypePanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.addPlantTypePanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.addPlantTypePanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.addPlantTypePanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.addPlantTypePanel.TabIndex = 20;
            this.addPlantTypePanel.Text = "איסופים שעבורם לא נרשמו אחוזי נביטה";
            // 
            // UpdateSproutingForm
            // 
            this.ClientSize = new System.Drawing.Size(682, 480);
            this.Controls.Add(this.addPlantTypePanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "UpdateSproutingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput1)).EndInit();
            this.addPlantTypePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.DoubleInput doubleInput1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.GroupPanel addPlantTypePanel;
    }
}
