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

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM informasi", con);
                MySqlDataReader read = cmd.ExecuteReader();
                read.Read();

                mInformasi.Nama = read["nama"].ToString();
                mInformasi.Alamat = read["alamat"].ToString();
            }

            return mInformasi;
        }
    }
}
