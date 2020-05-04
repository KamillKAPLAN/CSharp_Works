using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancesVirtual
{
    class BaseClass
    {
        public virtual void OzellikYazdir()
        {
            Console.WriteLine("BaseClass virtual");
        }
    }

    class ExampleClass : BaseClass
    {
        public override void OzellikYazdir()
        {
            Console.WriteLine("ExampleClass override");
            base.OzellikYazdir();
        }
    }

    class Canli
    {
        public virtual void Beslenme()
        { Console.WriteLine("Canlı beslenme virtual"); }
    }

    class Insan : Canli
    {
        public override void Beslenme()
        { base.Beslenme(); }

    }
}
