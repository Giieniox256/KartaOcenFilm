using System;
namespace konstruktor
{
    public class osoba
    {
        string imie;
        string nazwisko1;
        string miasto;
        string ulica;
        int wiek;


        public osoba()
        {
            imie = "default";
            nazwisko1 = "default";
            miasto = "default";
            ulica = "defaul";
            wiek = 10;
            Console.WriteLine("Konstruktor domyslny");

        }

        public osoba(string imie, string nazwisko, string miasto, string ulica,
            int wiek)
        {
            this.imie = imie;
            this.nazwisko1 = nazwisko;
            this.miasto = miasto;
            this.ulica = ulica;
            this.wiek = wiek;
            Console.WriteLine("Konstruktor 5 parametrowy");

        }
        public osoba(string imie, string nazwisko, string miasto)
        {
            this.imie = imie;
            this.nazwisko1 = nazwisko;
            this.miasto = miasto;
            Console.WriteLine("Konstruktor 3 parametrowy");

        }
        public osoba(string imie, string nazwisko) :this(imie,nazwisko,"Rzeszow","Rejtana 5", 20)
        {
            Console.WriteLine("Konstruktor 2 parametrowy");
        }
    }
}
