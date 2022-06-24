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
        int idTransaksi;

        public Order(int IDTransaksi, int NomorKamar)
        {
            InitializeComponent();
            idTransaksi = IDTransaksi;
            AmbilData(IDTransaksi);
            this.Text = "Nomor Kamar : " + NomorKamar;
        }

        private void AmbilData(int IdTransaksi)
        {
            //Ambil data Makanan_transaksi berdasarkan Id_Transaksi
            BindingSource bsTransaksi = new BindingSource();
            List<Model.MMakananTransaksi> lTransaksi = Database.DRestoran.ReadTransaksiDebug();

            bsTransaksi.DataSource = lTransaksi;
            dgvOrderList.DataSource = bsTransaksi;
        }
    }
}
