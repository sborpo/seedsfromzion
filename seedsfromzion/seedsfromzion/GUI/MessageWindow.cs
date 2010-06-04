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
    public partial class MessageWindow : DevComponents.DotNetBar.Office2007Form
    {
        public MessageWindow()
        {
            InitializeComponent();
        }

        public MessageWindow(string text)
        {
            InitializeComponent();
            labelX1.Text = text;
        }

        public void setText(string text)
        {
            labelX1.Text=text;
        }
    }
}