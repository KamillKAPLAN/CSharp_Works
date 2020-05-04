using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder_YouTube
{
    public abstract class Personel : Insan
    {
        public decimal Maas { get; set; }

        public abstract decimal IkramiyeHesapla();

        /* Abstract olmayan bir sınıfta polymorphism'e temel sağlamak amaçlı
         * virtual method oluşturulabilir.
         */
    }
}
