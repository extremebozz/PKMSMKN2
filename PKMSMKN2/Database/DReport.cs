using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Database
{
    internal class DReport
    {
        public static List<Model.MReportService> ReportService(DateTime Awal, DateTime Akhir)
        {
            List<Model.MReportService> rService = new List<Model.MReportService>();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM service_data WHERE waktu_selesai IS NOT NULL AND waktu_tambah BETWEEN @awal AND @akhir", con);
                cmd.Parameters.AddWithValue("@awal", Awal.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@akhir", Akhir.ToString("yyyy-MM-dd HH:mm:ss"));

                using (MySqlDataReader read = cmd.ExecuteReader())
                    while (read.Read())
                        rService.Add(new Model.MReportService()
                        {
                            NomorKamar = read["kamar"].ToString(),
                            Catatan = read["note"].ToString(),
                            Tanggal = DateTime.Parse(read["waktu_tambah"].ToString()),
                            TanggalSelesai = DateTime.Parse(read["waktu_selesai"].ToString())
                        });
            }

            return rService;
        }

        public static void ReportRestoran()
        {

        }

        public static void ReportHotel()
        {

        }
    }
}
