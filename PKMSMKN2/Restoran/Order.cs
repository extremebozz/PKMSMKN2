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
        bool orderanBaru = true;

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
            List<Model.MMakananTransaksi> lTransaksi = Database.DRestoran.ReadTransaksi(IdTransaksi);

            if (lTransaksi.Count == 0)
            {
                dgvOrderList.Columns.Add("", "");
                dgvOrderList.Rows.Add("Tidak Ada Orderan!");
                orderanBaru = false;
                return;
            }

            bsTransaksi.DataSource = lTransaksi;
            dgvOrderList.DataSource = bsTransaksi;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void bAddOrder_Click(object sender, EventArgs e)
        {
            //Kode Muncul Form Add Menu
        }
    }
}
