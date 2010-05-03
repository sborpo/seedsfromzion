using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace seedsfromzion.GUI
{
    public partial class BaseForm : DevComponents.DotNetBar.Office2007Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void BaseForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
