using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace seedsfromzion.GUI
{
    public partial class InheritedForm : seedsfromzion.GUI.BaseForm
    {
        public InheritedForm()
        {
            InitializeComponent();
        }

        private void InheritedForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
        }
    }
}
