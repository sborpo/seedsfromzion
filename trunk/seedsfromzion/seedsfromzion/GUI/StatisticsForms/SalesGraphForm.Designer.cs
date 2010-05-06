namespace seedsfromzion.GUI.StatisticsForms
{
    partial class SalesGraphFrom
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
            this.salesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.salesGraphControl = new ZedGraph.ZedGraphControl();
            this.salesTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesTableLayoutPanel
            // 
            this.salesTableLayoutPanel.ColumnCount = 2;
            this.salesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.salesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.salesTableLayoutPanel.Controls.Add(this.salesGraphControl, 0, 0);
            this.salesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.salesTableLayoutPanel.Name = "salesTableLayoutPanel";
            this.salesTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.salesTableLayoutPanel.RowCount = 1;
            this.salesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.salesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.salesTableLayoutPanel.Size = new System.Drawing.Size(659, 437);
            this.salesTableLayoutPanel.TabIndex = 0;
            // 
            // salesGraphControl
            // 
            this.salesGraphControl.AutoSize = true;
            this.salesGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesGraphControl.Location = new System.Drawing.Point(4, 4);
            this.salesGraphControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salesGraphControl.Name = "salesGraphControl";
            this.salesGraphControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.salesGraphControl.ScrollGrace = 0;
            this.salesGraphControl.ScrollMaxX = 0;
            this.salesGraphControl.ScrollMaxY = 0;
            this.salesGraphControl.ScrollMaxY2 = 0;
            this.salesGraphControl.ScrollMinX = 0;
            this.salesGraphControl.ScrollMinY = 0;
            this.salesGraphControl.ScrollMinY2 = 0;
            this.salesGraphControl.Size = new System.Drawing.Size(321, 429);
            this.salesGraphControl.TabIndex = 4;
            // 
            // SalesGraphFrom
            // 
            this.ClientSize = new System.Drawing.Size(659, 437);
            this.Controls.Add(this.salesTableLayoutPanel);
            this.DoubleBuffered = true;
            this.Name = "SalesGraphFrom";
            this.Text = "SalesGraphFrom";
            this.Load += new System.EventHandler(this.SalesGraphFrom_Load);
            this.salesTableLayoutPanel.ResumeLayout(false);
            this.salesTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel salesTableLayoutPanel;
        private ZedGraph.ZedGraphControl salesGraphControl;

    }
}
