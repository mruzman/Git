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
    public partial class OdaberiStavke : Form
    {
        public int kljent;
        public int stavke
        {
            get; set;
        }
        public OdaberiStavke(int kl)
        {
            kljent = kl;
            InitializeComponent();
        }

        private void OdaberiStavke_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16023_DBDataSet.rezervirano' table. You can move, or remove it, as needed.
           // this.rezerviranoTableAdapter.FillByKlijent(this._16023_DBDataSet.rezervirano, kljent);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                this.stavke = int.Parse(row.Cells[0].Value.ToString());
                this.DialogResult=DialogResult.OK;
                this.Close();
            }
            
        }
    }
}
