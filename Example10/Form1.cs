using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example10
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int seconds = 0;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            btnStart.Click += BtnStart_Click;
            btnStop.Click += BtnStop_Click;
            btnClear.Click += BtnClear_Click;
            UpdateLabel();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            UpdateLabel();
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            timer.Stop();
            seconds = 0;
            UpdateLabel();
        }
        private void UpdateLabel()
        {
            int min = seconds / 60;
            int sec = seconds % 60;
            lblTime.Text = $"{min:00}:{sec:00}";
        }
    }
}
