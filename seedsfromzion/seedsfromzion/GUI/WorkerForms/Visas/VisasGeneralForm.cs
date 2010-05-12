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
    public partial class VisasGeneralForm : BaseForm
    {
        public VisasGeneralForm()
        {
            InitializeComponent();
        }

        private void VisasGeneralForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            populateVisas();

        }

        private void btn_addVisa_Click(object sender, EventArgs e)
        {
            var addForm = new AddVisaForm();
            addForm.ShowDialog();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                populateVisas();
            }
        }

        private void populateVisas()
        {
            WorkerManager workerManager = new WorkerManager();

        }

        
    }
}
