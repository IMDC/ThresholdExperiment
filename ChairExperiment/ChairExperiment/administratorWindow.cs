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

namespace ChairExperiment
{
    public partial class administratorWindow : Form
    {
        public administratorWindow()
        {
            InitializeComponent();
        }

        private void administratorWindow_Load(object sender, EventArgs e)
        {
            this.Left = 1300;
        }

        private void administratorWindow_Close(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void buttonFindThresholds_Click(object sender, EventArgs e)
        {
            string server = "DRIVER={MySQL ODBC 3.51 Driver};" + "SERVER=141.117.145.50;" + "DATABASE=livedescribe;" + "UID=livedescribe;" + "PWD=livedescribe;" + "OPTION=3;";// builder.ConnectionString;

            
            OdbcConnection mysqlConnection = new OdbcConnection(server);

            mysqlConnection.Open();

            string sql = "SELECT * FROM `chairexperiment`.`sessions` ORDER BY `sessions`.`ID` ASC";

            OdbcCommand command = mysqlConnection.CreateCommand();
            command.CommandText = sql;

            int hr = command.ExecuteNonQuery();

            OdbcDataReader reader = command.ExecuteReader();

            TextWriter tw = new StreamWriter("c:\\results.txt");
            Boolean firstSameFound = false;
            Boolean firstDifferentFound = false;
            string previous0 = "";
            string previous1 = "";
            string previous2 = "";
            string previous3 = "";

            while (reader.Read())
            {
                if(reader[4].ToString().Equals("same")){
                    firstSameFound = true;
                }
                else if (reader[4].ToString().Equals("different"))
                {
                    firstDifferentFound = true;
                }
                if ((firstSameFound == true && firstDifferentFound == true && reader[4].ToString().Equals("same")) || (reader[4].ToString().Equals("different")) && (Convert.ToDouble(previous3) - Convert.ToDouble(previous2)) == 0.5)
                {
                    tw.WriteLine(previous0 + "\t" + previous1 + "\t" + previous2 + "\t" + previous3 + "\t" + (Convert.ToDouble(previous3) - Convert.ToDouble(previous2)));
                    firstDifferentFound = false;
                    firstSameFound = false;
                }


                previous0 = reader[0].ToString();
                previous1 = reader[1].ToString();
                previous2 = reader[2].ToString();
                previous3 = reader[3].ToString();

               
            }
            tw.Close();
        }

    }
}
