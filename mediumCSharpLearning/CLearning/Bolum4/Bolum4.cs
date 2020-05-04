using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLearning.Bolum4
{
    class Bolum4
    {
        public int Topla(int a, int b) { return a + b; }
        static void Yaz(object a, int b)
        {
            if (b > 10) return;
            /* değer tutmayan return komutu kullanımı sadece çıkışı sağlar */
            for (; b > 0; b--)
                Console.WriteLine("{0} : {1}", b, a);
            /*for (int i = 0; i < b; i++)
                Console.WriteLine(a); */
        }

        public static void metotlar(int a, int b = 2, int c = 4)
        {
            Console.WriteLine("a : {0}, b : {1}, c : {2}", a, b, c);
        }
    }
}
