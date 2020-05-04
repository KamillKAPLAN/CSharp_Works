using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class ContainerOverload
    {
        // Kapsayıcı = Container
        public class KapsayiciClass 
        {
            private int _Number;
            public int ExampleNumber
            {
                get { return _Number; }
                set { _Number = value; }
            }
        }

        public int OverloadMethod()
        {
            return 0;
        }

        public int OverloadMethod(int number)
        {
            return number;
        }

        public int OverloadMethod(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
