using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Database
{
    class DLogin
    {
        MySqlConnection con = DatabaseHelper.OpenKoneksi();

        public static bool CheckUser(string username, string password)
        {
            //Logic Cek User
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id, username, jabatan FROM user_data WHERE username = @username AND password = @password", con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", Function.ToMD5(password));

                using (MySqlDataReader read = cmd.ExecuteReader())
                    if (read.Read())
                    {
                        Model.MUser.USERID = Convert.ToInt32(read["id"].ToString());
                        Model.MUser.USERNAME = read["username"].ToString();
                        Model.MUser.ROLE = read["jabatan"].ToString();

                        return true;
                    }
            }
            
            return false;
        }
    }
}
