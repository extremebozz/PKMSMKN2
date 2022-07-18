using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Model
{
    internal class MReportService
    {
        public DateTime Tanggal { get; set; }
        public string Catatan { get; set; }
        public string NomorKamar { get; set; }
        public DateTime TanggalSelesai { get; set; }
    }
}
