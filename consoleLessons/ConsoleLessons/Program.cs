using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 01 C# Console Giris */
            /* Console.WriteLine("Kamil KAPLAN"); */

            /* 02 C# Console String  */
            /*
            string str = "Fırat Üniversitesi";
            Console.WriteLine(str);

            string county;
            county = "ELAZIĞ";
            Console.WriteLine(county);

            string isim;
            Console.Write("İsminizi Giriniz : ");
            isim = Console.ReadLine();
            Console.WriteLine("Hoşgeldiniz : " + isim);

            string ad, soyad, yas, meslek, sehir;
            Console.WriteLine("Lütfen Sırasıyla Ad, Soyad, Yaş, Meslek ve Şehirinizi Giriniz...");
            ad = Console.ReadLine();
            soyad = Console.ReadLine();
            yas = Console.ReadLine();
            meslek = Console.ReadLine();
            sehir = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ad : " + ad);
            Console.WriteLine("Soyad : " + soyad);
            Console.WriteLine("Yaş : " +  yas);
            Console.WriteLine("Meslek : " + meslek);
            Console.WriteLine("Şehir : " + sehir);

            String name;
            Console.Write("Lütfen İsminizi Giriniz : ");
            name = Console.ReadLine();
            Console.WriteLine("Merhaba {0}", name);

            string fName, lName, city;
            Console.Write("Adınız : ");
            fName = Console.ReadLine();
            Console.Write("Soyadınız : ");
            lName = Console.ReadLine();
            Console.Write("Şehriniz : ");
            city = Console.ReadLine();
            Console.WriteLine("Ad : {0}, Soyad : {1}, Şehir : {2}", fName, lName, city);
            */

            /* 03 C# Console Int  */
            /*
            int toplam, sayi1, sayi2;
            sayi1 = 5;
            sayi2 = 7;
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);

            int s1, s2, crpm;
            s1 = 8;
            s2 = 7;
            crpm = s1 * s2;
            Console.WriteLine("{0} * {1} = {2}", s1, s2, crpm);

            int bolum = (s1 + s2) / 2;
            Console.WriteLine(bolum);

            Console.WriteLine("*** Öğrenci Bilgileri ***");
            string fName, lName, number;
            int say1, say2, say3, proje, ortalama;
            fName = "Kamil";
            lName = "KAPLAN";
            number = "14542025";
            Console.WriteLine("{0} {1} - {2}", fName, lName, number);

            Console.WriteLine("*** Not Bilgisi ***");
            say1 = 60;
            say2 = 70;
            say3 = 100;
            proje = 94;
            Console.WriteLine("S1: {0}", say1);
            Console.WriteLine("S2: {0}", say2);
            Console.WriteLine("S3: {0}", say3);
            Console.WriteLine("Proje: {0}", proje);

            Console.WriteLine("*** Ortalama Bilgisi ***");
            ortalama = (say1 + say2 + say3 + proje) / 4;
            Console.WriteLine("Orrtalama: {0}", ortalama);
            */

            /* 04 C# Console Aritmetik 4 İşlem Uygulaması  */
            /*
            int number1, number2, total;
            Console.WriteLine("**** Toplama İşlemi ****");
            Console.Write("1.Sayıyı Giriniz : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            total = number1 + number2;
            Console.WriteLine("Toplam : " + total);

            int s1, s2, toplam, fark, carpim;
            double bolum;
            Console.WriteLine("**** Aritmetik 4 İşlem ****");
            Console.Write("1.Sayıyı Giriniz : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz : ");
            s2 = Convert.ToInt32(Console.ReadLine());

            toplam = s1 + s2;
            Console.WriteLine("TOPLAM : {0} + {1} = {2}", s1, s2, toplam);
            fark = s1 - s2;
            Console.WriteLine("FARK : {0} - {1} = {2}", s1, s2, fark);
            carpim= s1 * s2;
            Console.WriteLine("ÇARPIM : {0} * {1} = {2}", s1, s2, carpim);
            bolum = Convert.ToDouble(s1 / s2);
            Console.WriteLine("BÖLÜM : {0} / {1} = {2}", s1, s2, bolum);
            
            int kenar, kareAlan, kareCevre;
            int kisaKenar, uzunKenar, dikAlan, dikCevre;
            Console.WriteLine("*** Karenin Alan ve Çevresini Bulma ***");
            Console.Write("Karenin Bir Kenarı Giriniz : ");
            kenar = Convert.ToInt32(Console.ReadLine());
            kareAlan = kenar * kenar;
            kareCevre = 4 * kenar;
            Console.WriteLine("Karenin Alanı : {0}", kareAlan);
            Console.WriteLine("Karenin Çevresi : {0}", kareCevre);

            Console.WriteLine("");
            Console.WriteLine("*** Dikdörgenin Alan ve Çevresini Bulma ***");
            Console.Write("Dikdörgenin Kısa Kenarı Giriniz : ");
            kisaKenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dikdörgenin Uzun Kenarı Giriniz : ");
            uzunKenar = Convert.ToInt32(Console.ReadLine());
            dikAlan = kisaKenar * uzunKenar;
            dikCevre = 2 * kisaKenar + 2 * uzunKenar;
            Console.WriteLine("Dikdörgenin Alanı : {0}", dikAlan);
            Console.WriteLine("Dikdörgenin Çevresi : {0}", dikCevre);
            */

            /* 05 C# Console Double Değişkenler */
            /*
            Console.WriteLine("Öğrenci Not Hesaplama");
            double s1, s2, s3, proje, ort;
            string name, lastName, number;

            Console.WriteLine();
            Console.WriteLine("*** Öğrenci Kimlik Bilgileri ***");
            Console.WriteLine();
            Console.Write("Adınız : ");
            name = Console.ReadLine();
            Console.Write("Soyadınız : ");
            lastName = Console.ReadLine();
            Console.Write("Numaranız : ");
            number = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("*** Öğrenci Sınav Bilgileri ***");
            Console.WriteLine();
            Console.Write("Sınav 1 : ");
            s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sınav 2 : ");
            s2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sınav 3 : ");
            s3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Proje Notunuz : ");
            proje = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("*** Ortalama Bilgileri ***");
            Console.WriteLine();
            ort = (s1 + s2 + s3 + proje) / 4;
            Console.Write("Ortalama : {0}", ort);
            */

            /* 06 C# If Else Yapısı */
            /* 
            string name;
            name = "Kamil";
            if(name == "Kamil")
                Console.WriteLine("Doğru İsim Girişi");
            else
                Console.WriteLine("Hatalı İsim");
            
            string name2;
            Console.Write("İsminizi Giriniz : ");
            name2 = Console.ReadLine();
            if (name2 == "Kamil")
                Console.WriteLine("Doğru İsim Girişi");
            else
                Console.WriteLine("Hatalı İsim");

            int sayi;
            Console.Write("Sayı : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0)
                Console.WriteLine("Pozitif tamsayı");
            else
                Console.WriteLine("Negatif tamsayı");
            
            double s1, s2, ortalama;
            Console.Write("Not 1 : ");
            s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Not 2 : ");
            s2 = Convert.ToDouble(Console.ReadLine());
            ortalama = (s1 + s2) / 2;
            Console.WriteLine("Ortalama : {0}", ortalama);
            if (ortalama >= 50)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Geçti");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Kaldı");
            }
            */
            int snv1, snv2, proje, ort;
            Console.Write("1. Sınav Notunuz : ");
            snv1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sınav Notunuz : ");
            snv2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Proje Notunuz : ");
            proje = Convert.ToInt32(Console.ReadLine());
            ort = (snv1 + snv2 + proje) / 3;
            Console.Write("Ortalama : {0}", ort);


            Console.Read();
        }
    }
}
