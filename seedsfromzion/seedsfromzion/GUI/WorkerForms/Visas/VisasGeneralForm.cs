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
    /// A form which dispaly the visas in the system, and their workers.
    /// </summary>
    public partial class VisasGeneralForm : BaseForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisasGeneralForm"/> class.
        /// </summary>
        public VisasGeneralForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the VisasGeneralForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void VisasGeneralForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            populateVisas();
            populateWorkers();
            populateAllWorkers();

            this.dataGridVisas.SelectionChanged += new System.EventHandler(this.dataGridVisas_SelectionChanged);
        }

        /// <summary>
        /// Handles the Click event of the btn_addVisa control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btn_addVisa_Click(object sender, EventArgs e)
        {
            var addForm = new AddVisaForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                populateVisas();
            }
        }

        /// <summary>
        /// Handles the Click event of the btn_editVisa control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btn_editVisa_Click(object sender, EventArgs e)
        {
            if (dataGridVisas.SelectedRows.Count <= 0)
            {
                return;
            }
            int visaID = (int)((uint)dataGridVisas.SelectedRows[0].Cells["visaID"].Value);
            DateTime expireDate = ((DateTime)dataGridVisas.SelectedRows[0].Cells["expireDate"].Value);
            string contact = ((string)dataGridVisas.SelectedRows[0].Cells["contact"].Value);

            UpdateVisaForm form = new UpdateVisaForm(visaID, expireDate, contact);
            if (form.ShowDialog() == DialogResult.OK)
            {
                populateVisas();
            }
        }

        /// <summary>
        /// Populates the visas data grid.
        /// </summary>
        private void populateVisas()
        {
            WorkerManager workerManager = new WorkerManager();
            dataGridVisas.DataSource = workerManager.Visas;
            dataGridVisas.Columns["visaID"].HeaderText = "מזהה";
            dataGridVisas.Columns["visaID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridVisas.Columns["expireDate"].HeaderText = "תאריך תפוגה";
            dataGridVisas.Columns["expireDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridVisas.Columns["contact"].HeaderText = "איש קשר";
            dataGridVisas.Columns["contact"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridVisas.Refresh();
        }

        /// <summary>
        /// Populates the workers data grid. 
        /// </summary>
        private void populateWorkers()
        {
            if (dataGridVisas.SelectedRows.Count <= 0)
            {
                return;
            }
            int visaID = (int)((uint)dataGridVisas.SelectedRows[0].Cells["visaID"].Value);

            WorkerManager workerManager = new WorkerManager();
            dataGrid_workers.DataSource = workerManager.GetWorkersAttachedToVisa(visaID);
            dataGrid_workers.Columns["workerid"].HeaderText = "ת.ז עובד";
            dataGrid_workers.Columns["workerid"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridVisas.Columns["expireDate"].HeaderText = "תאריך תפוגה";
            //dataGridVisas.Columns["expireDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridVisas.Columns["contact"].HeaderText = "איש קשר";
            //dataGridVisas.Columns["contact"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridVisas.Refresh();
        }

        /// <summary>
        /// Populates all workers data grid.
        /// </summary>
        private void populateAllWorkers()
        {
            WorkerManager workerManager = new WorkerManager();
            dataGrid_allWorkers.DataSource = workerManager.Workers;
            dataGrid_allWorkers.Columns["id"].HeaderText = "ת.ז";
            dataGrid_allWorkers.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid_allWorkers.Columns["name"].HeaderText = "שם";
            dataGrid_allWorkers.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid_allWorkers.Columns["phone"].HeaderText = "טלפון";
            dataGrid_allWorkers.Columns["phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid_allWorkers.Columns["comments"].HeaderText = "הערות";
            dataGrid_allWorkers.Columns["comments"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// Handles the SelectionChanged event of the dataGridVisas control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void dataGridVisas_SelectionChanged(object sender, EventArgs e)
        {
            populateWorkers();
        }

        /// <summary>
        /// Handles the Click event of the btn_addWorkerToVisa control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btn_addWorkerToVisa_Click(object sender, EventArgs e)
        {
            if (dataGridVisas.SelectedRows.Count <= 0)
            {
                return;
            }
            int visaID = (int)((uint)dataGridVisas.SelectedRows[0].Cells["visaID"].Value);

            if (dataGrid_allWorkers.SelectedRows.Count <= 0)
            {
                return;
            }
            int workerId = (int)((uint)dataGrid_allWorkers.SelectedRows[0].Cells["id"].Value);

            WorkerManager workerManager = new WorkerManager();
            workerManager.AttachWorkerToVisa(workerId, visaID);

            populateWorkers();
        }

        /// <summary>
        /// Handles the Click event of the btn_deleteVisa control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btn_deleteVisa_Click(object sender, EventArgs e)
        {
            if (dataGridVisas.SelectedRows.Count <= 0)
            {
                return;
            }
            int visaID = (int)((uint)dataGridVisas.SelectedRows[0].Cells["visaID"].Value);

            WorkerManager workerManager = new WorkerManager();
            workerManager.RemoveVisa(visaID);

            //refresh the form
            populateVisas();
            populateWorkers();

            SuccessWindow success = new SuccessWindow();
            success.Show();
        }

        /// <summary>
        /// Handles the Click event of the btn_removeWorker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btn_removeWorker_Click(object sender, EventArgs e)
        {
            if (dataGridVisas.SelectedRows.Count <= 0)
            {
                return;
            }
            int visaID = (int)((uint)dataGridVisas.SelectedRows[0].Cells["visaID"].Value);

            if (dataGrid_workers.SelectedRows.Count <= 0)
            {
                return;
            }
            int workerId = (int)((uint)dataGrid_workers.SelectedRows[0].Cells["workerid"].Value);

            DialogBox dialog = new DialogBox("האם אתה בטוח כי ברצונך להסיר עובד מויזה?");
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            WorkerManager workerManager = new WorkerManager();
            workerManager.RemoveWorkerFromVisa(visaID, workerId);

            //refresh the form
            populateWorkers();

            SuccessWindow success = new SuccessWindow();
            success.Show();
        }

    }
}
