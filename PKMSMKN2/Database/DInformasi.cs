using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Database
{
    class DInformasi
    {
        public static Model.MInformasi ReadInformasi()
        {
            Model.MInformasi mInformasi = new Model.MInformasi();

            try
            {
                using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM informasi", con);
                    MySqlDataReader read = cmd.ExecuteReader();
                    read.Read();

                    mInformasi.Nama = read["nama"].ToString();
                    mInformasi.Alamat = read["alamat"].ToString();
                }
            }
            catch
            {
                using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO informasi(nama, alamat), VALUES('SMKN2 BATAM', 'Jl. Pemuda No. 5 Batam Center, Kota Batam')", con);
                }
            }

            return mInformasi;
        }

        public static void UpdateInformasi(string Nama, string Alamat)
        {
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE informasi SET nama = @nama, alamat = @alamat", con);
                cmd.Parameters.AddWithValue("@nama", Nama);
                cmd.Parameters.AddWithValue("@alamat", Alamat);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
