using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarApp
{
    class Racun
    {
        _16023_DBDataSetTableAdapters.racunTableAdapter adapter = new _16023_DBDataSetTableAdapters.racunTableAdapter();
        public int sifra { get; }
        DateTime? datum_izdavanja { get; set; }
        public DateTime datum_rezervacije { get; }
        public string klijent { get; set; }
        public string zaposlenik { get; set; }
        string status_racun { get; set; }
        public Racun(string klijent, string zaposlenik)
        {
            this.datum_izdavanja = null;
            this.datum_rezervacije = DateTime.Now;
            this.klijent = klijent;
            this.zaposlenik = zaposlenik;
            this.status_racun = "u_izradi";
            zapisiUBazu();
        }
        public Racun()
        {
            foreach (var red in adapter.GetDataBy1())
            {
                this.sifra = int.Parse(red.sifra.ToString());
                this.status_racun = red.status_rac;
                this.datum_rezervacije = DateTime.Parse(red.datum_rezervacije.ToString());
                this.klijent = red.klijent;
                this.zaposlenik = red.racun_izdao;
            }
        }
        public Racun(int sifra)
        {
            foreach(var red in adapter.DohvatiPoSifri(sifra))
            {
                this.sifra = int.Parse(red.sifra.ToString());
                this.status_racun = red.status_rac;
                this.datum_rezervacije = DateTime.Parse(red.datum_rezervacije.ToString());
                this.klijent = red.klijent;
                this.zaposlenik = red.racun_izdao;
            }
        }
        public void zapisiUBazu()
        {
             adapter.Insert(this.datum_izdavanja, this.datum_rezervacije, this.klijent, this.zaposlenik, this.status_racun);   
        }
        public int dohvatiRacun()
        {
            if (adapter.GetDataBy1().Rows.Count > 0)
            {
                foreach (var red in adapter.GetDataBy1())
                {
                    return red.sifra;
                }
                return -1;
            }

            else
            {
                return 0;
            }
        }
        public void brisanje()
        {
            adapter.DeleteQuery(this.sifra);
        }
        public void updateBazu()
        {
            adapter.UpdateQuery(this.sifra);//updajta sifru za promjenu statusa
        }
        public void updateBazuZaIzdaju()
        {
            adapter.updateZaIzdavanje(DateTime.Now, this.sifra);
        }
        
    }
}
