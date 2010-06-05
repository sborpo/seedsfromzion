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
    public partial class FindWorkerForm : BaseForm
    {
        public FindWorkerForm()
        {
            InitializeComponent();
            populateWorekres();
        }

        private void FindWorkerForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            seedsFromZion mainForm = (seedsFromZion)this.MdiParent;
            mainForm.deleteWorkerClicked += new seedsFromZion.deleteWorkerClickedHandler(mainForm_deleteWorkerClicked);
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            //find through name
            if (string.IsNullOrEmpty(textBox_ID.Text))
            {
                if (string.IsNullOrEmpty(textBox_firstName.Text) || string.IsNullOrEmpty(textBox_lastName.Text))
                {
                    dataGridWorkers.DataSource = null;
                    return;
                }
                else
                {
                    string name = textBox_firstName.Text + " " + textBox_lastName.Text;
                    populateWorekres(name);
                    return;
                }
                
            }
            //find through id
            int res;
            if (!int.TryParse(textBox_ID.Text, out res))
            {
                new ErrorWindow(" יש להזין תעודת זהות ת.ז תקינה").Show();
                return;
            }

            populateWorekres(int.Parse(textBox_ID.Text));
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

        private void populateWorekres(int id)
        {
            dataGridWorkers.DataSource = m_manager.FindWorker(id);
            dataGridWorkers.Columns["id"].HeaderText = "ת.ז";
            dataGridWorkers.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridWorkers.Columns["name"].HeaderText = "שם";
            dataGridWorkers.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridWorkers.Columns["phone"].HeaderText = "טלפון";
            dataGridWorkers.Columns["phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridWorkers.Columns["comments"].HeaderText = "הערות";
            dataGridWorkers.Columns["comments"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void populateWorekres(string name)
        {
            dataGridWorkers.DataSource = m_manager.FindWorker(name);
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

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            populateWorekres();
        }


        void mainForm_deleteWorkerClicked()
        {
            if (dataGridWorkers.SelectedRows.Count == 0)
            {
                return;
            }
            int workerid = (int)(UInt32)(dataGridWorkers.SelectedRows[0].Cells["id"].Value);

            try
            {
                m_manager.RemoveWorker(workerid);
            }
            catch (Exception e)
            {
                new ErrorWindow(e.Message).Show();
                return;
            }

            new SuccessWindow().Show();
            populateWorekres();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_firstName.Text = textBox_lastName.Text = textBox_ID.Text = "";
        }
        
    }
}
