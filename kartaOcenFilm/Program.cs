using System;

namespace kartaOcenFilm
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Karta karta = new Karta();
            Karta kartaUzytkownika = new Karta();
            int lTest1 = 1;
            _ = lTest1 < 5 ? "Mniej" : "więcej";

            karta.DodajOcene(5);
            karta.DodajOcene(3);
            karta.DodajOcene(8);
            karta.DodajOcene(3.5f);
            karta.DodajOcene(6.5f);

            float srednia = karta.ObliczSrednia();
            float maxVal = karta.MaxOcena();
            float minVal = karta.MinOcena();

            for (; ; )
            {
                float ocena;
                Console.WriteLine("Podaj ocene z zakresu 1 - 10");
                bool wynik = float.TryParse(Console.ReadLine(), out ocena);

                if (wynik)
                {
                    if (ocena == 11)
                    {
                        break;
                    }

                    if (ocena>0 && ocena <=10)
                    {
                        kartaUzytkownika.DodajOcene(ocena);
                    }
                    else
                    {
                        Console.WriteLine("Liczba spoza zakresu!");
                    }
                }
                else
                {
                    Console.WriteLine("To nie jest liczba");
                }
            }
            Console.WriteLine("Srednia liczba to: " + kartaUzytkownika.ObliczSrednia());
            Console.WriteLine("Nawiększa ocena to: " + kartaUzytkownika.MaxOcena());
            Console.WriteLine("Najmniejsza ocena to: " + kartaUzytkownika.MinOcena());

            

        }
    }
}
