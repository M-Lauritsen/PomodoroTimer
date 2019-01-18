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

            pausestart();

        }
        
        private void pausestart()
        {
            if (TimerCount.Text == "0:00")
            {
                TextLabel.Text = "Break!";
            }
            else if (TimerCount.Text != "0:00")
            {
                TextLabel.Text = "";

            }
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
            pausestart();

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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, Location.Y - lastLocation.Y + e.Y);

                Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
