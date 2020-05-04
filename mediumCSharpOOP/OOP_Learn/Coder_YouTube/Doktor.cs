using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder_YouTube
{
    public sealed class Doktor : Personel
    {
        public string Brans { get; set; }

        public override decimal IkramiyeHesapla()
        {
            return Maas * 3;
        }

        public override string ToString()
        {
            return Ad + " " + Soyad;
            // return base.ToString();
        }
    }
}
