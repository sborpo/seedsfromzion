using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using seedsfromzion.Managers;

namespace seedsfromzion.GUI.WorkerForms
{
    public partial class FindWorkerForm : BaseForm
    {
        public FindWorkerForm()
        {
            InitializeComponent();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            #region validation

            if (string.IsNullOrEmpty(btn_find.Text))
            {
                MessageBox.Show("יש להכניס תעודת זהות");
                return;
            }
            #endregion

            WorkerManager manager = new WorkerManager();
            
        }
    }
}
