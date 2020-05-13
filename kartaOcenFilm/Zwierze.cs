using System;
namespace kartaOcenFilm
{
    public class Zwierze
    {
        private string _nazwa;
        private string _nazwa2;
        private readonly string _readonly;

        //konstruktor
        public Zwierze(string nazwa, string nazwa2, string pole)
        {
            _nazwa = nazwa;
            _nazwa2 = nazwa2;
            _readonly = pole;
        }

        //właściwości dla pól
        public string Nazwa
        {
            get { return _nazwa; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nazwa = value;
                }
            }
        }

        //właściwość tylko do zapisu
        public string Nazwa2
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nazwa = value;
                }
            }
        }

        //właściwość tylko do odczytu
        public string Readonly
        {
            get
            {
                return _readonly;
            }
        }

        //właściwość automatyczna
        public int MyProperty { get; set; }
    }
}
