﻿using Microsoft.VisualBasic;
using System;
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
        MainForm mForm;

        bool admin = false;

        public RMain(MainForm MForm, bool Admin)
        {
            InitializeComponent();
            AmbilData();

            Timer timer = new Timer();
            timer.Interval = (10 * 1000); //10 Detik
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            mForm = MForm;
            admin = Admin;
        }

        private void timer_Tick(object sender, EventArgs e) 
        {
            AmbilData();
        }

        public void AmbilData()
        {
            //Ambil data kamar yang telah checkin
            //BindingSource bsKamar = new BindingSource();
            //List<Model.MRoom> lKamar = Database.DKamar.ReadRoom();

            //bsKamar.DataSource = lKamar;
            //dgvKamar.DataSource = bsKamar;

            //dgvKamar.Columns["ID"].Visible = false;
            //dgvKamar.Columns["JenisKamar"].Visible = false;
            //dgvKamar.Columns["IDJenisKamar"].Visible = false;
            //dgvKamar.Columns["HargaKamar"].Visible = false;
            //dgvKamar.Columns["Ketersediaan"].Visible = false;
            //dgvKamar.Columns["CheckOut"].Visible = false;
            //dgvKamar.Columns["IDTransaksi"].Visible = false;

            BindingSource bsRestoran = new BindingSource();
            List<Model.MRestoranView> lRestoran = Database.DRestoran.ReadTransaction();

            bsRestoran.DataSource = lRestoran;
            dgvKamar.DataSource = bsRestoran;

            dgvKamar.Columns["OrderID"].Visible = false;
            dgvKamar.Columns["Nominal"].DefaultCellStyle.Format = "#,##0";
        }

        private void dgvKamar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ////Ambil index
            //int index = dgvKamar.CurrentCell.RowIndex;
            //int idTransaksi = Convert.ToInt32(dgvKamar.Rows[index].Cells["IDTransaksi"].Value);
            //string nomorMeja = dgvKamar.Rows[index].Cells["NomorMeja"].Value.ToString();

            ////Check apakah kamar telah check in
            //if (!((DateTime?)dgvKamar.Rows[index].Cells["CheckIn"].Value).HasValue ? true : false)
            //{
            //    MessageBox.Show("Kamar Ini Belum CheckIn!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            ////Show form order
            //try
            //{
            //    Order order = new Order(this, "0", idTransaksi);
            //    order.ShowDialog();
            //}
            //catch { }
        }

        private void RMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!admin)
                mForm.ExitUser();
        }

        private void bReport_Click(object sender, EventArgs e)
        {
            CetakReport cReport = new CetakReport();
            cReport.ShowDialog();
        }

        private void bEditOrder_Click(object sender, EventArgs e)
        {
            //Ambil index
            int index = dgvKamar.CurrentCell.RowIndex;
            int idOrder = Convert.ToInt32(dgvKamar.Rows[index].Cells["OrderID"].Value);
            string nomorMeja = dgvKamar.Rows[index].Cells["NomorMeja"].Value.ToString();

            //Show form order
            try
            {
                Order order = new Order(this, nomorMeja, idOrder);
                order.ShowDialog();
            }
            catch (Exception msg) { MessageBox.Show(msg.ToString()); }
        }

        private void bAddOrder_Click(object sender, EventArgs e)
        {
            string nomorMeja;
            object inputBox = Interaction.InputBox("Masukan Nomor Meja Order", "Tambah Order");

            if (inputBox.ToString() != "")
            {
                nomorMeja = inputBox.ToString();

                if (!Database.DRestoran.ReadMeja(nomorMeja))
                {
                    Order oMenu = new Order(this, nomorMeja);
                    oMenu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Silakan Masukan Nomor Meja Yang Lain!", "Nomor Meja Telah Terisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}