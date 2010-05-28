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
    public partial class WorkersReportsForm : BaseForm
    {
        public WorkersReportsForm()
        {
            InitializeComponent();
            comboBoxEx1.SelectedIndex = 0;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            generateWorkerReport(r);
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

        private void generateWorkerReport(Report r)
        {
            WorkerManager manager = new WorkerManager();
            DataTable table = manager.Workers;
            table.Columns[0].ColumnName = "ת.ז";
            table.Columns[1].ColumnName = "שם";
            table.Columns[2].ColumnName = "טלפון";
            table.Columns[3].ColumnName = "הערות";
            workerStatus(r, "עובדים", table);
        }

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
    }
}
