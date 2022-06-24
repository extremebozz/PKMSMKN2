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
            Debug();
            AmbilData();
        }

        private void Debug()
        {
            BindingSource bsKamar = new BindingSource();
            List<Model.MRoom> lRoom = new List<Model.MRoom>();

            for (int i = 1; i < 10; i++)
            {
                lRoom.Add(new Model.MRoom()
                {
                    ID = i,
                    CheckIn = DateTime.Now,
                    TanggalIn = DateTime.Now,
                    TanggalOut = DateTime.Now.AddDays(1),
                    HargaKamar = 1250000,
                    IDJenisKamar = i,
                    IDTransaksi = i,
                    JenisKamar = "King",
                    NomorKamar = i.ToString(),
                    Ketersediaan = "n"
                });
            }

            bsKamar.DataSource = lRoom;
            dgvKamar.DataSource = bsKamar;
        }

        public void AmbilData()
        {
            //Ambil data kamar yang telah checkin

        }

        private void bPesan_Click(object sender, EventArgs e)
        {
            //Ambil index
            int index = dgvKamar.CurrentCell.RowIndex;
            int idTransaksi = Convert.ToInt32(dgvKamar.Rows[index].Cells["IDTransaksi"].Value);
            int nomorKamar = Convert.ToInt32(dgvKamar.Rows[index].Cells["NomorKamar"].Value);

            Order order = new Order(idTransaksi, nomorKamar);
            order.ShowDialog();
        }
    }
}
