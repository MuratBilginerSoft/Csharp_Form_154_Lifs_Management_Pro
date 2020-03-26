using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIFS_Management_Pro_Beta_v._1._0._0
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new _02_Forms._01_StarterForm());
            Application.Run(new _02_Forms._02_LoginForm());
            //Application.Run(new _02_Forms._03_MainForm());
        }
    }
}
