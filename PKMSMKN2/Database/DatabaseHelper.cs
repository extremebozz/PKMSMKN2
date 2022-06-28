using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKMSMKN2
{
    class DatabaseHelper
    {

        public static bool CheckKoneksi()
        {
            MySqlConnection con = OpenKoneksi();

            if (con.State.Equals(ConnectionState.Open))
            {
                con.Close();
                return true;
            }

            return false;
        }

        public static MySqlConnection OpenKoneksi()
        {
            MySqlConnection con = null;

            var connection = new MySqlConnectionStringBuilder
            {
                Server = "localhost", //ConfigurationManager.ConnectionStrings["server"].ConnectionString,
                UserID = "root",
                Password = "bukanadmin", //bukanadmin
                Database = "hotel_smkn2" //ConfigurationManager.ConnectionStrings["database"].ConnectionString
            };

            try
            {
                con = new MySqlConnection(connection.ToString() + @"; convert zero datetime=True; Charset=utf8mb4;");
                con.Open();
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString(), "Database Gagal Terhubung!");
            }

            return con;
        }
    }
}