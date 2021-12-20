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
        public Form1()
        {
            InitializeComponent();
            loadSQL("SELECT patient.voornaam FROM patient ");
        }
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
        private void cbxSelectPatient_Temp_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxPillen_Aantal.Items.Clear();
            string patientNaam = cbxSelectPatient_Temp.GetItemText(cbxSelectPatient_Temp.SelectedItem);
            reloadSQL("SELECT patient.id, patient.voornaam, inname_moment.patient_id, inname_moment.medicijn_id, inname_moment.aantal, medicijn.id, medicijn.medicijn_naam FROM dokter, patient, inname_moment, medicijn WHERE dokter.id = patient.dokter_id AND inname_moment.patient_id = patient.id AND patient.voornaam = '" + patientNaam +"' AND medicijn.id = inname_moment.medicijn_id; ");
            
        }

        private void cbxFilterOp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxPillen_Aantal_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
