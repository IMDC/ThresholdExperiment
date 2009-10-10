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
        int anchor = 0;

        int correctHigh = 0;
        int correctLow = 0;

        bool firstHalfComplete = false;


        int freq1;
        int freq2; // bring it over from calibration form. use setter methods.
        int ampl1; // 0-32500
        int ampl2;

        Form internalForm;


        double currentTestFrequency = 0.0;

        double[] comparisonFrequencies = new double[20];
        double[] subjectiveIntensityValues = new double[20];

        Random random = new Random(DateTime.UtcNow.Millisecond);
       

        public  experiment1_DirectScaling()
        {

            InitializeComponent();
            this.signalGen1.Stop();

            double frequency = 100;
            for (int i = 0; i < 20; i++)
            {
                comparisonFrequencies[i] = 100 + (i * 20);
            }
            
            subjectiveIntensityValues[19] = 1.0;
            subjectiveIntensityValues[18] = 1.0;
            subjectiveIntensityValues[17] = 1.0;
            subjectiveIntensityValues[16] = 0.95;
            subjectiveIntensityValues[15] = 0.95;
            subjectiveIntensityValues[14] = 0.95;
            subjectiveIntensityValues[13] = 0.9;
            subjectiveIntensityValues[12] = 0.9;
            subjectiveIntensityValues[11] = 0.9;
            subjectiveIntensityValues[10] = 0.9;
            subjectiveIntensityValues[9] = 0.85;
            subjectiveIntensityValues[8] = 0.85;
            subjectiveIntensityValues[7] = 0.85;
            subjectiveIntensityValues[6] = 0.85;
            subjectiveIntensityValues[5] = 0.8;
            subjectiveIntensityValues[4] = 0.8;
            subjectiveIntensityValues[3] = 0.8;
            subjectiveIntensityValues[2] = 0.7;
            subjectiveIntensityValues[1] = 0.7;
            subjectiveIntensityValues[0] = 0.7;
            

            hideAll();
                   
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

        private void getNewAnchor()
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

        }

        private void buttonStartVibration_Click(object sender, EventArgs e)
        {
            
            buttonStartVibration.Enabled = false;
            ((System.ComponentModel.ISupportInitialize)(this.channelMerger1)).EndInit();
            
            int index = random.Next(0, 20);
            currentTestFrequency = comparisonFrequencies[index];

                
                
                
                
            this.signalGen1.Frequency = currentTestFrequency;



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

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `chairexperiment`.`experiment1` (`ID`  ,`subjectID` ,`frequency`,`response`) VALUES (NULL , '" + ID + "', '" + currentTestFrequency  + "', '1')";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            int hr = command.ExecuteNonQuery();

            nextTrial();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `chairexperiment`.`experiment1` (`ID`  ,`subjectID` ,`frequency`,`response`) VALUES (NULL , '" + ID + "', '" + currentTestFrequency + "', '2')";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            int hr = command.ExecuteNonQuery();

            nextTrial();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `chairexperiment`.`experiment1` (`ID`  ,`subjectID` ,`frequency`,`response`) VALUES (NULL , '" + ID + "', '" + currentTestFrequency + "', '3')";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            int hr = command.ExecuteNonQuery();

            nextTrial();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `chairexperiment`.`experiment1` (`ID`  ,`subjectID` ,`frequency`,`response`) VALUES (NULL , '" + ID + "', '" + currentTestFrequency + "', '4')";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            int hr = command.ExecuteNonQuery();

            nextTrial();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `chairexperiment`.`experiment1` (`ID`  ,`subjectID` ,`frequency`,`response`) VALUES (NULL , '" + ID + "', '" + currentTestFrequency + "', '5')";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            int hr = command.ExecuteNonQuery();

            nextTrial();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `chairexperiment`.`experiment1` (`ID`  ,`subjectID` ,`frequency`,`response`) VALUES (NULL , '" + ID + "', '" + currentTestFrequency + "', '6')";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            int hr = command.ExecuteNonQuery();

            nextTrial();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `chairexperiment`.`experiment1` (`ID`  ,`subjectID` ,`frequency`,`response`) VALUES (NULL , '" + ID + "', '" + currentTestFrequency + "', '7')";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            int hr = command.ExecuteNonQuery();

            nextTrial();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `chairexperiment`.`experiment1` (`ID`  ,`subjectID` ,`frequency`,`response`) VALUES (NULL , '" + ID + "', '" + currentTestFrequency + "', '8')";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            int hr = command.ExecuteNonQuery();

            nextTrial();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `chairexperiment`.`experiment1` (`ID`  ,`subjectID` ,`frequency`,`response`) VALUES (NULL , '" + ID + "', '" + currentTestFrequency + "', '9')";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            int hr = command.ExecuteNonQuery();

            nextTrial();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `chairexperiment`.`experiment1` (`ID`  ,`subjectID` ,`frequency`,`response`) VALUES (NULL , '" + ID + "', '" + currentTestFrequency + "', '10')";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            int hr = command.ExecuteNonQuery();

            nextTrial();
        }

        public void nextTrial()
        {
            disableButtons();
            this.buttonStartVibration.Enabled = true;
            this.textBoxRating.Enabled = false;
            this.buttonAcceptRating.Enabled = false;
            checkBreak();
            session++;
            this.labelSession.Text = "Session " + session;
            this.textBoxRating.Text = "";





        }

        public void disableButtons(){
            
            this.buttonAcceptRating.Enabled = false;

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
            this.labelEnterText.Visible = true;
            this.textBoxRating.Visible = true;
            this.buttonAcceptRating.Visible = true;
            
            this.Controls.Remove(this.buttonExampleof2);
            this.Controls.Remove(this.buttonExampleof8);
        }

        private void buttonExampleof2_Click(object sender, EventArgs e)
        {
            buttonExampleof2.Enabled = false;
            buttonExampleof8.Enabled = true;

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
            buttonExampleof2.Enabled = false;
            buttonExampleof8.Enabled = false;

            ((System.ComponentModel.ISupportInitialize)(this.channelMerger1)).EndInit();


            currentTestFrequency = comparisonFrequencies[18];





            this.signalGen1.Frequency = currentTestFrequency;



            this.amplifier1.Coefficient = subjectiveIntensityValues[18];


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
                this.timer1.Stop();
                

                
                this.buttonStartVibration.Enabled = false;
                this.textBoxRating.Enabled = true;
                this.buttonAcceptRating.Enabled = true;
                
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

        private void buttonAcceptRating_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `chairexperiment`.`experiment1` (`ID`  ,`subjectID` ,`frequency`,`response`) VALUES (NULL , '" + ID + "', '" + currentTestFrequency + "', " + this.textBoxRating.Text + ")";

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