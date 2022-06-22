using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Model
{
    class MService
    {
        public int? ServiceID { get; set; }
        [DisplayName("No Kamar")]
        public int NomorKamar { get; set; }
        [DisplayName("Jenis Kamar")]
        public string JenisKamar { get; set; }
        [DisplayName("Catatan")]
        public string NoteService { get; set; }
        public int? Aktif { get; set; }
        [DisplayName("Tanggal Masuk")]
        public DateTime? TanggalIn { set; get; }
        [DisplayName("Tanggal Keluar")]
        public DateTime? TanggalOut { set; get; }
        [DisplayName("Check In")]
        public DateTime? CheckIn { set; get; }
        [DisplayName("Check Out")]
        public DateTime? CheckOut { set; get; }
    }
}
