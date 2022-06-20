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
            Form service = new Services.SMain(mf);

            //Restoran
            
        }

        public void AmbilData()
        {
            //User
            BindingSource bsUser = new BindingSource();
            List<Model.Model_User> lUser = Database.DUser.GetUser();

            bsUser.DataSource = lUser;
            dgvUser.DataSource = bsUser;

            dgvUser.Columns["Nomor"].FillWeight = 50;
            dgvUser.Columns["UserID"].Visible = false;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            mf.ExitUser();
        }

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
    }
}