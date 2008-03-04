using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;


namespace ChairExperiment
{
    public partial class Form1 : Form
    {
        private OdbcConnection mysqlConnection;
        public Form1()
        {
            InitializeComponent();

            


        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string sex = "";
            string age = "";
            string computer = "";
            string handedness = "";
            string speakerside = "";

            if (radioButtonMale.Checked)
            {
                sex = "Male";
            }
            else
            {
                sex = "Female";
            }


            if (radioButton19.Checked)
            {
                age = "19-29";
            }
            else if (radioButton30.Checked)
            {
                age = "30-39";
            }
            else if (radioButton40.Checked)
            {
                age = "49-49";
            }
            else if (radioButton50.Checked)
            {
                age = "50-59";
            }
            else if (radioButton60.Checked)
            {
                age = "60";
            }

            if (this.radioButtonPro.Checked)
            {
                computer = "Pro";
            }
            else if (radioButtonExpert.Checked)
            {
                computer = "Expert";
            }
            else if (this.radioButtonIntermediate.Checked)
            {
                computer = "Intermediate";
            }
            else if (this.radioButtonNovice.Checked)
            {
                computer = "Novice";
            }
            else if (radioButtonNo.Checked)
            {
                computer = "No";
            }


            if (this.radioButtonLeftHand.Checked)
            {
                handedness = "Left";
            }
            else if (this.radioButtonRightHand.Checked)
            {
                handedness = "Right";
            }


            if (this.radioButtonLeft.Checked)
            {
                speakerside = "Left";
            }
            else if (this.radioButtonRight.Checked)
            {
                speakerside = "Right";
            }

            string server = "DRIVER={MySQL ODBC 3.51 Driver};" + "SERVER=141.117.145.50;" + "DATABASE=livedescribe;" + "UID=livedescribe;" + "PWD=livedescribe;" + "OPTION=3;";// builder.ConnectionString;

            string sql = "INSERT INTO `chairexperiment`.`subjects` (`ID`  ,`sex` ,`age`,`experience`, `handedness`, `speakerside`) VALUES (NULL , '" + sex + "', '" + age + "', '" + computer + "', '" + handedness + "', '" + speakerside + "')";
            
            Byte[] originalBytes;
            Byte[] encodedBytes;

            try
            {
                mysqlConnection = new OdbcConnection(server);
                mysqlConnection.Open();
            }
            catch (Exception ex)
            {
                this.Text = "Connection failed . . . ";
                //MessageBox.Show(ex.Message);
            }

            this.Text = "Successful connection!!";


            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            int hr = command.ExecuteNonQuery();

            sql = "SELECT last_insert_id()";

            command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            OdbcDataReader reader = command.ExecuteReader();


            int ID = 0;
            while (reader.Read())
            {
               ID = Convert.ToInt32(reader[0].ToString());
            }

            

            this.Hide();

            subjectWindow start = new subjectWindow();
            administratorWindow admin = new administratorWindow();

            start.link(mysqlConnection, ID, admin);
            start.Show();

            //Array screens = System.Windows.Forms.Screen.AllScreens();




            admin.Left = 200;
            admin.Update();
            admin.Show();





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }




    }
}