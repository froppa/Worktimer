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
            Handlers.Ini_Handler Config = new Handlers.Ini_Handler();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Config.KeyExists("SaveTxt", "Saving") || !Config.KeyExists("SaveTxt_Path", "Saving")) // Need to check if the file exists instead.
            {
                Application.Run(new Loader());
            }
            else
            {
                Application.Run(new MainForm());
            }
        }
    }
}
