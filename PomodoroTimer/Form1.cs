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

        DateTime endoftime = new DateTime();
        
        public Form1()
        {
            InitializeComponent();
        }


        private void t_Tick(object p1, object p2)
        {
            TimeSpan ts = endoftime.Subtract(DateTime.Now);            
            TimerCount.Text = ts.ToString(@"mm\:ss");
        }

        public void startBtn_Click(object sender, EventArgs e)
        {
            startTimer();
            
        }

        public void startTimer()
        {
            endoftime = DateTime.Now.AddMinutes(25);
            Timer t = new Timer() { Interval = 1, Enabled = true };
            t.Tick += new EventHandler(t_Tick);
            t_Tick(null, null);
        }
    }
}
