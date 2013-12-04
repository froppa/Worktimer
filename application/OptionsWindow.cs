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
    public partial class OptionsWindow : Form
    {
        Handlers.Ini_Handler Config = new Handlers.Ini_Handler();
        public OptionsWindow()
        {
            InitializeComponent();
        }
       
        private void btn_BrowseTxtFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderPath = new FolderBrowserDialog();

            if (folderPath.ShowDialog() == DialogResult.OK)
            {
                // put the path into the txtbox
                txt_TxtPath.Text = folderPath.SelectedPath + "\\";
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

                Config.Write("SaveTxtPath", txt_TxtPath.Text + "\\", "Saving");
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

                Config.Write("SaveTxtPath", txt_TxtPath.Text, "Saving");
            }
            else
            {
                // Default
                Config.Write("SaveDB", "0", "Saving");
                Config.Write("SaveTxt", "1", "Saving");
            }

            btn_ApplyOptions.Enabled = false;

        }
    }
}
