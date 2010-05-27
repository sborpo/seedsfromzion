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
            int workerID;
            #region field validation
            if (String.IsNullOrEmpty(textBox_ID.Text))
            {
                new ErrorWindow("יש להזין תעודת זהות").Show();
                return;
            }
            else if (!int.TryParse(textBox_ID.Text,out workerID))
            {
                new ErrorWindow("יש להזין תעודת זהות תקינה").Show();
                return;
            }
            if (String.IsNullOrEmpty(textBox_firstName.Text))
            {
                new ErrorWindow("יש להכניס שם פרטי").Show();
                return;
            }
            if (String.IsNullOrEmpty(textBox_lastName.Text))
            {
                new ErrorWindow("יש להכניס שם משפחה").Show();
                return;
            } 
            #endregion

            string workerName = textBox_firstName.Text +" "+textBox_lastName.Text;
            WorkerManager workerManager = new WorkerManager();
            try
            {
                workerManager.AddWorker(int.Parse(textBox_ID.Text), workerName, textBox_phone.Text, textBox_comments.Text);
            }
            catch (ArgumentException)
            {
                new ErrorWindow("עובד בעל אותה ת.ז כבר נמצא במערכת").Show();
                return;
            }
        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {
           //TODO:validate that all the chars are numbers
        }
    }
}
