using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChairExperiment
{
    public partial class BreakTimer : Form
    {
        int seconds = 120;
        experiment2_MethodofLimits localSubject;
        public BreakTimer()
        {
            InitializeComponent();
        }

        public void startTimer(experiment2_MethodofLimits subjectwindow)
        {
            this.localSubject = subjectwindow;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            this.labelSeconds.Text = seconds.ToString();
            if (seconds == 0)
            {
                localSubject.Enabled = true;
                this.Close();
            }
        }
    }
}