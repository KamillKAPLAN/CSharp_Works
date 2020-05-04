using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLearning.Bolum3
{
    class Bolum3
    {
        public static void operatorler()
        {
            /* Operatör Önceliği */
            Console.WriteLine("6 + 8 * 10 : {0}", 6 + 8 * 10); // 86
            Console.WriteLine("((7 + (6 + 4) * 5) * 2) : {0}", ((7 + (6 + 4) * 5) * 2)); // 114

            Console.WriteLine("\n5 * 4 / 6 : {0}", (5 * 4 / 6)); // 3
            Console.WriteLine("5 * (4 / 6) : {0}", (5 * (4 / 6))); // 0 
            Console.WriteLine("4 + -6 : {0}", (4 + -6)); // -2

            Console.WriteLine("\n(5 / 4) : {0} \n(5f /4f) : {1}", (5 / 4), (5f / 4f)); // + , ‐, * ve / operatörleri

            Console.WriteLine("\n(10 % 3) : {0} \n(2.5f % 1.2f) : {1}", (10 % 3), (2.5f % 1.2f)); // % operatörleri

            int a = 5; int b = 10; int c = 20; int d = 50; float f = 3.4f;
            a++; ++b; c--; --d; f++;
            Console.WriteLine("\na++ : {0} \n++b : {1} \nc-- : {2} \n--d : {3} \nf++ {4}", a, b, c, d, f); // ++ ve -- operatörleri

            int a1 = 10, b1, c1;
            b1 = a1++; c1 = ++a1;
            Console.WriteLine("\na1 : {0} \nb1 : {1} \nc1 : {2}", a1, b1, c1); // ++ ve -- operatörleri

            // Karşılaştırma Operatörü
            int a2 = 10, b2 = 15;
            if (a2 == b2) Console.WriteLine("a, b'ye eşittir");
            if (a2 < b2) Console.WriteLine("a, b'denküçüktür");
            if (a2 > b2) Console.WriteLine("a, b'denbüyüktür");
            if (a2 != b2) Console.WriteLine("a, b'ye eşit değil");
            if (a >= b) Console.WriteLine("a, b'ye eşittir veya büyüktür");
            if (a <= b) Console.WriteLine("a, b'ye eşittir veya küçüktür");

            /* Mantıksal Operatörler 
             * (& AND, | OR, ! NOT, && Kısa Devre AND, || Kısa Devre OR) */
            Console.WriteLine("\n{0} - {1}", (25 < 15 && 5 == 50), (25 > 15 && 5 != 50)); // && operatörü
            Console.WriteLine("{0} - {1}", (25 < 15 || 5 == 50), (25 > 15 || 5 != 50));   // || operatörü
            Console.WriteLine("{0} - {1}", !(25 < 10), !(10 != 20));                      // !  operatörü

            if (true ^ false) Console.WriteLine("true ^ false : {0}", (true ^ false));
            if (true && false) Console.WriteLine("true && false : {0}", (true && false));
            if (true || false) Console.WriteLine("true || false : {0}", (true || false));

            /* Bit Tabanlı(Bitwise) Operatörler 
             * (& Bit tabanlı AND, | Bit tabanlı OR, ^ Bit tabanlı XOR, 
             *  >> sağa kaydırma, << sola kaydırma), ~ Birin tümleyeni 
             *  
             *  Bitsel operatörler sayıları ikilik olarak ele alır ve her bitlerinde işlem
             *  gerçekleştirirler Bitsel operatörler tamsayılarda kullanılır, gerçek sayılarda
             *  kullanılamaz Bitsel operatörlerde bool türünden ifadeler kullanılırsa
             *  mantıksal işlemler gerçekleştirir.
             *  Bu operatörler bitlerin durumlarını öğrenmek veya belirli bitlerin
             *  değerlerini değiştirmek için kullanılabilir.
             *  
             *  ~ (Bitsel DEĞİL)
             *  Tek operand alan operatörü bir değer içindeki bitlerin teker teker tersini alır.
             *  0000 1111 sayısının bitsel değili 1111 0000 olur.
             *  
             */
            byte byt1 = 254;
            byte byt2 = (byte)~byt1;
            Console.WriteLine("~ Bitsel DEĞİL : \n{0}", byt2); // 1

            byte byt3 = 153;
            byte byt4 = 104;
            // İki operandın bitlerini karşılıklı olarak VE işlemine tabi tutar.
            Console.WriteLine("& Bitsel AND : {0}", (byte)(byt3 & byt4)); // 8

            // İki operandın bitlerini karşılıklı olarak VEYA işlemine tabi tutar.
            Console.WriteLine("| Bitsel OR : {0}", (byte)(byt3 | byt4)); // 249

            // İki operandın bitlerini karşılıklı olarak Özel VEYA (XOR) işlemine tabi tutar.
            Console.WriteLine("^ (Bitsel Özel OR) : {0}", (byte)(byt3 ^ byt4)); // 241

            /* ? Operatörü 
             * Bir koşulu karşılaştırıp doğru ya da yanlış olduğu durumlar
             * için farklı değerler üretmeyi sağlayan operatördür. Üç tane operanda sahiptir. Kullanımı:
             * koşul ? doğru değeri : yanlış değeri
             */
            Console.WriteLine(25 > 10 ? "25 10'dan büyük" : "25 10'dan küçük"); // 25 10'dan büyük

            /* new Operatörü :
             * Yeni bir nesne oluşturmak için kullanılan operatördür.
             * Değer ve referans tiplerden yeni bir nesne oluşturmak için kullanılabilir
             * Örnek : Sinif s = new Sinif
             */

            /* checked ve unchecked Operatörleri : 
             * Büyük türün küçük türe dönüşümde taşma meydana geldiğinde 
             * uyarı veren ( checked ) veya taşmayı göz ardı eden
             * ( unchecked ) oparatörlerdir.
             */

            Type t;
            int int1 = 123;
            float float1 = 23.45F;

            t = typeof(int);
            Console.WriteLine("\n{0}", t.ToString());
            Console.WriteLine("{0}", int1.ToString());

            t = typeof(float);
            Console.WriteLine("\n{0}", t.ToString());
            Console.WriteLine("{0}", float1.ToString());
        }

        public static void akisKontrolMekanizmalari()
        {

            // ----- IF Deyimi -----
            int s1, s2, s3;
            Console.Write("1.sayıyı giriniz : ");
            s1 = Int32.Parse(Console.ReadLine());
            Console.Write("2.sayıyı giriniz : ");
            s2 = Int32.Parse(Console.ReadLine());
            Console.Write("3.sayıyı giriniz : ");
            s3 = Int32.Parse(Console.ReadLine());
            if (s1 >= s2 && s1 >= s3) Console.WriteLine("Enbyük : " + s1);
            else if (s2 >= s3) Console.WriteLine("Enbüyük : " + s2);
            else Console.WriteLine("Enbüyük : " + s3);

            // SWITCH Deyimi
            int classNumber;
            Console.Write("Kaçıncı sınıftasınız : ");
            classNumber = Int32.Parse(Console.ReadLine());
            switch (classNumber)
            {
                case (0): // ifade yok
                case (1): Console.WriteLine("Daha yenisiniz..."); break;
                case (2): Console.WriteLine("Mirasçınız..."); break;
                case (3): Console.WriteLine("Ev sahibisiniz..."); break;
                case (4): Console.WriteLine("Misafirsiniz..."); break;
                default: Console.WriteLine("Siz okulu uzatmışsınız..."); goto case (1);
            }

            int sayi1 = 1;
            switch (sayi1)
            {
                case (0):
                case (1): Console.WriteLine("Daha yrnisiniz..."); break;
                case (4): break;
                    // default: // Derleme zamanı hatası verir.(son ifade boş olamaz.)
            }
        }

        public static void loops()
        {
            // FOR Döngüsü
            Console.Write("Bir sayı giriniz : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 1; i <= n; i++)
            {
                toplam += i;
            }
            Console.WriteLine("1\'den {0}\'e kadar olan sayıların toplamı {1}\'dir.", n, toplam);

            // WHILE ve DO - WHILE Döngüsü
            int i2 = 0;
            while (i2 < 100)
            {
                i2 += 5;
                Console.WriteLine("{0,5}", i2);
                if (i2 % 50 == 0) Console.WriteLine();
            }

            // FOREACH Döngüsü
            string[] names = { "Kamil", "İlyas", "Aziz", "Azize", "Tuğba", "Arda" };
            foreach (string item in names)
            {   // elemanlar yazdırılıyor. (item sadece okunur(readonly))
                Console.WriteLine(item);
            }

            /* JUMP ( atlama ) Deyimleri 
             * break    : Çalışan bir döngüden “break” sözcüğü kullanılarak çıkılabilir. 
             *            Program akışı döngüden sonraki satırlardan devam eder.
             *            break sözcüğü sadece döngü ve switch ifadelerinde kullanılabilir.
             * continue : Döngünün bir sonraki tekrarına geçilmesini sağlar.    
             * goto     : Programın etiket ile belirlenmiş herhangi bir kısmına atlamak için kullanılır.
             * return   : Metotların herhangi bir anda sonlandırılması için kullanılır. 
             *            Metot sonlandırıldıktan sonra programın akışı
             */
            int sayi, t = 0;
            while (true)
            {
                Console.Write("Negatif bir sayı giriniz : ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0) break;
                if (sayi > 0)
                {
                    Console.WriteLine("Pozitif sayı giriniz, tekrar deneyin...");
                }
                t = t + sayi;
            }
            Console.WriteLine("Toplam : {0}", t);

            /* Random Sınıfı : Rastgele sayı üretmek için .NET Framework 
             *                 sınıf kütüphanesindeki 'System Random' 
             *                 sınıfı kullanılır.
             *                 Random rnd = new Random();
             *                 rnd nesnesini oluşturdurktan sonra, bu nesnenin metodlarına erişebiliriz.
             */
            Random rnd = new Random();
            int rndIntSayi;
            rndIntSayi = rnd.Next(10, 20);
            // 10 ile 20 arasında bir sayı üretir. (10 dahil 20 hariç)
            rndIntSayi = rnd.Next(50);
            // 0 ile 50 arasında bir sayı üretir.
            rndIntSayi = rnd.Next();
            // Herhangi bir rastgele sayı üretir.
            double rndDblSayi = rnd.NextDouble();
            // 0.0 ile 1 arasında bir sayı üretir
        }

        public static void arrays()
        {
            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Çalışma zamanında dizinin boyutunu belirleme
            Console.Write("Dizinin boyutunu giriniz : ");
            int boyut = Convert.ToInt32(Console.ReadLine());
            bool[] boolArray = new bool[boyut];
            for (int i = 0; i < boyut; i++)
                Console.Write(boolArray[i] + " - ");

            int k = 0;
            int[] newDizi = new int[10]; // diziye ait nesne oluşturuyoruz.
            k = newDizi.Length;
            Console.WriteLine("\nDizinin uzunluğu : " + k);

            // diziye rastgele değer ataması
            Random rnd = new Random();
            int[] rndDizi = new int[3];
            rndDizi[0] = rnd.Next(2, 10);
            rndDizi[1] = rnd.Next(50);
            rndDizi[2] = rnd.Next();
            for (int i = 0; i < rndDizi.Length; i++)
            {
                Console.Write(i + "-");
            }
            Console.WriteLine();
            // veya
            foreach (var item in rndDizi)
            {
                Console.Write(item + "-");
            }
            Console.WriteLine();

            // Çok Boyutlu Diziler 
            int[,] multiplyDizi = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,] multiplyDizi2 = new int[3, 2];

            int[,] array = new int[4, 4];
            int sayac = 1;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = sayac;
                    array[j, i] = sayac;
                    sayac++;
                }
            sayac = 1;
            foreach (int x in array)
            {
                if (sayac % 4 == 0)
                {
                    Console.Write(x + " ");
                    Console.WriteLine();
                }
                else
                    Console.Write(x + " ");
                sayac++;
            }
            Console.WriteLine();

            // Düzensiz Diziler(Jagged Arrays)
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[4];
            // jaggedArray dizisinin satır sayısı
            Console.WriteLine("jaggedArray dizisinin satır sayısı : " + jaggedArray.GetLength(0));
            // 2. satırdaki sütun sayısı
            Console.WriteLine("2. satırdaki sütun sayısı : " + jaggedArray[2].GetLength(0));

            int[][] jaggedArray2 = new int[3][];
            jaggedArray2[0] = new int[] { 1, 2 };
            jaggedArray2[1] = new int[] { 3, 4, 5, 6, 7 };
            jaggedArray2[2] = new int[] { 8, 9, 0 };
            for (int i = 0; i < jaggedArray2.GetLength(0); i++)
                for (int j = 0; j < jaggedArray2[i].GetLength(0); j++)
                    Console.WriteLine("jaggedArray2[{0}][{1}] = {2}", i, j, jaggedArray2[i][j]);
            for (int i = 0; i < jaggedArray2.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArray2.Length; j++)
                {

                }
            }
        }

        public static void systemArray()
        {
            // GetLength
            int[,,] dizi = new int[5, 4, 3];
            Console.Write("GetLength : " + dizi.GetLength(0) + ", ");
            Console.Write(dizi.GetLength(1) + ", ");
            Console.WriteLine(dizi.GetLength(2));

            // GetUpperBound
            Console.Write("GetUpperBound : " + dizi.GetUpperBound(0) + ", ");
            Console.Write(dizi.GetUpperBound(1) + ", ");
            Console.WriteLine(dizi.GetUpperBound(2));

            // Rank 
            Console.WriteLine("Rank : " + dizi.Rank);

            // GetValue
            int[] tekDizi = { 1, 22, 34 };
            Console.WriteLine(tekDizi.GetValue(2));
            Console.WriteLine(tekDizi[2]);

            // SetValue
            tekDizi.SetValue(20, 0);
            foreach (var item in tekDizi)
            {
                Console.Write(item + "-");
            }
            Console.WriteLine();

            // Resize
            string[] iller = new string[2];
            iller[0] = "İstanbul";
            iller[1] = "Ankara";
            Array.Resize(ref iller, 3);
            iller[2] = "Elazığ";
            foreach (var item in iller)
            {
                Console.Write(item + "-");
            }
            Console.WriteLine();

            // CopyTo
            int[] copyDizi = { 1, 2, 3, 4, 5, 6, 7 };
            int[] toDizi = new int[10];
            copyDizi.CopyTo(toDizi, 3);
            foreach (var item in toDizi)
            {
                Console.Write(item + "-");
            }

            // Array.Copy

            // Array.Sort

            // Array BinarySearch

            // Clear ()

            // Reverse()

            // ArrayList
            Console.WriteLine();

            string[] isimler = { "ali", " ahmet", " selda", " canan", "melike" };
            Console.Write("aranan isim : ");
            string aranan = Console.ReadLine();
            foreach (var ss in isimler)
            {
                if (aranan.Equals(isimler[0]))
                {
                    Console.WriteLine("aranan isim bulundu...");
                    break;
                }
                else
                {
                    Console.WriteLine("isim yok");
                    break;
                }
            }
        }
    }
}
