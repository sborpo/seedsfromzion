using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace seedsfromzion
{
    public partial class NotificationWindow : DevComponents.DotNetBar.Balloon
    {
        public delegate void ClosingBalloonHandler(object sender, EventArgs e);
        public event ClosingBalloonHandler closedBalloon;
        public NotificationWindow()
        {
            InitializeComponent();
        }

        public NotificationWindow(String title, String text,Rectangle r)
        {
            
            InitializeComponent();
            this.Location = new Point(r.Right - this.Width, r.Bottom - this.Height);
            this.AlertAnimation = DevComponents.DotNetBar.eAlertAnimation.BottomToTop;
            this.AlertAnimationDuration = 3000;
            label1.Text = title;
            string [] lines=Regex.Split(text, "\n");
            textBoxX1.Lines = lines;
        }

        private void NotificationWindow_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            closedBalloon(sender, e);
            this.Close();
        }

        
    }
}
