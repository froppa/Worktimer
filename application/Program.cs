using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worktimer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            handlers.ini_file Config = new handlers.ini_file();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += Application_ApplicationExit;

            if (!Config.KeyExists("SaveTxt", "Saving") || !Config.KeyExists("SaveTxt_Path", "Saving")) // Need to check if the file exists instead.
            {
                Application.Run(new Loader());
            }
            else
            {
                Application.Run(new MainForm());
            }
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            // If the timer is running, ask if you want the save the data.
        }
    }
}
