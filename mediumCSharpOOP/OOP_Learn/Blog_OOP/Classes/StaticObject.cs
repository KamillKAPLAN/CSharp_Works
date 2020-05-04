using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class StaticObject
    {
        public static string Property1 = "Hello ";
        public static string Property2 = "World";

        public static int PlusOne(int number)
        {
            return number + 1;
        }

        public static int Topla(int[] dizi)
        {
            int toplam = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                toplam += dizi[i];
            }
            return toplam;
        }

        public static int Cikar(int s1, int s2)
        {
            if (s1 > s2)
            {
                return s1 - s2;
            }
            else
            {
                Console.Write("1.Sayı 2.Sayıdan küçük : ");
                return 0;
            }
        }

        public void AnominTypes()
        {
            var obj = new { A = "Hello ", B = "World" };
            Console.WriteLine(obj.A + " " + obj.B);
        }
    }
}
