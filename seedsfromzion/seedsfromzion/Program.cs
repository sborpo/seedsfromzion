using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace seedsfromzion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new seedsfromzion.GUI.seedsFromZion());
            }
            catch (Exception e)
            {
                Application.Run(new seedsfromzion.GUI.SafeMode());
            }
        }
    }
}
