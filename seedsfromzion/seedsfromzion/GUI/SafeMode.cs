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
    public partial class SafeMode : DevComponents.DotNetBar.Office2007Form
    {
        public SafeMode()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            OpenFileDialog restoreDialog = new OpenFileDialog();
            if (restoreDialog.ShowDialog() == DialogResult.OK)
            {
                SystemManager.performSystemRestore(restoreDialog.FileName);
                MessageBox.Show("המערכת שוחזרה בהצלחה , אנא הפעל אותה שנית");
            }
        }
    }
}