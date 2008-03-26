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
        subjectWindow localSubject;
        public BreakTimer()
        {
            InitializeComponent();
        }

        public void startTimer(subjectWindow subjectwindow)
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