using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder_YouTube
{
    public sealed class Memur : Personel
    {
        public override decimal IkramiyeHesapla()
        {
            return Maas * 2;
        }
    }
}
