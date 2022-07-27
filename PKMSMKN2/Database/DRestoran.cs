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

        public static List<Model.MMakanan> ReadMakanan(int IDMenu = 0, int IDKategori = 0)
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

                if (IDMenu != 0)
                {
                    cmd.CommandText += " WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", IDMenu);
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

        public static Model.MMakananTransaksi ReadFoodTransaction(int FoodTrasactionID)
        {
            Model.MMakananTransaksi mTransaksi = new Model.MMakananTransaksi();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM restoran_detail WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", FoodTrasactionID);

                MySqlDataReader read = cmd.ExecuteReader();
                read.Read();

                mTransaksi = new Model.MMakananTransaksi()
                {
                    IDMakanan = read.GetInt32("id_makanan"),
                    Harga = read.GetInt32("harga"),
                    Qty = read.GetInt32("qty"),
                    IDTransaksi = read.GetInt32("id_transaksi"),
                    NamaMenu = read["nama"].ToString()
                };
            }

            return mTransaksi;
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

        public static List<Model.MKategoriMakanan> ReadOrderFood()
        {
            List<Model.MKategoriMakanan> lKategori = ReadCategory();

            for (int i = 0; i < lKategori.Count; i++)
            {
                List<Model.MMakanan> lMakanan = ReadMakanan(0, lKategori[i].CategoryID);
                lKategori[i].ListMakanan = lMakanan;
            }

            return lKategori;
        }
        #endregion

        #region Transaksi
        public static int AddTransaksi(Model.MMakananTransaksi MTransaksi, string Waiter, string NomorMeja)
        {
            int idOrder = 0;

            try
            {
                int? idKamar = MTransaksi.IDTransaksiKamar.Equals(0) ? (int?)null : MTransaksi.IDTransaksiKamar;

                using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO restoran_transaksi(id_transaksi_kamar, tanggal, waiter, meja) " +
                        "VALUES(@idKamar, @tanggal, @waiter, @meja); SELECT LAST_INSERT_ID();", con);
                    cmd.Parameters.AddWithValue("@idKamar", idKamar);
                    cmd.Parameters.AddWithValue("@tanggal", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@waiter", Waiter);
                    cmd.Parameters.AddWithValue("@meja", NomorMeja);
                    int idTransaksi = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    MTransaksi.IDTransaksi = idTransaksi;
                    idOrder = idTransaksi;
                }

                AddOrder(MTransaksi);
            }
            catch { throw; }

            return idOrder;
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

                    cmd.CommandText = "UPDATE restoran_transaksi SET total = " +
                    "(SELECT SUM(harga * qty) FROM restoran_detail WHERE id_transaksi = @idTransaksi) WHERE id = @idTransaksi";
                    cmd.ExecuteNonQuery();
                }
            }
            catch { throw; }
        }

        public static List<Model.MMakananTransaksi> ReadDetailTransaksi(int IDOrder)
        {
            List<Model.MMakananTransaksi> lTransaksi = new List<Model.MMakananTransaksi>();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT *, (SELECT kamar FROM kamar_transaksi WHERE id = RD.id_transaksi_kamar) AS nomor_kamar, " +
                    "(SELECT nama FROM menu_data WHERE id = id_makanan) AS makanan FROM restoran_detail JOIN restoran_transaksi AS RD ON " +
                    "id_transaksi = RD.id WHERE id_transaksi = @id", con);
                cmd.Parameters.AddWithValue("@id", IDOrder);

                try
                {
                    using (MySqlDataReader read = cmd.ExecuteReader())
                        while (read.Read())
                        {
                            int? idTransaksiKamar = Convert.IsDBNull(read["id_transaksi_kamar"]) ? (int?)null : read.GetInt32("id_transaksi_kamar");
                            lTransaksi.Add(new Model.MMakananTransaksi()
                            {
                                IDDetailTransaksi = read.GetInt32("id"),
                                IDTransaksi = read.GetInt32("id_transaksi"),
                                IDTransaksiKamar = idTransaksiKamar,
                                IDMakanan = read.GetInt32("id_makanan"),
                                Qty = read.GetInt32("qty"),
                                Harga = read.GetInt32("harga"),
                                NamaMenu = read["makanan"].ToString(),
                                NomorKamar = read["nomor_kamar"].ToString()
                            });
                        }
                }
                catch (Exception msg) { System.Windows.Forms.MessageBox.Show(msg.ToString()); }
            }

            return lTransaksi;
        }

        public static List<Model.MRestoranView> ReadTransaction()
        {
            List<Model.MRestoranView> lRestoran = new List<Model.MRestoranView>();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT *, (SELECT kamar FROM kamar_transaksi AS KT WHERE RT.id_transaksi_kamar = KT.id) " +
                    "AS nomor_kamar FROM restoran_transaksi AS RT WHERE aktif = 'Y'", con);
                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        lRestoran.Add(new Model.MRestoranView()
                        {
                            Nominal = read.GetInt32("total"),
                            NomorKamar = read["nomor_kamar"].ToString(),
                            NomorMeja = read["meja"].ToString(),
                            Waiter = read["waiter"].ToString(),
                            OrderID = read.GetInt32("id")
                        });
                    }
                }
            }

            return lRestoran;
        }

        public static void EditOrder(Model.MMakananTransaksi MTransaksi)
        {
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE restoran_detail SET id_makanan = @idMakanan, nama = @nama, qty = @qty, harga = @harga " +
                    "WHERE id = @idDetail", con);
                cmd.Parameters.AddWithValue("@idMakanan", MTransaksi.IDMakanan);
                cmd.Parameters.AddWithValue("@nama", MTransaksi.NamaMenu);
                cmd.Parameters.AddWithValue("@qty", MTransaksi.Qty);
                cmd.Parameters.AddWithValue("@harga", MTransaksi.Harga);
                cmd.Parameters.AddWithValue("@idDetail", MTransaksi.IDDetailTransaksi);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE restoran_transaksi SET total = " +
                    "(SELECT SUM(harga * qty) FROM restoran_detail WHERE id_transaksi = @idTransaksi) WHERE id = @idTransaksi";
                cmd.Parameters.AddWithValue("@idTransaksi", MTransaksi.IDTransaksi);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteOrder(int DetailOrderID, int TransaksiOrderID)
        {
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM restoran_detail WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", DetailOrderID);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE restoran_transaksi SET total = " +
                    "(SELECT SUM(harga * qty) FROM restoran_detail WHERE id_transaksi = @idTransaksi) WHERE id = @idTransaksi";
                cmd.Parameters.AddWithValue("@idTransaksi", TransaksiOrderID);
                cmd.ExecuteNonQuery();
            }
        }

        public static bool ReadMeja(string NomorMeja)
        {
            bool terisi;

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM restoran_transaksi WHERE meja = @meja AND aktif = 'Y'", con);
                cmd.Parameters.AddWithValue("@meja", NomorMeja);
                terisi = cmd.ExecuteScalar().ToString().Equals("0") ? false : true;
            }

            return terisi;
        }
        #endregion

        #region Link Kamar
        public static List<Model.MRoom> ReadCheckedRoom()
        {
            List<Model.MRoom> lRoom = new List<Model.MRoom>();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM kamar_transaksi AS KT WHERE check_in IS NOT NULL AND check_out IS NULL AND NOT EXISTS (SELECT * FROM restoran_transaksi AS RT WHERE RT.id_transaksi_kamar = KT.id)", con);
                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        lRoom.Add(new Model.MRoom()
                        {
                            NomorKamar = read["kamar"].ToString(),
                            NamaPemesan = read["nama"].ToString(),
                            IDTransaksi = read.GetInt32("id")
                        });
                    }
                }
            }

            return lRoom;
        }

        public static void LinkRoomToOrder(int OrderID, int RoomTrasactionID)
        {
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE restoran_transaksi SET id_transaksi_kamar = @roomid WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@roomid", RoomTrasactionID);
                cmd.Parameters.AddWithValue("@id", OrderID);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
    }
}