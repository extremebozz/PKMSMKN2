using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Model
{
    internal class MKategoriMakanan
    {
        public int CategoryID { get; set; }
        public string Nama { get; set; }
        public List<MMakanan> ListMakanan { get; set; }
    }
}
