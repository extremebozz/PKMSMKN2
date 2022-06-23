using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Model
{
    class MRoom
    {
        private string _Ketersediaan;

        public int Nomor { set; get; }
        public int ID { set; get; }
        public string NomorKamar { set; get; }
        public int IDJenisKamar { set; get; }
        public string JenisKamar { set; get; }
        public int HargaKamar { set; get; }
        public string Ketersediaan
        {
            set
            {
                _Ketersediaan = value;
            }

            get
            {
                if (_Ketersediaan.Equals("y"))
                    return "Ya";
                else
                    return "Tidak";
            }
        }
        public DateTime? TanggalIn { set; get; }
        public DateTime? TanggalOut { set; get; }
        public DateTime? CheckIn { set; get; }
        public DateTime? CheckOut { set; get; }
        public int? IDTransaksi { set; get; }
    }
}
