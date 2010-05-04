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
using Mitov.SignalLab;
using Mitov.PlotLab;

namespace ChairExperiment
{
    
    public partial class experiment1_DirectScaling : Form
    {

        private OdbcConnection mysqlConnection;
        int ID;
        int session = 1;
        const double e = 2.71828183;

        administratorWindow admin;

        ArrayList anchorFrequencies = new ArrayList();
        ArrayList testFrequencies = new ArrayList();

        static double startingFrequency = 27.5;
        double frequency = startingFrequency;

        //const double twentyforthrootoftwo = 1.02930224;
        //const double twelfthrootoftwo = 1.05946309;

        const double twentyforthrootoftwo = 1.05946309;
        const double arrayOffset = 0.5;

        double anchorStimuli = 0.0;
        double comparisonStimuli = 0.0;

        int firstStimuliPointer = 0;
        int secondStimuliPointer = 0;

        double amplifierCoefficient = 2;
        double comparisonamplifierCoefficient = 2;

        ListViewItem tempItem;

        int counter = 0;
        int localSession = 0;
        //int anchor = 0;

        int correctHigh = 0;
        int correctLow = 0;

        bool firstHalfComplete = false;


        int freq1;
        int freq2; // bring it over from calibration form. use setter methods.
        int ampl1; // 0-32500
        int ampl2;

        Form internalForm;


        double currentTestFrequency = 0.0;

        double[] comparisonFrequencies = new double[11];
        double[] subjectiveIntensityValues = new double[11];

        Random random = new Random(DateTime.UtcNow.Millisecond);

        ArrayList usedStimuli = new ArrayList();

        int anchor = 200;


        public  experiment1_DirectScaling()
        {

            InitializeComponent();
            this.signalGen1.Stop();

            comparisonFrequencies[0] = 230;
            comparisonFrequencies[1] = 225;
            comparisonFrequencies[2] = 220;
            comparisonFrequencies[3] = 215;
            comparisonFrequencies[4] = 210;
            comparisonFrequencies[5] = 205;
            comparisonFrequencies[6] = 200;
            comparisonFrequencies[7] = 195;
            comparisonFrequencies[8] = 190;
            comparisonFrequencies[9] = 185;
            comparisonFrequencies[10] = 180;
            comparisonFrequencies[11] = 175;
            comparisonFrequencies[12] = 170;

            subjectiveIntensityValues[0] = 0.9;
            subjectiveIntensityValues[1] = 0.9;
            subjectiveIntensityValues[2] = 0.9;
            subjectiveIntensityValues[3] = 0.9;
            subjectiveIntensityValues[4] = 1.0;
            subjectiveIntensityValues[5] = 1.0;
            subjectiveIntensityValues[6] = 1.0;
            subjectiveIntensityValues[7] = 1.0;
            subjectiveIntensityValues[8] = 1.0;
            subjectiveIntensityValues[9] = 1.1;
            subjectiveIntensityValues[10] = 1.1; 
            subjectiveIntensityValues[11] = 1.1;
            subjectiveIntensityValues[12] = 1.1;


            showAll();
                   
        }



        public void link(OdbcConnection mysqlConnection, int ID, administratorWindow admin)
        {
            this.mysqlConnection = mysqlConnection;
            this.ID = ID;
            this.admin = admin;

            this.admin.textBoxFirstArrayPos.Text = firstStimuliPointer.ToString();
            this.admin.textBoxSecondArrayPos.Text = secondStimuliPointer.ToString();

            this.admin.labelSessionNumber.Text = "Session " + session;
        }

        /*private void getNewAnchor()
        {
            anchor++;
            localSession = 0;
            correctHigh = 0;
            correctLow = 0;



            try
            {
                this.anchorStimuli = (double)anchorFrequencies[anchor];
            }
            catch (Exception ex)
            {
                //end of first half, repeat but reverse direction
                firstHalfComplete = true;
                anchor = 0;
                this.anchorStimuli = (double)anchorFrequencies[anchor];
            }

            testFrequencies = new ArrayList();
            testFrequencies.Add((double)anchorFrequencies[anchor]);

            double previousStimuli = 0;
            double nextStimuli = 0;
            //firstHalfComplete = true;
            if (firstHalfComplete)
            {
                nextStimuli = anchorStimuli / twentyforthrootoftwo;

                for (int i = 0; i < 20; i++)
                {

                    testFrequencies.Add(nextStimuli);
                    nextStimuli = nextStimuli / twentyforthrootoftwo;
                }

                previousStimuli = anchorStimuli * twentyforthrootoftwo;
                for (int i = 0; i < 5; i++)
                {

                    testFrequencies.Insert(0, previousStimuli);
                    previousStimuli = previousStimuli * twentyforthrootoftwo;
                }
            }
            else
            {
                previousStimuli = anchorStimuli / twentyforthrootoftwo;

                for (int i = 0; i < 5; i++)
                {

                    testFrequencies.Insert(0, previousStimuli);
                    previousStimuli = previousStimuli / twentyforthrootoftwo;
                }

                nextStimuli = anchorStimuli * twentyforthrootoftwo;
                for (int i = 0; i < 20; i++)
                {

                    testFrequencies.Add(nextStimuli);
                    nextStimuli = nextStimuli * twentyforthrootoftwo;
                }

            }

            this.comparisonStimuli = (double)testFrequencies[localSession];

        }*/

        private void buttonStartVibration_Click(object sender, EventArgs e)
        {
            
            buttonStartVibration.Enabled = false;
            ((System.ComponentModel.ISupportInitialize)(this.channelMerger1)).EndInit();
            
            int index = random.Next(0, 13);

           

            currentTestFrequency = comparisonFrequencies[index];

                
                
                
                
            this.signalGen1.Frequency = anchor;



            this.amplifier1.Coefficient = subjectiveIntensityValues[index];


            try
            {
                this.signalGen1.Start();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("hey");
            }


            this.timer1.Start();

            //this.buttonPlay1.Enabled = false; 
            //this.buttonPlay2.Enabled = true;
            
            /*string sql = "INSERT INTO `chairexperiment`.`sessions` (`ID`  ,`subjectID` ,`tone1`,`tone2`,`response`) VALUES (NULL , '" + ID + "', '" + anchorStimuli + "', '" + comparisonStimuli + "', 'slower')";

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
            if (anchorStimuli > comparisonStimuli)
            {
                tempItem.SubItems.Add("Y");
            }
            else
            {
                tempItem.SubItems.Add("N");
            }


            this.admin.listView1.Items.Add(tempItem);

            session++;
            localSession++;

            this.labelSession.Text = "Session " + session;
            this.admin.labelSessionNumber.Text = "Session " + session;

            try
            {
                comparisonStimuli = (double)testFrequencies[localSession];
            }
            catch(Exception ex){
                getNewAnchor();
            }

            this.admin.textBoxFirstFreq.Text = this.anchorStimuli.ToString();
            this.admin.textBoxSecondFreq.Text = this.comparisonStimuli.ToString();

            
            this.buttonStart.Enabled = false;



           

            //correctHigh = 0;

            if (anchorStimuli > comparisonStimuli && anchorStimuli != comparisonStimuli && firstHalfComplete)
            {
                correctLow++;

                if (correctLow > 2)
                {
                    getNewAnchor();
                }
            }
            checkBreak();*/
        }
        
        
        private void checkBreak()
        {
            if (this.session % 50 == 0)
            {
                BreakTimer breaktimer = new BreakTimer();                
                breaktimer.Left = this.Left;
                breaktimer.Show();

                breaktimer.labelMessage.Text = "You have completed " + this.session.ToString() + " sessions. Please rest for 2 minutes.";
                //breaktimer.startTimer(this);
                this.Enabled = false;
                
            }
        }
        

        



        

        

        public void setfreq1(int freq){
            freq1 = freq;
        }

        public void setfreq2(int freq)
        {
            freq2 = freq;
        }

        

        public void nextTrial()
        {
            disableButtons();
            this.buttonStartVibration.Enabled = true;
            
  
            //checkBreak();
            session++;
            this.labelSession.Text = "Session " + session;
            





        }

        public void disableButtons(){
            
            //this.buttonAcceptRating.Enabled = false;

        }
        //public void enableButtons()
        //{

          //  this.buttonStartVibration.Enabled = true;
            //this.buttonAcceptRating.Enabled = true;

        //}

        public void hideAll()
        {
            this.labelSession.Visible = false;
            this.buttonStartVibration.Visible = false;
            
            

        }

        public void showAll()
        {
            this.labelSession.Visible = true;
            this.buttonStartVibration.Visible = true;
            
            
            
            
            //this.Controls.Remove(this.buttonExampleof2);
            //this.Controls.Remove(this.buttonExampleof8);
        }

        private void buttonExampleof2_Click(object sender, EventArgs e)
        {
            //buttonExampleof2.Enabled = false;
            //buttonExampleof8.Enabled = true;

            ((System.ComponentModel.ISupportInitialize)(this.channelMerger1)).EndInit();

            
            currentTestFrequency = comparisonFrequencies[4];





            this.signalGen1.Frequency = currentTestFrequency;



            this.amplifier1.Coefficient = subjectiveIntensityValues[4];


            try
            {
                this.signalGen1.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("hey");
            }

            timer2.Start();
        }

        private void buttonExampleof8_Click(object sender, EventArgs e)
        {
            //buttonExampleof2.Enabled = false;
            //buttonExampleof8.Enabled = false;

            ((System.ComponentModel.ISupportInitialize)(this.channelMerger1)).EndInit();


            currentTestFrequency = comparisonFrequencies[8];





            this.signalGen1.Frequency = currentTestFrequency;



            this.amplifier1.Coefficient = subjectiveIntensityValues[8];


            try
            {
                this.signalGen1.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("hey");
            }

            timer2.Start();

            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;


            if (counter == 30)
            {
                this.signalGen1.Stop();
                //this.timer1.Stop();
                

                
                this.buttonStartVibration.Enabled = false;
                

                
                counter = 0;



            }
            if (counter == 40)
            {
                //this.signalGen1.Start;
                //this.timer1.Stop();



                this.buttonStartVibration.Enabled = false;



                counter = 0;



            }


        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            counter++;


            if (counter == 30)
            {
                this.signalGen1.Stop();

               

                

                this.timer2.Stop();
                



            }
            if (counter == 60)
            {
                this.signalGen1.Stop();



                

                this.timer2.Stop();
                counter = 0;
                showAll();


            }
        }



       

        private void buttonHigher_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `chairexperiment`.`experiment1` (`ID`  ,`subjectID` ,`anchor`,`frequency`,`response`) VALUES (NULL , '" + ID + "', '200', '" + currentTestFrequency + "', 'HIGHER')";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            try
            {
                int hr = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            nextTrial();
        }


        private void buttonLower_Click(object sender, EventArgs e)
        {
            
            
            string sql = "INSERT INTO `chairexperiment`.`experiment1` (`ID`  ,`subjectID` ,`anchor `,`frequency`,`response`) VALUES (NULL , '" + ID + "', '200' '" + currentTestFrequency + "', 'LOWER')";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            try
            {
                int hr = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            nextTrial();
        }





       


    }
}
