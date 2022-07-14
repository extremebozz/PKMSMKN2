using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKMSMKN2.Admin
{
    public partial class Main : Form
    {
        MainForm mf;

        public Main(MainForm mainForm)
        {
            InitializeComponent();
            mf = mainForm;
            Init();
            AmbilData();
            
            Timer timer = new Timer();
            timer.Interval = (10 * 1000); //10 Detik
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            AmbilData();
        }

        private void Init()
        {
            //Hotel
            Form hotel = new Hotel.Main(mf, true);
            hotel.TopLevel = false;
            hotel.FormBorderStyle = FormBorderStyle.None;
            tpHotel.Controls.Add(hotel);
            hotel.Dock = DockStyle.Fill;
            hotel.WindowState = FormWindowState.Normal;
            hotel.BringToFront();
            hotel.Show();

            //Service
            Form service = new Services.SMain(mf, true);
            service.TopLevel = false;
            service.FormBorderStyle = FormBorderStyle.None;
            tpService.Controls.Add(service);
            service.Dock = DockStyle.Fill;
            service.WindowState = FormWindowState.Normal;
            service.BringToFront();
            service.Show();

            //Restoran
            Form restoran = new Restoran.RMain();
            restoran.TopLevel = false;
            restoran.FormBorderStyle = FormBorderStyle.None;
            tpRestoran.Controls.Add(restoran);
            restoran.Dock = DockStyle.Fill;
            restoran.WindowState = FormWindowState.Normal;
            restoran.BringToFront();
            restoran.Show();
        }

        public void AmbilData()
        {
            //dgvUser
            BindingSource bsUser = new BindingSource();
            List<Model.Model_User> lUser = Database.DUser.GetUser();

            bsUser.DataSource = lUser;
            dgvUser.DataSource = bsUser;

            dgvUser.Columns["Nomor"].FillWeight = 50;
            dgvUser.Columns["UserID"].Visible = false;

            //dgvKonfigKamar
            BindingSource bsKamar = new BindingSource();
            List<Model.MRoom> lKamar = Database.DKamar.ReadRoom();

            bsKamar.DataSource = lKamar;
            dgvKonfigKamar.DataSource = bsKamar;

            //Formatting DataGridView Konfigurasi Kamar
            dgvKonfigKamar.Columns["Nomor"].Visible = false;
            dgvKonfigKamar.Columns["ID"].Visible = false;
            dgvKonfigKamar.Columns["IDJenisKamar"].Visible = false;
            dgvKonfigKamar.Columns["IDTransaksi"].Visible = false;
            dgvKonfigKamar.Columns["CheckIn"].Visible = false;
            dgvKonfigKamar.Columns["CheckOut"].Visible = false;
            dgvKonfigKamar.Columns["TanggalIn"].Visible = false;
            dgvKonfigKamar.Columns["TanggalOut"].Visible = false;
            dgvKonfigKamar.Columns["Ketersediaan"].Visible = false;
            dgvKonfigKamar.Columns["Pesanan"].Visible = false;
            dgvKonfigKamar.Columns["NamaPemesan"].Visible = false;
            dgvKonfigKamar.Columns["Nominal"].Visible = false;
            dgvKonfigKamar.Columns["Nomor"].HeaderText = "No";
            dgvKonfigKamar.Columns["Nomor"].FillWeight = 50;
            dgvKonfigKamar.Columns["NomorKamar"].FillWeight = 75;
            dgvKonfigKamar.Columns["NomorKamar"].HeaderText = "Nomor Kamar";
            dgvKonfigKamar.Columns["JenisKamar"].HeaderText = "Jenis Kamar";
            dgvKonfigKamar.Columns["HargaKamar"].HeaderText = "Harga Kamar";
            dgvKonfigKamar.Columns["HargaKamar"].DefaultCellStyle.Format = "#,###";

            //dgvKonfigJenisKamar
            BindingSource bsJenisKamar = new BindingSource();
            List<Model.MRoomCategory> lJenisKamar = Database.DKamar.ReadRoomCategory();

            bsJenisKamar.DataSource = lJenisKamar;
            dgvKonfigJenis.DataSource = bsJenisKamar;

            //Formatting DataGridView Konfigurasi Jenis Kamar
            dgvKonfigJenis.Columns["No"].Visible = false;
            dgvKonfigJenis.Columns["ID"].Visible = false;
            dgvKonfigJenis.Columns["JenisKamar"].HeaderText = "Jenis Kamar";
            dgvKonfigJenis.Columns["HargaKamar"].DefaultCellStyle.Format = "#,###";
            dgvKonfigJenis.Columns["HargaKamar"].HeaderText = "Harga Kamar";

            //dgvKonfigMakanan
            BindingSource bsMakanan = new BindingSource();
            List<Model.MMakanan> lMakanan = Database.DRestoran.ReadMakanan();

            bsMakanan.DataSource = lMakanan;
            dgvKonfigMenu.DataSource = bsMakanan;

            dgvKonfigMenu.Columns["FoodID"].Visible = false;
            dgvKonfigMenu.Columns["CategoryID"].Visible = false;
            dgvKonfigMenu.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            //dgvKonfigKategoriMakanan
            BindingSource bsKategori = new BindingSource();
            List<Model.MKategoriMakanan> lKategori = Database.DRestoran.ReadCategory();

            bsKategori.DataSource = lKategori;
            dgvKonfigKategori.DataSource = bsKategori;

            dgvKonfigKategori.Columns["CategoryID"].Visible = false;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            mf.ExitUser();
        }

        #region User
        private void bAddUser_Click(object sender, EventArgs e)
        {
            User.User aUser = new User.User(this);
            aUser.ShowDialog();
        }

        private void bEditUser_Click(object sender, EventArgs e)
        {
            int rowID = dgvUser.CurrentCell.RowIndex;
            int userID = Convert.ToInt32(dgvUser.Rows[rowID].Cells["UserID"].Value);

            User.User uUser = new User.User(this, userID);
            uUser.ShowDialog();
        }

        private void bHapusUser_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus User Ini?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                int rowID = dgvUser.CurrentCell.RowIndex;
                int userID = Convert.ToInt32(dgvUser.Rows[rowID].Cells["UserID"].Value);

                try
                {
                    Database.DUser.DeleteUser(userID);
                    MessageBox.Show("Data User Telah Berhasil Dihapus!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AmbilData();
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString(), "Data Gagal Dihapus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region Config Menu
        private void bAddMenu_Click(object sender, EventArgs e)
        {
            Restoran.AddFood restoran = new Restoran.AddFood(this);
            restoran.ShowDialog();
        }

        private void bEditMenu_Click(object sender, EventArgs e)
        {
            int index = dgvKonfigMenu.CurrentCell.RowIndex;
            int idMenu = Convert.ToInt32(dgvKonfigMenu.Rows[index].Cells["FoodID"].Value);

            Restoran.AddFood restoran = new Restoran.AddFood(this, idMenu);
            restoran.ShowDialog();
        }

        private void bDeleteMenu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                int index = dgvKonfigMenu.CurrentCell.RowIndex;
                int idMenu = Convert.ToInt32(dgvKonfigMenu.Rows[index].Cells["FoodID"].Value);

                try
                {
                    Database.DRestoran.DeleteMakanan(idMenu);
                    MessageBox.Show("Menu Telah Berhasil Dihapus!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AmbilData();
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString(), "Menu Gagal Dihapus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region Config Category Menu
        private void bAddCategory_Click(object sender, EventArgs e)
        {
            Restoran.AddFoodCategory kategori = new Restoran.AddFoodCategory(this);
            kategori.ShowDialog();
        }

        private void bEditCategory_Click(object sender, EventArgs e)
        {
            int index = dgvKonfigKategori.CurrentCell.RowIndex;
            int idKategori = Convert.ToInt32(dgvKonfigKategori.Rows[index].Cells["CategoryID"].Value);

            Restoran.AddFoodCategory kategori = new Restoran.AddFoodCategory(this, idKategori);
            kategori.ShowDialog();
        }

        private void bDeleteCategory_Click(object sender, EventArgs e)
        {
            int index = dgvKonfigKategori.CurrentCell.RowIndex,
                idKategori = Convert.ToInt32(dgvKonfigKategori.Rows[index].Cells["CategoryID"].Value);
            string kategori = dgvKonfigKategori.Rows[index].Cells["Nama"].Value.ToString();

            DialogResult dr = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Kategori " + kategori + "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr.Equals(DialogResult.Yes))
            {
                try
                {
                    Database.DRestoran.DeleteCategory(idKategori);
                    MessageBox.Show("Data Telah Berhasil Dihapus", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AmbilData();
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString(), "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region Config Kamar
        private void bAddKamar_Click(object sender, EventArgs e)
        {
            try
            {
                Hotel.AddKamar kamar = new Hotel.AddKamar(this);
                kamar.ShowDialog();
            }catch { }
        }

        private void bEditKamar_Click(object sender, EventArgs e)
        {
            int index = dgvKonfigKamar.CurrentCell.RowIndex,
                idKamar = Convert.ToInt32(dgvKonfigKamar.Rows[index].Cells["ID"].Value);

            Hotel.AddKamar kamar = new Hotel.AddKamar(this, idKamar);
            kamar.ShowDialog();
        }

        private void bDeleteKamar_Click(object sender, EventArgs e)
        {
            int index = dgvKonfigKamar.CurrentCell.RowIndex,
                idKamar = Convert.ToInt32(dgvKonfigKamar.Rows[index].Cells["ID"].Value);
            string nomorKamar = dgvKonfigKamar.Rows[index].Cells["NomorKamar"].Value.ToString();

            DialogResult dr = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Kamar " + nomorKamar, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr.Equals(DialogResult.Yes))
            {
                try
                {
                    Database.DKamar.DeleteRoom(idKamar);
                    MessageBox.Show("Data Telah Berhasil Dihapus!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AmbilData();
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region Config Jenis Kamar
        private void bTambahJenis_Click(object sender, EventArgs e)
        {
            Hotel.AddKategoriKamar kamar = new Hotel.AddKategoriKamar(this);
            kamar.ShowDialog();
        }

        private void bEditJenis_Click(object sender, EventArgs e)
        {
            int index = dgvKonfigJenis.CurrentCell.RowIndex,
                idJenis = Convert.ToInt32(dgvKonfigJenis.Rows[index].Cells["ID"].Value);

            Hotel.AddKategoriKamar kamar = new Hotel.AddKategoriKamar(this, idJenis);
            kamar.ShowDialog();
        }

        private void bDeleteJenis_Click(object sender, EventArgs e)
        {
            int index = dgvKonfigJenis.CurrentCell.RowIndex,
                idJenis = Convert.ToInt32(dgvKonfigJenis.Rows[index].Cells["ID"].Value);
            string jenis = dgvKonfigJenis.Rows[index].Cells["JenisKamar"].Value.ToString();

            DialogResult dr = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Kategori " + jenis, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr.Equals(DialogResult.Yes))
            {
                try
                {
                    Database.DKamar.DeleteCategory(idJenis);
                    MessageBox.Show("Data Telah Berhasil Dihapus!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AmbilData();
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion
    }
}