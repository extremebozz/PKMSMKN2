using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Database
{
    class DUser
    {
        public static List<Model.Model_User> GetUser()
        {
            List<Model.Model_User> mUser = new List<Model.Model_User>();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id, username, jabatan FROM user_data", con);

                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    int no = 1;

                    while (read.Read())
                    {
                        mUser.Add(new Model.Model_User
                        {
                            Nomor = no,
                            UserID = Convert.ToInt32(read["id"]),
                            Username = read["username"].ToString(),
                            Role = read["jabatan"].ToString()
                        });

                        no++;
                    }
                }
            }

            return mUser;
        }

        public static Model.Model_User GetUserByID(int ID)
        {
            Model.Model_User mUser = new Model.Model_User();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id, username, jabatan FROM user_data WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", ID);

                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    read.Read();

                    mUser = new Model.Model_User() 
                    {
                        UserID = Convert.ToInt32(read["id"]),
                        Username = read["username"].ToString(),
                        Role = read["jabatan"].ToString()
                    };
                }
            }

            return mUser;
        }

        public static void CreateUser(string Username, string Password, string Role)
        {
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                try
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO user_data(username, password, jabatan) VALUES(@username, @password, @role)", con);
                    cmd.Parameters.AddWithValue("@username", Username);
                    cmd.Parameters.AddWithValue("@password", Password);
                    cmd.Parameters.AddWithValue("@role", Role);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception msg)
                {
                    throw;
                }
        }

        public static void UpdateUser(int ID, string Username, string Password, string Role)
        {
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                try
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE user_data SET username = @username, jabatan = @jabatan", con);

                    if (Password.Length != 0)
                        cmd.CommandText += ", password = @password";

                    cmd.CommandText += " WHERE id = @id";

                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@username", Username);
                    cmd.Parameters.AddWithValue("@password", Password);
                    cmd.Parameters.AddWithValue("@jabatan", Role);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception msg)
                {
                    throw;
                }
        }

        public static void DeleteUser(int ID)
        {
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                try
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM user_data WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteReader();
                }
                catch (Exception msg)
                {
                    throw;
                }
        }
    }
}