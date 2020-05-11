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
        }


        List<float> oceny;

        /// <summary>
        /// dodaje ocene
        /// </summary>
        /// <param name="ocena"> nowa ocena</param>
        public void DodajOcene(float ocena)
        {
            oceny.Add(ocena);
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
    
           
        
    }
}
