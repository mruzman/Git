using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarApp
{
    public partial class Dodaj_novog_klijenta : Form
    {
        /*public bool greska = false;
        klijent novi;
        public int Id;

        public Dodaj_novog_klijenta()
        {
           
            InitializeComponent();
            btnObrisi.Enabled = false;
            if (!provjera())
            {
                btnDodaj.Text = "Dodaj";
                btnDodaj.Enabled = false;
            }

        }
        public Dodaj_novog_klijenta(int vri)
        {
            Id = vri;
            btnObrisi.Enabled = true;
            InitializeComponent();
            if (!provjera())
            {
                btnDodaj.Text = "Ažuriraj";
                btnDodaj.Enabled = false;
            }
        }
        public int nekaj = 0;
        private void btnDodaj_Click(object sender, EventArgs e)
        {/*
            if (Id > 0)
            {
                klijenti postojeci = new klijenti();
                _16023_DBDataSetTableAdapters.klijentiTableAdapter klijent = new _16023_DBDataSetTableAdapters.klijentiTableAdapter();
                postojeci.Id = int.Parse(klijent.GetDataById(Id).Rows[0].ToString());
                azuriraj();
            }
            else {
                dodaj();
            }/*
        }
        private void dodaj()
        {
            string ime;
            string prezime;
            string adresa;
            string kucni;
            string podbr;
            string OIB;
            string brMob;
            string mjesto;
            ime = txtIme.Text;
            prezime = txtPrezime.Text;
            adresa = txtAdresa.Text;
            OIB = txtOib.Text;
            brMob = txtBrMob.Text;
            kucni = txtKucniBroj.Text;
            podbr = txtPodbroj.Text;
            mjesto = txtMjesto.Text;
            if (provjera_unosa(ime, prezime, adresa, OIB, brMob, kucni, podbr, mjesto) == true)
            {
                MessageBox.Show("Greška u unosu!");

            }
            else
            {
                if (podbr == "")
                {
                    adresa = adresa + " " + kucni + ", " + mjesto;
                }
                else
                {
                    adresa = adresa + " " + kucni + "" + podbr + ", " + mjesto;
                }

                novi = new klijent(ime, prezime, adresa, brMob, OIB);
                nekaj = novi.dodaj();
                if (nekaj == 1)
                {
                    MessageBox.Show("Unešeno!");
                    inicijalizacija();
                }
                else
                {
                    MessageBox.Show("Doslo je do greške!");
                }
            }
        }
        private void azuriraj()
        {
            string ime;
            string prezime;
            string adresa;
            string kucni;
            string podbr;
            string OIB;
            string brMob;
            string mjesto;
            ime = txtIme.Text;
            prezime = txtPrezime.Text;
            adresa = txtAdresa.Text;
            OIB = txtOib.Text;
            brMob = txtBrMob.Text;
            kucni = txtKucniBroj.Text;
            podbr = txtPodbroj.Text;
            mjesto = txtMjesto.Text;
            if (provjera_unosa(ime, prezime, adresa, OIB, brMob, kucni, podbr, mjesto) == true)
            {
                MessageBox.Show("Greška u unosu!");

            }
            else
            {
                if (podbr == "")
                {
                    adresa = adresa + " " + kucni + ", " + mjesto;
                }
                else
                {
                    adresa = adresa + " " + kucni + "" + podbr + ", " + mjesto;
                }

                novi = new klijent(ime, prezime, adresa, brMob, OIB);
                nekaj = novi.dodaj();
                if (nekaj == 1)
                {
                    MessageBox.Show("Unešeno!");
                    inicijalizacija();
                }
                else
                {
                    MessageBox.Show("Doslo je do greške!");
                }
            }
        }
        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            if (provjera())
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }
        }

        private void txtAdresa_TextChanged(object sender, EventArgs e)
        {
            if (provjera())
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }
        }

        private void txtOib_TextChanged(object sender, EventArgs e)
        {
            if (provjera())
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            if (provjera())
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }
        }
        bool provjera()
        {
            if ((string.IsNullOrWhiteSpace(txtIme.Text)) || (string.IsNullOrWhiteSpace(txtPrezime.Text)) || (string.IsNullOrWhiteSpace(txtAdresa.Text)) ||
                string.IsNullOrWhiteSpace(txtOib.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnInicijaliziraj_Click(object sender, EventArgs e)
        {
            inicijalizacija();
        }

        private void inicijalizacija()
        {
            txtIme.Text = null;
            txtPrezime.Text = null;
            txtAdresa.Text = null;
            txtOib.Text = null;
            txtBrMob.Text = null;
            txtMjesto.Text = null;
            txtKucniBroj.Text = null;
            txtPodbroj.Text = null;
            lblPrezimeGreska.Visible = false;
            lblOIBGreska.Visible = false;
            lblGreskaIme.Visible = false;
            lblBrMobGreska.Visible = false;
            lblAdrGreska.Visible = false;
        }

        private bool provjera_unosa(string ime,string prezime,string adresa, string OIB,string brMob, string kucni,string podbroj,string mjesto)
        {
            lblAdrGreska.Visible = false;
            lblBrMobGreska.Visible = false;
            lblGreskaIme.Visible = false;
            lblOIBGreska.Visible = false;
            lblPrezimeGreska.Visible = false;
            greska = false;
            if (HasNumber(ime)==true) {
                greska = true;
                lblGreskaIme.Visible = true;
            }
            if (HasNumber(prezime)== true)
            {
                greska = true;
                lblPrezimeGreska.Visible = true;
            }
            if (OIB.Length!=11)
            {
                greska = true;
                lblOIBGreska.Text = "Nemate 11 brojeva!";
                lblOIBGreska.Visible = true;
            }
            if (HasString(OIB)== true)
            {
                greska = true;
                lblOIBGreska.Text = "Krivi unos OIB-a!";
                lblOIBGreska.Visible = true;
            }
            if (HasNumber(adresa) == true)
            {
                lblAdrGreska.Text = "Unijeli ste brojke na krivo mjesto!";
                greska = true;
                lblAdrGreska.Visible = true;
            }
            if (HasString(kucni) == true)
            {
                lblAdrGreska.Text = "Unijeli ste slova u kucni broj!";
                lblAdrGreska.Visible = true;
                greska = true;
            }
            if (HasNumber(mjesto) == true)
            {
                lblAdrGreska.Text = "Mjesto nemože imati broj!";
                greska = true;
            }
            if (brMob != "") {
                if (HasString(brMob) == true)
                {
                    lblBrMobGreska.Visible = true;
                    greska = true;
                }
                if(CheckRegex(brMob)== true)
                {
                    lblBrMobGreska.Text = "Unos mora biti xxx/xxx-xxxx";
                    greska = true;
                    lblBrMobGreska.Visible = true;
                }
            }
           
            return greska;
        }
        public static bool HasNumber(string input)
        {
             return input.Where(x => Char.IsDigit(x)).Any();
        }
        public static bool HasString(string input)
        {
            return input.Where(x => Char.IsLetter(x)).Any();
        }
        public static bool CheckRegex(string input)
        {
            if (Regex.IsMatch(input, @"\d{3}\/\d{3}\-\d{4}"))
            {
                return false;
            }
            else
            {
                return true;
            }
                
        }*/
    }
}
