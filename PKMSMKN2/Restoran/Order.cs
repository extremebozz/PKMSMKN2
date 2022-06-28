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
        int idTransaksiKamar, idTransaksiOrder;
        bool orderanBaru = true;

        RMain main;

        public Order(RMain Main, int IDTransaksiKamar, int NomorKamar)
        {
            InitializeComponent();
            idTransaksiKamar = IDTransaksiKamar;
            main = Main;
            AmbilData();
            this.Text = "Nomor Kamar : " + NomorKamar;
        }

        public void AmbilData()
        {
            //Ambil data Makanan_transaksi berdasarkan Id_Transaksi
            BindingSource bsTransaksi = new BindingSource();
            List<Model.MMakananTransaksi> lTransaksi = Database.DRestoran.ReadDetailTransaksi(idTransaksiKamar);

            if (lTransaksi.Count == 0)
            {
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
        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.AmbilData();
        }
        
        private void bAdd_Click(object sender, EventArgs e)
        {
            OrderMenu oMenu = new OrderMenu(this, idTransaksiKamar, idTransaksiOrder);
            oMenu.ShowDialog();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dgvOrderList.CurrentCell.RowIndex),
                idDetailTransaksi = Convert.ToInt32(dgvOrderList.Rows[index].Cells["IDDetailTransaksi"].Value);

            OrderMenu oMenu = new OrderMenu(this, idTransaksiKamar, idTransaksiOrder, idDetailTransaksi);
            oMenu.ShowDialog();
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