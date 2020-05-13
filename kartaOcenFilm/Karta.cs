using System;
using System.Collections.Generic;
using System.Linq;

namespace kartaOcenFilm
{
    public class Karta
    {

        public Karta()
        {
            oceny = new List<float>();
            licznik++;
        }

        public static float wersja = 0.1f;
        public static double licznik = 0;
        private List<float> oceny;
        //public string Nazwa;
        private string _nazwa;


        public string Nazwa
        {
            get
            {
                return _nazwa.ToUpper();
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if(_nazwa != value)
                    {
                        ZmianaNazwyEventArgs args = new ZmianaNazwyEventArgs();
                        args.IstniejacaNazwa = _nazwa;
                        args.NowaNazwa = value;

                        //ZmianaNazwy(_nazwa, value);
                        ZmianaNazwy(this, args);
                    }
                    _nazwa = value;
                }
            }

        }
        //DELEGAT
        //public ZmianaNazwyDelegat ZmianaNazwy;

        //zdarzenia
        public event ZmianaNazwyDelegat ZmianaNazwy;

        /// <summary>
        /// dodaje ocene
        /// </summary>
        /// <param name="ocena"> nowa ocena</param>
        public void DodajOcene(float ocena)
        {
            if (ocena >0 && ocena <= 10)
            {
                oceny.Add(ocena);
            }
            
        }
        /// <summary>
        /// oblicza srednią ocen
        /// </summary>
        /// <returns>zwraca średnią</returns>
        public float ObliczSrednia()
        {
            float suma = 0;
            float srednia = 0;

            foreach (var ocena in oceny)
            {
                suma += ocena;
            }
            srednia = suma / oceny.Count();

            return srednia;
        }
        /// <summary>
        /// zwraca najwyższą ocene
        /// </summary>
        public float MaxOcena()
        {
            return oceny.Max();
        }
        /// <summary>
        /// zwraca najniższą ocenę
        /// </summary>
        /// <returns></returns>
        public float MinOcena()
        {
            return oceny.Min();
        }

        internal KartaStatystyki Obliczstatystyki() //hermetyzacja
        {
            KartaStatystyki stat = new KartaStatystyki();

            float suma = 0;

            foreach (var ocena in oceny)
            {
                suma += ocena;
            }
            stat.sredniaOcena = suma / oceny.Count();
            stat.minimalnaOcena = oceny.Min();
            stat.maksymalnaOcena = oceny.Max();
            return stat;
        }
    }
}
