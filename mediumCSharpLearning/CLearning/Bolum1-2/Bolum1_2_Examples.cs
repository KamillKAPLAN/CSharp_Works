using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolum1_2
{
    class Bolum1_2_Examples
    {
        public static void baseValueTypes()
        {
            bool bl = new bool();
            byte byt = new byte();
            sbyte sbyt = new sbyte();
            char chr = new char();
            decimal dcml = new decimal();
            double dbl = new double();
            float flt = new float();
            int nt = new int();
            uint unt = new uint();
            long lng = new long();
            ulong ulng = new ulong();
            short shrt = new short();
            ushort ushrt = new ushort();

            Console.WriteLine("Bool : " + bl);
            Console.WriteLine("Byte : " + byt);
            Console.WriteLine("SByte : " + sbyt);
            Console.WriteLine("Char : " + chr.ToString());
            Console.WriteLine("Decimal : " + dcml);
            Console.WriteLine("Double : " + dbl);
            Console.WriteLine("Float : " + flt);
            Console.WriteLine("Int : " + nt);
            Console.WriteLine("UInt : " + unt);
            Console.WriteLine("Long : " + lng);
            Console.WriteLine("ULong : " + ulng);
            Console.WriteLine("Short : " + shrt);
            Console.WriteLine("UShort : " + ushrt);
        }

        public static void referemceTypes()
        {
            Object objct = new { a = "aa", b = 1 };
            Console.WriteLine(objct);

            string s1 = "Merhaba ";
            string s2 = ".Net";
            string s3 = s1 + s2;
            Console.WriteLine(s3);

            /* Özel anlamlar ifade eden karakterleri 
             * ifade etmek için '\' ifadesi kullanılır.
             */
            String path = "C:\\Users\\kamil\\Documents\\C#_Projects\\CLearning";
            Console.WriteLine(path);

            /* String içinde görünen ifadenin aynısını belirtmek 
             * için string ifadesinin önüne '@' işereti kınulur.
             */
            String path2 = @"C:\Users\kamil\Documents\C#_Projects\CLearning";
            Console.WriteLine(path2);
        }

        public static void objectAndStringDataType()
        {
            string s = new string('a', 4);
            object o = 5;

            Console.WriteLine(s);
            Console.WriteLine(o);
        }

        public static void objectExample()
        {
            object x;
            x = 10;
            Console.WriteLine(x + " : " + x.GetType());
            x = "Kamil KAPLAN";
            Console.WriteLine(x + " : " + x.GetType());
            x = 8.78F;
            Console.WriteLine(x + " : " + x.GetType());
            x = false;
            Console.WriteLine(x + " : " + x.GetType());
            x = 5.489M;
            Console.WriteLine(x + " : " + x.GetType());
        }

        public static void varVariable()
        {
            /* Derleyicimiz bu değer atamasından sonra değişkenimizin 
             * tipini string olarak belirleyecek ve RAM
             * üzerinde string olarak tutulacaktır.
             */
            var vrDegisken = "Kamil KAPLAN";
            Console.WriteLine(vrDegisken + " : " + vrDegisken.GetType());
            /* tekrar aynı değişkenimize int tipinde değer
             * atamaya çalıştığınızda derleyici hata verecektir. 
             */
            // vrDegisken = 1453;
            Console.WriteLine(vrDegisken + " : " + vrDegisken.GetType());

            /* Hata mesajı, veri tipi string olan değişkene int tipinde değer atamaya
             * çalışıyorsunuz ya da dönüştürme yapılamıyor şeklinde de yorumlanabilir.
             * Yani var tipindeki değişkenimize ilk atadığımız değerin tipini kendine tip
             * olarak belirleyecek, sonraki atamalarda da aynı tipte değer isteyecektir.
             */
        }

        public static void dynamicVariable()
        {
            dynamic str = "Sentez Yazılım ";
            dynamic i = 2;
            Console.WriteLine(str + " : " + str.GetType());
            Console.WriteLine(i + " : " + i.GetType());

            dynamic str2 = "Kamil KAPLAN";
            string s = str2 + " C# Blog";
            Console.WriteLine(s + " : " + s.GetType());

            str2 = 12;
            str2 = 4 + str2;
            Console.WriteLine(str2 + " : " + str2.GetType());

            str = str + str2;
            Console.WriteLine(str + " : " + str.GetType());
        }

        public static void objectDifferenceBetweenDynamic()
        {
            object o = "Kamil";
            int t = ((string)o).Length; // unboxing yapılıyor.

            dynamic d = "Kamil";
            int k = d.Length;

            object rakam = 10;
            // rakam = rakam + 10;
            /* Derleme zamanı hatası.Çünkü 
             * derleme anında rakam değişkeni 
             * 'System.Object' tipinde 
             */
            rakam = (int)rakam + 10;
            /* Hatasız atama için, unboxing yapmamız 
             * gerekiyor.(daha sonra değinilecek)
             */

            dynamic sayi = 5;
            sayi = sayi + 10;
            /* Hata vermez. */
        }

        public static void impicitTypeTransformation()
        {
            int x = 5;
            float a;
            a = x;
            Console.WriteLine(x + " : " + x.GetType());
            Console.WriteLine(a + " : " + a.GetType());
        }

        public static void convertingSmallToLarge()
        {
            byte a = 128;
            int b;
            b = a;
            Console.WriteLine(a + " : " + a.GetType());
            Console.WriteLine(b + " : " + b.GetType());

            float f = 20f;
            double d;
            d = f;
            Console.WriteLine(f + " : " + f.GetType());
            Console.WriteLine(d + " : " + d.GetType());

            char c = 'a';
            decimal m;
            m = c;
            Console.WriteLine(c + " : " + c.GetType());
            Console.WriteLine(m + " : " + m.GetType());

            float f1 = 32.32f;
            double d1;
            d1 = f1;
            Console.WriteLine("f1'nin değeri : " + f1 + "\nd1'nin değeri : " + d1);
        }

        public static void explicitTypeTransformation()
        {
            int a = 400;
            byte b1 = (byte)a;
            Console.WriteLine(a + " - " + b1);

            double d1;
            int i;
            byte b;
            char c;
            uint u;
            short s;
            d1 = 0.5;

            // double int'e dönüştü veri kaybı var virgülden sonrası atılır.
            i = (int)d1;
            Console.WriteLine("Double integere çevrildi.");
            Console.WriteLine("i'nin değeri : " + i + " d1'nin değeri : " + d1);

            // int'i byte'a dönüştürdük, veri kaybı yok.
            i = 123;
            b = (byte)i;
            Console.WriteLine("Int byte'a çevrildi. Veri kaybı yok");
            Console.WriteLine("i'nin değeri : " + i + " b'nin değeri : " + b);

            // veri kaybı var.
            i = 258;
            b = (byte)i;
            Console.WriteLine("Int byte'a çevrildi. Veri kaybı var");
            Console.WriteLine("i'nin değeri : " + i + " b'nin değeri : " + b);

            // uint'i short'a dönüştürdük, veri kaybı yok.
            u = 32146;
            s = (short)u;
            Console.WriteLine("UInt short'a çevrildi. Veri kaybı yok");
            Console.WriteLine("u'nin değeri : " + u + " s'nin değeri : " + s);

            // veri kaybı var.
            u = 35000;
            s = (short)u;
            Console.WriteLine("UInt short'a çevrildi. Veri kaybı var");
            Console.WriteLine("u'nin değeri : " + u + " s'nin değeri : " + s);

            // int'i char'a dönüştür.
            i = 90;
            c = (char)i;
            Console.WriteLine("Int char'a çevrildi");
            Console.WriteLine(i + " sayısını char'a dönüştürürsek : " + c + " olur.");

            // char'ı int'e dönüştür.
            c = 'a';
            i = c;
            Console.WriteLine("Char'ı int'e çevirdi");
            Console.WriteLine(c + " karakterini int'e dönüştürürsek : " + i + " olur.");
        }

        public static void checkedAndUnChecked()
        {
            int i = 256;
            byte b;
            checked
            { // Taşma olduğundan program hata
                b = (byte)i;
            }
            Console.WriteLine(b);

            /* checked bir blok oluşturduğu için içinde yapılan değişken
             * tanımlamaları dış bloklarda kullanılamaz.
             */

            // int i1 = 256;
            checked
            {
                // byte b = (byte)i1;
            }
            // Console.WriteLine(b); // Hata verir

            int i2 = 255;
            int i3 = 500;
            byte b1, b2;

            checked
            {
                b1 = (byte)i2;
                Console.WriteLine(b1);

                unchecked
                {
                    b2 = (byte)i3;
                }
                Console.WriteLine(b2);
            }
        }

        public static void toStringMethod()
        {
            Console.WriteLine(56.ToString());
            Console.WriteLine(12.34F.ToString());

            int a = 5;
            int b = 7;
            string a1 = a.ToString();
            string b1 = b.ToString();
            Console.WriteLine("a'nın değeri : " + a + " b'nin değeri : " + b + " a + b'nin toplamı : {0}", (a + b));
            Console.WriteLine("a1'in değeri : " + a1 + " b1'in değeri : " + b1 + " a1 + b1'nin toplamı : {0}", (a1 + b1));
        }

        public static void systemConvert()
        {
            int a = 50;
            string d = "50";
            int b = Convert.ToInt32(a);
            double c = Convert.ToDouble(d);

            Console.WriteLine("b : " + b + "\nc : " + c);

            string s1, s2;
            int i1, i2, t;

            Console.Write("1.Sayıyı Giriniz : ");
            s1 = Console.ReadLine();

            Console.Write("2.Sayıyı Giriniz : ");
            s2 = Console.ReadLine();

            i1 = Convert.ToInt32(s1);
            i2 = Convert.ToInt32(s2);

            t = i1 + i2;
            Console.WriteLine("Toplam : {0}", t.ToString());

            /* Dönüşüm işleminin sonucunda anlamlı bir sonuç
             * elde edilemeyeceği durumlarda hata meydana
             * gelir.
             */

            char chr = 'a';
            bool bll = Convert.ToBoolean(chr);
            Console.WriteLine(bll);
        }
    }
}
