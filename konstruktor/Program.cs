using System;

namespace konstruktor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            osoba osoba1 = new osoba();
            osoba osoba2 = new osoba("Jan","Kowalski");
            osoba osoba3 = new osoba("toma","madzur","Ibiza");
            osoba osoba4 = new osoba("Pepe","Progami","krzeczowice","Wesola",26);

        }
    }
}
