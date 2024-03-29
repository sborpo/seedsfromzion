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
    public partial class UserAuthentication : DevComponents.DotNetBar.Office2007Form
    {
        seedsFromZion mainForm;
        public UserAuthentication(seedsFromZion mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.mainForm.Disable();
           
        }

        private void login_Click(object sender, EventArgs e)
        {
            if ((userNameBox.Text=="") || (passBox.Text==""))
            {
                new ErrorWindow("שם המשתמש או הסיסמא ריקים").Show();
                return;
            }
            bool loged=SystemManager.logIn(userNameBox.Text, passBox.Text);
            if (loged == false)
            {
                new ErrorWindow("שם המשתמש או הסיסמא אינם נכונים").Show();
                return;
            }
            if (SystemManager.LogedUserType.Equals(UserType.ADMIN))
            {
                mainForm.DisplayAdminOptions = true;
            }
            else
            {
                mainForm.DisplayAdminOptions = false;
            }
            mainForm.DisplayLogOut = true;
            mainForm.Enable();
            mainForm.loggedIn();
            this.Close();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            mainForm.Close();
            this.Close();
        }

        private void UserAuthentication_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void UserAuthentication_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals((char)Keys.Enter))
            {
                login_Click(sender, (EventArgs)e);
            }
        }
    }
}