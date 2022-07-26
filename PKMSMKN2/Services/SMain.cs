using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKMSMKN2.Services
{
    public partial class SMain : Form
    {
        MainForm mf;
        bool isAdmin = false;

        public SMain(MainForm MForm, bool Admin)
        {
            InitializeComponent();
            mf = MForm;
            isAdmin = Admin;
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
            BindingSource bsService = new BindingSource();
            List<Model.MService> lService = Database.DService.FetchData();

            bsService.DataSource = lService;
            dgvService.DataSource = bsService;

            dgvService.Columns["ServiceID"].Visible = false;
            dgvService.Columns["Aktif"].Visible = false;

            dgvService.Columns["NomorKamar"].FillWeight = 50;
            dgvService.Columns["NoteService"].FillWeight = 150;
        }

        private void SMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isAdmin)
                mf.ExitUser();
        }

        private void dgvService_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvService.CurrentCell.RowIndex;
            int idService = Convert.ToInt32(dgvService.Rows[rowIndex].Cells["ServiceID"].Value);
            int nomorKamar = Convert.ToInt32(dgvService.Rows[rowIndex].Cells["NomorKamar"].Value);

            if (!((DateTime?)dgvService.Rows[rowIndex].Cells["CheckIn"].Value).HasValue ? true : false)
            {
                MessageBox.Show("Kamar Ini Belum Check In!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ServiceMenu sMenu = new ServiceMenu(this, idService, nomorKamar);
            sMenu.ShowDialog();
        }

        private void bReport_Click(object sender, EventArgs e)
        {
            CetakReport cReport = new CetakReport();
            cReport.ShowDialog();
        }

        private void bService_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvService.CurrentCell.RowIndex,
                idService = Convert.ToInt32(dgvService.Rows[rowIndex].Cells["ServiceID"].Value),
                nomorKamar = Convert.ToInt32(dgvService.Rows[rowIndex].Cells["NomorKamar"].Value);

            if (!((DateTime?)dgvService.Rows[rowIndex].Cells["CheckIn"].Value).HasValue ? true : false)
            {
                MessageBox.Show("Kamar Ini Belum Check In!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ServiceMenu sMenu = new ServiceMenu(this, idService, nomorKamar);
            sMenu.ShowDialog();
        }
    }
}
