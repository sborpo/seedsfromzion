using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Text.RegularExpressions;

namespace seedsfromzion.GUI
{
    public partial class ErrorWindow : DevComponents.DotNetBar.Office2007Form
    {
        public ErrorWindow()
        {
            InitializeComponent();
        }

        public ErrorWindow(string message)
        {
            InitializeComponent();
            string[] lines = Regex.Split(message, "\n");
            textBoxX1.Lines = lines;
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorWindow_Load(object sender, EventArgs e)
        {
            textBoxX1.SelectionLength = 0;
        }
    }
}