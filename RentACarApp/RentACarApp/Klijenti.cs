using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarApp
{
    class Klijenti
    {
        _16023_DBDataSetTableAdapters.klijentTableAdapter adapter = new _16023_DBDataSetTableAdapters.klijentTableAdapter();
        public string oib { get; set; }
        public string ime{get;set;}
        public string prezime{get;set;}
        public string adresa{get;set;}
        public string broj_mobitela{get;set;}
        public string email { get; set; }
        public Klijenti(string oib)
        {
            foreach(var red in adapter.GetDataBy(oib))
            {
                this.oib = oib;
                this.ime = red.ime;
                this.prezime = red.prezime;
                this.adresa = red.adresa;
                this.broj_mobitela = red.broj_mobitela;
                this.email = red.email;
            }
        }
    }
}
