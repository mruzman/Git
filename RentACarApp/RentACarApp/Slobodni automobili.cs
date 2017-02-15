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
    public partial class Slobodni_automobili : Form
    {
        _16023_DBDataSetTableAdapters.vozilaTableAdapter voz = new _16023_DBDataSetTableAdapters.vozilaTableAdapter();
        _16023_DBDataSetTableAdapters.rezervacijaTableAdapter rezervacije = new _16023_DBDataSetTableAdapters.rezervacijaTableAdapter();
        public int odabrano { get; set; }
        public DateTime Od { get; set; }
        public DateTime Do {get; set;}
        private DateTime? datum1, datum2;
        private string izvedba, klasa, marka, tip;
        private int? brojPutnika, motorOd, motorDo=null;
        public Slobodni_automobili(DateTime datumOd,DateTime datumDo)
        {
            InitializeComponent();
            datum1 = datumOd;
            datum2 = datumDo;
            dtpOd.Value = datum1.Value;
            dtDo.Value = datum2.Value;
            cmbVrijemeOd.Text = datumOd.ToString("HH:mm");
            cmbVrijemeDo.Text = datumDo.ToString("HH:mm");
            inicijalizacija();

        }
        public Slobodni_automobili()
        {
            InitializeComponent();
            dtpOd.Value = DateTime.Today.AddDays(1);
            dtDo.Value = DateTime.Today.AddDays(1);
            cmbVrijemeOd.Text = "12:00";
            cmbVrijemeDo.Text = "18:00";
            inicijalizacija();
        }
        private void inicijalizacija()
        {
            cmbIzvedba.DataSource = Enum.GetValues(typeof(Izvedba));
            cmbIzvedba.SelectedIndex = 6;
            cmbKlasa.DataSource = Enum.GetValues(typeof(Klasa));
            cmbKlasa.SelectedIndex = 4;
            cmbMarka.DataSource = Enum.GetValues(typeof(Marka));
            cmbMarka.SelectedIndex = 11;
            string[] tip_vozilaa = Enum.GetNames(typeof(Tip_vozila));
            foreach (string tip_vozila in tip_vozilaa)
            {
                cmbTipVozila.Items.Add(tip_vozila.Replace("_", " "));
            }
            cmbTipVozila.SelectedIndex = 5;
            initTable();
        }
        private void initTable()
        {
            try {
                
                txtPretraga.Clear();
                provjera();
                Proc_za_pretragu2TableAdapter adapter = new Proc_za_pretragu2TableAdapter();
                DataTable tablica = adapter.GetData(datum1, datum2, marka, klasa, izvedba, tip, motorOd, motorDo, brojPutnika);
                tablica.AcceptChanges();
                dataGridView1.DataSource = tablica;
                dataGridView1.Refresh();
            }
           catch
            {
                MessageBox.Show("Provjerite internet vezu!");
            }
        }
        private void initTable(string trazi)
        {
            try {
                txtBrojPutnika.Clear();
                txtSnagaOd.Clear();
                txtSnagaDo.Clear();
                cmbTipVozila.SelectedIndex = 5;
                cmbMarka.SelectedIndex = 11;
                cmbKlasa.SelectedIndex = 4;
                cmbIzvedba.SelectedIndex = 6;
                Proc_za_pretraguTableAdapter adapter = new Proc_za_pretraguTableAdapter();
                DataTable table = adapter.GetData(datum1, datum2, trazi);

                dataGridView1.DataSource = table;
                dataGridView1.Refresh();
            }
            catch
            {
                MessageBox.Show("Provjerite internet vezu!");
            }
        }
        private void provjera()
        {

            if (txtBrojPutnika.Text.Length > 0) {
                brojPutnika = int.Parse(txtBrojPutnika.Text.ToString());
            } else { brojPutnika = null; }
            if (txtSnagaOd.Text.Length > 0 || txtSnagaDo.Text.Length > 0)
                {
                    if (txtSnagaOd.Text.Length > 0)
                    {
                        motorOd = int.Parse(txtSnagaOd.Text.ToString());
                    }
                    else
                    {
                        motorOd = 0;
                    }
                    if (txtSnagaDo.Text.Length > 0)
                    {
                        motorDo = int.Parse(txtSnagaDo.Text.ToString());
                    }
                    else
                    {
                        motorDo = int.MaxValue;
                    }
                }
                else
                {
                    motorOd = null;
                    motorDo = null;
                }
            
            if (((int.Parse(cmbIzvedba.SelectedIndex.ToString()) !=-1))&&((int.Parse(cmbIzvedba.SelectedIndex.ToString())!=6)))
            {
                Izvedba izv = (Izvedba)cmbIzvedba.SelectedItem;
                izvedba = izv.ToString();
            }
            else { izvedba = null; }
            if (((int.Parse(cmbMarka.SelectedIndex.ToString()) != -1)) && ((int.Parse(cmbMarka.SelectedIndex.ToString()) != 11)))
            {
                Marka mar = (Marka)cmbMarka.SelectedItem;
                marka = mar.ToString();
            }
            else { marka = null; }
            if (((int.Parse(cmbKlasa.SelectedIndex.ToString()) != -1)) && ((int.Parse(cmbKlasa.SelectedIndex.ToString()) != 4)))
            {
                Klasa mar = (Klasa)cmbKlasa.SelectedItem;
                klasa = mar.ToString();
            }
            else { klasa = null; }
            if (((int.Parse(cmbTipVozila.SelectedIndex.ToString()) != -1)) && ((int.Parse(cmbTipVozila.SelectedIndex.ToString()) != 5)))
            {
                string mar = cmbTipVozila.SelectedItem.ToString();
                tip = mar.ToString();
            }
            else { tip = null; }
            izradiDatum();
        }


        private void izradiDatum(){
            
            string pomocna,pomocna2;
            pomocna = cmbVrijemeOd.Text.ToString();
            pomocna2 = dtpOd.Value.Date.Day.ToString()+"."+ dtpOd.Value.Date.Month.ToString()+"."+ dtpOd.Value.Date.Year.ToString();
            datum1 = DateTime.Parse(pomocna2 + " " + pomocna);
            pomocna = cmbVrijemeDo.Text.ToString();
            pomocna2 = dtDo.Value.Date.Day.ToString() + "." + dtDo.Value.Date.Month.ToString() + "." + dtDo.Value.Date.Year.ToString();
            datum2 = DateTime.Parse(pomocna2 + " " + pomocna);
            if (datum1 > datum2|| datum1 < DateTime.Now)
            {
                MessageBox.Show("Provjerite unos datuma!");
                datum1 = DateTime.Now.AddDays(1);
                datum2 = DateTime.Now.AddDays(3);
                dtDo.Value = datum2.Value.Date;
                dtpOd.Value = datum1.Value.Date;
                }
            }
        

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.odabrano = int.Parse(dataGridView1.SelectedCells[0].FormattedValue.ToString());
            this.Od = DateTime.Parse(datum1.ToString());
            this.Do = DateTime.Parse(datum2.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();   
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
        private void txtBrojPutnika_TextChanged(object sender, EventArgs e){
            if (txtBrojPutnika.Text.Length > 0)
            {
                if (tekst(txtBrojPutnika.Text.ToString()) == false) { txtBrojPutnika.Clear(); brojPutnika = null; }
            }
            initTable();
            
        }

        private void txtSnagaOd_TextChanged(object sender, EventArgs e)
        {
            if (txtSnagaOd.Text.Length > 0)
            {
                if (tekst(txtSnagaOd.Text.ToString()) == false) txtSnagaOd.Clear(); 
            }
            initTable();
        }

        private void txtSnagaDo_TextChanged(object sender, EventArgs e)
        {
            if (txtSnagaDo.Text.Length > 0)
            {
                if (tekst(txtSnagaDo.Text.ToString()) == false) txtSnagaDo.Clear();
            }
                initTable();
        }

        private void cmbIzvedba_SelectionChangeCommitted(object sender, EventArgs e)
        {
            initTable();
        }

        private void cmbMarka_SelectionChangeCommitted(object sender, EventArgs e)
        {
            initTable();
        }

        private void cmbTipVozila_SelectionChangeCommitted(object sender, EventArgs e)
        {
            initTable();
        }
       

        private void cmbVrijemeOd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            initTable();
        }

        private void cmbVrijemeDo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            initTable();
        }

        private void dtDo_CloseUp(object sender, EventArgs e)
        {
            initTable();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            string trazi;
            trazi = txtPretraga.Text.ToString();
            initTable(trazi);
        }

        private void dtpOd_CloseUp(object sender, EventArgs e)
        {
            initTable();
        }
        private void txtVrijemePreuz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 initTable();   
            }
        }

        private void txtVrijemePovrata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                initTable();
            }
        }
        private void cmbKlasa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            initTable();
        }
    }
}
