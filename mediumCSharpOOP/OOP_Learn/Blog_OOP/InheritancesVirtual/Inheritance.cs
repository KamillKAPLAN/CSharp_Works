using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancesVirtual
{
    /* Base Class */
    class A
    {
        public int AProp1 { get; set; }
        public int AProp2 { get; set; }
    }

    /* B class'ı A class'ının özelliklerini devralıyor. */
    class B : A
    { public int BProp { get; set; } }

    class C : B
    { }

    public sealed class D { }

    public abstract class E { }
}
