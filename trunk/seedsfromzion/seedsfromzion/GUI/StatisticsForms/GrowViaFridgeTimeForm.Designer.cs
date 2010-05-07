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
            this.GrowViaFridgeGraphControl = new ZedGraph.ZedGraphControl();
            this.fridgeTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fridgeTableLayoutPanel
            // 
            this.fridgeTableLayoutPanel.ColumnCount = 2;
            this.fridgeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fridgeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fridgeTableLayoutPanel.Controls.Add(this.GrowViaFridgeGraphControl, 0, 0);
            this.fridgeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fridgeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.fridgeTableLayoutPanel.Name = "fridgeTableLayoutPanel";
            this.fridgeTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fridgeTableLayoutPanel.RowCount = 1;
            this.fridgeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fridgeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fridgeTableLayoutPanel.Size = new System.Drawing.Size(734, 482);
            this.fridgeTableLayoutPanel.TabIndex = 3;
            // 
            // GrowViaFridgeGraphControl
            // 
            this.GrowViaFridgeGraphControl.AutoSize = true;
            this.GrowViaFridgeGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrowViaFridgeGraphControl.Location = new System.Drawing.Point(4, 4);
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
            this.GrowViaFridgeGraphControl.Size = new System.Drawing.Size(359, 474);
            this.GrowViaFridgeGraphControl.TabIndex = 4;
            this.GrowViaFridgeGraphControl.Load += new System.EventHandler(this.GrowViaFridgeGraphControl_Load);
            // 
            // GrowViaFridgeTime
            // 
            this.ClientSize = new System.Drawing.Size(734, 482);
            this.Controls.Add(this.fridgeTableLayoutPanel);
            this.DoubleBuffered = true;
            this.Name = "GrowViaFridgeTime";
            this.Load += new System.EventHandler(this.GrowViaFridgeTime_Load);
            this.fridgeTableLayoutPanel.ResumeLayout(false);
            this.fridgeTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel fridgeTableLayoutPanel;
        private ZedGraph.ZedGraphControl GrowViaFridgeGraphControl;
    }
}
