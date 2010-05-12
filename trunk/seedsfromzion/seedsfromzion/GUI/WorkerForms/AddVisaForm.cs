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
    public partial class AddVisaForm : BaseForm
    {
        public AddVisaForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            #region field validation
            if (String.IsNullOrEmpty(textBox_ID.Text))
            {
                ErrorWindow eroor = new ErrorWindow("יש להכניס מספר מזהה");
                eroor.Show();
                return;
            }
            if (String.IsNullOrEmpty(textBox_contact.Text))
            {
                ErrorWindow eroor = new ErrorWindow("יש להכניס איש קשר");
                eroor.Show();
                return;
            }
            #endregion

            WorkerManager workerManager = new WorkerManager();
            try
            {
                workerManager.AddVisa(int.Parse(textBox_ID.Text), dateTimeInput.Value, textBox_contact.Text);
            }
            catch(Exception e)
            {
                ErrorWindow eroor = new ErrorWindow(e.Message);
                eroor.Show();
                return;
            }

            //if we passed all other stages, so we OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
