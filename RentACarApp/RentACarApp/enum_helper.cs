using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarApp
{
    public enum Broj_brzina
    {
        četiri,
        pet,
        šest
    }
    public enum Izvedba
    {
        Sve=-1,
        Limuzina = 1,
        Karavan = 2,
        Kupe = 3,
        Kabriolet = 4,
        Višena = 5,
        Kombi= 6
    }
    public enum Klasa
    {
        Sve=-1,
        Niža = 1,
        Srednja = 2,
        Viša = 3,
        Supersport=4
    }
    public enum Rola
    {
        direktor = 1,
        menađer = 2,
        referent = 3,
        služba = 4
    }
    public enum Marka
    {
        Sve=-1,
        Opel,
        Volkswagen,
        Citroen,
        Renault,
        Peugeot,
        Audi,
        BMW,
        Mercedes,
        Mazda,
        Fiat,
        Škoda
    }
    public enum Mjenjač
    {
        ručno,
        automatski,
        sekvencijski,
        automatski_sekvencijski
    }
    public enum Motor
    {
        Benzin = 1,
        Diesel = 2,
        Hibrid = 3,
        Električni = 4
    }
    public enum Tip_vozila
    {
        Sva=-1,
        Osobno_standardno = 1,
        Osobno_luksuzno = 2,
        Ekstra_luksuzno = 3,
        Kombi_putničko = 4,
        Kombi_teretno = 5
    }
    public enum Status_rez
    {
        spremljeno,
        rezervirano,
        preuzeto,
        vraćeno,
        otkazano
    }
    public enum Status_rac
    {
        u_izradi,
        spremljen,
        izdan,
        plaćen,
        otkazan
    }
}
