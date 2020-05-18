using System;
namespace kartaOcenFilm
{
    public class LepszaKarta : Karta
    {
        public KartaStatystyki ObliczStatystyki()
        {
            float najnizsza = float.MaxValue;
            foreach (var ocena in oceny)
            {
                najnizsza = Math.Min(ocena, najnizsza);
            }
            oceny.Remove(najnizsza);
            return base.Obliczstatystyki();
        }
    }
}
