using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKMSMKN2.Admin.User
{
    public partial class User : Form
    {
        Main aMain;

        int userID;

        public User(Main AMain)
        {
            InitializeComponent();
            aMain = AMain;
            InitData();

            this.Text = "Add User";
        }

        public User(Main AMain, int ID)
        {
            InitializeComponent();
            aMain = AMain;
            userID = ID;
            InitData();
            AmbilData(ID);

            bSimpanData.Click -= new EventHandler(bSimpanData_Click);
            bSimpanData.Click += new EventHandler(bUpdateData_Click);

            this.Text = "Update User";
        }

        private void InitData()
        {
            cbRole.Items.Add("Hotel");
            cbRole.Items.Add("CS");
            cbRole.Items.Add("Restoran");
            cbRole.Items.Add("Admin");
            cbRole.SelectedIndex = 0;
        }

        private void AmbilData(int UserID)
        {
            Model.Model_User mUser = Database.DUser.GetUserByID(UserID);

            tUser.Text = mUser.Username;
            cbRole.SelectedItem = mUser.Role;
        }

        private void bSimpanData_Click(object sender, EventArgs e)
        {
            string password = Function.ToMD5(tPassword.Text);
            string username = tUser.Text;
            string role = cbRole.SelectedItem.ToString();

            if (username.Equals(""))
            {
                tUser.Focus();
                MessageBox.Show("Kolom Username Masi Kosong, Mohon Diisi Terlebih Dahulu!", "Data Berlum Terisi Secara Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tPassword.Text.Equals(""))
            {
                tPassword.Focus();
                MessageBox.Show("Kolom Password Masi Kosong, Mohon Diisi Terlebih Dahulu!", "Data Berlum Terisi Secara Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Database.DUser.CreateUser(username, password, role);
                MessageBox.Show("Data Berhasil Disimpan!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                aMain.AmbilData();
                this.Close();
                return;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), "Data Gagal Disimpan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bUpdateData_Click(object sender, EventArgs e) 
        {
            string password = Function.ToMD5(tPassword.Text);
            string username = tUser.Text;
            string role = cbRole.SelectedItem.ToString();

            if (username.Equals(""))
            {
                tUser.Focus();
                MessageBox.Show("Kolom Username Masi Kosong, Mohon Diisi Terlebih Dahulu!", "Data Berlum Terisi Secara Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Database.DUser.UpdateUser(userID, username, password, role);
                MessageBox.Show("Data Berhasil Disimpan!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                aMain.AmbilData();
                this.Close();
                return;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), "Data Gagal Disimpan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
