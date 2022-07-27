using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKMSMKN2.Hotel
{
    public partial class Main : Form
    {
        MainForm mf;

        bool admin;

        public Main(MainForm mainForm, bool Admin)
        {
            InitializeComponent();
            mf = mainForm;
            admin = Admin;
            AmbilData();

            Timer timer = new Timer();
            timer.Interval = (10 * 1000); //10 Detik
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            AmbilData();
        }

        public void AmbilData()
        {
            BindingSource bsKamar = new BindingSource();
            List<Model.MRoom> lKamar = Database.DKamar.ReadRoom();

            bsKamar.DataSource = lKamar;
            dgvKamar.DataSource = bsKamar;

            //Formatting DataGridView Kamar
            dgvKamar.Columns["ID"].Visible = false;
            dgvKamar.Columns["IDJenisKamar"].Visible = false;
            dgvKamar.Columns["IDTransaksi"].Visible = false;
            dgvKamar.Columns["CheckOut"].Visible = false;
            dgvKamar.Columns["Pesanan"].Visible = false;
            dgvKamar.Columns["NamaPemesan"].Visible = false;
            dgvKamar.Columns["Nominal"].Visible = false;
            dgvKamar.Columns["Nomor"].HeaderText = "No";
            dgvKamar.Columns["Nomor"].FillWeight = 50;
            dgvKamar.Columns["NomorKamar"].FillWeight = 50;
            dgvKamar.Columns["HargaKamar"].DefaultCellStyle.Format = "#,##0";
            dgvKamar.Columns["TanggalIn"].DefaultCellStyle.Format = "dd MMMM yyyy";
            dgvKamar.Columns["TanggalOut"].DefaultCellStyle.Format = "dd MMMM yyyy";
            dgvKamar.Columns["CheckIn"].DefaultCellStyle.Format = "dd MMMM yyyy HH:mm:ss";
            dgvKamar.Columns["CheckOut"].DefaultCellStyle.Format = "dd MMMM yyyy HH:mm:ss";

            //Buat Transaksi
            BindingSource bsTransaksi = new BindingSource();
            List<Model.MRoom> lTransaksi = Database.DKamar.ReadTransaksiRoom(); //new List<Model.MRoom>();

            bsTransaksi.DataSource = lTransaksi;
            dgvTransaksi.DataSource = bsTransaksi;

            dgvTransaksi.Columns["ID"].Visible = false;
            dgvTransaksi.Columns["IDJenisKamar"].Visible = false;
            dgvTransaksi.Columns["IDTransaksi"].Visible = false;
            dgvTransaksi.Columns["Ketersediaan"].Visible = false;
            dgvTransaksi.Columns["Nomor"].HeaderText = "No";
            dgvTransaksi.Columns["Nomor"].FillWeight = 50;
            dgvTransaksi.Columns["NomorKamar"].FillWeight = 50;
            dgvTransaksi.Columns["Pesanan"].FillWeight = 55;
            dgvTransaksi.Columns["Hari"].FillWeight = 50;
            dgvTransaksi.Columns["HargaKamar"].DefaultCellStyle.Format = "#,##0";
            dgvTransaksi.Columns["Nominal"].DefaultCellStyle.Format = "#,##0";
            dgvTransaksi.Columns["TanggalIn"].DefaultCellStyle.Format = "dd MMMM yyyy";
            dgvTransaksi.Columns["TanggalOut"].DefaultCellStyle.Format = "dd MMMM yyyy";
            dgvTransaksi.Columns["CheckIn"].DefaultCellStyle.Format = "dd MMMM yyyy HH:mm:ss";
            dgvTransaksi.Columns["CheckOut"].DefaultCellStyle.Format = "dd MMMM yyyy HH:mm:ss";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!admin)
                mf.ExitUser();
        }

        private void bCheckIn_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvKamar.CurrentCell.RowIndex;
            int idTransaksi = Convert.ToInt32(dgvKamar.Rows[rowIndex].Cells["IDTransaksi"].Value);

            if (idTransaksi.Equals(0))
            {
                MessageBox.Show("Kamar Ini Belum Dipesan!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (((DateTime?)dgvKamar.Rows[rowIndex].Cells["CheckIn"].Value).HasValue ? true : false)
            {
                MessageBox.Show("Kamar Ini Telah Check In!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CheckKamar cKamar = new CheckKamar(this, idTransaksi, true);
            cKamar.StartPosition = FormStartPosition.CenterScreen;
            cKamar.ShowDialog();
        }

        private void bCheckOut_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvKamar.CurrentCell.RowIndex;
            int idTransaksi = Convert.ToInt32(dgvKamar.Rows[rowIndex].Cells["IDTransaksi"].Value);

            if (!((DateTime?) dgvKamar.Rows[rowIndex].Cells["CheckIn"].Value).HasValue ? true : false)
            {
                MessageBox.Show("Kamar Ini Belum Check In!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CheckKamar cKamar = new CheckKamar(this, idTransaksi, false);
            cKamar.StartPosition = FormStartPosition.CenterScreen;
            cKamar.ShowDialog();
        }

        private void bPesanKamar_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvKamar.CurrentCell.RowIndex,
                idKamar = Convert.ToInt32(dgvKamar.Rows[rowIndex].Cells["ID"].Value);

            if (dgvKamar.Rows[rowIndex].Cells["Ketersediaan"].Value.Equals("Tidak"))
            {
                MessageBox.Show("Kamar Telah Dipesan!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                PesanKamar pKamar = new PesanKamar(this, idKamar);
                pKamar.StartPosition = FormStartPosition.CenterScreen;
                pKamar.ShowDialog();
            } 
            catch (Exception msg) 
            {
                MessageBox.Show(msg.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bRoomService_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvKamar.CurrentCell.RowIndex,
                noKamar = Convert.ToInt32(dgvKamar.Rows[rowIndex].Cells["NomorKamar"].Value),
                idTransaksi = Convert.ToInt32(dgvKamar.Rows[rowIndex].Cells["IDTransaksi"].Value);

            if (!((DateTime?)dgvKamar.Rows[rowIndex].Cells["CheckIn"].Value).HasValue ? true : false)
            {
                MessageBox.Show("Kamar Ini Belum Check In!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Service service = new Service(noKamar, idTransaksi);
            service.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvKamar.CurrentCell.RowIndex,
                idTransaksi = Convert.ToInt32(dgvKamar.Rows[rowIndex].Cells["IDTransaksi"].Value);

            CetakFaktur cFatkur = new CetakFaktur(idTransaksi);
            cFatkur.ShowDialog();
        }

        private void bReport_Click(object sender, EventArgs e)
        {
            CetakReport cReport = new CetakReport();
            cReport.ShowDialog();
        }
    }
}
