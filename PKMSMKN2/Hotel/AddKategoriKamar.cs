using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKMSMKN2.Hotel
{
    public partial class AddKategoriKamar : Form
    {
        Admin.Main aMain;

        int IdKamar, hargaKamar = 0;
        string jenisKamar;

        public AddKategoriKamar(Admin.Main Main)
        {
            InitializeComponent();
            aMain = Main;
        }

        public AddKategoriKamar(Admin.Main Main, int ID) : this(Main)
        {
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

                aMain.AmbilData();
                this.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), "Data Gagal Diupdate!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || tHarga.Text.Length < 16)
                Function.cekAngka(sender, e);
            else
                e.Handled = true;
        }

        private void tHarga_KeyUp(object sender, KeyEventArgs e)
        {
            Function.addNominal(tHarga);
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
            int hargaKamar = Convert.ToInt32(Regex.Replace(tHarga.Text, @"\W", ""));

            try
            {
                Database.DKamar.CreateRoomCategory(jenisKamar, hargaKamar);
                MessageBox.Show("Data Jenis Kamar Telah Tersimpan!", "Data Telah Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                aMain.AmbilData();
                this.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), "Data Gagal Disimpan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
