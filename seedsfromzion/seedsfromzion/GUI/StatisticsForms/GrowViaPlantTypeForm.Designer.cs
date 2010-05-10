namespace seedsfromzion.GUI.StatisticsForms
{
    partial class GrowViaPlantTypeForm
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
            this.components = new System.ComponentModel.Container();
            this.GrowViaTypeGraphControl = new ZedGraph.ZedGraphControl();
            this.graphicSettingsPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.showGraphButton = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.plantChoisePanel = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.plantNameTextBox = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.plantNameLabel = new DevComponents.DotNetBar.LabelX();
            this.typeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.graphicSettingsPanel.SuspendLayout();
            this.plantChoisePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.typeTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrowViaTypeGraphControl
            // 
            this.GrowViaTypeGraphControl.AutoSize = true;
            this.GrowViaTypeGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrowViaTypeGraphControl.Location = new System.Drawing.Point(6, 6);
            this.GrowViaTypeGraphControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrowViaTypeGraphControl.Name = "GrowViaTypeGraphControl";
            this.GrowViaTypeGraphControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrowViaTypeGraphControl.ScrollGrace = 0;
            this.GrowViaTypeGraphControl.ScrollMaxX = 0;
            this.GrowViaTypeGraphControl.ScrollMaxY = 0;
            this.GrowViaTypeGraphControl.ScrollMaxY2 = 0;
            this.GrowViaTypeGraphControl.ScrollMinX = 0;
            this.GrowViaTypeGraphControl.ScrollMinY = 0;
            this.GrowViaTypeGraphControl.ScrollMinY2 = 0;
            this.GrowViaTypeGraphControl.Size = new System.Drawing.Size(538, 564);
            this.GrowViaTypeGraphControl.TabIndex = 4;
            this.GrowViaTypeGraphControl.Load += new System.EventHandler(this.GrowViaTypeGraphControl_Load);
            // 
            // graphicSettingsPanel
            // 
            this.graphicSettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.graphicSettingsPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.graphicSettingsPanel.CanvasColor = System.Drawing.SystemColors.ActiveCaption;
            this.graphicSettingsPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.graphicSettingsPanel.Controls.Add(this.showGraphButton);
            this.graphicSettingsPanel.Controls.Add(this.plantChoisePanel);
            this.graphicSettingsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.graphicSettingsPanel.IsShadowEnabled = true;
            this.graphicSettingsPanel.Location = new System.Drawing.Point(553, 5);
            this.graphicSettingsPanel.Name = "graphicSettingsPanel";
            this.graphicSettingsPanel.ShowFocusRectangle = true;
            this.graphicSettingsPanel.Size = new System.Drawing.Size(541, 566);
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
            this.graphicSettingsPanel.TabIndex = 6;
            this.graphicSettingsPanel.Text = "הגדרות גרף אחוזי הנביטה לפי סוג הצמח";
            // 
            // showGraphButton
            // 
            this.showGraphButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showGraphButton.CanvasColor = System.Drawing.SystemColors.Control;
            this.showGraphButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showGraphButton.Location = new System.Drawing.Point(317, 124);
            this.showGraphButton.Name = "showGraphButton";
            this.showGraphButton.Size = new System.Drawing.Size(149, 54);
            // 
            // 
            // 
            this.showGraphButton.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.showGraphButton.Style.BackColorGradientAngle = 90;
            this.showGraphButton.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.showGraphButton.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile;
            this.showGraphButton.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.showGraphButton.Style.BorderBottomWidth = 1;
            this.showGraphButton.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.showGraphButton.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.showGraphButton.Style.BorderLeftWidth = 1;
            this.showGraphButton.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.showGraphButton.Style.BorderRightWidth = 1;
            this.showGraphButton.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.showGraphButton.Style.BorderTopWidth = 1;
            this.showGraphButton.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.showGraphButton.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.showGraphButton.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            // 
            // 
            // 
            this.showGraphButton.StyleMouseDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.showGraphButton.StyleMouseDown.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.showGraphButton.StyleMouseDown.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
            this.showGraphButton.StyleMouseDown.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.showGraphButton.StyleMouseDown.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
            // 
            // 
            // 
            this.showGraphButton.StyleMouseOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.showGraphButton.StyleMouseOver.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.showGraphButton.StyleMouseOver.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
            this.showGraphButton.StyleMouseOver.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.showGraphButton.StyleMouseOver.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.showGraphButton.TabIndex = 17;
            this.showGraphButton.Text = "הצג גרף";
            // 
            // plantChoisePanel
            // 
            this.plantChoisePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.plantChoisePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.plantChoisePanel.Controls.Add(this.tableLayoutPanel1);
            this.plantChoisePanel.Location = new System.Drawing.Point(64, 30);
            this.plantChoisePanel.Name = "plantChoisePanel";
            this.plantChoisePanel.Size = new System.Drawing.Size(402, 64);
            // 
            // 
            // 
            this.plantChoisePanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.plantChoisePanel.Style.BackColorGradientAngle = 90;
            this.plantChoisePanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.plantChoisePanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.plantChoisePanel.Style.BorderBottomWidth = 1;
            this.plantChoisePanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.plantChoisePanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.plantChoisePanel.Style.BorderLeftWidth = 1;
            this.plantChoisePanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.plantChoisePanel.Style.BorderRightWidth = 1;
            this.plantChoisePanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.plantChoisePanel.Style.BorderTopWidth = 1;
            this.plantChoisePanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.plantChoisePanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.plantChoisePanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.plantChoisePanel.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.0854F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.9146F));
            this.tableLayoutPanel1.Controls.Add(this.plantNameTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.plantNameLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // plantNameTextBox
            // 
            this.plantNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // 
            // 
            this.plantNameTextBox.BackgroundStyle.Class = "TextBoxBorder";
            this.plantNameTextBox.ButtonClear.Visible = true;
            this.plantNameTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.plantNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plantNameTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.plantNameTextBox.Location = new System.Drawing.Point(61, 19);
            this.plantNameTextBox.Name = "plantNameTextBox";
            this.plantNameTextBox.PromptChar = '|';
            this.plantNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plantNameTextBox.Size = new System.Drawing.Size(189, 25);
            this.plantNameTextBox.TabIndex = 6;
            this.plantNameTextBox.Text = "";
            this.plantNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.plantNameTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.plantNameTextBox.WatermarkText = "     הכנס שם של צמח";
            // 
            // plantNameLabel
            // 
            this.plantNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.plantNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.plantNameLabel.BackgroundStyle.BorderBottomWidth = 1;
            this.plantNameLabel.BackgroundStyle.BorderLeftWidth = 1;
            this.plantNameLabel.BackgroundStyle.BorderRightWidth = 1;
            this.plantNameLabel.BackgroundStyle.BorderTopWidth = 1;
            this.plantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plantNameLabel.ForeColor = System.Drawing.Color.Black;
            this.plantNameLabel.Location = new System.Drawing.Point(281, 19);
            this.plantNameLabel.Name = "plantNameLabel";
            this.plantNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plantNameLabel.Size = new System.Drawing.Size(118, 25);
            this.plantNameLabel.TabIndex = 7;
            this.plantNameLabel.Text = "  שם הצמח:";
            this.plantNameLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // typeTableLayoutPanel
            // 
            this.typeTableLayoutPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.typeTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.typeTableLayoutPanel.ColumnCount = 2;
            this.typeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.typeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.typeTableLayoutPanel.Controls.Add(this.graphicSettingsPanel, 0, 0);
            this.typeTableLayoutPanel.Controls.Add(this.GrowViaTypeGraphControl, 0, 0);
            this.typeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.typeTableLayoutPanel.Name = "typeTableLayoutPanel";
            this.typeTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.typeTableLayoutPanel.RowCount = 1;
            this.typeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.typeTableLayoutPanel.Size = new System.Drawing.Size(1099, 576);
            this.typeTableLayoutPanel.TabIndex = 2;
            // 
            // GrowViaPlantTypeForm
            // 
            this.ClientSize = new System.Drawing.Size(1099, 576);
            this.Controls.Add(this.typeTableLayoutPanel);
            this.DoubleBuffered = true;
            this.Name = "GrowViaPlantTypeForm";
            this.Text = "PlantType";
            this.Load += new System.EventHandler(this.GrowViaPlantTypeForm_Load);
            this.graphicSettingsPanel.ResumeLayout(false);
            this.plantChoisePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.typeTableLayoutPanel.ResumeLayout(false);
            this.typeTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl GrowViaTypeGraphControl;
        private DevComponents.DotNetBar.Controls.GroupPanel graphicSettingsPanel;
        private System.Windows.Forms.TableLayoutPanel typeTableLayoutPanel;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel showGraphButton;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel plantChoisePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv plantNameTextBox;
        private DevComponents.DotNetBar.LabelX plantNameLabel;

    }
}
