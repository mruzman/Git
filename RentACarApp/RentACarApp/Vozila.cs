using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarApp
{
    class Vozila
    {
        _16023_DBDataSetTableAdapters.vozilaTableAdapter adapter = new _16023_DBDataSetTableAdapters.vozilaTableAdapter();
        private int sifra { get; set; }
        private int automobil { get; set; }
        private string broj_sasije { get; set; }
        private string registracija { get; set; }
        private int godina_proizvodnje { get; set; }
        private string boja { get; set; }
        private int kilometraza { get; set; }
        public Vozila(int auto,string brsas,string rega,int god_pr,string boja,int kilom)
        {
            this.automobil = auto;
            this.broj_sasije = brsas;
            this.registracija = rega;
            this.godina_proizvodnje = god_pr;
            this.boja = boja;
            this.kilometraza = kilom;
        }
        public void upisiUBazu()
        {
            adapter.Insert(this.automobil, this.broj_sasije, this.registracija, this.godina_proizvodnje, this.boja, this.kilometraza);
        }
        public Vozila(int sifra,int auto, string brsas, string rega, int god_pr, string boja, int kilom)
        {
            this.sifra = sifra;
            this.automobil = auto;
            this.broj_sasije = brsas;
            this.registracija = rega;
            this.godina_proizvodnje = god_pr;
            this.boja = boja;
            this.kilometraza = kilom;
        }
        public Vozila(int sifra)
        {
            foreach(var red in adapter.GetDataBy2(sifra))
            {
                this.sifra = red.sifra;
                this.automobil = red.automobil;
                this.broj_sasije = red.broj_sasije;
                this.registracija = red.registracija;
                this.godina_proizvodnje = red.godina_proizvodnje;
                this.boja = red.boja;
                this.kilometraza = red.kilometraza;
            }
        }

        public void postavitiKilometrazu(int kilometri)
        {
            adapter.postaviKilometrazu(kilometri, this.sifra);
        }

    }
}
