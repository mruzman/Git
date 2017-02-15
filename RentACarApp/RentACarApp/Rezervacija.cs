using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarApp
{
    class Rezervacija
    {
        _16023_DBDataSetTableAdapters.rezervacijaTableAdapter adapter = new _16023_DBDataSetTableAdapters.rezervacijaTableAdapter();
        int sifra { get; }
        public int vozilo { get; set; }
        DateTime datum_preuzimanja { get; set; }
        DateTime datum_povrata { get; set; }
        int racun { get; set; }
        int? pocetna_kilometraza { get; set; }
        int? zavrsna_kilometraza { get; set; }
        string status_rez { get; set; }
        public Rezervacija(int vozilo,DateTime datum_pre,DateTime datum_pov,int rac)
        {
            this.vozilo = vozilo;
            this.datum_preuzimanja = datum_pre;
            this.datum_povrata = datum_pov;
            this.racun = rac;
            this.pocetna_kilometraza = null;
            this.zavrsna_kilometraza = null;
            this.status_rez = "rezervirano";
        }
        public Rezervacija(int broj)//dohvaca rezervaciju
        {
            
                foreach (var red in adapter.GetDataBy1(broj))
                {
                    this.sifra = red.sifra;
                    this.vozilo = red.vozilo;
                    this.datum_povrata = red.datum_povrata;
                    this.datum_preuzimanja = red.datum_preuzimanja;
                    this.status_rez = red.status_rez;
                }
            
            
        }
        public void zapisiUBazu()
        {
            adapter.Insert(this.vozilo, this.datum_preuzimanja,
                    this.datum_povrata, this.racun, this.pocetna_kilometraza,
                    this.zavrsna_kilometraza, this.status_rez);
        }

        public void obrisiRezervaciju()
        {
            adapter.DeleteQuery(this.sifra);
        }
        public void obrisi()
        {
            adapter.UpdateQuery(this.sifra);
        }
        public void vratiAuto(int zavrseno, DateTime datum1)
        {
            this.datum_povrata = datum1;
            this.zavrsna_kilometraza = zavrseno;
            adapter.vratiAuto(this.datum_povrata, this.zavrsna_kilometraza, this.sifra);
        }
    }
}
