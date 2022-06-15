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
    public partial class AddKategoriKamar : Form
    {
        Main hMain;

        int IdKamar, hargaKamar = 0;
        string jenisKamar;

        public AddKategoriKamar(Main HMain)
        {
            InitializeComponent();
            hMain = HMain;
        }

        public AddKategoriKamar(Main HMain, int ID)
        {
            InitializeComponent();
            hMain = HMain;
            IdKamar = ID;
            AmbilData(ID);

            bTambah.Text = "Update Kategori Kamar";
            bTambah.Click -= new EventHandler(bTambah_Click);
            bTambah.Click += new EventHandler(bUpdate_Click);
        }

        private void AmbilData(int IdKamar)
        {
            Model.MRoomCategory mRoomCategories = Database.DKamar.ReadRoomCategoryID(IdKamar);

            if (mRoomCategories.JenisKamar.Equals(null))
            {
                MessageBox.Show("Data Yang Dicari Tidak Dapat Ditemukan! Periksa Kembali Data Anda!", "Data Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            tJenisKamar.Text = mRoomCategories.JenisKamar;
            tHarga.Text = mRoomCategories.HargaKamar.ToString();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            jenisKamar = tJenisKamar.Text;
            hargaKamar = Convert.ToInt32(tHarga.Text);

            try
            {
                Database.DKamar.UpdateRoomCategory(IdKamar, jenisKamar, hargaKamar);
                MessageBox.Show("Data Telah Berhasil Disimpan!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                hMain.AmbilData();
                this.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), "Data Gagal Diupdate!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bTambah_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
                if (tb.Text.Equals("") & tb.ReadOnly.Equals(false))
                {
                    MessageBox.Show("Mohon Diisi Data Secara Lengkap!", "Data Belum Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb.Focus();
                    return;
                }

            string jenisKamar = tJenisKamar.Text;
            int hargaKamar = Convert.ToInt32(tHarga.Text);

            try
            {
                Database.DKamar.CreateRoomCategory(jenisKamar, hargaKamar);
                MessageBox.Show("Data Jenis Kamar Telah Tersimpan!", "Data Telah Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                hMain.AmbilData();
                this.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), "Data Gagal Disimpan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
