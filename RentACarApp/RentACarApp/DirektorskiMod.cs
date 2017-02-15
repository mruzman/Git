using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarApp
{
    public partial class DirektorskiMod : Form
    {
        public DirektorskiMod()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajAuto auto = new DodajAuto();
            auto.ShowDialog();
        }

        private void btnDodajZap_Click(object sender, EventArgs e)
        {
            DodajZaposlenika dodaj = new DodajZaposlenika();
            dodaj.ShowDialog();
        }

        
    }
}
