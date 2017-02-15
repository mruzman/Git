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
    public partial class RentACar : Form
    {
        DataTable tablica;
        private int nesto;//koji je broj rezervacije preuzet kod preuzimanja automobila
        public string oib;
        _16023_DBDataSetTableAdapters.rezervacija2TableAdapter zaDanas = new _16023_DBDataSetTableAdapters.rezervacija2TableAdapter();
        _16023_DBDataSetTableAdapters.rezervacijaTableAdapter pregledRez = new _16023_DBDataSetTableAdapters.rezervacijaTableAdapter();
        _16023_DBDataSetTableAdapters.racunTableAdapter racunAdapter = new _16023_DBDataSetTableAdapters.racunTableAdapter();
        _16023_DBDataSetTableAdapters.klijentTableAdapter klijentAdapter = new _16023_DBDataSetTableAdapters.klijentTableAdapter();
        public RentACar(string zapoib)
        {
            InitializeComponent();
            btnIzdaj.Enabled = false;
            btnVrati.Enabled = false;
            btnPreuzmi.Enabled = false;
            oib = zapoib;
            init();
            klik();
            initTab3();

         
            //za tablica2 ispisi na gumbu ako je zadnji ispis racuna inace nek ispise za povrat automobila.
        }
        private void init()
        {
            DateTime datum = dtpOd.Value.Date;
            tablica = zaDanas.GetDataBy(dtpOd.Value.Date, dtpDo.Value.Date.AddDays(1));
            dataGridView1.DataSource = tablica;
            dataGridView1.Refresh();
        }
        private void klik() {
            DataTable klijent = klijentAdapter.GetData();
            klijent.Columns.Add("puno_ime", typeof(string));

            foreach (DataRow row in klijent.Rows)
            {
                row["puno_ime"] = row["ime"].ToString() + " " + row["prezime"].ToString() + " - " + row["oib"].ToString();
            }
            cmbKlijenti.DataSource = klijent.DefaultView;
            cmbKlijenti.DisplayMember = "puno_ime";
            cmbKlijenti.ValueMember = "oib";
            cmbKlijenti.SelectedIndex = -1;
        }
       
        
        private void dodajNovogKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dodaj_novog_klijenta dodaj = new Dodaj_novog_klijenta();
            dodaj.ShowDialog();
        }
        

        private void rezervirajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rezervirajForma nova = new rezervirajForma(oib);
            nova.ShowDialog();
            tablica = zaDanas.GetDataBy(dtpOd.Value.Date, dtpDo.Value.Date.AddDays(1));
            dataGridView1.DataSource = tablica;
            dataGridView1.Refresh();
           
        }

        private void oAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            o_aplikaciji f2 = new o_aplikaciji();
            f2.ShowDialog();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite izaći iz aplikacije?", "Izađi iz aplikacije", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pregledajSlobodneAutomobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Slobodni_automobili slobodni = new Slobodni_automobili();
            slobodni.Show();
        }
        private void btnPreuzmi_Click(object sender, EventArgs e)
        {
            preuzmiAutomobil forma = new preuzmiAutomobil(1,nesto);
            forma.ShowDialog();
            init();
            initTab3();
            btnPreuzmi.Enabled = false;
        }
       
       

        private void dodajKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dodaj_novog_klijenta kl = new Dodaj_novog_klijenta();
            kl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var klijent = new SviKlijenti())
            {
                var odabrani = klijent.ShowDialog();
                if (odabrani == DialogResult.OK)
                {
                    cmbKlijenti.SelectedValue = klijent.oib;
                    initTab3();
                }
            }
        }
        private void initTab3()
        {
            if (cmbKlijenti.SelectedIndex == -1)
            {
                DataTable tablica= racunAdapter.ZaRacune();
                dataGridView3.DataSource = tablica;
                dataGridView3.Refresh();
            }
            else
            {
                DataTable tablica = racunAdapter.DohvatiPoKlijentu(cmbKlijenti.SelectedValue.ToString());
                dataGridView3.DataSource = tablica;
                dataGridView3.Refresh();
            }
        }

        private void RentACar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16023_DBDataSet1.zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this._16023_DBDataSet1.zaposlenik);
            // TODO: This line of code loads data into the '_16023_DBDataSet1.klijent' table. You can move, or remove it, as needed.
            this.klijentTableAdapter.Fill(this._16023_DBDataSet1.klijent);
            // TODO: This line of code loads data into the '_16023_DBDataSet1.racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this._16023_DBDataSet1.racun);

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnVrati.Enabled = false;
            DataTable tablicaN= zaDanas.DohvatiPoRacunu(int.Parse(dataGridView3.CurrentRow.Cells[0].FormattedValue.ToString()));
            dataGridView4.DataSource = tablicaN;
            dataGridView4.Refresh();
            provjeraIzdaja();
        }
        private void provjeraIzdaja()
        {
            bool vrati = false;
            foreach(DataGridViewRow red in dataGridView4.Rows)
            {
                if (red.Cells[9].FormattedValue.ToString() == "rezervirano" || red.Cells[9].FormattedValue.ToString() == "preuzeto")
                {
                    vrati = true;
                }
            }
            if (vrati == false) { btnIzdaj.Enabled = true; racunAdapter.SpremanZaIzradu(int.Parse(dataGridView3.CurrentRow.Cells[0].FormattedValue.ToString())); }
            else { btnIzdaj.Enabled = false; }
            
        }
        private void btnSvi_Click(object sender, EventArgs e)
        {
            klik();
            initTab3();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime prvi = DateTime.Parse(dataGridView1.SelectedCells[6].FormattedValue.ToString());
            if (prvi.Date == DateTime.Today){
                btnPreuzmi.Enabled = true;
                nesto = int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
            }
            else
            {
                btnPreuzmi.Enabled = false;
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.SelectedCells[9].EditedFormattedValue.ToString() == "preuzeto")
            {
                btnVrati.Enabled = true;
            }
            else
            {
                btnVrati.Enabled = false;
            }
        }

        private void btnIzdaj_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView3.CurrentCell.RowIndex;
            IzradiRacun novi = new IzradiRacun(int.Parse(dataGridView3.Rows[rowIndex].Cells[0].FormattedValue.ToString()));
            novi.ShowDialog();
            init();
            initTab3();
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            init();
            btnPreuzmi.Enabled = false;
        }

        

        private void dtpDo_CloseUp(object sender, EventArgs e)
        {
            init();
            btnPreuzmi.Enabled = false;
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView4.CurrentCell.RowIndex;
            preuzmiAutomobil novi = new preuzmiAutomobil(2, (int.Parse(dataGridView4.Rows[rowindex].Cells[8].FormattedValue.ToString())));
            novi.ShowDialog();
            init();
            initTab3();
        }

        
    }
}
