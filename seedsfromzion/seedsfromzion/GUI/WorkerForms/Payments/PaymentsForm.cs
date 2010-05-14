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
    public partial class PaymentsForm : BaseForm
    {
        public PaymentsForm()
        {
            InitializeComponent();
        }

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            populateWorkers();
        }

        private void populateWorkers()
        {
            WorkerManager workerManager = new WorkerManager();
            dataGrid_workers.DataSource = workerManager.Workers;
            //dataGridVisas.Columns["visaID"].HeaderText = "מזהה";
            //dataGridVisas.Columns["visaID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridVisas.Columns["expireDate"].HeaderText = "תאריך תפוגה";
            //dataGridVisas.Columns["expireDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridVisas.Columns["contact"].HeaderText = "איש קשר";
            //dataGridVisas.Columns["contact"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid_workers.Refresh();
        }
    }
}
