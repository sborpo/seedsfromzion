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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.salesGraphControl = new ZedGraph.ZedGraphControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.salesGraphControl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 437);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // salesGraphControl
            // 
            this.salesGraphControl.AutoSize = true;
            this.salesGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesGraphControl.Location = new System.Drawing.Point(4, 4);
            this.salesGraphControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salesGraphControl.Name = "salesGraphControl";
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
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "SalesGraphFrom";
            this.Text = "SalesGraphFrom";
            this.Load += new System.EventHandler(this.SalesGraphFrom_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ZedGraph.ZedGraphControl salesGraphControl;

    }
}
