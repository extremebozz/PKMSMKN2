using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Model
{
    class MRestoranView
    {
        public int OrderID { get; set; }
        [DisplayName("Nomor Meja")]
        public string NomorMeja { get; set; }
        public int Nominal { get; set; }
        [DisplayName("Nomor Kamar")]
        public string NomorKamar{ get; set; }
        public string Waiter { get; set; }        
    }
}
