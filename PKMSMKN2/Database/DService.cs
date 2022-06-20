using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Database
{
    class DService
    {
        public static List<Model.MService> FetchData()
        {
            List<Model.MService> lRoom = new List<Model.MService>();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("CALL pTampilService();", con);

                using (MySqlDataReader read = cmd.ExecuteReader())
                    while (read.Read())
                    {
                        DateTime? checkIn = Convert.IsDBNull(read["check_in"])
                            ? (DateTime?)null : Convert.ToDateTime(read["check_in"]),
                        checkOut = Convert.IsDBNull(read["check_out"])
                            ? (DateTime?)null : Convert.ToDateTime(read["check_out"]),
                        tanggalIn = Convert.IsDBNull(read["tanggal_in"])
                            ? (DateTime?)null : Convert.ToDateTime(read["tanggal_in"]),
                        tanggalOut = Convert.IsDBNull(read["tanggal_out"])
                            ? (DateTime?)null : Convert.ToDateTime(read["tanggal_out"]);

                        int? idService = Convert.IsDBNull(read["sId"])
                            ? (int?)null : Convert.ToInt32(read["sId"]),
                            aktif = Convert.IsDBNull(read["aktif"])
                            ? (int?)null : Convert.ToInt32(read["aktif"]);

                        lRoom.Add(new Model.MService()
                        {
                            ServiceID = idService,
                            NomorKamar = Convert.ToInt32(read["nomor_kamar"]),
                            JenisKamar = read["jenis_kamar"].ToString(),
                            NoteService = read["note"].ToString(),
                            Aktif = aktif,
                            TanggalIn = tanggalIn,
                            TanggalOut = tanggalOut,
                            CheckIn = checkIn,
                            CheckOut = checkOut
                        });
                    }
            }

            return lRoom;
        }
    }
}
