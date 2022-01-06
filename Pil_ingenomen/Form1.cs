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
            reader = SQL.loadSQL("SELECT first_name, id FROM patient ");

            if (reader.HasRows)
            {
                Dictionary<string, string> comboSource = new Dictionary<string, string>();

                while (reader.Read())
                {
                    comboSource.Add(reader.GetString("id"), reader.GetString("first_name"));


                    //cbxSelectPatient_Temp.Items.Add( { reader.GetString("id") reader.GetString("voornaam")} );
                    
                }
                cbxSelectPatient_Temp.DataSource = new BindingSource(comboSource, null);
                cbxSelectPatient_Temp.DisplayMember = "Value";
                cbxSelectPatient_Temp.ValueMember = "Key";
                
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
            lbxMedicijn.Items.Clear();
            reader = SQL.loadSQL("SELECT DISTINCT consumption_date.date FROM consumption_date WHERE consumption_date.patient_id = " + ((KeyValuePair<string, string>)cbxSelectPatient_Temp.SelectedItem).Key+";");
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string Date = ( reader.GetDateTime("date").ToString("yyyy'-'MM'-'dd HH':'mm':'ss") );
              
                    lbxDate.Items.Add(Date);

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
            string date = lbxDate.GetItemText(lbxDate.SelectedItem);
            Console.WriteLine(date);

            reader = SQL.loadSQL("SELECT medicine.name FROM medicine, consumption_date WHERE consumption_date.patient_id = " + ((KeyValuePair<string, string>)cbxSelectPatient_Temp.SelectedItem).Key + " AND consumption_date.medicine_id = medicine.id AND consumption_date.date ='"+ date +"';");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lbxMedicijn.Items.Add(reader.GetString("name"));
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
            string medicijn = lbxMedicijn.GetItemText(lbxMedicijn.SelectedItem);
            string date = lbxDate.GetItemText(lbxDate.SelectedItem);
            Console.WriteLine(medicijn);
            Console.WriteLine(date);

            reader = SQL.loadSQL("SELECT medicine.name, medicine.consumption_method, consumption_date.amount, consumption_date.is_consumed FROM medicine, consumption_date WHERE consumption_date.patient_id = " + ((KeyValuePair<string, string>)cbxSelectPatient_Temp.SelectedItem).Key + " AND medicine.name = '" + medicijn +"' AND consumption_date.medicine_id = medicine.id AND consumption_date.date ='" + date + "';");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lbmedicineName.Text = reader.GetString("name");
                    lbdose.Text = reader.GetString("amount"); 
                    lbwijzeInname.Text = reader.GetString("consumption_method");
                    lbingenomen.Text = reader.GetString("is_consumed");
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
