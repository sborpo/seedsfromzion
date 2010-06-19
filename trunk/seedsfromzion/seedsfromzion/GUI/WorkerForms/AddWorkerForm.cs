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
    /// A form which deals with adding a new worker to the system.
    /// </summary>
    public partial class AddWorkerForm : BaseForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddWorkerForm"/> class.
        /// </summary>
        public AddWorkerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btn_addWorker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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
            //if we got till here, showe a success window
            SuccessWindow successWindow = new SuccessWindow();
            successWindow.Show();
        }

        /// <summary>
        /// Handles the TextChanged event of the textBox_ID control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {
           //TODO:validate that all the chars are numbers
        }
    }
}
