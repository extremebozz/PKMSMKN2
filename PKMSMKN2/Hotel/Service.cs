using Microsoft.VisualBasic;
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
    public partial class Service : Form
    {
        int noKamar, idTransaksi;

        public Service(int NomorKamar, int IDTransaksi)
        {
            InitializeComponent();
            this.Text = "Nomor Kamar : " + NomorKamar;
            noKamar = NomorKamar;
            idTransaksi = IDTransaksi;
        }

        private void bCallService_Click(object sender, EventArgs e)
        {
            //Kode Add Service Note
            try
            {
                string note = "Ditambahkan Oleh Room Service!";

                object inputBox = Interaction.InputBox("Masukan Catatan Pemanggilan Room Service", "Pemanggilan Room Service");
                if (inputBox.ToString() != "")
                {
                    note = inputBox.ToString();
                    Database.DService.CreateService(noKamar, note);

                    this.Close();

                    return;
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), "Service Gagal Ditambahkan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bExtraBed_Click(object sender, EventArgs e)
        {
            try
            {
                AddExtraBed aExtra = new AddExtraBed(idTransaksi);
                aExtra.ShowDialog();
            }
            catch { }
        }
    }
}
