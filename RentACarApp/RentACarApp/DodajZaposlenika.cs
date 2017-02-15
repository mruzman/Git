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
    public partial class DodajZaposlenika : Form
    {
        string ime, prezime, adresa, OIB, brMob, korIme, lozinka,email;

       
        int rola,vrati;
        public DodajZaposlenika()
        {
            InitializeComponent();
        }
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DodajZaposlenika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16023_DBDataSet.rola' table. You can move, or remove it, as needed.
            //this.rolaTableAdapter.Fill(this._16023_DBDataSet.rola);

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            email = txtEmail.Text;
            ime = txtIme.Text;
            prezime = txtPrezime.Text;
            adresa = txtAdresa.Text;
            brMob = txtBrMob.Text;
            OIB = txtOIB.Text;
            rola = int.Parse(cmbRola.SelectedValue.ToString());
            korIme = txtKorime.Text;
            lozinka = txtLozinka.Text;
            Zaposlenici zaposlenik = new Zaposlenici(ime, prezime, adresa, OIB, brMob, rola, korIme, lozinka,email);
            vrati=zaposlenik.DodajZaposlenika();
            if (vrati == 1)
            {
                MessageBox.Show("Uspješno uneseno!");
            }
            else
            {
                MessageBox.Show("Greška!");
            }
        }
    }
}
