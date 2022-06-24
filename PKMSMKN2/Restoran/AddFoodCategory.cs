using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKMSMKN2.Restoran
{
    public partial class AddFoodCategory : Form
    {
        bool edit = false;
        int idCategory = 0;

        Admin.Main aMain;

        public AddFoodCategory(Admin.Main Main)
        {
            InitializeComponent();
            aMain = Main;
        }

        public AddFoodCategory(Admin.Main Main, int CategoryID) : this(Main)
        {
            idCategory = CategoryID;
            edit = true;
            AmbilData(CategoryID);
        }

        private void AmbilData(int CategoryID)
        {
            //Ambil Data Category By ID
            List<Model.MKategoriMakanan> lKategori = Database.DRestoran.ReadCategory(CategoryID);

            if (lKategori.Count == 0)
            {
                MessageBox.Show("Pastikan Data Yang Dicari Benar!", "Data Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            tKategori.Text = lKategori[0].Nama;
        }

        private void bSimpan_Click(object sender, EventArgs e)
        {
            string namaKategori = tKategori.Text;

            //Simpan Data atau Update Data tergantung edit true atau false
            try
            {
                if (edit)
                    Database.DRestoran.UpdateCategory(idCategory, namaKategori);
                else
                    Database.DRestoran.AddCategory(namaKategori);
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), "Data Gagal Tersimpan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddFoodCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            aMain.AmbilData();
        }
    }
}
