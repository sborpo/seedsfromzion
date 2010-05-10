﻿

namespace seedsfromzion.GUI.StatisticsForms
{
    partial class GrowViaFridgeTimeForm
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
            this.fridgeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.graphicSettingsPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.showGraphButton = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.plantChoisePanel = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.isChosenTypeCHBX = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.plantNameTextBox = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.plantNameLabel = new DevComponents.DotNetBar.LabelX();
            this.plantTypeDropText = new DevComponents.DotNetBar.Controls.TextBoxDropDown();
            this.planrTypeLabel = new DevComponents.DotNetBar.LabelX();
            this.GrowViaFridgeGraphControl = new ZedGraph.ZedGraphControl();
            this.fridgeTableLayoutPanel.SuspendLayout();
            this.graphicSettingsPanel.SuspendLayout();
            this.plantChoisePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fridgeTableLayoutPanel
            // 
            this.fridgeTableLayoutPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.fridgeTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.fridgeTableLayoutPanel.ColumnCount = 2;
            this.fridgeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fridgeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fridgeTableLayoutPanel.Controls.Add(this.graphicSettingsPanel, 0, 0);
            this.fridgeTableLayoutPanel.Controls.Add(this.GrowViaFridgeGraphControl, 0, 0);
            this.fridgeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fridgeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.fridgeTableLayoutPanel.Name = "fridgeTableLayoutPanel";
            this.fridgeTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fridgeTableLayoutPanel.RowCount = 1;
            this.fridgeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fridgeTableLayoutPanel.Size = new System.Drawing.Size(1065, 580);
            this.fridgeTableLayoutPanel.TabIndex = 3;
            // 
            // graphicSettingsPanel
            // 
            this.graphicSettingsPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.graphicSettingsPanel.CanvasColor = System.Drawing.SystemColors.ActiveCaption;
            this.graphicSettingsPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.graphicSettingsPanel.Controls.Add(this.showGraphButton);
            this.graphicSettingsPanel.Controls.Add(this.plantChoisePanel);
            this.graphicSettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicSettingsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.graphicSettingsPanel.IsShadowEnabled = true;
            this.graphicSettingsPanel.Location = new System.Drawing.Point(536, 5);
            this.graphicSettingsPanel.Name = "graphicSettingsPanel";
            this.graphicSettingsPanel.ShowFocusRectangle = true;
            this.graphicSettingsPanel.Size = new System.Drawing.Size(524, 570);
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
            this.graphicSettingsPanel.TabIndex = 7;
            this.graphicSettingsPanel.Text = "הגדרות גרף אחוזי הנביטה לפי זמן שהיה במקרר";
            // 
            // showGraphButton
            // 
            this.showGraphButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showGraphButton.CanvasColor = System.Drawing.SystemColors.Control;
            this.showGraphButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showGraphButton.Location = new System.Drawing.Point(322, 204);
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
            this.showGraphButton.TabIndex = 15;
            this.showGraphButton.Text = "הצג גרף";
            // 
            // plantChoisePanel
            // 
            this.plantChoisePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.plantChoisePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.plantChoisePanel.Controls.Add(this.tableLayoutPanel1);
            this.plantChoisePanel.Location = new System.Drawing.Point(40, 30);
            this.plantChoisePanel.Name = "plantChoisePanel";
            this.plantChoisePanel.Size = new System.Drawing.Size(431, 142);
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
            this.plantChoisePanel.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.0854F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.9146F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.isChosenTypeCHBX, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.plantNameTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.plantNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.plantTypeDropText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.planrTypeLabel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 142);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // isChosenTypeCHBX
            // 
            this.isChosenTypeCHBX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.isChosenTypeCHBX.BackColor = System.Drawing.Color.Transparent;
            this.isChosenTypeCHBX.Checked = true;
            this.isChosenTypeCHBX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isChosenTypeCHBX.CheckValue = "Y";
            this.isChosenTypeCHBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.isChosenTypeCHBX.Location = new System.Drawing.Point(406, 74);
            this.isChosenTypeCHBX.Name = "isChosenTypeCHBX";
            this.isChosenTypeCHBX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.isChosenTypeCHBX.Size = new System.Drawing.Size(22, 65);
            this.isChosenTypeCHBX.TabIndex = 12;
            this.isChosenTypeCHBX.Text = " ";
            this.isChosenTypeCHBX.CheckedChanged += new System.EventHandler(this.isChosenTypeCHBX_CheckedChanged);
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
            this.plantNameTextBox.Location = new System.Drawing.Point(62, 23);
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
            this.plantNameLabel.Location = new System.Drawing.Point(284, 23);
            this.plantNameLabel.Name = "plantNameLabel";
            this.plantNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plantNameLabel.Size = new System.Drawing.Size(116, 25);
            this.plantNameLabel.TabIndex = 7;
            this.plantNameLabel.Text = "  שם הצמח:";
            this.plantNameLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // plantTypeDropText
            // 
            this.plantTypeDropText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.plantTypeDropText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.plantTypeDropText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            // 
            // 
            // 
            this.plantTypeDropText.BackgroundStyle.Class = "TextBoxBorder";
            this.plantTypeDropText.ButtonDropDown.Visible = true;
            this.plantTypeDropText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.plantTypeDropText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plantTypeDropText.Location = new System.Drawing.Point(62, 94);
            this.plantTypeDropText.Name = "plantTypeDropText";
            this.plantTypeDropText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plantTypeDropText.Size = new System.Drawing.Size(189, 25);
            this.plantTypeDropText.TabIndex = 9;
            this.plantTypeDropText.Text = "";
            this.plantTypeDropText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.plantTypeDropText.WatermarkText = "הכנס סוג של צמח";
            // 
            // planrTypeLabel
            // 
            this.planrTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.planrTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.planrTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.planrTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.planrTypeLabel.Location = new System.Drawing.Point(284, 93);
            this.planrTypeLabel.Name = "planrTypeLabel";
            this.planrTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.planrTypeLabel.Size = new System.Drawing.Size(116, 26);
            this.planrTypeLabel.TabIndex = 8;
            this.planrTypeLabel.Text = "  סוג הצמח:";
            this.planrTypeLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // GrowViaFridgeGraphControl
            // 
            this.GrowViaFridgeGraphControl.AutoSize = true;
            this.GrowViaFridgeGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrowViaFridgeGraphControl.Location = new System.Drawing.Point(6, 6);
            this.GrowViaFridgeGraphControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrowViaFridgeGraphControl.Name = "GrowViaFridgeGraphControl";
            this.GrowViaFridgeGraphControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrowViaFridgeGraphControl.ScrollGrace = 0;
            this.GrowViaFridgeGraphControl.ScrollMaxX = 0;
            this.GrowViaFridgeGraphControl.ScrollMaxY = 0;
            this.GrowViaFridgeGraphControl.ScrollMaxY2 = 0;
            this.GrowViaFridgeGraphControl.ScrollMinX = 0;
            this.GrowViaFridgeGraphControl.ScrollMinY = 0;
            this.GrowViaFridgeGraphControl.ScrollMinY2 = 0;
            this.GrowViaFridgeGraphControl.Size = new System.Drawing.Size(521, 568);
            this.GrowViaFridgeGraphControl.TabIndex = 4;
            this.GrowViaFridgeGraphControl.Load += new System.EventHandler(this.GrowViaFridgeGraphControl_Load);
            // 
            // GrowViaFridgeTimeForm
            // 
            this.ClientSize = new System.Drawing.Size(1065, 580);
            this.Controls.Add(this.fridgeTableLayoutPanel);
            this.DoubleBuffered = true;
            this.Name = "GrowViaFridgeTimeForm";
            this.Text = "FridgeTime";
            this.Load += new System.EventHandler(this.GrowViaFridgeTime_Load);
            this.fridgeTableLayoutPanel.ResumeLayout(false);
            this.fridgeTableLayoutPanel.PerformLayout();
            this.graphicSettingsPanel.ResumeLayout(false);
            this.plantChoisePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel fridgeTableLayoutPanel;
        private ZedGraph.ZedGraphControl GrowViaFridgeGraphControl;
        private DevComponents.DotNetBar.Controls.GroupPanel graphicSettingsPanel;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel showGraphButton;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel plantChoisePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.CheckBoxX isChosenTypeCHBX;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv plantNameTextBox;
        private DevComponents.DotNetBar.LabelX plantNameLabel;
        private DevComponents.DotNetBar.Controls.TextBoxDropDown plantTypeDropText;
        private DevComponents.DotNetBar.LabelX planrTypeLabel;
    }
}
