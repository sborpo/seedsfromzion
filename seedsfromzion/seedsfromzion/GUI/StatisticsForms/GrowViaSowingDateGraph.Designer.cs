namespace seedsfromzion.GUI.StatisticsForms
{
    partial class GrowViaSowingDateGraph
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
            this.sowTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GrowViaSowGraphControl = new ZedGraph.ZedGraphControl();
            this.sowTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sowTableLayoutPanel
            // 
            this.sowTableLayoutPanel.ColumnCount = 2;
            this.sowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sowTableLayoutPanel.Controls.Add(this.GrowViaSowGraphControl, 0, 0);
            this.sowTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sowTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.sowTableLayoutPanel.Name = "sowTableLayoutPanel";
            this.sowTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sowTableLayoutPanel.RowCount = 1;
            this.sowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.sowTableLayoutPanel.Size = new System.Drawing.Size(656, 402);
            this.sowTableLayoutPanel.TabIndex = 1;
            // 
            // GrowViaSowGraphControl
            // 
            this.GrowViaSowGraphControl.AutoSize = true;
            this.GrowViaSowGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrowViaSowGraphControl.Location = new System.Drawing.Point(4, 4);
            this.GrowViaSowGraphControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrowViaSowGraphControl.Name = "GrowViaSowGraphControl";
            this.GrowViaSowGraphControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrowViaSowGraphControl.ScrollGrace = 0;
            this.GrowViaSowGraphControl.ScrollMaxX = 0;
            this.GrowViaSowGraphControl.ScrollMaxY = 0;
            this.GrowViaSowGraphControl.ScrollMaxY2 = 0;
            this.GrowViaSowGraphControl.ScrollMinX = 0;
            this.GrowViaSowGraphControl.ScrollMinY = 0;
            this.GrowViaSowGraphControl.ScrollMinY2 = 0;
            this.GrowViaSowGraphControl.Size = new System.Drawing.Size(320, 394);
            this.GrowViaSowGraphControl.TabIndex = 4;
            this.GrowViaSowGraphControl.Load += new System.EventHandler(this.GrowViaSowGraphControl_Load);
            // 
            // GrowViaSowingDateGraph
            // 
            this.ClientSize = new System.Drawing.Size(656, 402);
            this.Controls.Add(this.sowTableLayoutPanel);
            this.DoubleBuffered = true;
            this.Name = "GrowViaSowingDateGraph";
            this.Text = "SalesViaSowingDateGraph";
            this.Load += new System.EventHandler(this.GrowViaSowingDateGraph_Load);
            this.sowTableLayoutPanel.ResumeLayout(false);
            this.sowTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel sowTableLayoutPanel;
        private ZedGraph.ZedGraphControl GrowViaSowGraphControl;
    }
}
