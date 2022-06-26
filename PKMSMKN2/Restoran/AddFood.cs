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

namespace PKMSMKN2.Restoran
{
    public partial class AddFood : Form
    {
        Admin.Main main;

        int idMenu;
        bool edit = false;

        public AddFood(Admin.Main Main)
        {
            InitializeComponent();
            main = Main;
            Init();
        }

        public AddFood(Admin.Main Main, int IdMenu) : this(Main)
        {
            idMenu = IdMenu;
            this.Text = "Edit Menu";
            edit = true;

            AmbilData(IdMenu);
        }

        private void Init()
        {
            //Ambil data kategori untuk dimasukan ke combobox
            List<Model.MKategoriMakanan> lKategori = Database.DRestoran.ReadCategory();
            Dictionary<string, int> dKategori = new Dictionary<string, int>();

            if (lKategori.Count == 0)
            {
                MessageBox.Show("Belum Ada Data Kategori, Silakan Tambahkan Data Kategori Terlebih Dahulu!", "Data Kategori Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            for (int i = 0; i < lKategori.Count; i++)
                dKategori.Add(lKategori[i].Nama, lKategori[i].CategoryID);

            cbKategori.DataSource = new BindingSource(dKategori, null);
            cbKategori.DisplayMember = "Key";
            cbKategori.ValueMember = "Value";
        }

        private void AmbilData(int MenuID)
        {
            //Kode Ambil Data Menu
            List<Model.MMakanan> mMakanan = Database.DRestoran.ReadMakanan(MenuID);

            if (mMakanan.Count == 0)
            {
                MessageBox.Show("Pastikan Data Yang Dicari Benar!", "Data Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            cbKategori.SelectedValue = mMakanan[0].CategoryID;
            tNama.Text = mMakanan[0].Nama;
            tHarga.Text = mMakanan[0].Harga.ToString();
        }

        private void bSimpan_Click(object sender, EventArgs e)
        {
            //Ambil data dari form
            int idCategory = Convert.ToInt32(cbKategori.SelectedValue),
                harga = Convert.ToInt32(tHarga.Text);
            string nama = tNama.Text;

            //Masukan data diatas ke dalam model
            Model.MMakanan mMakanan = new Model.MMakanan()
            {
                CategoryID = idCategory,
                Harga = harga,
                Nama = nama
            };

            if (edit)
                mMakanan.FoodID = idMenu;

            //Simpan data ke database
            using (MySqlConnection con = DatabaseHelper.OpenKoneksi())
                try
                {
                    if (!edit)
                        Database.DRestoran.AddMakanan(mMakanan);
                    else
                        Database.DRestoran.UpdateMakanan(mMakanan);

                    MessageBox.Show("Data Telah Tersimpan", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    main.AmbilData();
                    this.Close();
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString(), "Data Tidak Berhasil Disimpan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
    }
}
