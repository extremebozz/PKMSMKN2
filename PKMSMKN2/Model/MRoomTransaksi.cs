using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Model
{
    internal class MRoomTransaksi
    {
        public int ID { set; get; }
        public string NomorKamar { set; get; }
        public string Nama { get; set; }
        public string Identitas { get; set; }
        public string JenisKelamin { get; set; }
        public int ExtraBed { get; set; }
        public int TotalHari { get; set; }
        public DateTime TanggalMasuk { get; set; }
        public DateTime TanggalKeluar { get; set; }
    }
}
