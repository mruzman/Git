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
    public partial class SviKlijenti : Form
    {
        DataTable klijenti;
        public string oib { get; set; }

        _16023_DBDataSetTableAdapters.klijentTableAdapter adapter = new _16023_DBDataSetTableAdapters.klijentTableAdapter();
        public SviKlijenti()
        {
            InitializeComponent();
            klijenti = adapter.GetData();
            dataGridView1.DataSource = klijenti;
            dataGridView1.Refresh();
        }

        private void SviKlijenti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16023_DBDataSet.klijent' table. You can move, or remove it, as needed.
            this.klijentTableAdapter.Fill(this._16023_DBDataSet.klijent);

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource= adapter.GetDataBy1(textBox1.Text.ToString());
            dataGridView1.Refresh();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            oib = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
