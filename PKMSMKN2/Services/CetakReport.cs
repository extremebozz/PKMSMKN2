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
    public partial class CetakReport : Form
    {
        List<Model.MReportService> lService = new List<Model.MReportService>();
        Model.MReportInformasi mInformasi = new Model.MReportInformasi();

        public CetakReport()
        {
            InitializeComponent();
        }

        private void AmbilData()
        {
            DateTime dtAwal = dtpAwal.Value,
                dtAkhir = dtpAkhir.Value;
            DateTime pAwal = new DateTime(dtAwal.Year, dtAwal.Month, dtAwal.Day),
                pAkhir = new DateTime(dtAkhir.Year, dtAkhir.Month, dtAkhir.Day, 23, 59, 59);

            mInformasi.TanggalAwal = pAwal;
            mInformasi.TanggalAkhir = pAkhir;

            lService = Database.DReport.ReportService(pAwal, pAkhir);

            this.MReportServiceBindingSource.DataSource = lService;
            this.MReportInformasiBindingSource.DataSource = mInformasi;
            this.rRestoran.RefreshReport();
        }

        private void CetakReport_Load(object sender, EventArgs e)
        {
            AmbilData();
        }

        private void bCetak_Click(object sender, EventArgs e)
        {
            AmbilData();
        }
    }
}
