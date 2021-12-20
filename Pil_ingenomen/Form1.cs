using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pil_ingenomen
{
    public partial class Form1 : Form
    {
        Sql SQL = new Sql();
        MySqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
            reader = SQL.loadSQL("SELECT patient.voornaam FROM patient ");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cbxSelectPatient_Temp.Items.Add(reader.GetString("voornaam"));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }

        }

                    /*
            string aantalPillen = lbxDate.SelectedItem.ToString();
            string[] pillenAantal = aantalPillen.Split(';',' ');


            foreach(var sub in pillenAantal)
            {
                Console.WriteLine($"Substring: {sub}");
            }
            */


        /*
        private void loadSQL(string query)
        {
            cbxSelectPatient_Temp.Items.Clear();
            string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=medu_database;";
            MySqlConnection databaseConnection = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbxSelectPatient_Temp.Items.Add(reader.GetString("voornaam"));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                // Finally close the connection
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }
        */

        /*
        private void reloadSQL(string query)
        {
            string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=medu_database;";
            MySqlConnection databaseConnection = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            MySqlDataReader reader;

            databaseConnection.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lbxPillen_Aantal.Items.Add(reader.GetString("medicijn_naam") + " " + reader.GetString("aantal"));

                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            databaseConnection.Close();
           }
        */
        private void cbxSelectPatient_Temp_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxDate.Items.Clear();
            string patientNaam = cbxSelectPatient_Temp.GetItemText(cbxSelectPatient_Temp.SelectedItem);
            
            reader = SQL.loadSQL("SELECT patient.id, patient.voornaam, inname_moment.patient_id, inname_moment.date FROM dokter, patient, inname_moment, medicijn WHERE dokter.id = patient.dokter_id AND inname_moment.patient_id = patient.id AND patient.voornaam = '" + patientNaam +"' AND medicijn.id = inname_moment.medicijn_id; ");
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    
                    lbxDate.Items.Add(reader.GetString("date"));

                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
        }

        private void cbxFilterOp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxPillen_Aantal_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxMedicijn.Items.Clear();
            string patientNaam = cbxSelectPatient_Temp.GetItemText(cbxSelectPatient_Temp.SelectedItem);
            string date = lbxDate.GetItemText(lbxDate.SelectedItem);
            Console.WriteLine(date);

            reader = SQL.loadSQL("SELECT patient.id, patient.voornaam, inname_moment.patient_id, inname_moment.date, medicijn.id, medicijn.medicijn_naam FROM dokter, patient, inname_moment, medicijn WHERE dokter.id = patient.dokter_id AND inname_moment.patient_id = patient.id AND patient.voornaam ='"+ patientNaam +"' AND medicijn.id = inname_moment.medicijn_id AND date ='"+ date +"';" );
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lbxMedicijn.Items.Add(reader.GetString("medicijn_naam"));

                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
        }

        private void btPil_Ingenomen_Click(object sender, EventArgs e)
        {

        }

        private void btPil_Niet_Ingenomen_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbxMedicijn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
