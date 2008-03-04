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

        public subjectWindow()
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
        private void buttonSlower_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `chairexperiment`.`sessions` (`ID`  ,`subjectID` ,`tone1`,`tone2`,`response`) VALUES (NULL , '" + ID + "', '" + anchorStimuli + "', '" + comparisonStimuli + "', 'slower')";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            int hr = command.ExecuteNonQuery();

            MessageBox.Show("Thank you for your response, click OK to begin the next session when ready.");

            tempItem = new System.Windows.Forms.ListViewItem();
            tempItem.Text = session.ToString();
            tempItem.SubItems.Add(firstStimuliPointer.ToString());
            tempItem.SubItems.Add(secondStimuliPointer.ToString());
            tempItem.SubItems.Add(anchorStimuli.ToString());
            tempItem.SubItems.Add(comparisonStimuli.ToString());
            tempItem.SubItems.Add("LOWER");
            //tempItem.SubItems.Add("X");


            this.admin.listView1.Items.Add(tempItem);
            
            session++;
            localSession++;

            this.labelSession.Text = "Session " + session;
            this.admin.labelSessionNumber.Text = "Session " + session;
           
            comparisonStimuli = (double)testFrequencies[localSession];

            this.admin.textBoxFirstFreq.Text = this.anchorStimuli.ToString();
            this.admin.textBoxSecondFreq.Text = this.comparisonStimuli.ToString();

           /* if (firstStimuli != secondStimuli)
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

                //

                //firstStimuli = (double)frequencies[firstStimuliPointer];
                //secondStimuli = (double)frequencies[secondStimuliPointer];

              

                this.admin.textBoxFirstArrayPos.Text = firstStimuliPointer.ToString();
                this.admin.textBoxSecondArrayPos.Text = secondStimuliPointer.ToString();

                this.admin.textBoxFirstFreq.Text = firstStimuli.ToString();//frequencies[firstStimuliPointer].ToString();
                this.admin.textBoxSecondFreq.Text = secondStimuli.ToString();//frequencies[secondStimuliPointer].ToString();

                this.admin.labelSessionNumber.Text = "Session " + session;
                this.admin.labelAnswer.ForeColor = Color.Red;
                this.admin.labelAnswer.Text = "Subject incorrectly stated " + firstStimuli + " and " + secondStimuli + " were the same";

                
            } */       
            this.buttonFaster.Enabled = false;
            this.buttonSlower.Enabled = false;

            checkRandomCase();

            this.buttonPlay1.Enabled = true;

        }
        private void getNewAnchor()
        {
            anchor++;
            localSession = 0;

            this.anchorStimuli = (double)anchorFrequencies[anchor];
            
            testFrequencies = new ArrayList();
            testFrequencies.Add((double)anchorFrequencies[anchor]);

            double previousStimuli = 0;
            double nextStimuli = 0;

            previousStimuli = anchorStimuli / twentyforthrootoftwo;

            for (int i = 0; i < 5; i++)
            {

                testFrequencies.Insert(0, previousStimuli);
                previousStimuli = previousStimuli / twentyforthrootoftwo;
            }

            nextStimuli = anchorStimuli * twentyforthrootoftwo;
            for (int i = 0; i < 10; i++)
            {

                testFrequencies.Add(nextStimuli);
                nextStimuli = nextStimuli * twentyforthrootoftwo;
            }


            this.comparisonStimuli = (double)testFrequencies[localSession];

        }
        private void buttonFaster_Click(object sender, EventArgs e)
        {

            if (anchorStimuli < comparisonStimuli)
            {
                correctHigh++;

                if (correctHigh > 2)
                {
                    getNewAnchor();
                }
            }
            
            tempItem = new System.Windows.Forms.ListViewItem();
            tempItem.Text = session.ToString();
            tempItem.SubItems.Add(firstStimuliPointer.ToString());
            tempItem.SubItems.Add(secondStimuliPointer.ToString());
            tempItem.SubItems.Add(anchorStimuli.ToString());
            tempItem.SubItems.Add(comparisonStimuli.ToString());
            tempItem.SubItems.Add("FASTER");
            tempItem.SubItems.Add("Y");

            this.admin.listView1.Items.Add(tempItem);

            string sql = "INSERT INTO `chairexperiment`.`sessions` (`ID`  ,`subjectID` ,`tone1`,`tone2`,`response`) VALUES (NULL , '" + ID + "', '" + anchorStimuli + "', '" + comparisonStimuli + "', 'faster')";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            int hr = command.ExecuteNonQuery();

            MessageBox.Show("Thank you for your response, click OK to begin the next session when ready.");

            session++;
            localSession++;

            this.labelSession.Text = "Session " + session;
            this.admin.labelSessionNumber.Text = "Session " + session;

            comparisonStimuli = (double)testFrequencies[localSession];


            
           /* previousFirstStimuliPointer = firstStimuliPointer;
            previousSecondStimuliPointer = secondStimuliPointer;

            if (Math.Abs(firstStimuliPointer - secondStimuliPointer) <= 1)
            {
                firstStimuliPointer = secondStimuliPointer;
                secondStimuliPointer = secondStimuliPointer + 1;
                foundPossibleThreshold = false;
                pointerDifference = 1;
                //firstStimuli = (double)frequencies[firstStimuliPointer];
                //secondStimuli = (double)frequencies[secondStimuliPointer];
            }
            else if(anchorStimuli != comparisonStimuli)
            {
                pointerDifference = pointerDifference / 2;
                if (pointerDifference < 1)
                {
                    pointerDifference = 1;
                }
                secondStimuliPointer = secondStimuliPointer - pointerDifference;

                

               // firstStimuli = (double)frequencies[firstStimuliPointer];
               // secondStimuli = (double)frequencies[secondStimuliPointer];

                if (firstStimuliPointer == previousFirstStimuliPointer && secondStimuliPointer == previousSecondStimuliPointer)
                {
                    firstStimuliPointer = secondStimuliPointer;
                    secondStimuliPointer = secondStimuliPointer + 1;
                }

                foundPossibleThreshold = true;
                possibleThresholdValue = comparisonStimuli;

                this.admin.labelAnswer.ForeColor = Color.Green;
                this.admin.labelAnswer.Text = "Subject correctly stated " + anchorStimuli + " and " + comparisonStimuli + " were different";
            }*/

           

            this.admin.textBoxFirstArrayPos.Text = firstStimuliPointer.ToString();
            this.admin.textBoxSecondArrayPos.Text = secondStimuliPointer.ToString();

            this.admin.textBoxFirstFreq.Text = anchorStimuli.ToString();//frequencies[firstStimuliPointer].ToString();
            this.admin.textBoxSecondFreq.Text = comparisonStimuli.ToString();//frequencies[secondStimuliPointer].ToString();

            
            this.buttonFaster.Enabled = false;
            this.buttonSlower.Enabled = false;

            checkRandomCase();


            this.buttonPlay1.Enabled = true;



        }

        private void buttonPlay1_Click(object sender, EventArgs e)
        {
            //add this last minute to avoid playing before play is pressed
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


            this.amplifierCoefficient = 1.0;
            this.signalGen1.Frequency = anchorStimuli;
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
                //firstStimuli = (double)frequencies[arrayPosition];
               // secondStimuli = (double)frequencies[arrayPosition];

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
                this.signalGen1.Frequency = this.comparisonStimuli;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                
            }
            if (counter == 40)
            {
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
                this.buttonFaster.Enabled = true;
                this.buttonSlower.Enabled = true;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
            
            }
        }

        private void subjectWindow_Load(object sender, EventArgs e)
        {
         
        }



    }
}