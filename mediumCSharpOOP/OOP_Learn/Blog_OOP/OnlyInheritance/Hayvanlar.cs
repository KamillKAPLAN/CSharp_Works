using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyInheritance
{
    class Hayvanlar : BaseCanli
    {
        public void Kosma()
        {
            Console.WriteLine("Hayvan koştu");
        }
        
    }
}
