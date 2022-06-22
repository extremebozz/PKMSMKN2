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

        public static void CreateService(int NomorKamar, string Note)
        {
            try
            {
                using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO service_data(waktu_tambah, kamar, note) VALUES(@waktu, @kamar, @note)", con);
                    cmd.Parameters.AddWithValue("@waktu", DateTime.Now);
                    cmd.Parameters.AddWithValue("@kamar", NomorKamar);
                    cmd.Parameters.AddWithValue("@note", Note);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception msg)
            {
                throw;
            }
        }

        public static void CloseService(int IDService)
        {
            try
            {
                using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE service_data SET waktu_selesai = @waktu, aktif = '0' WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@waktu", DateTime.Now);
                    cmd.Parameters.AddWithValue("@id", IDService);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception msg)
            {
                throw;
            }
        }
    }
}
