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
    /// A popup form which updates selected visa propertis.
    /// </summary>
    public partial class UpdateVisaForm : DevComponents.DotNetBar.Office2007Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVisaForm"/> class.
        /// </summary>
        /// <param name="visaId">The visa id.</param>
        /// <param name="expireDate">The expire date.</param>
        /// <param name="contact">The contact.</param>
        public UpdateVisaForm(int visaId, DateTime expireDate, string contact)
        {
            InitializeComponent();

            textBox_ID.Text = visaId.ToString();
            dateTimeInput.Value = expireDate;
            textBox_contact.Text = contact;
        }

        /// <summary>
        /// Handles the Click event of the btn_Update control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            int visaID;
            #region field validation
            if (String.IsNullOrEmpty(textBox_ID.Text))
            {
                ErrorWindow eroor = new ErrorWindow("יש להכניס מספר מזהה");
                eroor.Show();
                return;
            }
            else if (!int.TryParse(textBox_ID.Text, out visaID))
            {
                ErrorWindow eroor = new ErrorWindow("יש להזין מספר מזהה תקין");
                eroor.Show();
                return;
            }
            if (String.IsNullOrEmpty(textBox_contact.Text))
            {
                ErrorWindow eroor = new ErrorWindow("יש להכניס איש קשר");
                eroor.Show();
                return;
            }
            if (dateTimeInput.Value <= DateTime.MinValue)
            {
                ErrorWindow eroor = new ErrorWindow("יש להכניס תאריך תפוגה");
                eroor.Show();
                return;
            }
            #endregion

            WorkerManager workerManager = new WorkerManager();
            try
            {
                workerManager.UpdateVisa(int.Parse(textBox_ID.Text), dateTimeInput.Value, textBox_contact.Text);
            }
            catch (Exception exception)
            {
                ErrorWindow eroor = new ErrorWindow(exception.Message);
                eroor.Show();
                return;
            }
            //if we got till here, showe a success window
            SuccessWindow successWindow = new SuccessWindow();
            successWindow.Show();
            //if we passed all other stages, so we OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btn_cancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
