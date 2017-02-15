using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarApp
{

    class Zaposlenici
    {
        _16023_DBDataSetTableAdapters.zaposlenikTableAdapter baza = new _16023_DBDataSetTableAdapters.zaposlenikTableAdapter(); 
        public string OIB { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string adresa { get; set; }
        public string brMob { get; set; }
        public string email { get; set; }
        public int rola { get; set; }
        public string korIme { get; set; }
        public string lozinka { get; set; }
        public Zaposlenici(string ime,string prezime,string adresa,string OIB, string brMob,int rola,string korIme,string lozinka,string email)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.adresa = adresa;
            this.OIB = OIB;
            this.brMob = brMob;
            this.rola = rola;
            this.korIme = korIme;
            this.lozinka = lozinka;
            this.email = email;
        }
        public Zaposlenici(string OIB)
        {
            foreach (var row in baza.GetDataBy2(OIB)){
                this.OIB = row.oib;
                this.ime = row.ime;
                this.prezime = row.prezime;
                this.rola = row.rola;
                this.adresa = row.adresa;
                this.brMob = row.broj_mobitela;
                this.korIme = korIme;
                this.lozinka = lozinka;
                this.email = row.email;
            }
            
        }
        public int DodajZaposlenika()
        {
            try {
                baza.InsertQuery(this.OIB, this.ime, this.prezime, this.adresa, this.brMob, this.email, this.rola, this.korIme, this.lozinka);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public string vratiIme()
        {
            return this.ime + " " + this.prezime;
        }
        
    }
}
