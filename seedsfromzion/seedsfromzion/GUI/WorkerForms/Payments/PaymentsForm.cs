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
            dataGrid_workers.DataSource = workerManager.WorkersWithPayments;
            //dataGridVisas.Columns["visaID"].HeaderText = "מזהה";
            //dataGridVisas.Columns["visaID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridVisas.Columns["expireDate"].HeaderText = "תאריך תפוגה";
            //dataGridVisas.Columns["expireDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridVisas.Columns["contact"].HeaderText = "איש קשר";
            //dataGridVisas.Columns["contact"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid_workers.Refresh();
        }

        private void dataGrid_workers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid_workers.SelectedRows.Count <= 0)
            {
                return;
            }
            numericUpDowd_advancedPay.Value = (decimal)((double)dataGrid_workers.SelectedRows[0].Cells["advancedPay"].Value);
            numericUpDown_postponedPay.Value = (decimal)((double)dataGrid_workers.SelectedRows[0].Cells["postponedPay"].Value);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            WorkerManager manager = new WorkerManager();
            if (dataGrid_workers.SelectedRows.Count <= 0)
            {
                return;
            }

            int workerID = (int)((uint)dataGrid_workers.SelectedRows[0].Cells["id"].Value);

            manager.UpdateAdvancePayment(workerID, (double)numericUpDowd_advancedPay.Value);
            manager.UpdatePostpondedPayment(workerID, (double)numericUpDown_postponedPay.Value);

            populateWorkers();
        }
    }
}
