using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Model
{
    class MService
    {
        public int? ServiceID { get; set; }
        public int NomorKamar { get; set; }
        public string JenisKamar { get; set; }
        public string NoteService { get; set; }
        public int? Aktif { get; set; }
        public DateTime? TanggalIn { set; get; }
        public DateTime? TanggalOut { set; get; }
        public DateTime? CheckIn { set; get; }
        public DateTime? CheckOut { set; get; }
    }
}
