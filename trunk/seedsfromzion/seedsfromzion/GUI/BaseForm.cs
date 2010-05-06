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

        public void BaseForm_Load(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != null)
            {
                this.MdiParent.ActiveMdiChild.Close();
            }
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void BaseForm_Deactivate(object sender, EventArgs e)
        {
        }
    }
}
