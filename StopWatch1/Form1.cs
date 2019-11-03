using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Lbl_hour.Text = null;
            Lbl_min.Text = null;
            Lbl_sec.Text = null;
            Lbl_msec.Text = null;
        }

        private string postTime;
        int hour, min, sec, msec;

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            hour = 0;
            min = 0;
            sec = 0;
            msec = 0;

            Lbl_msec.Text = msec.ToString();
            Lbl_sec.Text = sec.ToString();
            Lbl_min.Text = min.ToString();
            Lbl_hour.Text = hour.ToString();
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            aTimer.Enabled = true;
        }

        private void Btn_stop_Click(object sender, EventArgs e)
        {
            aTimer.Enabled = false;
        }

        private void aTimer_Tick(object sender, EventArgs e)
        {
            if(msec == 100)
            {
                sec++;
                msec = 0;
            }
            if(sec == 60)
            {
                min++;
                sec = 0;
            }
            if(sec == 60)
            {
                hour++;
            }
            
            
            msec += aTimer.Interval;

            Lbl_msec.Text = msec.ToString();
            Lbl_sec.Text = sec.ToString();
            Lbl_min.Text = min.ToString();
            Lbl_hour.Text = hour.ToString();

        }

        private void Btn_getTime_Click(object sender, EventArgs e)
        {
            postTime = hour.ToString() + ":" +  min.ToString() + ":" + sec.ToString() + ":" + msec.ToString();
            Lb_times.Items.Add(postTime);
        }
    }
}
