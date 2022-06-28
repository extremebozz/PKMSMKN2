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
            List<Model.MMakananTransaksi> lTransaksi = Database.DRestoran.ReadTransaksi(idTransaksiKamar);

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
        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.AmbilData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderMenu oMenu = new OrderMenu(this, idTransaksiKamar, idTransaksiOrder);
            oMenu.ShowDialog();
        }
    }
}
