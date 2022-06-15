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
        int idKamar;

        Model.MRoom mKamar;

        public PesanKamar(Main HMain, int IdKamar)
        {
            InitializeComponent();
            hMain = HMain;
            idKamar = IdKamar;

            AmbilData(IdKamar);
        }

        public void AmbilData(int IDKamar)
        {
            mKamar = Database.DKamar.ReadRoomID(IDKamar);

            if (string.IsNullOrEmpty(mKamar.JenisKamar))
            {
                MessageBox.Show("Data Kamar Yang Dicari Tidak Ditemukan! Silakan Periksa Kembali Data Anda!", "Data Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            tNoKamar.Text = mKamar.NomorKamar.ToString();
            tJenisKamar.Text = mKamar.JenisKamar;
            tHargaPerMalam.Text = string.Format("{0:#,###}", mKamar.HargaKamar);

            dtCheckin.MinDate = DateTime.Now;
            dtCheckOut.MinDate = DateTime.Now.AddDays(1);
        }

        private void bPesanKamar_Click(object sender, EventArgs e)
        {
            //Kode Simpan Data
            DateTime Checkin = dtCheckin.Value,
                Checkout = dtCheckOut.Value;
            int extraBed = Convert.ToInt32(nExtraBed.Value),
                hari = Convert.ToInt32((Checkout - Checkin).TotalDays);

            try
            {
                Database.DKamar.PesanKamar(Convert.ToInt32(mKamar.NomorKamar), extraBed, Checkin, Checkout, hari);
                
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
    }
}
