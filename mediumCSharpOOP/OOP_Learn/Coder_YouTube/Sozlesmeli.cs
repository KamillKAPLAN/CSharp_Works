using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder_YouTube
{
    public sealed class Sozlesmeli : Personel
    {
        public byte SozlesmeSuresi { get; set; }

        public override decimal IkramiyeHesapla()
        {
            return Maas * 1.5M;
        }
    }
}
