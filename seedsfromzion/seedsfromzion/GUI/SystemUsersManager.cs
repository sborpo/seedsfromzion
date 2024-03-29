using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using seedsfromzion.Managers;
using System.Data;
namespace seedsfromzion.GUI
{
    public partial class SystemUsersManager : DevComponents.DotNetBar.Office2007Form
    {
        private DataTable usersTable;
        public SystemUsersManager()
        {
            InitializeComponent();
            initializeFields();
            refreshUserTable();
        }

        private void refreshUserTable()
        {
            usersTable = SystemManager.getUsers();
            dataGridViewX1.DataSource = usersTable;
            dataGridViewX1.Refresh();
            dataGridViewX1.Columns["username"].HeaderText = "שם משתמש";
            dataGridViewX1.Columns["username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void SystemUsersManager_Load(object sender, EventArgs e)
        {
            initializeFields();
        }

        private void displayError(String error)
        {
            new ErrorWindow(error).Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if ((userTextBox.Text == "") || (passTextBox.Text == "") || (passAuthTextBox.Text==""))
            {
                displayError("שם המשתמש או הסיסמא ריקים");
                return;
            }
            if (!(passTextBox.Text.Equals(passAuthTextBox.Text)))
            {
                displayError("סיסמת האישור אינה תואמת לסיסמא שהוזנה");
                return;
            }
            UserType user;
            if (userTypeCombo.SelectedIndex==1)
            {
                user= UserType.ORDINARY;
            }
            else
            {
                user=UserType.ADMIN;
            }
            try
            {
                AdminManager.addUser(userTextBox.Text, passTextBox.Text, user);
            }
            catch (UserAlreadyExists ex)
            {
                displayError("שם המשתמש כבר קיים במערכת");
                return;
            }
            initializeFields();
            refreshUserTable();
            SuccessWindow wind = new SuccessWindow();
            wind.Show();


        }

        private void initializeFields()
        {
            passTextBox.Text = "";
            userTextBox.Text = "";
            passAuthTextBox.Text = "";
            userTypeCombo.SelectedIndex = 1;
           

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewX1.SelectedRows[0];
            string username = (string)row.Cells[0].Value;
            try
            {
                AdminManager.removeUser(username);
                dataGridViewX1.Rows.Remove(row);
            }
            catch (CannotDeleteAdmin ex)
            {
                displayError("אין אפשרות למחוק מנהל על");
            }


        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if ((textBoxX4.Text == "") || (textBoxX3.Text == "") || (textBoxX5.Text == ""))
            {
                displayError("אחד השדות של הסיסמא הוא ריק");
                return;
            }
            if (!(textBoxX4.Text.Equals(textBoxX5.Text)))
            {
                displayError("אנא אשר את הסיסמא החדשה שנית");
                return;
            }
            DataGridViewRow row = dataGridViewX1.SelectedRows[0];
            string username = (string)row.Cells[0].Value;
            try
            {
                AdminManager.changePassword(username, textBoxX3.Text, textBoxX4.Text);
                SuccessWindow wind = new SuccessWindow();
                wind.Show();
            }
            catch (UserNotFound ex)
            {
                displayError("הסיסמא הנוכחית אינה נכונה");
            }
        }

       
    }
}