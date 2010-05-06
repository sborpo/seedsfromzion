using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace seedsfromzion.GUI
{
    public partial class SuccessWindow : DevComponents.DotNetBar.Office2007Form
    {
        public SuccessWindow()
        {
            InitializeComponent();
        }

        private void SuccessWindow_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}