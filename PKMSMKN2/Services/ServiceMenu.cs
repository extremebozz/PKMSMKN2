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

namespace PKMSMKN2.Services
{
    public partial class ServiceMenu : Form
    {
        SMain main = null;
        int idService;
        int noKamar;

        public ServiceMenu(int IDService, int NomorKamar)
        {
            InitializeComponent();
            idService = IDService;
            noKamar = NomorKamar;

            if (idService == 0)
                bDoneService.Enabled = false;
            else
                bCallService.Enabled = false;

            this.Text = "Kamar " + noKamar;
        }

        public ServiceMenu(SMain Main, int IDService, int NomorKamar) : this(IDService, NomorKamar)
        {
            main = Main;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bDoneService_Click(object sender, EventArgs e)
        {
            //Kode Update Database Bahwa Service Telah Dilakukan
            try
            {
                Database.DService.CloseService(idService);
                main.AmbilData();
                this.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), "Service Gagal Diselesaikan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bCallService_Click(object sender, EventArgs e)
        {
            //Kode Add Service Note
            try
            {
                string note = "Ditambahkan Oleh Room Service!";

                if (!Model.MUser.ROLE.Equals("CS"))
                {
                    object inputBox = Interaction.InputBox("Masukan Catatan Pemanggilan Room Service", "Pemanggilan Room Service");
                    if (inputBox.ToString() != "")
                    {
                        note = inputBox.ToString();
                        Database.DService.CreateService(noKamar, note);

                        if (main != null)
                            main.AmbilData();

                        this.Close();

                        return;
                    }
                }
                else
                {
                    Database.DService.CreateService(noKamar, note);

                    if (main != null)
                        main.AmbilData();

                    this.Close();
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), "Service Gagal Ditambahkan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
