using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Window.libs
{
    public class Timer_Functions
    {
        Timer timer;

        int time = 0;

        TextBox textbox = new TextBox();
        Handlers.Ini_Handler Config = new Handlers.Ini_Handler();
        

        public Timer_Functions(TextBox x)
        {
            textbox = x;
            textbox.Text = Time_Format(0);           
        }

        public void Timer_Start()
        {
         
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Time_Elapsed;
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
            timer.Stop();            
        }
        public void Timer_Pause()
        {
            timer.Stop();  
        }
        public void Timer_Save()
        {
            string date = DateTime.Now.ToString();
            string[] data = date.Split(' ');

            if (Config.Read("SaveTxt", "Saving") == "1")
            {
                string FilePath = Config.Read("SaveTxtPath", "Saving") + data[0] + ".txt";

                using (StreamWriter file = File.AppendText(FilePath))
                {
                    file.WriteLine("Date: " + data[0] + "\n Timestamp: " + data[1] + "\n Working Hours: " + Time_Format(time) + "\n\n");
                }

            }  

        }

    }
}
