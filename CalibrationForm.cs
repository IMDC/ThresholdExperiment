using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Odbc;
using System.IO;
using DirectShowLib;
using System.Collections;
//using Mitov.SignalLab;
//using Mitov.PlotLab;

namespace ChairExperiment
{
    public partial class CalibrationForm : Form
    {

        private OdbcConnection mysqlConnection;
        int ID;      
        int session = 1;
        const double e = 2.71828183;

        administratorWindow admin;

        ArrayList anchorFrequencies = new ArrayList();
        ArrayList testFrequencies =  new ArrayList();
       /* ArrayList reverseFrequencies = new ArrayList();
        ArrayList highFrequencies = new ArrayList();
        ArrayList midFrequencies = new ArrayList();
        ArrayList lowFrequencies = new ArrayList();*/

       // double highCoefficient = 25.23;
       // double highExponent = 0.090;

        
       // double lowCoefficient = 25.45;
       // double lowExponent = 0.050;

        static double startingFrequency = 27.5;
        double frequency = startingFrequency;

        const double twentyforthrootoftwo = 1.02930224;
        const double arrayOffset = 0.5;

        double anchorStimuli = 0.0;
        double comparisonStimuli = 0.0;

        int firstStimuliPointer = 0;
        int secondStimuliPointer = 0;

        double amplifierCoefficient = 2;

        ListViewItem tempItem;

        int counter = 0;
        int localSession = 0;
        int anchor = 0;

        int correctHigh = 0;

        public CalibrationForm()
        {
            
            InitializeComponent();
            this.signalGen1.Stop();

            anchorFrequencies.Add(32.7032);//C1
            anchorFrequencies.Add(46.2493);//F#1

            anchorFrequencies.Add(65.4064);//C2
            anchorFrequencies.Add(92.4986);//F#2

            anchorFrequencies.Add(130.813);//C3
            anchorFrequencies.Add(184.997);//F#3

            anchorFrequencies.Add(261.626);//C4
            anchorFrequencies.Add(369.994);//F#4

            anchorFrequencies.Add(523.251);//C5
            anchorFrequencies.Add(739.989);//F#5

            anchorFrequencies.Add(1046.50);//C5
            anchorFrequencies.Add(1479.98);//F#6

            this.anchorStimuli = (double)anchorFrequencies[anchor];

            testFrequencies.Add((double)anchorFrequencies[localSession]);

            double previousStimuli = 0;
            double nextStimuli = 0;
            
            previousStimuli = anchorStimuli / twentyforthrootoftwo;

            for(int i = 0; i < 5; i++){                
                
                testFrequencies.Insert(0, previousStimuli);
                previousStimuli = previousStimuli / twentyforthrootoftwo;
            }

            nextStimuli = anchorStimuli * twentyforthrootoftwo;
            for(int i = 0; i < 10; i++){                
               
                testFrequencies.Add(nextStimuli);
                nextStimuli = nextStimuli * twentyforthrootoftwo;
            }


            this.comparisonStimuli = (double)testFrequencies[localSession];


          
           


        }
   

        public void link(OdbcConnection mysqlConnection, int ID, administratorWindow admin)
        {
            this.mysqlConnection = mysqlConnection;
            this.ID = ID;
            this.admin = admin;

            this.admin.textBoxFirstArrayPos.Text = firstStimuliPointer.ToString();
            this.admin.textBoxSecondArrayPos.Text = secondStimuliPointer.ToString();

           // this.admin.textBoxFirstFreq.Text = frequencies[firstStimuliPointer].ToString();
           // this.admin.textBoxSecondFreq.Text = frequencies[secondStimuliPointer].ToString();

            this.admin.labelSessionNumber.Text = "Session " + session;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((System.ComponentModel.ISupportInitialize)(this.dsAudioOut1)).EndInit();
            // Mitov.AudioLab.SystemMixer mixer = new Mitov.AudioLab.SystemMixer();

            /*if (this.firstStimuli < 10)
            {
                this.amplifierCoefficient = 1.0;
            }
            else if (this.firstStimuli >= 10 && this.secondStimuli < 20)
            {
                this.amplifierCoefficient = 1.0;
            }
            else if (this.firstStimuli >= 20)
            {
                this.amplifierCoefficient = 1.0;
            }*/


            this.amplifierCoefficient = Convert.ToDouble(this.textBoxAmp.Text);
            this.signalGen1.Frequency = Convert.ToDouble(this.textBoxFreq.Text);
            this.amplifier1.Coefficient = this.amplifierCoefficient;
            Mitov.AudioLab.AudioFormat audioFormat1 = new Mitov.AudioLab.AudioFormat();

            // this.admin.labelIsPlaying.Text = "Now playing Frequency 1";
            //buttonPlay1.Text = "STOP";
            this.signalGen1.Start();
           // this.timer1.Start();

            //this.buttonPlay1.Enabled = false;
        }

        private void CalibrationForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.signalGen1.Stop();
        }
        



    }
}