using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKMSMKN2.Hotel
{
    public partial class CetakFaktur : Form
    {
        Main hMain;
        int idTransaksi;
        Model.MCetakFaktur cFaktur = new Model.MCetakFaktur();

        List<Model.MMakananTransaksi> listOrder = new List<Model.MMakananTransaksi>();
        Model.MRoomTransaksi detailKamar = new Model.MRoomTransaksi();

        public CetakFaktur(Main Main, int IDTransaksi)
        {
            InitializeComponent();
            hMain = Main;
            idTransaksi = IDTransaksi;
            AmbilData();
        }

        private void AmbilData()
        {
            detailKamar = Database.DKamar.ReadTransactionByID(idTransaksi);
            listOrder = Database.DRestoran.ReadDetailTransaksi(idTransaksi);
        }

        private void CetakFaktur_Load(object sender, EventArgs e)
        {
            this.mMakananTransaksiBindingSource.DataSource = listOrder;
            this.mRoomTransaksiBindingSource.DataSource = detailKamar;
            this.reportViewer1.RefreshReport();
        }
    }
}
