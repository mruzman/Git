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
    public partial class DodajAuto : Form
    {
        public DodajAuto()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void DodajAuto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16023_DBDataSet.marke' table. You can move, or remove it, as needed.
            //this.markeTableAdapter.Fill(this._16023_DBDataSet.marke);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite prekinuti unos?", "Odbaci unos", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* int vr;
            string naziv = "";
            string vrijednost = "";
            int marka;
            naziv = txtNaziv.Text;
            vrijednost = txtVrijednost.Text;
            marka = int.Parse(cmbMarka.SelectedValue.ToString());
            /*auto novi = new auto(naziv,marka,vrijednost);
            vr=novi.dodaj();
            if (vr == 1)
            {
                MessageBox.Show("Uspješno dodan automobil!");
                inicijaliziraj();
            }
            else
            {
                MessageBox.Show("Greška u unosu!");
            }*/
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            txtVrijednost.Enabled = true;
        }

        private void cmbMarka_TextChanged(object sender, EventArgs e)
        {
            txtNaziv.Enabled = true;
        }

        private void txtVrijednost_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void cmbMarka_SelectedValueChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void inicijaliziraj()
        {
            txtNaziv.Text = "";
            txtVrijednost.Text = "";
            cmbMarka.Text = "";
            button1.Enabled = false;
        }
    }
}
