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
    public partial class AddWorkerForm : BaseForm
    {
        public AddWorkerForm()
        {
            InitializeComponent();
        }

        private void btn_addWorker_Click(object sender, EventArgs e)
        {
            #region field validation
            if (String.IsNullOrEmpty(textBox_ID.Text))
            {
                MessageBox.Show("יש להכניס תעודת זהות");
                return;
            }
            if (String.IsNullOrEmpty(textBox_firstName.Text))
            {
                MessageBox.Show("יש להכניס שם פרטי");
                return;
            }
            if (String.IsNullOrEmpty(textBox_lastName.Text))
            {
                MessageBox.Show("יש להכניס שם משפחה");
                return;
            } 
            #endregion

            string workerName = textBox_firstName.Text +" "+textBox_lastName.Text;
            WorkerManager workerManager = new WorkerManager();
            try
            {
                workerManager.AddWorker(int.Parse(textBox_ID.Text), workerName);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("עובד בעל אותה ת.ז כבר נמצא במערכת");
            }
        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {
           //TODO:validate that all the chars are numbers
        }
    }
}
