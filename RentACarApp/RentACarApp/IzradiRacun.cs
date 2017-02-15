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
    public partial class IzradiRacun : Form
    {
        _16023_DBDataSetTableAdapters.zaRacunTableAdapter adapter = new _16023_DBDataSetTableAdapters.zaRacunTableAdapter();
        int sifra;
        int kilometri, klasa,sati;
        float cijenaKilometra,cijenaUsluge;
        public IzradiRacun(int sifraa)
        {
            sifra = sifraa;
            InitializeComponent();
            inicijalizirajRacun();
        }
        
        private void inicijalizirajRacun()
        {
            Racun rac = new Racun(sifra);
            Klijenti klij = new Klijenti(rac.klijent);
            Zaposlenici zap = new Zaposlenici(rac.zaposlenik);
            txtIme.Text = klij.ime;
            txtOIB.Text = klij.oib;
            txtPrezime.Text = klij.prezime;
            txtDatumRezervacije.Text = rac.datum_rezervacije.ToString();
            txtDatumIzdavanja.Text = DateTime.Today.Date.Day.ToString()+"."+ DateTime.Today.Date.Month.ToString()+"."+ DateTime.Today.Date.Year.ToString();
            txtRacunIzdao.Text = zap.vratiIme();
            DataTable tablica = adapter.ZaRacun(sifra);
            dataGridView1.DataSource = tablica;
            dataGridView1.Refresh();
            foreach (DataGridViewRow red in dataGridView1.Rows)
            {
                izracunKlasa(red.Cells[4].FormattedValue.ToString());
                izracunKilometraze((int.Parse(red.Cells[10].FormattedValue.ToString())), (int.Parse(red.Cells[11].FormattedValue.ToString())));
                izracunSati(DateTime.Parse(red.Cells[7].FormattedValue.ToString()), DateTime.Parse(red.Cells[8].FormattedValue.ToString()));
                red.Cells[12].Value = (kilometri * cijenaKilometra + klasa * sati).ToString();
                dataGridView1.Update();
            }
            dataGridView1.Refresh();
            cijenaUsluge = 0;
            foreach(DataGridViewRow red in dataGridView1.Rows)
            {
                cijenaUsluge += float.Parse(red.Cells[12].EditedFormattedValue.ToString());
            }
            txtUkupnaCijena.Text = cijenaUsluge.ToString() + " kn";   
        }
            //cijena se izračunava prema: KLASI, KILOMETRAŽI, TRAJANJU RENTANJA!!!
            /* Ovisno o odabiru klase računa se 
            niža klasa iznajmljivanje je 130kn/dan+0,4kn/km
            srednja klasa iznajmljivanje je 220kn/dan+0,75kn/km
            viša klasa iznajmljivanje je 340kn/dan+1,5kn/km
            supersport klasa iznajmljivanje je 800kn/dan + 3kn/km*/
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblKlasa.Visible = true;
            lblKilometraza.Visible = true;
            lblTrajanje.Visible = true;
            lblIznos.Visible = true;
            txtPregledZaAuto.Text = dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString() + " " + dataGridView1.CurrentRow.Cells[2].FormattedValue.ToString();
            izracunKlasa(dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString());
            txtKlasa.Text = dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString();
            lblKlasa.Text = klasa.ToString()+"kn/h";
            izracunKilometraze((int.Parse(dataGridView1.CurrentRow.Cells[10].FormattedValue.ToString())), (int.Parse(dataGridView1.CurrentRow.Cells[11].FormattedValue.ToString())));
            txtKilometri.Text = kilometri.ToString()+"km";
            lblKilometraza.Text = cijenaKilometra.ToString()+"kn/km = "+kilometri*cijenaKilometra+"kn";
            izracunSati(DateTime.Parse(dataGridView1.CurrentRow.Cells[7].FormattedValue.ToString()), DateTime.Parse(dataGridView1.CurrentRow.Cells[8].FormattedValue.ToString()));
            txtTrajanje.Text = sati.ToString()+" sati";
            lblTrajanje.Text = sati * klasa+"kn";
            txtIznos.Text = kilometri * cijenaKilometra + klasa * sati + "kn";
            lblIznos.Text = kilometri + "*" + cijenaKilometra + "+" + klasa + "*" + sati;
        }

        private void btnIZDAJ_Click(object sender, EventArgs e)
        {
            Racun rac = new Racun(sifra);
            rac.updateBazuZaIzdaju();
        }

        private void izracunSati(DateTime datumOD,DateTime datumDO)
        {
            var diff = datumDO.Subtract(datumOD);
            sati = Convert.ToInt32(diff.TotalHours);
        }
        private void izracunKilometraze(int pocetna,int zavrsna)
        {
            kilometri = zavrsna - pocetna;
        }
        private void izracunKlasa(string kl)
        {
            if (kl == "niža")
            {
                klasa = 3;
                cijenaKilometra = 0.05F;

            }else if (kl == "srednja")
            {
                klasa = 8;
                cijenaKilometra = 0.15F;
            }else if (kl == "viša")
            {
                klasa = 18;
                cijenaKilometra = 0.40F;
            }
            else
            {
                klasa = 40;
                cijenaKilometra = 1F;
            }
            
        }


    }
}
