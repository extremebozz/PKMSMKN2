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
    public partial class SMain : Form
    {
        MainForm mf;
        bool isAdmin = false;

        public SMain(MainForm MForm, bool Admin)
        {
            InitializeComponent();
            mf = MForm;
            isAdmin = Admin;
            AmbilData();
        }

        private void AmbilData()
        {
            BindingSource bsService = new BindingSource();
            List<Model.MService> lService = Database.DService.FetchData();

            bsService.DataSource = lService;
            dgvService.DataSource = bsService;
        }

        private void SMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!admin)
                mf.ExitUser();
        }
    }
}
