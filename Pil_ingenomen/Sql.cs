using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pil_ingenomen
{
    class Sql
    {
        private string query;
        public Sql()
        {

        }
        private void loadSQL(string query)
        {
            string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sqldatabase;";
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
            
            string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sqldatabase;";
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
                    // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                    // Do something with every received database ROW
                    
                    /* nudAantalPillen.Value = Convert.ToInt32(reader.GetString(8)); */


                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            databaseConnection.Close();
        }
    }
}
