using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Elysium;

/* *** BUGS ***
 * 
 * 
 * 
 * *** TO-DO ***
 * 
 * Config file ( DONE )
 * Changing icon ( DONE )
 * Change GUI
 * Tray_Icon ( Right click = Start/Stop/pause timer ) ( DONE)
 * Installer
 * Alarm
 * Current Project ( be able to make a project and manage hours )
 * Project manager
 * Port to Mac
 * 
 * Restructure some of the code, making a Core file to init everything instead of the timing window.. 
 * Make a bootstrap
 * */


namespace Worktimer
{
    public partial class Form1 : Form
    {
        libs.Timer_Functions Timer;

        public Form1()
        {
            InitializeComponent();
            Timer = new libs.Timer_Functions(this.Counter_TextBox);

            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }

            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Work_Timer_Tray.Visible = true;
                this.Hide();
                e.Cancel = true;
            }
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
       

        private void start_Click(object sender, EventArgs e)
        {
            start_Button.Enabled = false;
            pause_Button.Enabled = true;
            stop_Button.Enabled = true;

            this.startToolStripMenuItem.Enabled = false;
            this.pauseToolStripMenuItem.Enabled = true;
            this.stopToolStripMenuItem.Enabled = true;

            Counter_TextBox.Text = Timer.Time_Format(0);   
            Timer.Timer_Start();            

        }

        private void pause_Click(object sender, EventArgs e)
        {            
            if (Timer.Timer_Enabled())
            {
                pause_Button.Text = "Resume";
                pauseToolStripMenuItem.Text = "Resume";
                Timer.Timer_Pause();
            }
            else
            {
                pause_Button.Text = "Pause";
                pauseToolStripMenuItem.Text = "Pause";
                Timer.Timer_Start();
            }
        }
        
        private void stop_Click(object sender, EventArgs e)
        {  
            start_Button.Enabled = true;
            pause_Button.Enabled = false;
            stop_Button.Enabled = false;

            this.startToolStripMenuItem.Enabled = true;
            this.pauseToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Enabled = false;

            Counter_TextBox.Text = Timer.Time_Format(0);
            Timer.Timer_Pause();

            pause_Button.Text = "Pause";
            pauseToolStripMenuItem.Text = "Pause";
            
            DialogResult SaveBox = MessageBox.Show("Do you wish to save the data?", "Saveing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(SaveBox == DialogResult.Yes)
            {
                Timer.Timer_Save();
                Timer.Timer_Stop();                
            }
            else
            {
                Timer.Timer_Stop();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start_Button.Enabled = false;
            pause_Button.Enabled = true;
            stop_Button.Enabled = true;

            this.startToolStripMenuItem.Enabled = false;
            this.pauseToolStripMenuItem.Enabled = true;
            this.stopToolStripMenuItem.Enabled = true;

            pause_Button.Text = "Pause";
            pauseToolStripMenuItem.Text = "Pause";        
          
        

            Counter_TextBox.Text = Timer.Time_Format(0);
            Timer.Timer_Start();    
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Timer.Timer_Enabled())
            {
                pause_Button.Text = "Resume";
                pauseToolStripMenuItem.Text = "Resume";
                Timer.Timer_Pause();
            }
            else
            {
                pause_Button.Text = "Pause";
                pauseToolStripMenuItem.Text = "Pause";
                Timer.Timer_Start();
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start_Button.Enabled = true;
            pause_Button.Enabled = false;
            stop_Button.Enabled = false;

            this.startToolStripMenuItem.Enabled = true;
            this.pauseToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Enabled = false;

            Counter_TextBox.Text = Timer.Time_Format(0);
            Timer.Timer_Pause();

            pause_Button.Text = "Pause";
            pauseToolStripMenuItem.Text = "Pause";

            DialogResult SaveBox = MessageBox.Show("Do you wish to save the data?", "Saveing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SaveBox == DialogResult.Yes)
            {
                Timer.Timer_Save();
                Timer.Timer_Stop();
            }
            else
            {
                Timer.Timer_Stop();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options_Window options = new Options_Window();
            options.Show(); // then just this
        }
    }
}
