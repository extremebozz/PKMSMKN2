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
    public partial class LinkRoom : Form
    {
        int idOrder;

        List<Model.MRoom> lRoom;
        Order order;

        public LinkRoom(Order Order, int OrderID)
        {
            InitializeComponent();
            idOrder = OrderID;
            order = Order;
            AmbilData();
        }

        private void AmbilData()
        {
            Dictionary<string, int> listJenisKamar = new Dictionary<string, int>();

            lRoom = Database.DRestoran.ReadCheckedRoom();

            if (lRoom.Count.Equals(0))
            {
                MessageBox.Show("Tidak ada kamar yang dapat dilink!");
                this.Close();
                return;
            }

            for (int i = 0; i < lRoom.Count; i++)
            {
                listJenisKamar.Add(lRoom[i].NomorKamar, (int)lRoom[i].IDTransaksi);
            }

            cbKamar.DataSource = new BindingSource(listJenisKamar, null);
            cbKamar.DisplayMember = "Key";
            cbKamar.ValueMember = "Value";
            cbKamar.SelectedIndex = 0;
        }

        private void bLink_Click(object sender, EventArgs e)
        {
            Database.DRestoran.LinkRoomToOrder(idOrder, Convert.ToInt32(cbKamar.SelectedValue));

            MessageBox.Show("Transaksi restoran telah berhasil disambungkan ke kamar!");
            this.Close();
        }

        private void cbKamar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbKamar.SelectedIndex;

            lNama.Text = ": " + lRoom[index].NamaPemesan;
        }

        private void LinkRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            order.AmbilData();
        }
    }
}
