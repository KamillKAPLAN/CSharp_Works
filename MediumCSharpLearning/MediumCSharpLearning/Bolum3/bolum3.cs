using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumCSharpLearning
{
    class Bolum3
    {
        public static void bolum3_Example()
        {
            {
                int i = 4 + -6;
                Console.WriteLine(i);
            }

            {
                int i = 5 / 4;
                float f = 5 / 4;
                float f1 = 5f / 4f;

                Console.WriteLine(i);
                Console.WriteLine(f);
                Console.WriteLine(f1);
            }

            {
                Console.WriteLine(10 % 3);
                Console.WriteLine(2.5f % 1.2f);
            }

            {
                int a = 5, b = 10, c = 20, d = 50;
                float f = 3.4f;
                a++;
                ++b;
                c--;
                --d;
                f++;
                Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", a, b, c, d, f);
                Console.WriteLine("a + c : {0}", a + c);
            }

            {
                int a = 10, b, c;
                b = a++;
                c = ++a;

                Console.WriteLine("a : {0}", a);
                Console.WriteLine("b : {0}", b);
                Console.WriteLine("c : {0}", c);
            }

            {
                int a = 10, b = 15;
                if (a == b) Console.WriteLine("a = b");
                if (a < b) Console.WriteLine("a < b");
                if (a > b) Console.WriteLine("a > b");
                if (a != b) Console.WriteLine("a != b");
                if (a >= b) Console.WriteLine("a >= b");
                if (a <= b) Console.WriteLine("a <= b");
            }

            /* if Deyimi */
            {
                string s;
                int a, b, c;
                Console.Write("1. sayıyı giriniz : ");
                // s = Console.ReadLine();
                s = "1";
                a = Int32.Parse(s);
                Console.Write("2. sayıyı giriniz : ");
                // s = Console.ReadLine();
                s = "1";
                b = Int32.Parse(s);
                Console.Write("3. sayıyı giriniz : ");
                s = "1";
                // s = Console.ReadLine();
                c = Int32.Parse(s);
                if (a >= b && a >= c) Console.WriteLine("Enbüyük : " + a);
                else if (b >= c) Console.WriteLine("Enbüyük : " + b);
                else Console.WriteLine("Enbüyük : " + c);
            }

            /* switch Deyimi */
            {
                /*
                 * Her case ifadesinin bir atlama (break, goto , return , continue )
                 * ifadesi ile sonlandırmalıyız.
                 */
                int a;
                Console.Write("Kaçıncı sınıftasınız : ");
                // a = Int32.Parse(Console.ReadLine());
                a = 4;
                switch (a)
                {
                    case 0:
                    case 1: Console.WriteLine("Daha yenisiniz"); break;
                    case 2: Console.WriteLine("Mirasçınız"); break;
                    case 3: Console.WriteLine("Ev sahibisiniz"); break;
                    case 4: Console.WriteLine("Misafirsiniz"); break;
                    default: Console.WriteLine("Siz okulu uzatmışsınız"); break;
                }
            }

            /* Döngüler */
            // For
            {
                for (int i = 1, j = 10; (i <= 10) & (j >= 1); i++, j--)
                {
                    Console.WriteLine(i + "- " + j);
                }
            }

            // while
            {
                int i = 0;
                while (i < 1000)
                {
                    i += 5;
                    Console.WriteLine("{0,5}", i);
                    if (i % 50 == 0) Console.WriteLine();
                }
            }

            // foreach
            {
                string[] isimler = { "Kamil", "HAsan", "Ali", "Hüseyin", "Melih" };
                foreach (var item in isimler)
                {
                    Console.WriteLine(item);
                }
            }

            // jump
            {
                int sayi, t = 0;
                while (true)
                {
                    Console.Write("Negatif bir sayı girin: ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi == 0) break;
                    if (sayi > 0)
                    {
                        Console.WriteLine("Pozitif sayı girdiniz, repeat");
                        continue;
                    }
                    t = t + sayi;
                }
                Console.WriteLine("Toplam : {0}", t);
            }

            // System.Random
            {
                Random rnd = new Random();
                Console.WriteLine(rnd.Next(20));
            }

            {
                Random rnd = new Random();

                for (int i = 0; i <= 5; i++)
                {
                    for (int j = 0; j <= 5; j++)
                    {
                        i = rnd.Next(10);
                        j = rnd.Next(5);
                        Console.WriteLine(i + "" + j);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
