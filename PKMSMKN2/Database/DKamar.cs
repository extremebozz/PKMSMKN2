using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Database
{
    class DKamar
    {
        public static void PesanKamar(Model.MRoomTransaksi MPesanKamar)
        {
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO kamar_transaksi(kamar, extra_bed, tanggal_in, tanggal_out, hari, nama, identitas, jenis_kelamin) " +
                        "VALUES (@kamar, @extraBed, @tanggalIn, @tanggalOut, @hari, @nama, @identitas, @jk); SELECT LAST_INSERT_ID();", con);
                    cmd.Parameters.AddWithValue("@kamar", MPesanKamar.NomorKamar);
                    cmd.Parameters.AddWithValue("@extraBed", MPesanKamar.ExtraBed);
                    cmd.Parameters.AddWithValue("@tanggalIn", MPesanKamar.TanggalMasuk.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@tanggalOut", MPesanKamar.TanggalKeluar.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@hari", MPesanKamar.TotalHari);
                    cmd.Parameters.AddWithValue("@nama", MPesanKamar.Nama);
                    cmd.Parameters.AddWithValue("@identitas", MPesanKamar.Identitas);
                    cmd.Parameters.AddWithValue("@jk", MPesanKamar.JenisKelamin);
                    int idTransaksi = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.CommandText = "UPDATE kamar_data SET ketersediaan = 'n', id_transaksi = @idTransaksi WHERE nomor_kamar = @kamar";
                    cmd.Parameters.AddWithValue("@idTransaksi", idTransaksi);
                    cmd.ExecuteNonQuery();
                }
                catch(Exception msg)
                {
                    throw;
                }
            }
        }

        public static void CheckIn(int IDTransaksi, DateTime TanggalCheckIn)
        {
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE kamar_transaksi SET check_in = @checkIn WHERE id = @idTransaksi", con);                    
                    cmd.Parameters.AddWithValue("@idTransaksi", IDTransaksi);
                    cmd.Parameters.AddWithValue("@checkIn", TanggalCheckIn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception msg) 
                {
                    throw;
                }
            }
        }

        public static void CheckOut(int IDTransaksi, DateTime TanggalCheckOut)
        {
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE kamar_transaksi SET check_out = @checkOut WHERE id = @idTransaksi", con);
                    cmd.Parameters.AddWithValue("@checkOut", TanggalCheckOut);
                    cmd.Parameters.AddWithValue("@idTransaksi", IDTransaksi);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "UPDATE kamar_data SET id_transaksi = null, ketersediaan = 'y' WHERE id_transaksi = @idTransaksi";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception msg)
                {
                    throw;
                }
            }
        }

        public static List<Model.MRoomCategory> ReadRoomCategory()
        {
            List<Model.MRoomCategory> kKamar = new List<Model.MRoomCategory>();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT id, jenis, harga, (SELECT count(*) FROM kamar_data WHERE jenis_kamar = kamar_jenis.id) AS total_kamar FROM kamar_jenis", con);
                    int no = 1;

                    using (MySqlDataReader read = cmd.ExecuteReader())
                        while (read.Read())
                        {
                            kKamar.Add(new Model.MRoomCategory()
                            {
                                No = no,
                                ID = Convert.ToInt32(read["id"]),
                                JenisKamar = read["jenis"].ToString(),
                                HargaKamar = Convert.ToInt32(read["harga"]),
                                TotalKamar = Convert.ToInt32(read["total_kamar"])
                            });

                            no++;
                        }
                }
                catch(Exception msg)
                {
                    throw;
                }
            
            return kKamar;
        }

        public static List<Model.MRoom> ReadRoom()
        {
            List<Model.MRoom> kKamar = new List<Model.MRoom>();
            int nomorList = 1;

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                try
                {
                    MySqlCommand cmd = new MySqlCommand("CALL pTampilKamar();", con);

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

                            int? idTransaksi = Convert.IsDBNull(read["id_transaksi"])
                                ? (int?)null : Convert.ToInt32(read["id_transaksi"]);

                            kKamar.Add(new Model.MRoom()
                            {
                                Nomor = nomorList,
                                ID = Convert.ToInt32(read["id"]),
                                NomorKamar = read["nomor_kamar"].ToString(),
                                JenisKamar = read["jenis_kamar"].ToString(),
                                IDJenisKamar = Convert.ToInt32(read["id_jenis_kamar"]),
                                HargaKamar = Convert.ToInt32(read["harga_kamar"]),
                                Ketersediaan = read["ketersediaan"].ToString(),
                                TanggalIn = tanggalIn,
                                TanggalOut = tanggalOut,
                                CheckIn = checkIn,
                                CheckOut = checkOut,
                                IDTransaksi = idTransaksi
                            });

                            nomorList++;
                        }
                }
                catch (Exception msg)
                {
                    throw;
                }

            return kKamar;
        }

        public static void CreateRoomCategory(string Jenis, int Harga)
        {
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                try
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO kamar_jenis(jenis, harga) VALUES(@jenis, @harga)", con);
                    cmd.Parameters.AddWithValue("@jenis", Jenis);
                    cmd.Parameters.AddWithValue("@harga", Harga);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception msg)
                {
                    throw;
                }
        }

        public static Model.MRoomCategory ReadRoomCategoryID(int ID)
        {
            Model.MRoomCategory mRoomCategories = new Model.MRoomCategory();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT id, jenis, harga FROM kamar_jenis WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", ID);

                    MySqlDataReader read = cmd.ExecuteReader();
                    read.Read();

                    mRoomCategories.ID = Convert.ToInt32(read["id"].ToString());
                    mRoomCategories.JenisKamar = read["jenis"].ToString();
                    mRoomCategories.HargaKamar = Convert.ToInt32(read["harga"].ToString());
                }
                catch(Exception msg)
                {
                    throw;
                }

            return mRoomCategories;
        }

        public static Model.MRoom ReadExtraBed()
        {
            Model.MRoom mRoomCategories = new Model.MRoom();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT id, jenis, harga FROM kamar_jenis WHERE jenis = 'extra_bed'", con);

                    MySqlDataReader read = cmd.ExecuteReader();
                    read.Read();

                    mRoomCategories.ID = Convert.ToInt32(read["id"].ToString());
                    mRoomCategories.JenisKamar = read["jenis"].ToString();
                    mRoomCategories.HargaKamar = Convert.ToInt32(read["harga"].ToString());
                }
                catch
                {
                    throw;
                }

            return mRoomCategories;
        }

        public static void UpdateRoomCategory(int ID, string Jenis, int Harga)
        {
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                try
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE kamar_jenis SET jenis = @jenis, harga = @harga WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@jenis", Jenis);
                    cmd.Parameters.AddWithValue("@harga", Harga);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception msg)
                {
                    throw;
                }
        }

        public static void CreateRoom(int Nomor, int Jenis)
        {
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                try
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO kamar_data(nomor_kamar, jenis_kamar) VALUES(@nomor, @jenis)", con);
                    cmd.Parameters.AddWithValue("@nomor", Nomor);
                    cmd.Parameters.AddWithValue("@jenis", Jenis);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception msg)
                {
                    throw;
                }
        }

        public static Model.MRoom ReadRoomID(int ID)
        {
            Model.MRoom mRoom = new Model.MRoom();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                try
                {
                    MySqlCommand cmd = new MySqlCommand("CALL pTampilKamarByID(@id)", con);
                    cmd.Parameters.AddWithValue("@id", ID);

                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            mRoom.ID = Convert.ToInt32(read["id"].ToString());
                            mRoom.NomorKamar = read["nomor_kamar"].ToString();
                            mRoom.IDJenisKamar = Convert.ToInt32(read["id_jenis_kamar"].ToString());
                            mRoom.JenisKamar = read["jenis_kamar"].ToString();
                            mRoom.HargaKamar = Convert.ToInt32(read["harga_kamar"]);
                        }
                    }
                }
                catch (Exception msg)
                {
                    throw;
                }

            return mRoom;
        }

        public static void UpdateRoom(int ID, int NomorKamar, int JenisKamar)
        {
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                try
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE kamar_data SET nomor_kamar = @nomorKamar, jenis_kamar = @jenisKamar WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@nomorKamar", NomorKamar);
                    cmd.Parameters.AddWithValue("@jenisKamar", JenisKamar);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception msg)
                {
                    throw;
                }
        }

        public static void DeleteRoom(int RoomID)
        {
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM kamar_data WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", RoomID);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }

        public static void DeleteCategory(int CategoryID)
        {
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM kamar_jenis WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", CategoryID);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }

        public static int GetLastestRoomNumber()
        {
            int nomorKamar = 0;

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(MAX(nomor_kamar), 0) AS nomor_kamar FROM kamar_data", con);

                MySqlDataReader read = cmd.ExecuteReader();
                read.Read();

                nomorKamar = Convert.ToInt32(read["nomor_kamar"]);
            }

            return nomorKamar;
        }

        public static Model.MRoomTransaksi ReadTransactionByID(int IDTransaksi)
        {
            Model.MRoomTransaksi mTransaksi = new Model.MRoomTransaksi();

            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM kamar_transaksi WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", IDTransaksi);

                using (MySqlDataReader read = cmd.ExecuteReader()) 
                    while (read.Read())
                        mTransaksi = new Model.MRoomTransaksi()
                        {
                            ID = Convert.ToInt32(read["id"]),
                            NomorKamar = read["kamar"].ToString(),
                            Nama = read["nama"].ToString(),
                            Identitas = read["identitas"].ToString(),
                            JenisKelamin = read["jenis_kelamin"].ToString(),
                            TanggalMasuk = Convert.ToDateTime(read["tanggal_in"]),
                            TanggalKeluar = Convert.ToDateTime(read["tanggal_out"]),
                            ExtraBed = Convert.ToInt32(read["extra_bed"]),
                            TotalHari = Convert.ToInt32(read["hari"])
                        };
            }

            return mTransaksi;
        }
    }
}