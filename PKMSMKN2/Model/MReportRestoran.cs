using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Model
{
    class MReportRestoran
    {
        public DateTime TanggalOrder { get; set; }
        public string NomorMeja { get; set; }
        public string NomorKamar { get; set; }
        public int Nominal { get; set; }
    }
}