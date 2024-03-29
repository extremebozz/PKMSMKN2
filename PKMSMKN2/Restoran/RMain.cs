﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKMSMKN2.Restoran
{
    public partial class RMain : Form
    {
        public RMain()
        {
            InitializeComponent();
            AmbilData();

            Timer timer = new Timer();
            timer.Interval = (10 * 1000); //10 Detik
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e) 
        {
            AmbilData();
        }

        public void AmbilData()
        {
            //Ambil data kamar yang telah checkin
            BindingSource bsKamar = new BindingSource();
            List<Model.MRoom> lKamar = Database.DKamar.ReadRoom();

            bsKamar.DataSource = lKamar;
            dgvKamar.DataSource = bsKamar;

            dgvKamar.Columns["ID"].Visible = false;
            dgvKamar.Columns["JenisKamar"].Visible = false;
            dgvKamar.Columns["IDJenisKamar"].Visible = false;
            dgvKamar.Columns["HargaKamar"].Visible = false;
            dgvKamar.Columns["Ketersediaan"].Visible = false;
            dgvKamar.Columns["CheckOut"].Visible = false;
            dgvKamar.Columns["IDTransaksi"].Visible = false;
        }

        private void dgvKamar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ambil index
            int index = dgvKamar.CurrentCell.RowIndex;
            int idTransaksi = Convert.ToInt32(dgvKamar.Rows[index].Cells["IDTransaksi"].Value);
            int nomorKamar = Convert.ToInt32(dgvKamar.Rows[index].Cells["NomorKamar"].Value);

            //Check apakah kamar telah check in
            if (!((DateTime?)dgvKamar.Rows[index].Cells["CheckIn"].Value).HasValue ? true : false)
            {
                MessageBox.Show("Kamar Ini Belum CheckIn!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Show form order
            Order order = new Order(this, idTransaksi, nomorKamar);
            order.ShowDialog();
        }
    }
}