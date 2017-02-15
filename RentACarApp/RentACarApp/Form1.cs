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
    public partial class Form1 : Form
    {
        public string oib;
        public string korIme;
        public string lozinka;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrijavi_Click(object sender, EventArgs e){
            korIme = txtKorIme.Text;
            lozinka = txtLozinka.Text;
            
            try {
                _16023_DBDataSetTableAdapters.zaposlenikTableAdapter provjera = new _16023_DBDataSetTableAdapters.zaposlenikTableAdapter();
                _16023_DBDataSet.zaposlenikDataTable nova = new _16023_DBDataSet.zaposlenikDataTable();
                provjera.provjeraLogina(nova, korIme, lozinka);
                int rez = nova.Rows.Count;
                if (rez == 1)
                {
                    int rola = 0;
                    DataRow[] rezultat = nova.Select();
                    foreach (DataRow row in rezultat)
                    {
                        rola = int.Parse(row[6].ToString());
                        oib = row[0].ToString();
                    }
                    if (rola == 1)
                    {
                        if (MessageBox.Show("Želite li ući u direktorski način rada?", "Direktorski način rada", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            this.Hide();
                            DirektorskiMod rent = new DirektorskiMod();
                            rent.Closed += (s, args) => this.Close();
                            rent.Show();
                        }
                        else
                        {
                            this.Hide();
                            RentACar rent = new RentACar(oib);
                            rent.Closed += (s, args) => this.Close();
                            rent.Show();
                        }

                    }
                    else {
                        this.Hide();
                        RentACar rent = new RentACar(oib);
                        rent.Closed += (s, args) => this.Close();
                        rent.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Pogrešno korisničko ime i/ili lozinka");
                }
            }
            catch
            {
                MessageBox.Show("Provjerite internet vezu!");
            }
             
        }


        private void txtKorIme_Click(object sender, EventArgs e)
        {
            tssStrip1.Text = "Unos vašeg korisničkog imena";
            
        }

        private void txtLozinka_Click(object sender, EventArgs e)
        {
            tssStrip1.Text = "Unos vaše lozinke";
        }
        private void oAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_aplikaciji f2 = new o_aplikaciji();
            f2.ShowDialog();
        }

        private void oAplikacijiToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tssStrip1.Text = "Pogledajte sve o aplikaciji";
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

            tssStrip1.Text = "Dobro došli u prijavu";
        }

        private void izlazakToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite izaći iz aplikacije?", "Izađi iz aplikacije", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnPrijavi_Click(sender, e);
            }
        }

        private void txtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnPrijavi_Click(sender, e);
            }
        }
    }
}
