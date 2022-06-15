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
    public partial class CheckKamar : Form
    {
        Main hMain;

        bool checkIn;
        int idTransaksi;

        public CheckKamar(Main HMain, int IDTransaksi, bool CheckIn)
        {
            InitializeComponent();
            hMain = HMain;
            checkIn = CheckIn;
            idTransaksi = IDTransaksi;
        }

        private void AmbilData()
        {

        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            DateTime waktuCheck = dtTanggalCheck.Value.Date + dtJamCheck.Value.TimeOfDay;

            //Check jam check in apakah sudah diset?

            //Apabila checkIn true makan jalankan kode checkin
            if (checkIn)
                try
                {
                    Database.DKamar.CheckIn(idTransaksi, waktuCheck);


                    hMain.AmbilData();
                    this.Close();
                    return;
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString(), "Data Gagal Tersimpan!");
                }

            //Apabila checkIn false maka jalankan kode checkout
            if (!checkIn)
                try
                {
                    Database.DKamar.CheckOut(idTransaksi, waktuCheck);
                    hMain.AmbilData();
                    this.Close();
                    return;
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString(), "Data Gagal Tersimpan!");
                }
        }
    }
}
