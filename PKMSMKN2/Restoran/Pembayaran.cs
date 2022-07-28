using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKMSMKN2.Restoran
{
    public partial class Pembayaran : Form
    {
        int idOrder, total;

        private void bBayar_Click(object sender, EventArgs e)
        {
            int pembayaran = Convert.ToInt32(Regex.Replace(tPembayaran.Text, @"\W", ""));

            if (pembayaran >= total)
            {
                Database.DRestoran.Pembayaran(idOrder);
                this.Close();
                return;
            }

            MessageBox.Show("Pembayaran Kurang Dari Total!");
        }

        private void tPembayaran_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || tPembayaran.Text.Length < 16)
                Function.cekAngka(sender, e);
            else
                e.Handled = true;
        }

        private void tPembayaran_KeyUp(object sender, KeyEventArgs e)
        {
            Function.addNominal(tPembayaran);
        }

        public Pembayaran(int OrderID, int Total)
        {
            InitializeComponent();
            idOrder = OrderID;
            total = Total;
            lTotal.Text += String.Format("{0:#,##0}", Total);
        }
    }
}