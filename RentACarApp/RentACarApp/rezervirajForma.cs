using RentACarApp._16023_DBDataSetTableAdapters;
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
    public partial class rezervirajForma : Form
    {
        _16023_DBDataSetTableAdapters.rezervacija2TableAdapter zaPregled = new rezervacija2TableAdapter();
        private Rezervacija rez;
        private Racun rac;
        private Zaposlenici zap;
        int broj;
        int sifra;
        DateTime datum1, datum2;
        string marka, model, tablice, izvedba, klasa, boja;
        DataTable klijenti,tablica;
        public rezervirajForma(string zapoib)
        {
            zap = new Zaposlenici(zapoib);
            InitializeComponent();
            txtRezervacijuZapisao.Text = zap.vratiIme();
            inicijalizacija();
            klijentTableAdapter adapter = new klijentTableAdapter();
            klijenti = adapter.GetData();

            klijenti.Columns.Add("puno_ime", typeof(string));

            foreach (DataRow row in klijenti.Rows)
            {
                row["puno_ime"] = row["ime"].ToString() + " " + row["prezime"].ToString() + " - " + row["oib"].ToString();
            }
            cmbKlijent.DataSource = klijenti.DefaultView;
            cmbKlijent.DisplayMember = "puno_ime";
            cmbKlijent.ValueMember = "oib";
            cmbKlijent.SelectedIndex = -1;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Obriši rezervaciju";
            btn.Text = "Obriši";
            btn.Name = "gumb";
            btn.UseColumnTextForButtonValue = true;
            tablica = zaPregled.GetData();
            dataGridView1.DataSource = tablica;
            dataGridView1.Refresh();
            if (tablica.Rows.Count > 0)
            {
                btnZavrsi.Enabled = true;
            }

        }
        private void izradiDatum()
        {
            string pomocna, pomocna2;
            pomocna = cmbVureOd.SelectedItem.ToString();
            pomocna2 = dtOd.Value.Date.Day.ToString() + "." + dtOd.Value.Date.Month.ToString() + "." + dtOd.Value.Date.Year.ToString();
            datum1 = DateTime.Parse(pomocna2 + " " + pomocna);
            pomocna = cmbVureDo.SelectedItem.ToString();
            pomocna2 = dtDo.Value.Date.Day.ToString() + "." + dtDo.Value.Date.Month.ToString() + "." + dtDo.Value.Date.Year.ToString();
            datum2 = DateTime.Parse(pomocna2 + " " + pomocna);
            if (datum1 >= datum2||datum1<DateTime.Now ||provjeraDvaSata()==true)
            {
                MessageBox.Show("Provjerite unos datuma!");
                datum1 = DateTime.Now.AddDays(1);
                datum2 = datum1.AddDays(3);
                dtOd.Value = datum1.Date;
                dtDo.Value = datum2.Date;
            }
        }
        private bool provjeraDvaSata()
        {
            if (datum1.Date == datum2.Date)
            {
                if (DateTime.Now.Minute >= 30 && DateTime.Now.Minute < 60)
                {
                    if ((int.Parse(datum1.Hour.ToString())) + 3 > (int.Parse(datum2.Hour.ToString()) + 1))
                    {
                        MessageBox.Show("Minimalno trajanje rezervacije je 2 sata!");
                        button1.Enabled = false;
                        return true;
                    }
                    else
                    {
                        button1.Enabled = true;
                        return false;
                    }
                }
                else
                {
                    if ((int.Parse(datum1.Hour.ToString())) + 2 > (int.Parse(datum2.Hour.ToString())))
                    {
                        MessageBox.Show("Minimalno trajanje rezervacije je 2 sata!");
                        button1.Enabled = false;
                        return true;
                    }
                    else{
                        button1.Enabled = true;
                        return false;
                    }
                }
            }
            else {
                button1.Enabled = true;
                return false;
            }
        }
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            btnSviKlijenti.Enabled = false;
            rac = new Racun();
            broj = rac.dohvatiRacun();
            if (broj == -1)
            {
                MessageBox.Show("Doslo je do pogreske!");
            }
            else if(broj==0)
            {
                rac = new Racun(cmbKlijent.SelectedValue.ToString(), zap.OIB);
                spremiRez();
                novi();
            }else
            {
                spremiRez();
                novi();
            }
            cmbKlijent.Enabled = false;
            btnSviKlijenti.Enabled = false;
        }
        private void novi()
        {   
                inicijalizacija();
                dtOd.Enabled = true;
                btnZavrsi.Enabled = true;
        }
        private void spremiRez()
        {
            rac = new Racun();
            rez = new Rezervacija(sifra, datum1, datum2, rac.sifra);
            rez.zapisiUBazu();
            tablica = zaPregled.GetData();
            dataGridView1.DataSource = tablica;
            dataGridView1.Refresh();
        }
        private void dtOd_CloseUp(object sender, EventArgs e)
        {
            dtDo.Enabled = true;
            cmbVureDo.Enabled = true;
            izradiDatum();
        }

        private void dtDo_CloseUp(object sender, EventArgs e)
        {
            izradiDatum();
        }

        private void provjeri_za_gumb()
        {
            if (string.IsNullOrEmpty(txtTablice.Text.ToString()) == false && cmbKlijent.SelectedIndex != -1)
            {
                btnSpremi.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value);
                rez = new Rezervacija(index);
                rez.obrisiRezervaciju();
                tablica = zaPregled.GetData();
                dataGridView1.DataSource = tablica;
                dataGridView1.Refresh();
                rac = new Racun();
                if (tablica.Rows.Count == 0)
                {
                    btnSviKlijenti.Enabled = true;
                    btnZavrsi.Enabled = false;
                    inicijalizacija();
                }
                else
                {
                    btnZavrsi.Enabled = true;
                }

            }
        }

        private void rezervirajForma_Load(object sender, EventArgs e)
        {
            _16023_DBDataSetTableAdapters.racunTableAdapter racunic = new _16023_DBDataSetTableAdapters.racunTableAdapter();
            DataTable tabla = racunic.GetData();
            foreach (DataRow red in tabla.Rows)
            {
                if (red["status_rac"].ToString() == "u_izradi")
                {
                    {
                        rac = new Racun();
                        DialogResult dialogResult1 = MessageBox.Show("Želite li nastaviti nakon što se isključila aplikacija?", "Nastaviti staro", MessageBoxButtons.YesNo);
                        if (dialogResult1 == DialogResult.Yes)
                        {
                            btnSviKlijenti.Enabled = false;
                            broj = rac.sifra;
                            cmbKlijent.SelectedValue = rac.klijent;
                            txtRezervacijuZapisao.Text = zap.vratiIme();
                            cmbKlijent.Enabled = false;
                        }
                        if (dialogResult1 == DialogResult.No)
                        {
                            btnSviKlijenti.Enabled = true;
                            tablica = zaPregled.GetData();
                            if (tablica.Rows.Count > 0) rac.updateBazu();
                            else rac.brisanje();
                            tablica = zaPregled.GetData();
                            dataGridView1.DataSource = tablica;
                            dataGridView1.Refresh();
                        }
                        btnZavrsi.Enabled = false;
                    }
                }
            }
        }

        private void btnSviKlijenti_Click(object sender, EventArgs e)
        {
            using (var klijent = new SviKlijenti())
            {
                var odabrani = klijent.ShowDialog();
                if (odabrani == DialogResult.OK)
                {
                    cmbKlijent.SelectedValue = klijent.oib;
                    provjeri_za_gumb();
                }
            }
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            rac = new Racun();
            rac.updateBazu();
            this.Close();
        }

        private void cmbVureOd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtDo.Enabled = true;
            cmbVureDo.Enabled = true;
            izradiDatum();
        }

        private void cmbVureDo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            button1.Enabled = true;
            izradiDatum();
        }

        

        private bool provjeri()
        {
            return true;
        }

        private void inicijalizacija()
        {
            cmbVureOd.Enabled = true;
            btnSpremi.Enabled = false;
            if (DateTime.Now.Minute >= 30 && DateTime.Now.Minute < 60) {
                string vr, v2;
                vr = (int.Parse(DateTime.Now.Hour.ToString()) + 1).ToString();
                v2 = "30";
                if (int.Parse(vr) >= 22)
                {
                    vr = "08";
                    cmbVureOd.Text = vr + ":" + v2;
                    if ((int.Parse(vr) + 2) > 22) cmbVureDo.Text = "08:" + v2;
                    else cmbVureDo.Text = (int.Parse(vr) + 2).ToString() + ":" + v2;
                }
                else {
                    cmbVureOd.Text = vr + ":" + v2;
                    if ((int.Parse(vr) + 2) > 22) cmbVureDo.Text = "08:" + v2;
                        else cmbVureDo.Text = "08:" + v2;
                } 
            }if (DateTime.Now.Minute >= 0 && DateTime.Now.Minute < 30)
            {
                string vr, v2;
                vr = (int.Parse(DateTime.Now.Hour.ToString()) + 1).ToString();
                v2 = "00";
                if (int.Parse(vr) >= 22)
                {
                    vr = "08";
                    cmbVureOd.Text = vr + ":" + v2;
                    if ((int.Parse(vr) + 2) > 22) cmbVureDo.Text = "08:" + v2;
                    else cmbVureDo.Text = (int.Parse(vr) + 2).ToString() + ":" + v2;
                }
                else {
                    cmbVureOd.Text = vr + ":" + v2;
                    if ((int.Parse(vr) + 2) > 22) cmbVureDo.Text = "08:" + v2;
                        else
                    cmbVureDo.Text = (int.Parse(vr) + 2).ToString() + ":" + v2;
                }
            }
            if (int.Parse(DateTime.Now.Hour.ToString()) >= 21)
            {
                dtDo.Value = DateTime.Today.AddMonths(1);
                dtOd.Value = DateTime.Today.AddDays(1);
            }
            else
            {
                dtDo.Value = DateTime.Today.AddMonths(1);
                dtOd.Value = DateTime.Today;
            }
            txtMarka.Text = "";
            txtModel.Text = "";
            txtBoja.Text = "";
            txtIzvedba.Text = "";
            txtKlasa.Text = "";
            txtTablice.Text = "";
            button1.Enabled = true;
        }

        private void cmbKlijent_TextChanged(object sender, EventArgs e)
        {
            provjeri_za_gumb();
            izradiDatum();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            izradiDatum();
            using (var stavka = new Slobodni_automobili(datum1,datum2))
            {
                var rezultat = stavka.ShowDialog();
                if (rezultat == DialogResult.OK)
                {

                    sifra = stavka.odabrano;
                    datum1 = stavka.Od;
                    datum2 = stavka.Do;
                    vozila1TableAdapter vozila = new vozila1TableAdapter();
                    DataTable tablica= vozila.GetData(sifra);
                    foreach (DataRow red in tablica.Rows)
                    {
                        marka = red["marka"].ToString();
                        model = red["naziv"].ToString();
                        tablice = red["registracija"].ToString();
                        izvedba = red["izvedba"].ToString();
                        klasa = red["klasa"].ToString();
                        boja = red["boja"].ToString();
                    }
                    txtMarka.Text = marka;
                    txtModel.Text = model;
                    txtBoja.Text = boja;
                    txtIzvedba.Text = izvedba;
                    txtKlasa.Text = klasa;
                    txtTablice.Text = tablice;
                    dtOd.Value = datum1;
                    dtDo.Value = datum2;
                    cmbVureOd.Text = datum1.ToString("HH:mm");
                    cmbVureDo.Text = datum2.ToString("HH:mm");
                    dtOd.Enabled = false;
                    dtDo.Enabled = false;
                    cmbVureDo.Enabled = false;
                    cmbVureOd.Enabled = false;
                    btnZavrsi.Enabled = false;
                    provjeri_za_gumb();
                }
            }
        }
    }
}
