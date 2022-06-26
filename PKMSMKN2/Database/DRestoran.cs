using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Database
{
    internal class DRestoran
    {
        #region Kategori Makanan
        public static void AddCategory(string Nama)
        {
            try
            {
                using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO menu_kategori(nama) VALUES(@nama)", con);
                    cmd.Parameters.AddWithValue("@nama", Nama);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }

        public static List<Model.MKategoriMakanan> ReadCategory(int CategoryID = 0)
        {
            List<Model.MKategoriMakanan> mKategori = new List<Model.MKategoriMakanan>();

            using ( MySqlConnection con = DatabaseHelper.OpenKoneksi() )
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM menu_kategori", con);

                if (CategoryID != 0)
                {
                    cmd.CommandText += " WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", CategoryID);
                }

                using (MySqlDataReader read = cmd.ExecuteReader())
                    while (read.Read())
                        mKategori.Add(new Model.MKategoriMakanan()
                        {
                            CategoryID = read.GetInt32("id"),
                            Nama = read["nama"].ToString()
                        });
            }

            return mKategori;
        }

        public static void UpdateCategory(int CategoryID, string CategoryNama)
        {
            try
            {
                using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE menu_kategori SET nama = @nama WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@nama", CategoryNama);
                    cmd.Parameters.AddWithValue("@id", CategoryID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }

        public static void DeleteCategory(int CategoryID)
        {
            try
            {
                using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM menu_kategori WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", CategoryID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Makanan
        public static void AddMakanan(Model.MMakanan MMakanan)
        {
            try
            {
                using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO menu_data(id_kategori, nama, harga) VALUES(@id, @nama, @harga)", con);
                    cmd.Parameters.AddWithValue("@id", MMakanan.CategoryID);
                    cmd.Parameters.AddWithValue("@nama", MMakanan.Nama);
                    cmd.Parameters.AddWithValue("@harga", MMakanan.Harga);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }

        public static List<Model.MMakanan> ReadMakanan(int IDKategori = 0)
        {
            List<Model.MMakanan> lMakanan = new List<Model.MMakanan>();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT *, (SELECT nama FROM menu_kategori WHERE id = id_kategori) AS kategori FROM menu_data", con);

                if (IDKategori != 0)
                {
                    cmd.CommandText += " WHERE id_kategori = @idKategori";
                    cmd.Parameters.AddWithValue("@idKategori", IDKategori);
                }

                using (MySqlDataReader read = cmd.ExecuteReader())
                    while (read.Read())
                        lMakanan.Add(new Model.MMakanan()
                        {
                            CategoryID = read.GetInt32("id_kategori"),
                            Category = read["kategori"].ToString(),
                            FoodID = read.GetInt32("id"),
                            Harga = read.GetInt32("harga"),
                            Nama = read.GetString("nama")
                        });
            }

            return lMakanan;
        }

        public static void UpdateMakanan(Model.MMakanan MMakanan)
        {
            try
            {
                using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE menu_data SET id_kategori = @idKategori, nama = @nama, harga = @harga WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@idKategori", MMakanan.CategoryID);
                    cmd.Parameters.AddWithValue("@nama", MMakanan.Nama);
                    cmd.Parameters.AddWithValue("@harga", MMakanan.Harga);
                    cmd.Parameters.AddWithValue("@id", MMakanan.FoodID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }

        public static void DeleteMakanan(int MenuID)
        {
            try
            {
                using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM menu_data WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", MenuID);
                    cmd.ExecuteReader();
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Transaksi
        public static void AddTransaksi(Model.MMakananTransaksi MTransaksi, string Waiter)
        {
            try
            {
                using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO restoran_transaksi(id_transaksi_kamar, tanggal, waiter) " +
                        "VALUES(@idKamar, @tanggal, @waiter); SELECT LAST_INSERT_ID();", con);
                    cmd.Parameters.AddWithValue("@idKamar", MTransaksi.IDTransaksiKamar);
                    cmd.Parameters.AddWithValue("@tanggal", DateTime.Now.ToString("yyyy-mm-dd"));
                    cmd.Parameters.AddWithValue("@waiter", Waiter);
                    int idTransaksi = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    MTransaksi.IDTransaksi = idTransaksi;
                }

                AddOrder(MTransaksi);
            }
            catch { throw; }
        }

        public static void AddOrder(Model.MMakananTransaksi MTransaksi)
        {
            try
            {
                using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                {

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO restoran_detail(id_transaksi, id_makanan, nama, qty, harga) " +
                    "VALUES(@idTransaksi, @idMakanan, @nama, @qty, @harga)", con);
                    cmd.Parameters.AddWithValue("@idTransaksi", MTransaksi.IDTransaksi);
                    cmd.Parameters.AddWithValue("@idMakanan", MTransaksi.IDMakanan);
                    cmd.Parameters.AddWithValue("@nama", MTransaksi.NamaMenu);
                    cmd.Parameters.AddWithValue("@qty", MTransaksi.Qty);
                    cmd.Parameters.AddWithValue("@harga", MTransaksi.Harga);
                    cmd.ExecuteNonQuery();
                }
            }
            catch { throw; }
        }

        public static List<Model.MMakananTransaksi> ReadTransaksi(int IDTransaksi)
        {
            List<Model.MMakananTransaksi> lTransaksi = new List<Model.MMakananTransaksi>();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT *, (SELECT id_transaksi_kamar FROM restoran_transaksi WHERE id = @id) AS nomor_kamar, " +
                    "(SELECT nama FROM menu_data WHERE id = id_makanan) AS makanan FROM restoran_detail WHERE id_transaksi = @id", con);
                cmd.Parameters.AddWithValue("@id", IDTransaksi);

                using (MySqlDataReader read = cmd.ExecuteReader())
                    while (read.Read())
                        lTransaksi.Add(new Model.MMakananTransaksi()
                        {
                            IDTransaksi = read.GetInt32("id_transaksi"),
                            IDTransaksiKamar = read.GetInt32("nomor_kamar"),
                            IDMakanan = read.GetInt32("id_makanan"),
                            Qty = read.GetInt32("qty"),
                            Harga = read.GetInt32("harga"),
                            NamaMenu = read["makanan"].ToString()
                        });
            }

            return lTransaksi;
        }
        #endregion
    }
}