using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worktimer
{
    public partial class Loader : Form
    {
        handlers.ini_file Config = new handlers.ini_file();
        MainForm timerForm = new MainForm();     

        public Loader()
        {
            InitializeComponent();
        }
       
        private void Loader_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
          
            Config.Write("SaveTxt", "1", "Saving");
            Config.Write("SaveTxt_Path", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\work\", "Saving");

            Config.Write("SaveDB", "0", "Saving");
            Config.Write("SaveDB_Host", "hostname", "Saving");
            Config.Write("SaveDB_User", "username", "Saving");
            Config.Write("SaveDB_Pass", "password", "Saving");
            Config.Write("SaveDB_Name", "databasename", "Saving");

            Config.Write("MinimizeTray", "1", "General");
               
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.pb_Loader.Increment(1);

            if (pb_Loader.Value == 100)
            {
                this.Hide();
                this.timer1.Stop();
                timerForm.Show();
            }            
            
        }

    }
}
