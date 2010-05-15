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

        private void btn_find_Click(object sender, EventArgs e)
        {
            //find throw name
            if (string.IsNullOrEmpty(textBox_ID.Text))
            {
                if (string.IsNullOrEmpty(textBox_firstName.Text) || string.IsNullOrEmpty(textBox_lastName.Text))
                {
                    populateWorekres();
                    return;
                }
                else
                {
                    string name = textBox_firstName.Text + " " + textBox_lastName.Text;
                    populateWorekres(name);
                    return;
                }
                
            }
            //find throw id
            int res;
            if (!int.TryParse(textBox_ID.Text, out res))
            {
                MessageBox.Show("יש להכניס תעודת זהות תקינה");
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
    }
}
