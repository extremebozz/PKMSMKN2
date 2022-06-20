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
    public partial class Main : Form
    {
        MainForm mf;

        bool admin;

        public Main(MainForm mainForm, bool Admin)
        {
            InitializeComponent();
            mf = mainForm;
            admin = Admin;
            AmbilData();

            if (!admin)
            {
                tabControl1.TabPages.Remove(tpJenisKamar);

                bAddRoom.Visible = false;
                bEditRoom.Visible = false;
                bDeleteRoom.Visible = false;
            }
        }

        public void AmbilData()
        {
            BindingSource bsKamar = new BindingSource();
            List<Model.MRoom> lKamar = Database.DKamar.ReadRoom();

            bsKamar.DataSource = lKamar;
            dgvKamar.DataSource = bsKamar;
            dgvKonfirgurasiKamar.DataSource = bsKamar;

            //Formatting DataGridView Kamar
            dgvKamar.Columns["ID"].Visible = false;
            dgvKamar.Columns["IDJenisKamar"].Visible = false;
            dgvKamar.Columns["IDTransaksi"].Visible = false;
            //dgvKamar.Columns["CheckIn"].Visible = false;
            //dgvKamar.Columns["CheckOut"].Visible = false;
            dgvKamar.Columns["Nomor"].HeaderText = "No";
            dgvKamar.Columns["Nomor"].FillWeight = 50;
            dgvKamar.Columns["NomorKamar"].FillWeight = 75;
            dgvKamar.Columns["NomorKamar"].HeaderText = "Nomor Kamar";
            dgvKamar.Columns["JenisKamar"].HeaderText = "Jenis Kamar";
            dgvKamar.Columns["HargaKamar"].HeaderText = "Harga Kamar";
            dgvKamar.Columns["HargaKamar"].DefaultCellStyle.Format = "#,###";
            dgvKamar.Columns["TanggalIn"].HeaderText = "Tanggal Masuk";
            dgvKamar.Columns["TanggalIn"].DefaultCellStyle.Format = "dd MMMM yyyy";
            dgvKamar.Columns["TanggalOut"].HeaderText = "Tanggal Keluar";
            dgvKamar.Columns["TanggalOut"].DefaultCellStyle.Format = "dd MMMM yyyy";
            dgvKamar.Columns["CheckIn"].DefaultCellStyle.Format = "dd MMMM yyyy HH:mm:ss";
            dgvKamar.Columns["CheckOut"].DefaultCellStyle.Format = "dd MMMM yyyy HH:mm:ss";

            //Formatting DataGridView Kamar
            dgvKonfirgurasiKamar.Columns["Nomor"].Visible = false;
            dgvKonfirgurasiKamar.Columns["ID"].Visible = false;
            dgvKonfirgurasiKamar.Columns["IDJenisKamar"].Visible = false;
            dgvKonfirgurasiKamar.Columns["IDTransaksi"].Visible = false;
            dgvKonfirgurasiKamar.Columns["CheckIn"].Visible = false;
            dgvKonfirgurasiKamar.Columns["CheckOut"].Visible = false;
            dgvKonfirgurasiKamar.Columns["TanggalIn"].Visible = false;
            dgvKonfirgurasiKamar.Columns["TanggalOut"].Visible = false;
            dgvKonfirgurasiKamar.Columns["Ketersediaan"].Visible = false;
            dgvKonfirgurasiKamar.Columns["Nomor"].HeaderText = "No";
            dgvKonfirgurasiKamar.Columns["Nomor"].FillWeight = 50;
            dgvKonfirgurasiKamar.Columns["NomorKamar"].FillWeight = 75;
            dgvKonfirgurasiKamar.Columns["NomorKamar"].HeaderText = "Nomor Kamar";
            dgvKonfirgurasiKamar.Columns["JenisKamar"].HeaderText = "Jenis Kamar";
            dgvKonfirgurasiKamar.Columns["HargaKamar"].HeaderText = "Harga Kamar";
            dgvKonfirgurasiKamar.Columns["HargaKamar"].DefaultCellStyle.Format = "#,###";

            BindingSource bsJenisKamar = new BindingSource();
            List<Model.MRoomCategory> lJenisKamar = Database.DKamar.ReadRoomCategory();

            bsJenisKamar.DataSource = lJenisKamar;
            dgvJenisKamar.DataSource = bsJenisKamar;

            //Formatting DataGridView Jenis Kamar
            dgvJenisKamar.Columns["ID"].Visible = false;
            dgvJenisKamar.Columns["JenisKamar"].HeaderText = "Jenis Kamar";
            dgvJenisKamar.Columns["HargaKamar"].DefaultCellStyle.Format = "#,###";
            dgvJenisKamar.Columns["HargaKamar"].HeaderText = "Harga Kamar";
        }

        private void bAddRoom_Click(object sender, EventArgs e)
        {
            mf.ShowForm(new AddKamar(this));
        }

        private void bDeleteRoom_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvKonfirgurasiKamar.CurrentCell.RowIndex;
            int idKamar = Convert.ToInt32(dgvKonfirgurasiKamar.Rows[rowIndex].Cells["ID"].Value);

            MessageBox.Show("Disini Ditampilkan Konfirmasi", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void bEditRoom_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvKonfirgurasiKamar.CurrentCell.RowIndex;
            int idKamar = Convert.ToInt32(dgvKonfirgurasiKamar.Rows[rowIndex].Cells["ID"].Value);

            AddKamar aKamar = new AddKamar(this, idKamar);
            aKamar.ShowDialog();
        }

        private void bAddRoomCategory_Click(object sender, EventArgs e)
        {
            mf.ShowForm(new AddKategoriKamar(this));
        }

        private void bEditRoomCategory_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvJenisKamar.CurrentCell.RowIndex;
            int idJenisKamar = Convert.ToInt32(dgvJenisKamar.Rows[rowIndex].Cells["ID"].Value);

            mf.ShowForm(new AddKategoriKamar(this, idJenisKamar));
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!admin)
                mf.ExitUser();
        }

        private void dgvJenisKamar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvJenisKamar.Rows[e.RowIndex].Cells["ID"].Value);
                AddKategoriKamar aKategoriKamar = new AddKategoriKamar(this, id);
                aKategoriKamar.ShowDialog();
            }
        }

        private void dgvKamar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvKamar.Rows[e.RowIndex].Cells[1].Value);
                AddKamar aKamar = new AddKamar(this, id);
                aKamar.ShowDialog();
            }
        }

        private void bCheckIn_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvKamar.CurrentCell.RowIndex;
            int idTransaksi = Convert.ToInt32(dgvKamar.Rows[rowIndex].Cells["IDTransaksi"].Value);

            if (idTransaksi.Equals(0))
            {
                MessageBox.Show("Kamar Ini Belum Dipesan!", "");
                return;
            }

            if (((DateTime?)dgvKamar.Rows[rowIndex].Cells["CheckIn"].Value).HasValue ? true : false)
            {
                MessageBox.Show("Kamar Ini Telah Check In!", "");
                return;
            }

            CheckKamar cKamar = new CheckKamar(this, idTransaksi, true);
            cKamar.StartPosition = FormStartPosition.CenterScreen;
            cKamar.ShowDialog();
        }

        private void bCheckOut_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvKamar.CurrentCell.RowIndex;
            int idTransaksi = Convert.ToInt32(dgvKamar.Rows[rowIndex].Cells["IDTransaksi"].Value);

            if (!((DateTime?) dgvKamar.Rows[rowIndex].Cells["CheckIn"].Value).HasValue ? true : false)
            {
                MessageBox.Show("Kamar Ini Belum Check In!", "");
                return;
            }

            CheckKamar cKamar = new CheckKamar(this, idTransaksi, false);
            cKamar.StartPosition = FormStartPosition.CenterScreen;
            cKamar.ShowDialog();
        }

        private void bPesanKamar_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvKamar.CurrentCell.RowIndex,
                idKamar = Convert.ToInt32(dgvKamar.Rows[rowIndex].Cells["ID"].Value);

            if (dgvKamar.Rows[rowIndex].Cells["Ketersediaan"].Value.Equals("Tidak"))
            {
                MessageBox.Show("Kamar Telah Dipesan!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                PesanKamar pKamar = new PesanKamar(this, idKamar);
                pKamar.StartPosition = FormStartPosition.CenterScreen;
                pKamar.ShowDialog();
            } catch (Exception msg) {  }
        }        
    }
}
