using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLearn
{
    class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }
        public string NefesAl()
        {
            return "Ben nefes alabilirim.";
        }
    }
}
