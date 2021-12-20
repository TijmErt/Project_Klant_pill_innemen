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
        public Sql()
        {

        }
        public MySqlDataReader loadSQL(string query)
        {
            string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=medu_database;";
            MySqlConnection databaseConnection = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();
            reader = cmd.ExecuteReader();
            return (reader);
            databaseConnection.Close();



        }

    }
}
