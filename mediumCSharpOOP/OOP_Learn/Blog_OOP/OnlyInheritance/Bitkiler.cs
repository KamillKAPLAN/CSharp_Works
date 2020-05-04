using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyInheritance
{
    class Bitkiler : BaseCanli
    {
        public void GuneseYonelme()
        {
            Console.WriteLine("Bitki güneşe yöneldi");
        }
    }
}
