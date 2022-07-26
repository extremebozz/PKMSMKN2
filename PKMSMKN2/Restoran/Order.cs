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
    public partial class Order : Form
    {
        int idTransaksiKamar, idTransaksiOrder, idOrder;
        string nomorMeja;
        bool orderanBaru = true;

        RMain main;

        public Order(RMain Main, string NomorMeja, int OrderID = 0)
        {
            InitializeComponent();
            idOrder = OrderID;
            main = Main;
            nomorMeja = NomorMeja;
            AmbilData();
            this.Text = "Nomor Meja : " + NomorMeja;
            lMeja.Text = ": " + NomorMeja;
        }

        public void AmbilData(int OrderID = 0)
        {
            if (OrderID != 0)
                idOrder = OrderID;

            dgvOrderList.Columns.Clear();

            //Ambil data Makanan_transaksi berdasarkan Id_Transaksi
            BindingSource bsTransaksi = new BindingSource();
            List<Model.MMakananTransaksi> lTransaksi = Database.DRestoran.ReadDetailTransaksi(idOrder);

            if (lTransaksi.Count == 0)
            {
                lTotal.Text = ": 0";

                dgvOrderList.Columns.Clear();

                dgvOrderList.Columns.Add("", "");
                dgvOrderList.Rows.Add("Tidak Ada Orderan!");
                orderanBaru = false;
                return;
            }

            if (lTransaksi[0].IDTransaksi != 0)
                idTransaksiOrder = lTransaksi[0].IDTransaksi;

            bsTransaksi.DataSource = lTransaksi;
            dgvOrderList.DataSource = bsTransaksi;

            dgvOrderList.Columns["IDDetailTransaksi"].Visible = false;
            dgvOrderList.Columns["IDTransaksi"].Visible = false;
            dgvOrderList.Columns["IDTransaksiKamar"].Visible = false;
            dgvOrderList.Columns["IDMakanan"].Visible = false;
            dgvOrderList.Columns["harga"].DefaultCellStyle.Format = "#,##0";
            dgvOrderList.Columns["total"].DefaultCellStyle.Format = "#,##0";

            int test = lTransaksi.Sum(transaksi => transaksi.Total);

            lTotal.Text = ": " + string.Format("{0:#,##0}", lTransaksi.Sum(transaksi => transaksi.Total));
        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.AmbilData();
        }
        
        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OrderMenu oMenu = new OrderMenu(this, idTransaksiKamar, nomorMeja, idOrder);
                oMenu.ShowDialog();
            }
            catch { }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dgvOrderList.CurrentCell.RowIndex),
                idDetailTransaksi = Convert.ToInt32(dgvOrderList.Rows[index].Cells["IDDetailTransaksi"].Value);

            OrderMenu oMenu = new OrderMenu(this, idTransaksiKamar, idOrder, idDetailTransaksi);
            oMenu.ShowDialog();
        }

        private void bLinkKamar_Click(object sender, EventArgs e)
        {

        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Orderan Ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr.Equals(DialogResult.Yes))
            {
                int index = Convert.ToInt32(dgvOrderList.CurrentCell.RowIndex),
                    idDetailTransaksi = Convert.ToInt32(dgvOrderList.Rows[index].Cells["IDDetailTransaksi"].Value),
                    idTransaksi = Convert.ToInt32(dgvOrderList.Rows[index].Cells["IDTransaksi"].Value);

                Database.DRestoran.DeleteOrder(idDetailTransaksi, idTransaksi);
                AmbilData();
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}