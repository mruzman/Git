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
    public partial class preuzmiAutomobil : Form
    {
        _16023_DBDataSetTableAdapters.RezervacijaPreuzmiTableAdapter adapter = new _16023_DBDataSetTableAdapters.RezervacijaPreuzmiTableAdapter();
        _16023_DBDataSetTableAdapters.rezervacijaTableAdapter adapterRezervacija = new _16023_DBDataSetTableAdapters.rezervacijaTableAdapter();
        int kilometraza,broj,arg;
        public preuzmiAutomobil(int argv,int broj1)
        {
            arg = argv;
            broj = broj1;
            InitializeComponent();
            if (argv == 1)
            {
                btnPreuzmi.Text = "Izdaj automobil";
                lblPocetna.Visible = false;
                txtZavrsna.Visible = false;
                lblZavrsna.Visible = false;
                txtPocetna.Enabled = true;
                try
                {
                    foreach (var red in adapter.GetData(broj))
                    {
                        btnPreuzmi.Enabled = false;
                        txtOIB.Text = red.oib;
                        txtIme.Text = red.ime;
                        txtPrezime.Text = red.prezime;
                        txtMarka.Text = red.marka;
                        txtModel.Text = red.naziv;
                        txtIzvedba.Text = red.izvedba;
                        txtTablice.Text = red.registracija;
                        txtDatumOd.Text = red.datum_preuzimanja.Date.Day.ToString() + "." + red.datum_preuzimanja.Date.Month.ToString() + "." + red.datum_preuzimanja.Date.Year.ToString();
                        txtVrijemeOd.Text = red.datum_preuzimanja.Hour.ToString() + ":" + red.datum_preuzimanja.Minute.ToString();
                        txtDatumDo.Text = red.datum_povrata.Date.Day.ToString() + "." + red.datum_povrata.Date.Month.ToString() + "." + red.datum_povrata.Date.Year.ToString();
                        txtVrijemeDo.Text = red.datum_povrata.Hour.ToString() + ":" + red.datum_povrata.Minute.ToString();
                        txtPocetna.Text = red.kilometraza.ToString();
                        kilometraza = red.kilometraza;
                    }
                }
                catch
                {
                    MessageBox.Show("Provjerite internet vezu");
                }
            }
            if (argv == 2)
            {
                btnPreuzmi.Text = "Preuzmi automobil";
                lblPocetna.Visible = false;
                txtZavrsna.Visible = true;
                lblZavrsna.Visible = true;
                txtPocetna.Enabled = false;
                try
                {
                    foreach (var red in adapter.GetData(broj))
                    {
                        btnPreuzmi.Enabled = false;
                        txtOIB.Text = red.oib;
                        txtIme.Text = red.ime;
                        txtPrezime.Text = red.prezime;
                        txtMarka.Text = red.marka;
                        txtModel.Text = red.naziv;
                        txtIzvedba.Text = red.izvedba;
                        txtTablice.Text = red.registracija;
                        txtDatumOd.Text = red.datum_preuzimanja.Date.Day.ToString() + "." + red.datum_preuzimanja.Date.Month.ToString() + "." + red.datum_preuzimanja.Date.Year.ToString();
                        txtVrijemeOd.Text = red.datum_preuzimanja.Hour.ToString() + ":" + red.datum_preuzimanja.Minute.ToString();
                        txtDatumDo.Text = DateTime.Today.Date.Day.ToString() + "." + DateTime.Today.Date.Month.ToString() + "." + DateTime.Today.Date.Year.ToString();
                        txtVrijemeDo.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
                        txtPocetna.Text = red.kilometraza.ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Provjerite internet vezu!");
                }
            }
        }
        private void txtPocetna_TextChanged(object sender, EventArgs e)
        {
            lblPocetna.Visible = true;
            if (txtPocetna.Text.Length > 0)
            {
                if (tekst(txtPocetna.Text.ToString()) == false) txtPocetna.Clear();
                else { btnPreuzmi.Enabled = true; lblPocetna.Visible = false; }
            }
            else btnPreuzmi.Enabled = false;
        }

        private void txtZavrsna_TextChanged(object sender, EventArgs e)
        {
            lblPocetna.Text = "Unesite završnu kilometražu";
            lblPocetna.Visible = true;
            if (txtZavrsna.Text.Length > 0)
            {
                if (tekst(txtZavrsna.Text.ToString()) == false) txtZavrsna.Clear();
                else { btnPreuzmi.Enabled = true; lblPocetna.Visible = false; }
            }
            else btnPreuzmi.Enabled = false;
        }

        private bool tekst(string tekstek)
        {
            int n;
            bool result = int.TryParse(tekstek, out n);
            if (result == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Unesite BROJ,a ne slova ili znakove!");
                return false;
            }
        }
        private void btnPreuzmi_Click(object sender, EventArgs e)
        {
            if (arg == 1)
            {
                if (int.Parse(txtPocetna.Text.ToString()) < kilometraza)
                {
                    MessageBox.Show("Pripazite na unos! Moguće varanje!Smanjena kilometraža");
                    txtPocetna.Clear();
                }
                else {
                    try
                    {//update tablice rezervacija --postaviti pocetnu kilometrazu, postaviti na preuzeto
                        kilometraza = int.Parse(txtPocetna.Text.ToString());
                        Rezervacija rez = new Rezervacija(broj);
                        Vozila voz = new Vozila(rez.vozilo);
                        voz.postavitiKilometrazu(kilometraza);
                        adapterRezervacija.UpdatePreuzeto(int.Parse(txtPocetna.Text.ToString()), broj);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Provjerite internet vezu!");
                    }
                }
            }
            else
            {
                if(int.Parse(txtPocetna.Text.ToString()) > int.Parse(txtZavrsna.Text.ToString()))
                {
                    MessageBox.Show("Pripazite na unos! Moguće Varanje! Smanjena kilometraža!");
                    txtZavrsna.Clear();
                }
                else
                {
                    try
                    { //postaviti zavrsnu kilometrazu na vozilo i postaviti zavrsnu kilometrazu na rezervaciji!
                        Rezervacija rez = new Rezervacija(broj);
                        Vozila voz = new Vozila(rez.vozilo);
                        kilometraza=int.Parse(txtZavrsna.Text.ToString());
                        voz.postavitiKilometrazu(kilometraza);
                        adapterRezervacija.UpdateZavrsne(kilometraza, DateTime.Parse(txtDatumDo.Text.ToString() + " " + txtVrijemeDo.Text.ToString()), broj);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Dogodila se greška");
                    }
                }
            }
        }
    }
}
