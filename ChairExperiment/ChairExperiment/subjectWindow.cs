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
        int session = 149;
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

        public subjectWindow()
        {

            InitializeComponent();
            this.signalGen1.Stop();

  
           // anchorFrequencies.Add(32.7032);//C1
            //anchorFrequencies.Add(46.2493);//F#1

            anchorFrequencies.Add(65.4064);//C2
            anchorFrequencies.Add(92.4986);//F#2

            anchorFrequencies.Add(130.813);//C3
            anchorFrequencies.Add(184.997);//F#3

            anchorFrequencies.Add(261.626);//C4
            anchorFrequencies.Add(369.994);//F#4

            anchorFrequencies.Add(523.251);//C5
            anchorFrequencies.Add(739.989);//F#5

            anchorFrequencies.Add(1046.50);//C5
            //anchorFrequencies.Add(1479.98);//F#6

            this.anchorStimuli = (double)anchorFrequencies[anchor];

            testFrequencies.Add((double)anchorFrequencies[localSession]);

            double previousStimuli = 0;
            double nextStimuli = 0;

            //add stimuli lower then the anchor
            previousStimuli = anchorStimuli / twentyforthrootoftwo;

            for (int i = 0; i < 5; i++)
            {

                testFrequencies.Insert(0, previousStimuli);
                previousStimuli = previousStimuli / twentyforthrootoftwo;
            }

            //add stimuli higher then the anchor
            nextStimuli = anchorStimuli * twentyforthrootoftwo;
            for (int i = 0; i < 10; i++)
            {

                testFrequencies.Add(nextStimuli);
                nextStimuli = nextStimuli * twentyforthrootoftwo;
            }


            this.comparisonStimuli = (double)testFrequencies[localSession];

           // getNewAnchor();
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

            this.buttonFaster.Enabled = false;
            this.buttonSlower.Enabled = false;



            this.buttonPlay1.Enabled = true;

            //correctHigh = 0;

            if (anchorStimuli > comparisonStimuli && anchorStimuli != comparisonStimuli && firstHalfComplete)
            {
                correctLow++;

                if (correctLow > 2)
                {
                    getNewAnchor();
                }
            }
            checkBreak();
        }
        
        private void buttonFaster_Click(object sender, EventArgs e)
        {

          

            tempItem = new System.Windows.Forms.ListViewItem();
            tempItem.Text = session.ToString();
            tempItem.SubItems.Add(firstStimuliPointer.ToString());
            tempItem.SubItems.Add(secondStimuliPointer.ToString());
            tempItem.SubItems.Add(anchorStimuli.ToString());
            tempItem.SubItems.Add(comparisonStimuli.ToString());
            tempItem.SubItems.Add("FASTER");

            if (anchorStimuli < comparisonStimuli)
            {
                tempItem.SubItems.Add("Y");
            }
            else
            {
                tempItem.SubItems.Add("N");
            }


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


            //correctLow = 0;
            if (anchorStimuli < comparisonStimuli && anchorStimuli != comparisonStimuli && !firstHalfComplete)
            {
                correctHigh++;

                if (correctHigh > 2)
                {
                    getNewAnchor();
                }
            }

            try
            {
                comparisonStimuli = (double)testFrequencies[localSession];
            }
            catch (Exception ex)
            {
                getNewAnchor();
            }
            
            

            this.admin.textBoxFirstArrayPos.Text = firstStimuliPointer.ToString();
            this.admin.textBoxSecondArrayPos.Text = secondStimuliPointer.ToString();

            this.admin.textBoxFirstFreq.Text = anchorStimuli.ToString();//frequencies[firstStimuliPointer].ToString();
            this.admin.textBoxSecondFreq.Text = comparisonStimuli.ToString();//frequencies[secondStimuliPointer].ToString();


            this.buttonFaster.Enabled = false;
            this.buttonSlower.Enabled = false;

            this.buttonPlay1.Enabled = true;
            checkBreak();

        }
        private void checkBreak()
        {
            if (this.session % 50 == 0)
            {
                BreakTimer breaktimer = new BreakTimer();                
                breaktimer.Left = this.Left;
                breaktimer.Show();

                breaktimer.labelMessage.Text = "You have completed " + this.session.ToString() + " sessions. Please rest for 2 minutes.";
                breaktimer.startTimer(this);
                this.Enabled = false;
                
            }
        }
        private void buttonPlay1_Click(object sender, EventArgs e)
        {

            this.admin.textBoxFirstFreq.Text = anchorStimuli.ToString();//frequencies[firstStimuliPointer].ToString();
            this.admin.textBoxSecondFreq.Text = comparisonStimuli.ToString();//frequencies[secondStimuliPointer].ToString();
            //add this last minute to avoid playing before play is pressed
            ((System.ComponentModel.ISupportInitialize)(this.dsAudioOut1)).EndInit();

            if (this.anchorStimuli <= 65.4064)
            {
                //this.amplifierCoefficient = 0.006;
                //y = 0.009x                                               
                this.amplifierCoefficient = ((0.009 * this.anchorStimuli)) / 100;
                
            }
            if (this.anchorStimuli > 65.4064 && this.anchorStimuli <= 92.49)
            {
                //this.amplifierCoefficient = 0.0095;
                //y = (0.012x-0.245)/100                                                
                this.amplifierCoefficient = ((0.012 * this.anchorStimuli) - 0.245) / 100;
                
            }
            if (this.anchorStimuli > 92.49 && this.anchorStimuli <= 130.913)
            {
                //this.amplifierCoefficient = 0.011;
                //y=0.003x+0.588               
                this.amplifierCoefficient = ((0.003 * this.anchorStimuli) + 0.588) / 100;
                

            }
            if (this.anchorStimuli > 130.913 && this.anchorStimuli <= 184.997)
            {
                //this.amplifierCoefficient = 0.015;
                //y=0.007x+0.131                
                this.amplifierCoefficient = ((0.007 * this.anchorStimuli) + 0.131) / 100;
                
            }
            if (this.anchorStimuli > 184.997 && this.anchorStimuli <= 261.626)
            {
                //this.amplifierCoefficient = 0.0225;
                //y=0.009x-0.310               
                this.amplifierCoefficient = ((0.009 * this.anchorStimuli) - 0.310) / 100;
                
            }
            if (this.anchorStimuli > 261.626 && this.anchorStimuli <= 369.994)
            {
                //this.amplifierCoefficient = 0.0425;
                //y=0.018x-2.578                
                this.amplifierCoefficient = ((0.018 * this.anchorStimuli) - 2.578) / 100;
                
            }
            if (this.anchorStimuli > 369.994 && this.anchorStimuli <= 523.251)
            {
                //this.amplifierCoefficient = 0.0625;
                //y=0.013x-0.578                
                this.amplifierCoefficient = ((0.013 * this.anchorStimuli) - 0.578) / 100;
                
            }
            if (this.anchorStimuli > 523.251 && this.anchorStimuli <= 739.989)
            {
                //this.amplifierCoefficient = 1.725;
                //y=0.767x-395.1                
                this.amplifierCoefficient = ((0.767 * this.anchorStimuli) - 395.1) / 100;
            }
            if (this.anchorStimuli > 739.989 && this.anchorStimuli <= 1046.5)
            {
                //this.amplifierCoefficient = 1.9;
                //y=0.057x+130.2                
                this.amplifierCoefficient = ((0.057 * this.anchorStimuli) + 130.2) / 100;
            }







            if (this.comparisonStimuli <= 65.4064)
            {
                //this.comparisonamplifierCoefficient = 0.006;
                //y = 0.009x                                               
                this.comparisonamplifierCoefficient = ((0.009 * this.comparisonStimuli)) / 100;
            }
            if (this.comparisonStimuli > 65.4064 && this.comparisonStimuli <= 92.49)
            {
                //this.comparisonamplifierCoefficient = 0.0095;
                //y = (0.012x-0.245)/100                                                
                this.comparisonamplifierCoefficient = ((0.012 * this.comparisonStimuli) - 0.245) / 100;
            }
            if (this.comparisonStimuli > 92.49 && this.comparisonStimuli <= 130.913)
            {
                //this.comparisonamplifierCoefficient = 0.011;
                //y=0.003x+0.588               
                this.comparisonamplifierCoefficient = ((0.003 * this.comparisonStimuli) + 0.588) / 100;
            }
            if (this.comparisonStimuli > 130.913 && this.comparisonStimuli <= 184.997)
            {
                //this.comparisonamplifierCoefficient = 0.015;
                //y=0.007x+0.131                
                this.comparisonamplifierCoefficient = ((0.007 * this.comparisonStimuli) + 0.131) / 100;
            }
            if (this.comparisonStimuli > 184.997 && this.comparisonStimuli <= 261.626)
            {
                //this.comparisonamplifierCoefficient = 0.0225;
                //y=0.009x-0.310               
                this.comparisonamplifierCoefficient = ((0.009 * this.comparisonStimuli) - 0.310) / 100;
            }
            if (this.comparisonStimuli > 261.626 && this.comparisonStimuli <= 369.994)
            {
                //this.comparisonamplifierCoefficient = 0.0425;
                //y=0.018x-2.578                
                this.comparisonamplifierCoefficient = ((0.018 * this.comparisonStimuli) - 2.578) / 100;
            }
            if (this.comparisonStimuli > 369.994 && this.comparisonStimuli <= 523.251)
            {
                //this.comparisonamplifierCoefficient = 0.0625;
                //y=0.013x-0.578                
                this.comparisonamplifierCoefficient = ((0.013 * this.comparisonStimuli) - 0.578) / 100;
            }
            if (this.comparisonStimuli > 523.251 && this.comparisonStimuli <= 739.989)
            {
                //this.comparisonamplifierCoefficient = 1.725;
                //y=0.767x-395.1                
                this.comparisonamplifierCoefficient = ((0.767 * this.comparisonStimuli) - 395.1) / 100;
            }
            if (this.comparisonStimuli > 739.989 && this.comparisonStimuli <= 1046.5)
            {
                //this.comparisonamplifierCoefficient = 1.9;
                //y=0.057x+130.2                
                this.comparisonamplifierCoefficient = ((0.057 * this.comparisonStimuli) + 130.2) / 100;
            }
            //amplifierCoefficient = 1.0;

            this.admin.textBoxAmpCo.Text = this.amplifierCoefficient.ToString();

            this.signalGen1.Frequency = anchorStimuli;
            this.amplifier1.Coefficient = this.amplifierCoefficient;
            Mitov.AudioLab.AudioFormat audioFormat1 = new Mitov.AudioLab.AudioFormat();
            try
            {
                this.signalGen1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hey");
            }
            this.timer1.Start();

            this.buttonPlay1.Enabled = false;



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
                this.amplifier1.Coefficient = this.comparisonamplifierCoefficient;

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