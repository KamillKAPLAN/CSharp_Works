using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class PropMethod
    {
        // Encapsulation
        private string exampleField;
        private int exampleAge;
        /* okuma ve atama işlemlerinde herhangi bir aksiyon almak
         * istediğimizde 'get' ve 'set' 'leri kullanırız.
         */
        public string exampleProperty
        {
            /* Field'daki data get ediliyor. */
            get { return "Sayın. " + exampleField; }
            /* Field'daki data set ediliyor. */
            set { exampleField = value; }
        }

        public int ageProperty
        {
            get { return exampleAge; }
            set
            {
                if (value < 0 || value > 100)
                {
                    exampleAge = 0;
                }
                else
                {
                    exampleAge = value;
                }
            }
        }

        /* erisimBelirteci donusTipi metodAdı(optional Parametreler)
           { } 
         */

        /* parametresiz method */
        public void VoidExampleMethod()
        {
            Console.WriteLine("Parametresiz Method");
        }

        /* parametreli method 
         * (erişimBelirteci belirtilmezse 'private' olarak kabul edilir.) 
         */
        public int IntExampleMethod(int value)
        {
            Console.WriteLine("Parametreli Method");
            return value;
        }

        ~PropMethod()
        {
            Console.WriteLine("Burası yıkıcı method");
        }
    }
}
