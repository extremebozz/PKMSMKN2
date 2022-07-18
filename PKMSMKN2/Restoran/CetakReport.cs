﻿using System;
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
    public partial class CetakReport : Form
    {
        List<Model.MReportService> lService = new List<Model.MReportService>();

        public CetakReport()
        {
            InitializeComponent();
        }

        private void bCetak_Click(object sender, EventArgs e)
        {
            DateTime dtAwal = dtpAwal.Value,
                dtAkhir = dtpAkhir.Value;
            DateTime pAwal = new DateTime(dtAwal.Year, dtAwal.Month, dtAwal.Day),
                pAkhir = new DateTime(dtAkhir.Year, dtAkhir.Month, dtAkhir.Day, 23, 59, 59);

            lService = Database.DReport.ReportService(pAwal, pAkhir);
        }

        private void CetakReport_Load(object sender, EventArgs e)
        {

            this.rRestoran.RefreshReport();
        }
    }
}
