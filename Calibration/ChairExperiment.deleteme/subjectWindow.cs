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
    public partial class subjectWindow : Form
    {

        private OdbcConnection mysqlConnection;
        int ID;      
        int session = 1;

        administratorWindow admin;

        ArrayList frequencies = new ArrayList();
        ArrayList reverseFrequencies = new ArrayList();

        static double startingFrequency = 25;
        double frequency = startingFrequency;

        const double twentyforthrootoftwo = 1.02930224;
        const double arrayOffset = 0.5;

        double firstStimuli = 0.0;
        double secondStimuli = 0.0;

        int firstStimuliPointer = 0;
        int secondStimuliPointer = 0;

        int previousFirstStimuliPointer = 0;
        int previousSecondStimuliPointer = 0;

        int pointerDifference = 1;

        bool foundPossibleThreshold = false;
        double possibleThresholdValue = 0.0;

        double amplifierCoefficient = 1;

        ListViewItem tempItem;

        int counter = 0;

        public subjectWindow()
        {
            
            InitializeComponent();
            this.signalGen1.Stop();

            while (frequency < 1200)
            {
                frequencies.Add(frequency);
                //frequency = frequency + arrayOffset;
                frequency = frequency * twentyforthrootoftwo;
            }
           /* this.reverseFrequencies.Insert(0, 25);
            this.reverseFrequencies.Insert(0, 25);
            this.reverseFrequencies.Insert(0, 25);
            this.reverseFrequencies.Insert(0, 25);
            this.reverseFrequencies.Insert(0, 25);
            this.reverseFrequencies.Insert(0, 25);

            /*reverse array************************************************/
            foreach (double freq in frequencies)
            {
                this.reverseFrequencies.Insert(0, freq);
            }
            /*reverse array************************************************/
          // frequencies = this.reverseFrequencies
            
            firstStimuliPointer = 0;
            secondStimuliPointer = firstStimuliPointer + pointerDifference;

            firstStimuli = (double)frequencies[firstStimuliPointer];
            secondStimuli = (double)frequencies[secondStimuliPointer];

        }

        public void link(OdbcConnection mysqlConnection, int ID, administratorWindow admin)
        {
            this.mysqlConnection = mysqlConnection;
            this.ID = ID;
            this.admin = admin;

            this.admin.textBoxFirstArrayPos.Text = firstStimuliPointer.ToString();
            this.admin.textBoxSecondArrayPos.Text = secondStimuliPointer.ToString();

            this.admin.textBoxFirstFreq.Text = frequencies[firstStimuliPointer].ToString();
            this.admin.textBoxSecondFreq.Text = frequencies[secondStimuliPointer].ToString();

            this.admin.labelSessionNumber.Text = "Session " + session;
        }
        private void buttonSame_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `chairexperiment`.`sessions` (`ID`  ,`subjectID` ,`tone1`,`tone2`,`response`) VALUES (NULL , '" + ID + "', '" + firstStimuli + "', '" + secondStimuli + "', 'same')";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            int hr = command.ExecuteNonQuery();

            MessageBox.Show("Thank you for your response, click OK to begin the next session when ready.");

            tempItem = new System.Windows.Forms.ListViewItem();
            tempItem.Text = session.ToString();
            tempItem.SubItems.Add(firstStimuliPointer.ToString());
            tempItem.SubItems.Add(secondStimuliPointer.ToString());
            tempItem.SubItems.Add(firstStimuli.ToString());
            tempItem.SubItems.Add(secondStimuli.ToString());
            tempItem.SubItems.Add("SAME");
            tempItem.SubItems.Add("X");


            this.admin.listView1.Items.Add(tempItem);

            session++;

            this.labelSession.Text = "Session " + session;
            this.admin.labelSessionNumber.Text = "Session " + session;

            if (firstStimuli != secondStimuli)
            {

               // previousFirstStimuliPointer = firstStimuliPointer;
              //  previousSecondStimuliPointer = secondStimuliPointer;

                if (foundPossibleThreshold == true)
                {
                    foundPossibleThreshold = false;
                    firstStimuliPointer = previousSecondStimuliPointer;
                    secondStimuliPointer = firstStimuliPointer + 1;
                }
                else
                {                    
                    pointerDifference = pointerDifference * 2;
                    secondStimuliPointer = secondStimuliPointer + pointerDifference ;
                }
                this.admin.textBoxFirstArrayPos.Text = firstStimuliPointer.ToString();
                this.admin.textBoxSecondArrayPos.Text = secondStimuliPointer.ToString();

                this.admin.textBoxFirstFreq.Text = frequencies[firstStimuliPointer].ToString();
                this.admin.textBoxSecondFreq.Text = frequencies[secondStimuliPointer].ToString();

                firstStimuli = (double)frequencies[firstStimuliPointer];
                secondStimuli = (double)frequencies[secondStimuliPointer];

              

                this.admin.textBoxFirstArrayPos.Text = firstStimuliPointer.ToString();
                this.admin.textBoxSecondArrayPos.Text = secondStimuliPointer.ToString();

                this.admin.textBoxFirstFreq.Text = firstStimuli.ToString();//frequencies[firstStimuliPointer].ToString();
                this.admin.textBoxSecondFreq.Text = secondStimuli.ToString();//frequencies[secondStimuliPointer].ToString();

                this.admin.labelSessionNumber.Text = "Session " + session;
                this.admin.labelAnswer.ForeColor = Color.Red;
                this.admin.labelAnswer.Text = "Subject incorrectly stated " + firstStimuli + " and " + secondStimuli + " were the same";

                
            }        
            this.buttonDifferent.Enabled = false;
            this.buttonSame.Enabled = false;

            checkRandomCase();

            this.buttonPlay1.Enabled = true;

        }

        private void buttonDifferent_Click(object sender, EventArgs e)
        {
            tempItem = new System.Windows.Forms.ListViewItem();
            tempItem.Text = session.ToString();
            tempItem.SubItems.Add(firstStimuliPointer.ToString());
            tempItem.SubItems.Add(secondStimuliPointer.ToString());
            tempItem.SubItems.Add(firstStimuli.ToString());
            tempItem.SubItems.Add(secondStimuli.ToString());
            tempItem.SubItems.Add("DIFF");
            tempItem.SubItems.Add("Y");

            this.admin.listView1.Items.Add(tempItem);

            string sql = "INSERT INTO `chairexperiment`.`sessions` (`ID`  ,`subjectID` ,`tone1`,`tone2`,`response`) VALUES (NULL , '" + ID + "', '" + firstStimuli + "', '" + secondStimuli + "', 'different')";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            int hr = command.ExecuteNonQuery();

            MessageBox.Show("Thank you for your response, click OK to begin the next session when ready.");

            session++;

            this.labelSession.Text = "Session " + session;
            this.admin.labelSessionNumber.Text = "Session " + session;
            
            previousFirstStimuliPointer = firstStimuliPointer;
            previousSecondStimuliPointer = secondStimuliPointer;

            if (Math.Abs(firstStimuliPointer - secondStimuliPointer) <= 1)
            {
                firstStimuliPointer = secondStimuliPointer;
                secondStimuliPointer = secondStimuliPointer + 1;
                foundPossibleThreshold = false;
                pointerDifference = 1;
                firstStimuli = (double)frequencies[firstStimuliPointer];
                secondStimuli = (double)frequencies[secondStimuliPointer];
            }
            else if(firstStimuli != secondStimuli)
            {
                pointerDifference = pointerDifference / 2;
                if (pointerDifference < 1)
                {
                    pointerDifference = 1;
                }
                secondStimuliPointer = secondStimuliPointer - pointerDifference;

                

                firstStimuli = (double)frequencies[firstStimuliPointer];
                secondStimuli = (double)frequencies[secondStimuliPointer];

                if (firstStimuliPointer == previousFirstStimuliPointer && secondStimuliPointer == previousSecondStimuliPointer)
                {
                    firstStimuliPointer = secondStimuliPointer;
                    secondStimuliPointer = secondStimuliPointer + 1;
                }

                foundPossibleThreshold = true;
                possibleThresholdValue = secondStimuli;

                this.admin.labelAnswer.ForeColor = Color.Green;
                this.admin.labelAnswer.Text = "Subject correctly stated " + firstStimuli + " and " + secondStimuli + " were different";
            }

           

            this.admin.textBoxFirstArrayPos.Text = firstStimuliPointer.ToString();
            this.admin.textBoxSecondArrayPos.Text = secondStimuliPointer.ToString();

            this.admin.textBoxFirstFreq.Text = firstStimuli.ToString();//frequencies[firstStimuliPointer].ToString();
            this.admin.textBoxSecondFreq.Text = secondStimuli.ToString();//frequencies[secondStimuliPointer].ToString();

            
            this.buttonDifferent.Enabled = false;
            this.buttonSame.Enabled = false;

            checkRandomCase();


            this.buttonPlay1.Enabled = true;



        }

        private void buttonPlay1_Click(object sender, EventArgs e)
        {
            //add this last minute to avoid playing before play is pressed
            ((System.ComponentModel.ISupportInitialize)(this.dsAudioOut1)).EndInit();
           // Mitov.AudioLab.SystemMixer mixer = new Mitov.AudioLab.SystemMixer();

           /* if (this.firstStimuli < 10)
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
           // this.amplifierCoefficient = 1.0;
            this.signalGen1.Frequency = firstStimuli;
            this.amplifier1.Coefficient = this.amplifierCoefficient;
            Mitov.AudioLab.AudioFormat audioFormat1 = new Mitov.AudioLab.AudioFormat();          

           // this.admin.labelIsPlaying.Text = "Now playing Frequency 1";
            //buttonPlay1.Text = "STOP";
            this.signalGen1.Start();
            this.timer1.Start();

            this.buttonPlay1.Enabled = false;
                
        }

        public void checkRandomCase(){
            Random random = new Random();

            int randomCase = random.Next(1, 10);

            if (randomCase == 10)
            {
                int arrayPosition = random.Next(0,127);
                firstStimuli = (double)frequencies[arrayPosition];
                secondStimuli = (double)frequencies[arrayPosition];

                this.admin.labelSessionNumber.Text = "RANDOM SESSION " + arrayPosition;
            }
        }
        

        public static IBaseFilter AddFilterFromClsId(IGraphBuilder graphBuilder, Guid clsid, string name)
        {
            int hr = 0;

            Type type = Type.GetTypeFromCLSID(clsid);
            IBaseFilter filter = (IBaseFilter)Activator.CreateInstance(type);

            hr = graphBuilder.AddFilter(filter, name);
            DsError.ThrowExceptionForHR(hr);

            return filter;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 1)
            {
                this.label1.ForeColor = Color.Red;
                this.label2.ForeColor = Color.Black;
            }

            if (counter == 30)
            {
                this.signalGen1.Stop();
                this.signalGen1.Frequency = this.secondStimuli;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                
            }
            if (counter == 40)
            {
             //   this.amplifier1.Coefficient =0.25;
                this.signalGen1.Start();
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Red;
                //this.signalGen1.Frequency = this.secondStimuli;
            }
            if (counter == 70)
            {
                this.signalGen1.Stop();
                this.counter = 0;
                this.timer1.Stop();
                this.buttonDifferent.Enabled = true;
                this.buttonSame.Enabled = true;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
            
            }
        }

        private void subjectWindow_Load(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add this last minute to avoid playing before play is pressed
            ((System.ComponentModel.ISupportInitialize)(this.dsAudioOut1)).EndInit();
            // Mitov.AudioLab.SystemMixer mixer = new Mitov.AudioLab.SystemMixer();

            /* if (this.firstStimuli < 10)
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
            // this.amplifierCoefficient = 1.0;
            this.signalGen1.Frequency = Convert.ToDouble(this.textBoxFreq.Text);
            this.amplifier1.Coefficient = Convert.ToDouble(this.textBoxAmp.Text);
            Mitov.AudioLab.AudioFormat audioFormat1 = new Mitov.AudioLab.AudioFormat();

            // this.admin.labelIsPlaying.Text = "Now playing Frequency 1";
            //buttonPlay1.Text = "STOP";
            this.signalGen1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.signalGen1.Stop();
        }



    }
}