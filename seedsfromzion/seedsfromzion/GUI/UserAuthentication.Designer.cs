namespace seedsfromzion.GUI
{
    partial class UserAuthentication
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.userNameBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.passBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.login = new DevComponents.DotNetBar.ButtonX();
            this.quit = new DevComponents.DotNetBar.ButtonX();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelX1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.userNameBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.passBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 76);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(219, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(210, 32);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "שם משתמש";
            // 
            // labelX2
            // 
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(219, 41);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(210, 32);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "סיסמא";
            // 
            // userNameBox
            // 
            // 
            // 
            // 
            this.userNameBox.Border.Class = "TextBoxBorder";
            this.userNameBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.userNameBox.Location = new System.Drawing.Point(3, 3);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userNameBox.Size = new System.Drawing.Size(210, 20);
            this.userNameBox.TabIndex = 2;
            this.userNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserAuthentication_KeyPress);
            // 
            // passBox
            // 
            // 
            // 
            // 
            this.passBox.Border.Class = "TextBoxBorder";
            this.passBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.passBox.Location = new System.Drawing.Point(3, 41);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passBox.Size = new System.Drawing.Size(210, 22);
            this.passBox.TabIndex = 3;
            this.passBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserAuthentication_KeyPress);
            // 
            // login
            // 
            this.login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.login.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login.Location = new System.Drawing.Point(294, 123);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(84, 31);
            this.login.TabIndex = 1;
            this.login.Text = "התחבר";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // quit
            // 
            this.quit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.quit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.quit.Location = new System.Drawing.Point(123, 123);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(81, 31);
            this.quit.TabIndex = 2;
            this.quit.Text = "צא";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // UserAuthentication
            // 
            this.ClientSize = new System.Drawing.Size(495, 180);
            this.ControlBox = false;
            this.Controls.Add(this.quit);
            this.Controls.Add(this.login);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserAuthentication";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "אימות משתמש";
            this.TitleText = "אימות משתמש";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserAuthentication_KeyPress);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserAuthentication_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX userNameBox;
        private DevComponents.DotNetBar.Controls.TextBoxX passBox;
        private DevComponents.DotNetBar.ButtonX login;
        private DevComponents.DotNetBar.ButtonX quit;
    }
}