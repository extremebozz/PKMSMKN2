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
    public partial class OrderMenu : Form
    {
        Order order;
        List<Model.MKategoriMakanan> lKategori;

        int qty, idFood, harga, idOrder, idKamar, idFoodTransaction = 0;
        string menu, nomorMeja;

        public OrderMenu(Order Order, int RoomID, string NomorMeja, int OrderID = 0)
        {
            InitializeComponent();
            order = Order;
            idKamar = RoomID;
            idOrder = OrderID;
            nomorMeja = NomorMeja;
            InitData();
        }

        public OrderMenu(Order Order, int RoomID, int OrderID, int FoodTransactionID) : this(Order, RoomID, "0", OrderID)
        {
            nQty.ValueChanged -= numericUpDown1_ValueChanged;
            idFoodTransaction = FoodTransactionID;
            AmbilData(FoodTransactionID);
            nQty.ValueChanged += numericUpDown1_ValueChanged;
        }

        private void InitData()
        {
            lKategori = Database.DRestoran.ReadOrderFood();

            if (lKategori.Count == 0)
            {
                MessageBox.Show("Data menu atau kategori masih kosong! Silahkan masukan data terlebih dahulu!", "Data Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            for (int i = lKategori.Count - 1; i >= 0; i--)
            {
                //Add Label
                Label label = new Label();
                label.Dock = DockStyle.Fill;
                label.Location = new Point(0, 0);
                label.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                label.ForeColor = Color.White;
                label.Name = i.ToString();
                label.Size = new Size(194, 50);
                label.TabIndex = 0;
                label.Text = lKategori[i].Nama;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Click += new EventHandler(pLabel_Click);

                //Add Panel
                Panel panel = new Panel();
                panel.Controls.Add(label);
                panel.Dock = DockStyle.Top;
                panel.Location = new Point(0, 0);
                panel.Name = lKategori[i].Nama;
                panel.Size = new Size(194, 50);
                panel.TabIndex = i;
                panel.BackColor = Color.DarkBlue;

                this.pKategori.Controls.Add(panel);
            }

            ShowDataGridViewData();
        }

        private void AmbilData(int FoodTransactionID)
        {
            Model.MMakananTransaksi mTransaksi = Database.DRestoran.ReadFoodTransaction(FoodTransactionID);

            lMenu.Text = mTransaksi.NamaMenu.ToString();
            lHarga.Text = string.Format("{0:#,##0}", mTransaksi.Harga * mTransaksi.Qty);
            nQty.Value = mTransaksi.Qty;

            List<Model.MMakanan> mMakanan = Database.DRestoran.ReadMakanan(mTransaksi.IDMakanan);
            int idCategory = mMakanan[0].CategoryID;
            int index = lKategori.FindIndex(kat => kat.CategoryID == idCategory);

            ShowDataGridViewData(index);
        }

        private void ShowDataGridViewData(int index = 0)
        {
            List<Model.MMakanan> lMakanan = lKategori[index].ListMakanan;
            BindingSource bs = new BindingSource();

            bs.DataSource = lMakanan;
            dgvMenu.DataSource = bs;

            dgvMenu.Columns["FoodID"].Visible = false;
            dgvMenu.Columns["CategoryID"].Visible = false;
            dgvMenu.Columns["Category"].Visible = false;
            dgvMenu.Columns["Harga"].DefaultCellStyle.Format = "#,###";
        }

        private void OrderMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            order.AmbilData();
        }

        private void pLabel_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Control)sender).Name);
            ShowDataGridViewData(index);
        }

        private void bSimpan_Click(object sender, EventArgs e)
        {
            if (idFood == 0)
            {
                MessageBox.Show("Silahkan Pilih Menu Terlebih Dahulu!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Model.MMakananTransaksi mTransaksi = new Model.MMakananTransaksi()
                {
                    Harga = harga,
                    IDMakanan = idFood,
                    IDTransaksi = idOrder,
                    IDTransaksiKamar = idKamar,
                    NamaMenu = menu,
                    Qty = qty,
                    IDDetailTransaksi = idFoodTransaction
                };

                if (idFoodTransaction == 0)
                {
                    if (idOrder == 0)
                        idOrder = Database.DRestoran.AddTransaksi(mTransaksi, Model.MUser.USERNAME, nomorMeja);
                    else
                        Database.DRestoran.AddOrder(mTransaksi);
                }
                else
                {
                    Database.DRestoran.EditOrder(mTransaksi);
                }

                order.AmbilData(idOrder);
                this.Close();
            }
            catch (Exception msg){ MessageBox.Show(msg.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateOrderStatus();
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateOrderStatus();
        }

        private void UpdateOrderStatus()
        {
            if (dgvMenu.CurrentCell.RowIndex >= 0)
            {
                int index = Convert.ToInt32(dgvMenu.CurrentCell.RowIndex);

                idFood = Convert.ToInt32(dgvMenu.Rows[index].Cells["FoodID"].Value);
                harga = Convert.ToInt32(dgvMenu.Rows[index].Cells["Harga"].Value);
                qty = Convert.ToInt32(nQty.Value);

                menu = dgvMenu.Rows[index].Cells["Nama"].Value.ToString();

                lMenu.Text = menu;
                lHarga.Text = string.Format("{0:#,##0}", harga * qty);
            }
        }
    }
}
