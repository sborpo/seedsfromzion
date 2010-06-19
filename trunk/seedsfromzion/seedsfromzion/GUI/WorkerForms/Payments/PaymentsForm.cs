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
    /// <summary>
    /// A form that deals with the payment to the workers.
    /// </summary>
    public partial class PaymentsForm : BaseForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsForm"/> class.
        /// </summary>
        public PaymentsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the PaymentsForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            this.BaseForm_Load(sender, e);
            populateWorkers();
        }

        /// <summary>
        /// Populates the workers data grid.
        /// </summary>
        private void populateWorkers()
        {
            WorkerManager workerManager = new WorkerManager();
            dataGrid_workers.DataSource = workerManager.WorkersWithPayments;
            dataGrid_workers.Columns["id"].HeaderText = "ת.ז";
            dataGrid_workers.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid_workers.Columns["name"].HeaderText = "שם";
            dataGrid_workers.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid_workers.Columns["advancedPay"].HeaderText = "מקדמה";
            dataGrid_workers.Columns["advancedPay"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid_workers.Columns["postponedPay"].HeaderText = "דחוי";
            dataGrid_workers.Columns["postponedPay"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid_workers.Refresh();
        }

        /// <summary>
        /// Handles the SelectionChanged event of the dataGrid_workers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void dataGrid_workers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid_workers.SelectedRows.Count <= 0)
            {
                return;
            }
            numericUpDowd_advancedPay.Value = (decimal)((double)dataGrid_workers.SelectedRows[0].Cells["advancedPay"].Value);
            numericUpDown_postponedPay.Value = (decimal)((double)dataGrid_workers.SelectedRows[0].Cells["postponedPay"].Value);
        }

        /// <summary>
        /// Handles the Click event of the btn_update control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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

            //if we got till here, showe a success window
            SuccessWindow successWindow = new SuccessWindow();
            successWindow.Show();
        }
    }
}
