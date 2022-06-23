using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2.Model
{
    class MRoom
    {
        private string _Ketersediaan;

        [DisplayName("No")]
        public int Nomor { set; get; }
        public int ID { set; get; }
        [DisplayName("Nomor Kamar")]
        public string NomorKamar { set; get; }
        public int IDJenisKamar { set; get; }
        [DisplayName("Jenis Kamar")]
        public string JenisKamar { set; get; }
        [DisplayName("Harga Kamar")]
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
        [DisplayName("Tanggal Masuk")]
        public DateTime? TanggalIn { set; get; }
        [DisplayName("Tanggal Keluar")]
        public DateTime? TanggalOut { set; get; }
        [DisplayName("Check In")]
        public DateTime? CheckIn { set; get; }
        public DateTime? CheckOut { set; get; }
        public int? IDTransaksi { set; get; }
    }
}
