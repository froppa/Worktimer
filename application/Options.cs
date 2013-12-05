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
    public partial class Options : Form
    {
        handlers.ini_file Config = new handlers.ini_file();
        public Options()
        {
            InitializeComponent();

            rbtn_SaveTxt.Checked = Config.Read("SaveTxt", "Saving") == "1";

            if (!rbtn_SaveTxt.Checked)
            {
                rbtn_SaveDB.Checked = true;
            }
          
            cbTray.Checked = Config.Read("MinimizeTray", "General") == "1";

            txt_TxtPath.Text = Config.Read("SaveTxt_Path", "Saving");

        }        
       
        private void btn_BrowseTxtFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderPath = new FolderBrowserDialog();

            if (folderPath.ShowDialog() == DialogResult.OK)
            {
                // put the path into the txtbox
                txt_TxtPath.Text = folderPath.SelectedPath + @"\";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rbtn_SaveDB.Checked == true)
            {
                Config.Write("SaveDB", "1", "Saving");
                Config.Write("SaveTxt", "0", "Saving");
                //Config.Write("SaveDB_Host", txt_DbHost.Text, "Saving");
                //Config.Write("SaveDB_User", txt_DbUser.Text, "Saving");
                //Config.Write("SaveDB_Pass", txt_DbPass.Text, "Saving");
                //Config.Write("SaveDB_Name", txt_DbName.Text, "Saving");
            }
            else if (rbtn_SaveTxt.Checked == true)
            {
                Config.Write("SaveDB", "0", "Saving");
                Config.Write("SaveTxt", "1", "Saving");

                Config.Write("SaveTxt_Path", txt_TxtPath.Text, "Saving");
            }
            else
            {
                // Default
                Config.Write("SaveDB", "0", "Saving");
                Config.Write("SaveTxt", "1", "Saving");
            }           

            this.Close();
        }

        private void btn_CancelOptions_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ApplyOptions_Click(object sender, EventArgs e)
        {
            if (rbtn_SaveDB.Checked == true)
            {
                Config.Write("SaveDB", "1", "Saving");
                Config.Write("SaveTxt", "0", "Saving");
                //Config.Write("SaveDB_Host", txt_DbHost.Text, "Saving");
                //Config.Write("SaveDB_User", txt_DbUser.Text, "Saving");
                //Config.Write("SaveDB_Pass", txt_DbPass.Text, "Saving");
                //Config.Write("SaveDB_Name", txt_DbName.Text, "Saving");
            }
            else if (rbtn_SaveTxt.Checked == true)
            {
                Config.Write("SaveDB", "0", "Saving");
                Config.Write("SaveTxt", "1", "Saving");

                Config.Write("SaveTxt_Path", txt_TxtPath.Text, "Saving");
            }
            else
            {
                // Default
                Config.Write("SaveDB", "0", "Saving");
                Config.Write("SaveTxt", "1", "Saving");
            }

            btn_ApplyOptions.Enabled = false;

        }

        private void cbTray_CheckedChanged(object sender, EventArgs e)
        {
            Config.Write("MinimizeTray", cbTray.Checked ? "1" : "0", "General");
        }
    }
}
