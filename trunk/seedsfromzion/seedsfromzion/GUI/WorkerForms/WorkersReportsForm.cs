using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using seedsfromzion.Managers;
using seedsfromzion.DataAccess;

namespace seedsfromzion.GUI.WorkerForms
{
    /// <summary>
    /// A form that takes care of the workers report.
    /// </summary>
    public partial class WorkersReportsForm : BaseForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkersReportsForm"/> class.
        /// </summary>
        public WorkersReportsForm()
        {
            InitializeComponent();
            comboBoxEx1.SelectedIndex = 0;

            populateAllWorkers();
        }

        /// <summary>
        /// Handles the Click event of the btn_save control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            if (comboBox_type.SelectedIndex == 0)
            {
                generateAllWorkersReport(r);
            }
            else
            {
                generateWorkersReport(r);
            }
            
            r.ReportColor = (comboBoxEx1.SelectedIndex == 0) ? Report.ReportStyle.Color : Report.ReportStyle.BlackWhite;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = @"c:\";
            dialog.Filter = "HTML File (*.html) |*.html";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                r.save(dialog.FileName);
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "iexplore";
                proc.StartInfo.Arguments = dialog.FileName;
                proc.Start();
            }
        }

        /// <summary>
        /// Generates all workers report.
        /// </summary>
        /// <param name="r">The r.</param>
        private void generateAllWorkersReport(Report r)
        {
            WorkerManager manager = new WorkerManager();
            DataTable table = manager.Workers;
            table.Columns[0].ColumnName = "ת.ז";
            table.Columns[1].ColumnName = "שם";
            table.Columns[2].ColumnName = "טלפון";
            table.Columns[3].ColumnName = "הערות";
            workerStatus(r, "עובדים", table);
        }

        /// <summary>
        /// Generates the workers report.
        /// </summary>
        /// <param name="r">The r.</param>
        private void generateWorkersReport(Report r)
        {
            if (dataGrid_allWorkers.SelectedRows.Count <= 0)
            {
                return;
            }
            int workerID = (int)((uint)dataGrid_allWorkers.SelectedRows[0].Cells["id"].Value);
            string workerName = (string)dataGrid_allWorkers.SelectedRows[0].Cells["name"].Value;

            DateTime month = dateTimePicker.Value;
            //to start a new month
            while (month.Day!= 1)
            {
                month = month.AddDays(-1);
            }
            WorkerManager manager = new WorkerManager();
            DataTable table = manager.GetWorkerHoursPerMonth(workerID, month);

            table.Columns[0].ColumnName = "תאריך";
            table.Columns[1].ColumnName = "שעת התחלה";
            table.Columns[2].ColumnName = "שעת סיום";

            string headr = " שעות לעובד " + workerName + " ת.ז: " + workerID.ToString() + " בחודש " + String.Format("{0:yyyy-M}", month);
            workerStatus(r, headr, table);
        }

        /// <summary>
        /// Workers the status.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="headingStr">The heading STR.</param>
        /// <param name="workers">The workers.</param>
        private void workerStatus(Report r, string headingStr, DataTable workers)
        {
            HtmlTable htmlTable = new HtmlTable(workers);
            htmlTable.align(HtmlAlign.center);
            r.append(new HtmlEndLine(4));
            HtmlHeading heading = new HtmlHeading(headingStr);
            heading.align(HtmlAlign.center);
            r.append(heading);
            r.append(new HtmlEndLine(2));
            r.append(htmlTable);
            r.append(new HtmlEndLine(2));
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the comboBox_type control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_type.SelectedIndex == 0)
            {
                dateTimePicker.Enabled = false;
                dataGrid_allWorkers.Enabled = false;
            }
            else
            {
                dateTimePicker.Enabled = true;
                dataGrid_allWorkers.Enabled = true;
            }
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
            dataGrid_allWorkers.Columns["phone"].Visible  = false;
            dataGrid_allWorkers.Columns["comments"].Visible = false;
        }
    }
}
