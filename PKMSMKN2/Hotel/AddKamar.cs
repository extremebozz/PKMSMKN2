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
    public partial class AddKamar : Form
    {
        Main hMain;

        List<Model.MRoomCategory> lKategoriKamar;
        int NomorKamar = 0, IdKamar;

        public AddKamar(Main HMain)
        {
            InitializeComponent();
            InitData();
            hMain = HMain;
        }

        public AddKamar(Main HMain, int ID)
        {
            InitializeComponent();
            hMain = HMain;
            IdKamar = ID;
            AmbilData(ID);

            bTambah.Text = "Update";
            bTambah.Click -= new EventHandler(bTambah_Click);
            bTambah.Click += new EventHandler(bUpdate_Click);
        }

        private void InitData()
        {
            Dictionary<string, int> listJenisKamar = new Dictionary<string, int>();
            lKategoriKamar = Database.DKamar.ReadRoomCategory();

            if (lKategoriKamar.Count.Equals(0))
            {
                MessageBox.Show("Silakan Masukan Terlebih Dahulu Data Jenis Kamar!", "Data Jenis Kamar Kosong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            for (int i = 0; lKategoriKamar.Count > i; i++)
                listJenisKamar.Add(lKategoriKamar[i].JenisKamar, lKategoriKamar[i].ID);

            cbJenisKamar.DataSource = new BindingSource(listJenisKamar, null);
            cbJenisKamar.DisplayMember = "Key";
            cbJenisKamar.ValueMember = "Value";

            NomorKamar = Database.DKamar.GetLastestRoomNumber();
            nNomorKamar.Value = NomorKamar + 1;
        }

        private void AmbilData(int ID)
        {
            //Kode Isi ComboBox
            InitData();

            //Kode Ambil Data Kamar
            Model.MRoom mRoom = Database.DKamar.ReadRoomID(ID);

            if (mRoom.NomorKamar.Equals(null))
            {
                MessageBox.Show("Data Yang Dicari Tidak Dapat Ditemukan! Periksa Kembali Data Anda!", "Data Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            nNomorKamar.Value = Convert.ToInt32(mRoom.NomorKamar);
            cbJenisKamar.SelectedValue = mRoom.IDJenisKamar;
        }

        private void bTambah_Click(object sender, EventArgs e)
        {
            int nomorKamar = int.Parse(nNomorKamar.Value.ToString());
            int jenisKamar = int.Parse(cbJenisKamar.SelectedValue.ToString());

            try
            {
                Database.DKamar.CreateRoom(nomorKamar, jenisKamar);
                MessageBox.Show("Data Kamar Berhasil Disimpan!", "Data Telah Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                hMain.AmbilData();
                this.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), "Data Gagal Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            int nomorKamar = int.Parse(nNomorKamar.Value.ToString());
            int jenisKamar = int.Parse(cbJenisKamar.SelectedValue.ToString());

            try
            {
                Database.DKamar.UpdateRoom(IdKamar, nomorKamar, jenisKamar);
                MessageBox.Show("Data Kamar Berhasil Disimpan!", "Data Telah Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                hMain.AmbilData();
                this.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), "Data Gagal Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}