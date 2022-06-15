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

namespace PKMSMKN2
{
    public partial class Login : Form
    {
        MainForm mf;

        public Login(MainForm mainForm)
        {
            InitializeComponent();
            mf = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check apakah input masih kosong
            foreach (TextBox tb in pLogin.Controls.OfType<TextBox>())
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show("Data Belum Terisi Secara Lengkap!");
                    tb.Focus();
                    return;
                }

            //Proses login disini lalu kembalikan username ke mainform
            bool checkUser = Database.DLogin.CheckUser(tUsername.Text.ToString(), tPassword.Text.ToString());
            if (checkUser)
            {
                mf.CheckUser();
                this.Close();
            }
            else
                MessageBox.Show("Username atau Password yang dimasukan salah!", "Login Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        private void Login_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            if (string.IsNullOrEmpty(Model.MUser.USERNAME))
                Application.Exit();
        }
    }
}
