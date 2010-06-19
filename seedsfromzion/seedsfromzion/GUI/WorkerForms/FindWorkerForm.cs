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
    /// 
    /// </summary>
    public partial class FindWorkerForm : BaseForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindWorkerForm"/> class.
        /// </summary>
        public FindWorkerForm()
        {
            InitializeComponent();
            populateWorekres();
        }

        /// <summary>
        /// Handles the Load event of the FindWorkerForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void FindWorkerForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            seedsFromZion mainForm = (seedsFromZion)this.MdiParent;
            mainForm.deleteWorkerClicked += new seedsFromZion.deleteWorkerClickedHandler(mainForm_deleteWorkerClicked);
        }

        /// <summary>
        /// Handles the Click event of the btn_find control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Populates the worekres data grid.
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
        /// Populates the woreker data grid.
        /// </summary>
        /// <param name="id">The id.</param>
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

        /// <summary>
        /// Populates the woreker data grid.
        /// </summary>
        /// <param name="name">The name.</param>
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

        /// <summary>
        /// Handles the Click event of the btn_showAll control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btn_showAll_Click(object sender, EventArgs e)
        {
            populateWorekres();
        }


        /// <summary>
        /// Mains the form_delete worker clicked.
        /// </summary>
        void mainForm_deleteWorkerClicked()
        {
            if (dataGridWorkers.SelectedRows.Count == 0)
            {
                return;
            }
            int workerid = (int)(UInt32)(dataGridWorkers.SelectedRows[0].Cells["id"].Value);

            DialogBox dialog = new DialogBox("האם אתה בטוח כי ברצונך למחוק עובד?");
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

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

        /// <summary>
        /// Handles the SelectedIndexChanged event of the tabControl1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_firstName.Text = textBox_lastName.Text = textBox_ID.Text = "";
        }
        
    }
}
