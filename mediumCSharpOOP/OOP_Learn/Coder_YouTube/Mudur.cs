using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder_YouTube
{
    public sealed class Mudur : Personel
    {
        ///<summary>
        ///Müdürn ilgili olduğu bölüm
        ///</summary>
        public string Bolum { get; set; }

        public override decimal IkramiyeHesapla()
        {
            return Maas * 3.5M;
        }
    }
}
