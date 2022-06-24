using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Model
{
    internal class MMakananTransaksi
    {
        public int IDTransaksi { get; set; }
        public int IDTransaksiKamar { get; set; }
        public int IDMakanan { get; set; }
        public string NamaMenu { get; set; }
        public int Harga { get; set; }
        public int Qty { get; set; }
    }
}
