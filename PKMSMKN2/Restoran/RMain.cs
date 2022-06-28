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
    public partial class RMain : Form
    {
        public RMain()
        {
            InitializeComponent();
            AmbilData();
        }

        public void AmbilData()
        {
            //Ambil data kamar yang telah checkin
            BindingSource bsKamar = new BindingSource();
            List<Model.MRoom> lKamar = Database.DKamar.ReadRoom();

            bsKamar.DataSource = lKamar;
            dgvKamar.DataSource = bsKamar;
        }

        private void bPesan_Click(object sender, EventArgs e)
        {
            //Ambil index
            int index = dgvKamar.CurrentCell.RowIndex;
            int idTransaksi = Convert.ToInt32(dgvKamar.Rows[index].Cells["IDTransaksi"].Value);
            int nomorKamar = Convert.ToInt32(dgvKamar.Rows[index].Cells["NomorKamar"].Value);

            //Check apakah kamar telah check in
            if (!((DateTime?)dgvKamar.Rows[index].Cells["CheckIn"].Value).HasValue ? true : false)
            {
                MessageBox.Show("Kamar Ini Belum CheckIn!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Show form order
            Order order = new Order(this, idTransaksi, nomorKamar);
            order.ShowDialog();
        }
    }
}