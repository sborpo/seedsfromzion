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
    public partial class DialogBox : DevComponents.DotNetBar.Office2007Form
    {
        
        public DialogBox()
        {
            InitializeComponent();
            text.Text = "��� ���� ���� ������� ���� ����� ��" + "?";
        }

        public DialogBox(string userText)
        {
            InitializeComponent();
            text.Text = userText;
        }

    

        private void reflectionImage1_Click(object sender, EventArgs e)
        {

        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            
        }

        private void NoButton_Click(object sender, EventArgs e)
        {

        }
    }
}