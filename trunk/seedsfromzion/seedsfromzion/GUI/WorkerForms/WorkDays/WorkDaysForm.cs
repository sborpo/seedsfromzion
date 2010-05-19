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
    public partial class WorkDaysForm : BaseForm
    {
        public WorkDaysForm()
        {
            InitializeComponent();
        }

        private void WorkDaysForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            populateWorekres();
        }

        private void populateWorekres()
        {
            dataGridWorkers.DataSource = m_manager.Workers;
            dataGridWorkers.Columns["id"].HeaderText = "ת.ז";
            dataGridWorkers.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridWorkers.Columns["name"].HeaderText = "שם";
            dataGridWorkers.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridWorkers.Columns["phone"].HeaderText = "טלפון";
            dataGridWorkers.Columns["phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridWorkers.Columns["comments"].HeaderText = "הערות";
            dataGridWorkers.Columns["comments"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }



        private WorkerManager m_manager = new WorkerManager();

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (dataGridWorkers.SelectedRows.Count <= 0)
            {
                return;
            }
            int workerID = (int)((uint)dataGridWorkers.SelectedRows[0].Cells["id"].Value);
            DateTime date = e.Start;

            var hours = m_manager.GetWorkerHours(workerID, date);
            if (hours.Rows.Count != 1)
            {
                dataGridView_hours.DataSource = null;
                return;
            }
            dataGridView_hours.DataSource = hours;
        }
    }
}
