using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKMSMKN2.Hotel
{
    public partial class PesanKamar : Form
    {
        Main hMain;
        int idKamar, hargaKamar, hargaExtraBed, totalTransaksi; 
        string nomorKamar;

        Model.MRoom mKamar;

        public PesanKamar(Main HMain, int IdKamar)
        {
            InitializeComponent();
            hMain = HMain;
            idKamar = IdKamar;

            AmbilData(IdKamar);
        }

        public PesanKamar()
        {
            InitializeComponent();
            AmbilData(10);
        }

        public void AmbilData(int IDKamar)
        {
            //Init Combobox
            Dictionary<string, string> listJenisKelamin = new Dictionary<string, string>();

            listJenisKelamin.Add("Laki Laki", "LK");
            listJenisKelamin.Add("Perempuan", "PR");

            cbJenisKelamin.DataSource = new BindingSource(listJenisKelamin, null);
            cbJenisKelamin.DisplayMember = "Key";
            cbJenisKelamin.ValueMember = "Value";

            //Kode Ambil Data Kamar
            //mKamar = Database.DKamar.ReadRoomID(IDKamar);

            mKamar = new Model.MRoom()
            {
                ID = 10,
                NomorKamar = "25",
                HargaKamar = 1500000,
                JenisKamar = "King Debug"
            };

            if (string.IsNullOrEmpty(mKamar.JenisKamar))
            {
                MessageBox.Show("Data Kamar Yang Dicari Tidak Ditemukan! Silakan Periksa Kembali Data Anda!", "Data Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            nomorKamar = mKamar.NomorKamar;
            hargaKamar = mKamar.HargaKamar;

            lNoKamar.Text += nomorKamar;
            lJenisKamar.Text += mKamar.JenisKamar;
            lHargaKamar.Text += string.Format("{0:#,##0}", hargaKamar);

            //mKamar = Database.DKamar.ReadExtraBed();

            mKamar = new Model.MRoom()
            {
                ID = 10,
                NomorKamar = "25",
                HargaKamar = 150000,
                JenisKamar = "King Debug"
            };

            hargaExtraBed = mKamar.HargaKamar;

            dtCheckin.MinDate = DateTime.Now;
            dtCheckOut.MinDate = DateTime.Now.AddDays(1);

            UpdateNominal();
        }

        private void UpdateNominal()
        {
            DateTime cIn = dtCheckin.Value.Date,
                cOut = dtCheckOut.Value.Date;

            int totalHari = Convert.ToInt32((cOut - cIn).TotalDays),
                extraBed = Convert.ToInt32(nExtraBed.Value);

            totalTransaksi = (totalHari * hargaKamar) + (extraBed * hargaExtraBed);

            lTotalHari.Text = "Total Hari : " + totalHari.ToString();
            lTotalTrasansaksi.Text = "Total Transaksi : Rp" + string.Format("{0:#,##0}", totalTransaksi);
        }

        private void bPesanKamar_Click(object sender, EventArgs e)
        {
            //Cek apakah semua kolom telah terisi
            foreach (TextBox tb in groupBox2.Controls.OfType<TextBox>())
                if (tb.Text.Equals(""))
                {
                    MessageBox.Show("Silahkan lengkapi dulu kolom yang kosong!", "Data Belum Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb.Focus();
                    return;
                }

            //Kode Simpan Data
            DateTime Checkin = dtCheckin.Value.Date,
                Checkout = dtCheckOut.Value.Date;
            int extraBed = Convert.ToInt32(nExtraBed.Value),
                hari = Convert.ToInt32((Checkout - Checkin).TotalDays);

            if (Checkin >= Checkout)
            {
                MessageBox.Show("Tanggal Masuk Lebih Besar Dari Tanggal Keluar!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtCheckin.Focus();
                return;
            }

            try
            {
                //Nanti masukan data ke model MRoomTransaksi baru dioper ke function!
                //Database.DKamar.PesanKamar(Convert.ToInt32(nomorKamar), extraBed, Checkin, Checkout, hari);
                
                //Kode Refresh Data
                hMain.AmbilData();
                this.Close();
                return;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), "Data Gagal Tersimpan");
            }
        }

        private void nExtraBed_ValueChanged(object sender, EventArgs e)
        {
            UpdateNominal();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtCheck_ValueChanged(object sender, EventArgs e)
        {
            UpdateNominal();
        }      
    }
}
