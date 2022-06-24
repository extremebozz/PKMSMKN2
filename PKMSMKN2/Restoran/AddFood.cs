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
    public partial class AddFood : Form
    {
        Admin.Main main;
        int idMenu;

        public AddFood(Admin.Main Main)
        {
            InitializeComponent();
            main = Main;
        }

        public AddFood(Admin.Main Main, int IdMenu) : this(Main)
        {
            idMenu = IdMenu;
            this.Text = "Edit Menu";

            AmbilData(IdMenu);
        }

        private void AmbilData(int MenuID)
        {
            //Kode Ambil Data Menu
        }
    }
}
