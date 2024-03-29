﻿using System;
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
    /// A form which takes care of the workers work days and hours.
    /// </summary>
    public partial class WorkDaysForm : BaseForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkDaysForm"/> class.
        /// </summary>
        public WorkDaysForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the WorkDaysForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void WorkDaysForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            populateWorekres();
            populateHours();

            //set the max day on the callendar to TODAY
            monthCalendar.MaxDate = DateTime.Today;
        }

        /// <summary>
        /// Populates the worekres data grid..
        /// </summary>
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

        /// <summary>
        /// Populates the hours data grid.
        /// </summary>
        private void populateHours()
        {
            if (dataGridWorkers.SelectedRows.Count <= 0)
            {
                return;
            }
            int workerID = (int)((uint)dataGridWorkers.SelectedRows[0].Cells["id"].Value);
            DateTime date = monthCalendar.SelectionStart;

            var hours = m_manager.GetWorkerHours(workerID, date);

            dataGridView_hours.DataSource = hours;
            dataGridView_hours.Columns["startTime"].HeaderText = "התחלה";
            dataGridView_hours.Columns["startTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView_hours.Columns["endTime"].HeaderText = "סיום";
            dataGridView_hours.Columns["endTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }



        private WorkerManager m_manager = new WorkerManager();

        /// <summary>
        /// Handles the DateChanged event of the monthCalendar1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.DateRangeEventArgs"/> instance containing the event data.</param>
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            populateHours();   
        }

        /// <summary>
        /// Handles the Click event of the btn_update_hours control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btn_update_hours_Click(object sender, EventArgs e)
        {
            if (dataGridWorkers.SelectedRows.Count <= 0)
            {
                return;
            }
            int[] workersId = new int[dataGridWorkers.SelectedRows.Count];

            for (int i = 0; i < dataGridWorkers.SelectedRows.Count; i++)
            {
                workersId[i] = (int)((uint)dataGridWorkers.SelectedRows[i].Cells["id"].Value);
            }


            DateTime date = monthCalendar.SelectionStart;

            //check if there is already working hours in this date

            m_manager.AddWorkerHours(workersId, date, dateTime_start.Value.TimeOfDay.ToString(), dateTime_end.Value.TimeOfDay.ToString());

            populateHours();

            //if we got till here, showe a success window
            SuccessWindow successWindow = new SuccessWindow();
            successWindow.Show();
        }

        /// <summary>
        /// Handles the SelectionChanged event of the dataGridWorkers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void dataGridWorkers_SelectionChanged(object sender, EventArgs e)
        {
            populateHours();
        }
    }
}
