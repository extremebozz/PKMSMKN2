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

        public static List<Model.MReportHotel> ReportHotel(DateTime TanggalAwal, DateTime TanggalAkhir)
        {
            List<Model.MReportHotel> rHotel = new List<Model.MReportHotel>();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("CALL pTampilReportHotel(@awal, @akhir);", con);
                cmd.Parameters.AddWithValue("@awal", TanggalAwal);
                cmd.Parameters.AddWithValue("@akhir", TanggalAkhir);

                using (MySqlDataReader read = cmd.ExecuteReader())
                    while (read.Read())
                        rHotel.Add(new Model.MReportHotel()
                        {
                            CheckIn = DateTime.Parse(read["check_in"].ToString()),
                            CheckOut = DateTime.Parse(read["check_out"].ToString()),
                            ExtraBed = read.GetInt32("extra_bed"),
                            Hari = read.GetInt32("hari"),
                            NamaPelanggan = read["nama"].ToString(),
                            NomorKamar = read["kamar"].ToString(),
                            Rate = read.GetInt32("rate"),
                            TanggalKeluar = DateTime.Parse(read["tanggal_out"].ToString()),
                            TanggalMasuk = DateTime.Parse(read["tanggal_in"].ToString()),
                            JenisKamar = read["jenis"].ToString()
                        });
            }

            return rHotel;
        }

        public static List<Model.MReportRestoran> ReportRestoran(DateTime TanggalAwal, DateTime TanggalAkhir)
        {
            List<Model.MReportRestoran> rRestoran = new List<Model.MReportRestoran>();

            try
            {
                using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT *, (SELECT kamar FROM kamar_transaksi WHERE id = id_transaksi_kamar) AS nomor_kamar FROM restoran_transaksi WHERE tanggal BETWEEN @awal AND @akhir AND aktif = 'N'", con);
                    cmd.Parameters.AddWithValue("@awal", TanggalAwal.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@akhir", TanggalAkhir.ToString("yyyy-MM-dd"));

                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            string billTo = read.GetInt32("id_transaksi_kamar").Equals(null) ? "Bayar Lansung" : "Kamar " + read["nomor_kamar"].ToString();

                            rRestoran.Add(new Model.MReportRestoran()
                            {
                                Nominal = read.GetInt32("total"),
                                NomorMeja = read["meja"].ToString(),
                                TanggalOrder = DateTime.Parse(read["tanggal"].ToString()),
                                NomorKamar = billTo
                            });
                        }
                    }
                }
            }
            catch (Exception msg) { System.Windows.Forms.MessageBox.Show(msg.ToString()); }

            return rRestoran;
        }
    }
}
