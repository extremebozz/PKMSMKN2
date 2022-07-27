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
    public partial class CetakReport : Form
    {
        List<Model.MReportHotel> lHotel;
        Model.MReportInformasi mInformasi = new Model.MReportInformasi();

        public CetakReport()
        {
            InitializeComponent();
            AmbilData();
        }

        private void AmbilData()
        {
            DateTime dtAwal = dtpAwal.Value,
                dtAkhir = dtpAkhir.Value;
            DateTime pAwal = new DateTime(dtAwal.Year, dtAwal.Month, dtAwal.Day),
                pAkhir = new DateTime(dtAkhir.Year, dtAkhir.Month, dtAkhir.Day, 23, 59, 59);

            mInformasi.TanggalAwal = pAwal;
            mInformasi.TanggalAkhir = pAkhir;

            lHotel = Database.DReport.ReportHotel(pAwal, pAkhir);

            this.MReportInformasiBindingSource.DataSource = mInformasi;
            this.MReportHotelBindingSource.DataSource = lHotel;
            this.reportViewer1.RefreshReport();
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
