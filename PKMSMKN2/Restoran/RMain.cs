using Microsoft.VisualBasic;
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
        MainForm mForm;

        bool admin = false;

        public RMain(MainForm MForm, bool Admin)
        {
            InitializeComponent();
            AmbilData();

            Timer timer = new Timer();
            timer.Interval = (10 * 1000); //10 Detik
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            mForm = MForm;
            admin = Admin;
        }

        private void timer_Tick(object sender, EventArgs e) 
        {
            AmbilData();
        }

        public void AmbilData()
        {
            //Ambil data kamar yang telah checkin
            BindingSource bsKamar = new BindingSource();
            List<Model.MRoom> lKamar = Database.DKamar.ReadRoom();

            bsKamar.DataSource = lKamar;
            dgvKamar.DataSource = bsKamar;

            dgvKamar.Columns["ID"].Visible = false;
            dgvKamar.Columns["JenisKamar"].Visible = false;
            dgvKamar.Columns["IDJenisKamar"].Visible = false;
            dgvKamar.Columns["HargaKamar"].Visible = false;
            dgvKamar.Columns["Ketersediaan"].Visible = false;
            dgvKamar.Columns["CheckOut"].Visible = false;
            dgvKamar.Columns["IDTransaksi"].Visible = false;
        }

        private void dgvKamar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            try
            {
                Order order = new Order(this, idTransaksi, "0");
                order.ShowDialog();
            }
            catch { }
        }

        private void RMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!admin)
                mForm.ExitUser();
        }

        private void bReport_Click(object sender, EventArgs e)
        {
            CetakReport cReport = new CetakReport();
            cReport.ShowDialog();
        }

        private void bEditOrder_Click(object sender, EventArgs e)
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
            try
            {
                Order order = new Order(this, idTransaksi, "0");
                order.ShowDialog();
            }
            catch { }
        }

        private void bAddOrder_Click(object sender, EventArgs e)
        {
            string nomorMeja;
            object inputBox = Interaction.InputBox("Masukan Nomor Meja Order", "Tambah Order");

            int index = dgvKamar.CurrentCell.RowIndex;
            int idTransaksi = Convert.ToInt32(dgvKamar.Rows[index].Cells["IDTransaksi"].Value);
            int nomorKamar = Convert.ToInt32(dgvKamar.Rows[index].Cells["NomorKamar"].Value);

            if (inputBox.ToString() != "")
            {
                nomorMeja = inputBox.ToString();

                Order oMenu = new Order(this, idTransaksi, nomorMeja);
                oMenu.ShowDialog();
            }
        }
    }
}