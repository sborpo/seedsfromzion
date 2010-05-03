using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using seedsfromzion.Managers;
namespace seedsfromzion.GUI
{
    public partial class SystemUsersManager : DevComponents.DotNetBar.Office2007Form
    {
        public SystemUsersManager()
        {
            InitializeComponent();
        }

        private void SystemUsersManager_Load(object sender, EventArgs e)
        {
            initializeFields();
        }

        private void displayError(String error)
        {
            MessageBox.Show(error);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if ((textBoxX1.Text == "") || (textBoxX2.Text == ""))
            {
                displayError("שם המשתמש או הסיסמא ריקים");
            }
            UserType user;
            if (comboBoxEx1.SelectedIndex==1)
            {
                user= UserType.ORDINARY;
            }
            else
            {
                user=UserType.ADMIN;
            }
            try
            {
                AdminManager.addUser(textBoxX1.Text, textBoxX2.Text, user);
            }
            catch (UserAlreadyExists ex)
            {
                displayError("שם המשתמש כבר קיים במערכת");
                return;
            }
            initializeFields();

        }

        private void initializeFields()
        {
            textBoxX2.Text = "";
            textBoxX1.Text = "";
            comboBoxEx1.SelectedIndex = 1;

        }
    }
}