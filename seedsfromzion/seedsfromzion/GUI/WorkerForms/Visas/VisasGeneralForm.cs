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
            populateWorkers();

            this.dataGridVisas.SelectionChanged += new System.EventHandler(this.dataGridVisas_SelectionChanged);
        }

        private void btn_addVisa_Click(object sender, EventArgs e)
        {
            var addForm = new AddVisaForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                populateVisas();
            }
        }

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

        private void populateWorkers()
        {
            if (dataGridVisas.SelectedRows.Count <=0)
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

        private void dataGridVisas_SelectionChanged(object sender, EventArgs e)
        {
            populateWorkers();
        }

        
    }
}
