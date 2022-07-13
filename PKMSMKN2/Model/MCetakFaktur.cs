using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Model
{
    internal class MCetakFaktur
    {
        //Hotel
        //Transaksi Kamar
        public MRoomTransaksi TransaksiKamar { get; set; }
        //List menu yang dipesan
        public List<MMakananTransaksi> Order { get; set; }
        public MKategoriMakanan Test { get; set; }
    }
}
