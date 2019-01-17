using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class Form1 : Form
    {
        private DateTime mTrigger;
        private TimeSpan mPauseToGo;
        private bool mPaused;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan sp = mTrigger - DateTime.Now;
            if (sp.Ticks < 0)
            {
                sp = new TimeSpan();
                timer1.Enabled = false;
                startBtn.Text = "Start";

            }
            TimerCount.Text = string.Format("{0}:{1:00}", sp.Minutes, sp.Seconds);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (mPaused)
            {
                timer1.Enabled = true;
                mPaused = false;
                mTrigger = DateTime.Now + mPauseToGo;
                startBtn.Text = "Pause";
            }
            else if (timer1.Enabled)            
            {
                timer1.Enabled = false;
                startBtn.Text = "Resume";
                mPauseToGo = mTrigger - DateTime.Now;
                mPaused = true;
            }
            else
            {
                timer1.Enabled = true;
                startBtn.Text = "Pause";
                mTrigger = DateTime.Now + new TimeSpan(0, 25, 0);
                timer1_Tick(this, EventArgs.Empty);
            }
        }
    }
}
