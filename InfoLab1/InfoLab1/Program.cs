using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoLab1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormAuthorizatoin fa = new FormAuthorizatoin();
            if(fa.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormOrg());
            }
        }
    }
}
