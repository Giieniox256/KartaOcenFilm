using System;

namespace kartaOcenFilm
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Karta karta = new Karta();
            //Karta kartaUzytkownika = new Karta();

            //karta.DodajOcene(5);
            //karta.DodajOcene(3);
            //karta.DodajOcene(8);
            //karta.DodajOcene(3.5f);
            //karta.DodajOcene(6.5f);
            

            //float srednia = karta.ObliczSrednia();
            //float maxVal = karta.MaxOcena();
            //float minVal = karta.MinOcena();
            //#region wpisywanie danych
            //for (; ; )
            //{
            //    float ocena;
            //    Console.WriteLine("Podaj ocene z zakresu 1 - 10");
            //    bool wynik = float.TryParse(Console.ReadLine(), out ocena);

            //    if (wynik)
            //    {
            //        if (ocena == 11)
            //        {
            //            break;
            //        }

            //        if (ocena>0 && ocena <=10)
            //        {
            //            kartaUzytkownika.DodajOcene(ocena);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Liczba spoza zakresu!");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("To nie jest liczba");
            //    }
            //}
            //Console.WriteLine("Srednia liczba to: " + kartaUzytkownika.ObliczSrednia());
            //Console.WriteLine("Nawiększa ocena to: " + kartaUzytkownika.MaxOcena());
            //Console.WriteLine("Najmniejsza ocena to: " + kartaUzytkownika.MinOcena());
            //#endregion

            //KartaStatystyki statystyki = karta.Obliczstatystyki();

            //Karta karta2 = new Karta();

            //karta2.DodajOcene(1);
            //karta2.DodajOcene(5);
            //karta2.DodajOcene(9);
            //karta2.DodajOcene(2.5f);
            //karta2.DodajOcene(6.5f);

            //Console.WriteLine("Średnia to : {0}",statystyki.sredniaOcena);
            //Console.WriteLine("Minimalna to : {0}", statystyki.minimalnaOcena);
            //Console.WriteLine("Maksymalna to : {0}",statystyki.maksymalnaOcena);

            //KartaStatystyki statystyki2 = karta2.Obliczstatystyki();

            //Console.WriteLine("Średnia to : {0}", statystyki2.sredniaOcena);
            //Console.WriteLine("Minimalna to : {0}", statystyki2.minimalnaOcena);
            //Console.WriteLine("Maksymalna to : {0}", statystyki2.maksymalnaOcena);

            //Console.WriteLine(Karta.wersja); //wypisanie statycznej funkcji
            //Console.WriteLine("Ilość kart to: {0}",Karta.licznik);

            //karta.Nazwa = "test wlasciwosci";
            //Console.WriteLine(karta.Nazwa);

            //Delegaty

            Karta kartaD = new Karta();
            kartaD.ZmianaNazwy += new ZmianaNazwyDelegat(KiedyZmianaNazwy);
            kartaD.ZmianaNazwy += new ZmianaNazwyDelegat(KiedyZmianaNazwy2);
            kartaD.ZmianaNazwy += KiedyZmianaNazwy2;
            kartaD.ZmianaNazwy += KiedyZmianaNazwy2;

            kartaD.Nazwa = "Pietrek";
            kartaD.Nazwa = "Janusz";


        }

        private static void KiedyZmianaNazwy2(object sender, ZmianaNazwyEventArgs args)
        {
            Console.WriteLine("*****************");
        }

        private static void KiedyZmianaNazwy(object sender, ZmianaNazwyEventArgs args)
        {
            Console.WriteLine($"Zmiana nazwy z {args.IstniejacaNazwa} na {args.NowaNazwa}");
        }

    }
}