using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumCSharpLearning
{
    class Bolum1_2
    {
        public void bolum1_2_Example()
        {
            /* Değişken Faaliyet Alanı */
            {
                int x = 29;
                Console.WriteLine(x);
            }
            {
                int x = 10;
                Console.WriteLine(x);
            }

            /* Sbitler */
            {
                const double pi = 3.14;

                int x = 5, y;
                y = 10;
                // const int t = x + y; /* The expression being assigned to 't' must be constant */

                const int x2 = 5, x3 = 10;
                // x2 += 2; /* The left-hand side of an assignment must be a variable, property or indexer */
            }

            /* Değer Tipleri */
            {
                // değer tipine ilk değer verme
                int a;
                a = new int(); // yapıcı çalışır. (referans tip)
                a = 0;
                // Yukarıdaki iki satırda aynı işlemi yapar
            }
            {
                bool boolVariable = new bool();
                byte byteVariable = new byte();
                char charVariable = new char();
                decimal decimalVariable = new decimal();
                double doubleVariable = new double();
                float floatVariable = new float();

                Console.WriteLine(boolVariable);
                Console.WriteLine(byteVariable);
                Console.WriteLine(charVariable);
                Console.WriteLine(decimalVariable);
                Console.WriteLine(doubleVariable);
                Console.WriteLine(floatVariable);
            }

            /* String Türü */
            String path = "C:\\Windows\\assembly";
            Console.WriteLine(path);

            String path2 = @"C:\Windows\assembly";
            Console.WriteLine(path2);

            /* Object ve String Veri Türü */
            {
                char[] x = { 'K', 'a', 'm', 'i', 'l', };
                string s = new string(x);
                Console.WriteLine(s);
                object o = 5;
                Console.WriteLine(o);
            }

            /* Object Veri Türü */
            {
                object x;
                x = 10;
                Console.WriteLine(x.GetType());
                x = "B";
                Console.WriteLine(x.GetType());
                x = 8.78F;
                Console.WriteLine(x.GetType());
                x = false;
                Console.WriteLine(x.GetType());
                x = 5.489M;
                Console.WriteLine(x.GetType());
            }

            /* var Değişken Yapısı */
            {
                var vrDegisken = "string değer";
                // vrDegisken = 64;
                Console.WriteLine(vrDegisken);
            }

            /* dynamic Değişken Yapısı */
            {
                dynamic str = "Sentez Yazılım";
                dynamic i = 2;
                Console.WriteLine(str.GetType()); // System.String
                Console.WriteLine(i.GetType());   // System.Int32

                dynamic strValue = "Kamil ";
                string s = strValue + "KAPLAN";
                Console.WriteLine(s);             //  Kamil KAPLAN
                strValue = 12;
                strValue = 4 + strValue;
                Console.WriteLine(strValue);      // 16
            }

            /* object ve dynamic Arasındaki Farklar */
            {
                object oValue = "Kamil";
                int t = ((string)oValue).Length; // unBoxing yapılıyor.

                dynamic dValue = "Fırat Üniversitesi";
                int k = dValue.Length;

                object rakam = 10;
                // rakam = rakam + 10;
                /*
                 * Derleme zamanı hatası. Çünkü derleme 
                 * anında Rakam değişkeni "System.Object" tipinde
                 */
                rakam = (int)rakam + 10;
                /*
                 * Hatasız atama için, "unboxing" yapmamız gerekiyor.
                 */

                dynamic sayi = 5;
                sayi = sayi + 5;
                /*
                 * Hata vermez
                 */
            }

            /* bilinçsiz tür dönüşümü */
            {
                int intVlaue = 5;
                float floatValue;
                floatValue = intVlaue;
                Console.WriteLine(floatValue);
            }

            /* bilinçli tür dönüşümü */
            {
                int a = 400;
                byte b = (byte)a;
                Console.WriteLine(b); // 144
            }

            /* Checked ve Unchecked */
            {
                int intValue = 256;
                byte byteValue;
                checked // programın hata vermesi için kullanılır.
                {
                    byteValue = (byte)intValue; // Taşma olduğundan program hata verir.
                }
                Console.WriteLine(byteValue);

            }

            {
                int intValue1 = 255;
                int intValue2 = 500;
                byte byteValue1, byteValue2;

                checked
                {
                    byteValue1 = (byte)intValue1;
                    Console.WriteLine(byteValue1);

                    unchecked
                    {
                        byteValue2 = (byte)intValue2;
                        Console.WriteLine(byteValue2);
                    }
                    Console.WriteLine(byteValue2);
                }

            }

            /* Referans ve Değer Türleri Arasındaki Dönüşüm */


            /* System.Convert İle Tür Dönüşümü */
            {
                int i = 50;
                string s = "50";
                int b = Convert.ToInt32(i);
                double c = Convert.ToDouble(s);
                Console.WriteLine("b : " + b + " c: " + c); // b : 50 c: 50

                string str1, str2;
                int i1, i2, t;

                Console.Write("1. Sayıyı Giriniz : ");
                i1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("2. Sayıyı Giriniz : ");
                str2 = Console.ReadLine();
                i2 = Convert.ToInt32(str2);

                t = i1 + i2;

                Console.WriteLine("Toplam : " + t.ToString());
            }
        }
    }
}
