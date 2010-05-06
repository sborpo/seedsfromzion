namespace seedsfromzion.GUI
{
    partial class InheritedForm
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
            this.theContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.theContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // theContainer
            // 
            this.theContainer.Controls.Add(this.tableLayoutPanel1);
            this.theContainer.Controls.Add(this.reflectionLabel1);
            this.theContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theContainer.Location = new System.Drawing.Point(0, 0);
            this.theContainer.Name = "theContainer";
            this.theContainer.Size = new System.Drawing.Size(904, 451);
            this.theContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonX1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelX1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxX1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(263, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 259F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(641, 381);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonX1.Location = new System.Drawing.Point(3, 84);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(100, 35);
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "חפש עכשיו";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX1.Location = new System.Drawing.Point(324, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(314, 34);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "שם הצמח: ";
            // 
            // textBoxX1
            // 
            this.textBoxX1.AutoCompleteCustomSource.AddRange(new string[] {
            "צמח בר",
            "צמח",
            "קלונית",
            "פרח",
            "קלינה"});
            this.textBoxX1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxX1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX1.Location = new System.Drawing.Point(3, 3);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(315, 34);
            this.textBoxX1.TabIndex = 5;
            this.textBoxX1.Text = "הקלד כאן שם של הצמח";
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.reflectionLabel1.Location = new System.Drawing.Point(0, 0);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.ReflectionEnabled = false;
            this.reflectionLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reflectionLabel1.Size = new System.Drawing.Size(904, 70);
            this.reflectionLabel1.TabIndex = 1;
            this.reflectionLabel1.Text = "<b><font size=\"+8\"><font color=\"#B02B2C\">חיפוש צמחים</font></font></b>";
            // 
            // InheritedForm
            // 
            this.ClientSize = new System.Drawing.Size(904, 451);
            this.Controls.Add(this.theContainer);
            this.DoubleBuffered = true;
            this.Name = "InheritedForm";
            this.Text = "InheritedSearchPlantForm";
            this.theContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel theContainer;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;


    }
}
