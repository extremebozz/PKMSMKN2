﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKMSMKN2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckUser();
            this.AutoScroll = false;
        }

        public void ShowForm(Form form)
        {
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.AutoScroll = false;
            form.Show();
        }

        private void ShowLogin()
        {
            if (string.IsNullOrEmpty(Model.MUser.USERNAME))
            {
                Login lg = new Login(this);
                lg.MdiParent = this;
                lg.StartPosition = FormStartPosition.CenterScreen;
                lg.AutoScroll = false;
                lg.Show();
            }
        }

        internal bool CheckUser()
        {
            //Check info user sudah terisi atau belum
            if (!string.IsNullOrEmpty(Model.MUser.USERNAME) && !string.IsNullOrEmpty(Model.MUser.ROLE))
            {
                switch (Model.MUser.ROLE)
                {
                    case "admin":
                    case "Admin":
                        Admin.Main AdminMain = new Admin.Main(this);
                        AdminMain.MdiParent = this;
                        AdminMain.StartPosition = FormStartPosition.CenterScreen;
                        AdminMain.Show();
                        //ShowForm(new Admin.Main(this));
                        break;

                    case "hotel":
                    case "Hotel":
                        Hotel.Main HotelMain = new Hotel.Main(this, false);
                        HotelMain.MdiParent = this;
                        HotelMain.StartPosition = FormStartPosition.CenterScreen;
                        HotelMain.WindowState = FormWindowState.Maximized;
                        HotelMain.Show();
                        break;

                    case "cs":
                    case "CS":
                        break;

                    case "restoran":
                    case "Restoran":
                        break;
                }

                return true;
            }

            ShowLogin();
            return false;
        }

        internal void ExitUser()
        {
            if (!string.IsNullOrEmpty(Model.MUser.USERNAME))
            {
                Model.MUser.USERNAME = null;
                Model.MUser.ROLE = null;
                Model.MUser.USERID = null;

                CheckUser();

                if (this.MdiChildren[1].WindowState == FormWindowState.Maximized)
                    this.MdiChildren[1].WindowState = FormWindowState.Normal;

                return;
            }

            this.Close();
        }
    }
}