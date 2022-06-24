﻿using MySql.Data.MySqlClient;
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
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO makanan_kategori(nama) VALUES(@nama)", con);
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
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM makanan_kategori", con);

                if (CategoryID != 0)
                {
                    cmd.CommandText += " WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", CategoryID);
                }

                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    mKategori.Add(new Model.MKategoriMakanan()
                    {
                        CategoryID = read.GetInt32("id"),
                        Nama = read["nama"].ToString()
                    });
                }
            }

            return mKategori;
        }

        public static void UpdateCategory(int CategoryID, string CategoryNama)
        {
            try
            {
                using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE makanan_kategori SET nama = @nama WHERE id = @id", con);
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
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM makanan_category WHERE id = @id", con);
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
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO makanan_data(id_kategori, nama, harga) VALUES(@id, @nama, @harga)", con);
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
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM makanan_data", con);

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
                    MySqlCommand cmd = new MySqlCommand("UPDATE makanan_data SET id_kategori = @idKategori, nama = @nama, harga = @harga WHERE id = @id", con);
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
        #endregion

        #region Transaksi
        public static List<Model.MMakananTransaksi> ReadTransaksi(int IDTransaksi)
        {
            List<Model.MMakananTransaksi> lTransaksi = new List<Model.MMakananTransaksi>();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT *, (SELECT id_transaksi_kamar FROM restoran_transaksi WHERE id = @id) AS nomor_kamar, " +
                    "(SELECT nama FROM makanan_data WHERE id = id_makanan) AS makanan FROM restoran_detail WHERE id_transaksi = @id", con);
                cmd.Parameters.AddWithValue("@id", IDTransaksi);

                using (MySqlDataReader read = cmd.ExecuteReader())
                {
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
            }

            return lTransaksi;
        }
        #endregion

        #region Debug
        public static List<Model.MMakananTransaksi> ReadTransaksiDebug()
        {
            List<Model.MMakananTransaksi> lTransaksi = new List<Model.MMakananTransaksi>();

            for (int i = 1; i <= 5; i++)
            {
                lTransaksi.Add(new Model.MMakananTransaksi()
                {
                    IDTransaksi = i,
                    IDTransaksiKamar = 1,
                    IDMakanan = i,
                    Qty = i,
                    Harga = 12500,
                    NamaMenu = "Nasi Goreng"
                });
            }

            return lTransaksi;
        }

        public static List<Model.MMakanan> ReadMakananDebug()
        {
            List<Model.MMakanan> lMakanan = new List<Model.MMakanan>();

            for (int i = 10000; i <= 50000; i += 10000)
            {
                lMakanan.Add(new Model.MMakanan()
                {
                    Nama = "test" + i,
                    Harga = i,
                    CategoryID = i / 1000,
                    FoodID = i / 100
                });
            }

            return lMakanan;
        }
        #endregion
    }
}