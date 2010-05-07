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
            this.typeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GrowViaTypeGraphControl = new ZedGraph.ZedGraphControl();
            this.typeTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeTableLayoutPanel
            // 
            this.typeTableLayoutPanel.ColumnCount = 2;
            this.typeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.typeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.typeTableLayoutPanel.Controls.Add(this.GrowViaTypeGraphControl, 0, 0);
            this.typeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.typeTableLayoutPanel.Name = "typeTableLayoutPanel";
            this.typeTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.typeTableLayoutPanel.RowCount = 1;
            this.typeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.typeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.typeTableLayoutPanel.Size = new System.Drawing.Size(792, 535);
            this.typeTableLayoutPanel.TabIndex = 2;
            // 
            // GrowViaTypeGraphControl
            // 
            this.GrowViaTypeGraphControl.AutoSize = true;
            this.GrowViaTypeGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrowViaTypeGraphControl.Location = new System.Drawing.Point(4, 4);
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
            this.GrowViaTypeGraphControl.Size = new System.Drawing.Size(388, 527);
            this.GrowViaTypeGraphControl.TabIndex = 4;
            this.GrowViaTypeGraphControl.Load += new System.EventHandler(this.GrowViaTypeGraphControl_Load);
            // 
            // GrowViaPlantTypeForm
            // 
            this.ClientSize = new System.Drawing.Size(792, 535);
            this.Controls.Add(this.typeTableLayoutPanel);
            this.DoubleBuffered = true;
            this.Name = "GrowViaPlantTypeForm";
            this.Load += new System.EventHandler(this.GrowViaPlantTypeForm_Load);
            this.typeTableLayoutPanel.ResumeLayout(false);
            this.typeTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel typeTableLayoutPanel;
        private ZedGraph.ZedGraphControl GrowViaTypeGraphControl;
    }
}
