using MySql.Data.MySqlClient;
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
    public partial class AddExtraBed : Form
    {
        int idTransaksi = 0, extraBed = 0;

        public AddExtraBed(int idTransaksi)
        {
            InitializeComponent();
            this.idTransaksi = idTransaksi;
            AmbilData(idTransaksi);
        }

        private void AmbilData(int IDTransaksi)
        {
            nExtraBed.Value = Database.DKamar.ReadExtraBed(IDTransaksi);
            extraBed = Convert.ToInt32(nExtraBed.Value);
        }

        private void bSimpan_Click(object sender, EventArgs e)
        {
            int newExtraBed = Convert.ToInt32(nExtraBed.Value);

            if (!(newExtraBed - extraBed).Equals(0))
            {
                try
                {
                    Database.DKamar.UpdateExtraBed(idTransaksi, newExtraBed, extraBed);
                }
                catch (MySqlException msg)
                {
                    MessageBox.Show(msg.ToString(), "Data Gagal Tersimpan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            MessageBox.Show("Data Berhasil Disimpan!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
