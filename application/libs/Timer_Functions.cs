using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worktimer.libs
{
    public class Timer_Functions
    {
        Timer timer;

        int time = 0;

        TextBox textbox = new TextBox();
        handlers.ini_file Config = new handlers.ini_file();

        bool running;

        public bool Running
        {
            get
            {
                return running;
            }
            set
            {
                running = value;
            }
        }

        public Timer_Functions(TextBox x)
        {
            textbox = x;
            textbox.Text = Time_Format(0);
            running = false;
        }

        public void Timer_Start()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Time_Elapsed;
            running = true;
            timer.Start();
        }

        void Time_Elapsed(object sender, EventArgs e)
        {
            ++time;
            textbox.Text = Time_Format(time);
        }     

        public string Time_Format(int time)
        {
            TimeSpan t = TimeSpan.FromSeconds(time);
            string time_formatted = string.Format("{0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
            return time_formatted;
        }

        public bool Timer_Enabled()
        {
            return timer.Enabled;
        }

        public void Timer_Stop()
        {
            time = 0;
            running = false;
            timer.Stop();
        }
        public void Timer_Pause()
        {
            timer.Stop();  
        }

        public void Timer_Save()
        {
            string datetime = DateTime.Now.ToString();
            string date = DateTime.Now.ToString("dd-MM-yyyy");

            if (Config.Read("SaveTxt", "Saving") == "1")
            {
                string filepath = Config.Read("SaveTxt_Path", "Saving") + date + ".txt";

                string dir = System.IO.Path.GetDirectoryName(filepath);
                if (!System.IO.Directory.Exists(dir))
                {
                    System.IO.Directory.CreateDirectory(dir);
                }

                using (StreamWriter file = File.AppendText(filepath))
                {
                    file.WriteLine("Date: " + date + " Timestamp: " + datetime + " Working Hours: " + Time_Format(time) + "\n\n");
                    // Find a better view..
                }

            }  

        }

    }
}
