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
            loadSQL("SELECT * FROM Patient ");
        }
        
        private void loadSQL(string query)
        {
            
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
                        cbxSelectPatient_Temp.Items.Add(reader.GetString(1));
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
            lbxPillen_Aantal.Items.Clear();
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
                    lbxPillen_Aantal.Items.Add(reader.GetString("Voornaam") +" "+ reader.GetString("Achternaam"));

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
            reloadSQL("SELECT dokter.voornaam, dokter.achternaam, dokter.id, patient.id, patient.voornaam FROM dokter, patient WHERE dokter.id = patient.dokter_id AND patient.voornaam ='" + cbxSelectPatient_Temp.GetItemText(cbxSelectPatient_Temp.SelectedItem) + "';");
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
