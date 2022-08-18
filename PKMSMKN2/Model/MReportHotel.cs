using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Model
{
    internal class MReportHotel
    {
        public DateTime TanggalMasuk { get; set; }
        public DateTime TanggalKeluar { get; set; }
        public string NomorKamar { get; set; }
        public string JenisKamar { get; set; }
        public int ExtraBed { get; set; }
        public int Hari { get; set; }
        public int Rate { get; set; }
        public int Total { 
            get
            {
                return Hari * Rate;
            }
        }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut{ get; set; }
        public string NamaPelanggan { get; set; }
    }
}
