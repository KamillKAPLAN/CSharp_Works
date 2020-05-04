using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ---------- Property, Field and Method ---------- */
            // PropFieldMethod();            

            /* ---------- Virtual Method ---------- */
            // VirtualMethods();

            /* ---------- Interfaces ---------- */
            // InterfaceExamples();

            /* ---------- Inheritance ---------- */
            // InheritanceExammple();

            /* ---------- Abstract ---------- */
            // AbstractClassExample();

            /* ---------- Blog_OOP ---------- */

            // -- CLASSES --
            // FieldMethodClass();
            // PropMethodClass(); // Encapsulation
            // ContainerOverloadClass();
            // StaticObjectClass();
            // GenericTypeClass();

            // -- INHERITANCE --
            // InheritancesVirtualClass();
            // OnlyInheritanceClass();

            // -- INTERFACES --
            // InterfaceInheritanceClass();

            CoderYouTubeOOP();

            Console.ReadLine();
        }

        private static void PropFieldMethod()
        {
            /* Class Kullanımı 1.Yol */
            Models.CustomerModel customer = new Models.CustomerModel();
            customer.Id = 1;
            customer.FirstName = "Kamil";          /* Property'deki set blogu çalışır. */
            customer.LastName = "Kaplan";
            customer.City = "İstanbul";
            Console.WriteLine(customer.FirstName); /* Property'deki get blogu çalışır. */

            /* Class Kullanımı 2.Yol */
            Models.CustomerModel customerModel = new Models.CustomerModel
            {
                Id = 1,
                FirstName = "Melih",
                LastName = "Kaplan",
                City = "Malatya"
            };

            Methods.CustomerMethod customerMethod = new Methods.CustomerMethod();
            customerMethod.Add();

            Methods.ProductMethod productMethod = new Methods.ProductMethod();
            productMethod.Add();
        }

        private static void VirtualMethods()
        {
            VirtualMethod.VSqlServer sqlServer = new VirtualMethod.VSqlServer();
            sqlServer.Add();

            VirtualMethod.VMySql mySql = new VirtualMethod.VMySql();
            mySql.Add();
        }

        private static void InterfaceExamples()
        {
            Interfaces.LoggerManager loggerManager = new Interfaces.LoggerManager();
            loggerManager.Logger = new Interfaces.DatabaseLogger();
            loggerManager.Add();

            Interfaces.CustomerDalManager customerDalManager = new Interfaces.CustomerDalManager();
            customerDalManager.Add(new Interfaces.SqlServerCustomerDal());


            Interfaces.PersonManager personManager = new Interfaces.PersonManager();
            personManager.Add(new Interfaces.PCustomer { Id = 1, FirstName = "Kamil", LastName = "Kaplan", CAddress = "İstanbul" });

            /*Interfaces.PCustomer customer = new Interfaces.PCustomer
            {
                Id = 2,
                FirstName = "Hasan Hüseyin",
                LastName = "KAPLAN",
                CAddress = "Malatya"
            };
            personManager.Add(customer);

            Interfaces.PStudent student = new Interfaces.PStudent();
            student.Id = 1;
            student.FirstName = "Melih";
            student.LastName = "KAPLAN";
            student.SDepartmant = "Elektrik Elektronik";
            personManager.Add(student);*/


            Interfaces.ICustomerDal[] customerDal = new Interfaces.ICustomerDal[3]
            {
                new Interfaces.SqlServerCustomerDal(),
                new Interfaces.MySqlCustomerDal(),
                new Interfaces.OracleCustomerDal()
            };

            foreach (var item in customerDal)
            {
                item.Add();
            }


            Interfaces.IWork work = new Interfaces.Manager();
            work.Work();

            Interfaces.IWork[] worker =
            {
                new Interfaces.Manager(),
                new Interfaces.Worker(),
                new Interfaces.Robot()
            };

            foreach (var item in worker)
            {
                item.Work();
            }
        }

        private static void InheritanceExammple()
        {
            Inheritance.Person person = new Inheritance.Person();
            person.Id = 1;
            person.FirstName = "Kamil";
            person.LastName = "KAPLAN";
            Console.WriteLine(person.Id + " " + person.FirstName + " " + person.LastName);

            Inheritance.Person[] people =
            {
                new Inheritance.Customer{FirstName="Hasan"},
                new Inheritance.Student{ FirstName="Melih"}
            };

            foreach (var item in people)
            {
                Console.WriteLine(item.FirstName);
            }
        }

        private static void AbstractClassExample()
        {
            /* Abstract classlarımızı new anahtar sözcüğü ile kullanamayız. */
            AbstractClass.Database database = new AbstractClass.SqlServer();
            database.Add();
            database.Delete();

            AbstractClass.Database database1 = new AbstractClass.Oracle();
            database1.Add();
            database1.Delete();
        }

        private static void FieldMethodClass()
        {
            Classes.FieldMethod personel = new Classes.FieldMethod("İlyas", "Bural", 36);
            personel.FirstName = "Kamil";
            personel.LastName = "Kaplan";
            personel.Age = 26;
            personel.InformationWrtie();
            Console.WriteLine(personel.BirthDateWrite(personel.Age));
        }

        private static void PropMethodClass()
        {
            Classes.PropMethod propMethod = new Classes.PropMethod();
            propMethod.exampleProperty = "Kamil";
            propMethod.ageProperty = -3;
            Console.WriteLine("exampleProperty: " + propMethod.exampleProperty);
            Console.WriteLine("ageProperty: " + propMethod.ageProperty);
            propMethod.VoidExampleMethod();
            Console.WriteLine(propMethod.IntExampleMethod(3));
        }

        private static void ContainerOverloadClass()
        {
            Classes.ContainerOverload.KapsayiciClass exampleClass = new Classes.ContainerOverload.KapsayiciClass();
            exampleClass.ExampleNumber = 15;
            Console.WriteLine(exampleClass.ExampleNumber);

            Classes.ContainerOverload kapsayiciOverload = new Classes.ContainerOverload();
            Console.WriteLine(kapsayiciOverload.OverloadMethod(1, 4));
        }

        private static void StaticObjectClass()
        {
            Console.WriteLine(Classes.StaticObject.Property1 + Classes.StaticObject.Property2);

            Console.WriteLine(Classes.StaticObject.PlusOne(5));

            int[] dizi = { 1, 2, 3, 4, 5 };

            Console.WriteLine(Classes.StaticObject.Topla(dizi));

            Console.WriteLine(Classes.StaticObject.Cikar(5, 2));

            Classes.StaticObject staticObject = new Classes.StaticObject();
            staticObject.AnominTypes();
        }

        private static void InheritancesVirtualClass()
        {
            InheritancesVirtual.D d = new InheritancesVirtual.D();

            InheritancesVirtual.ExampleClass exampleClass = new InheritancesVirtual.ExampleClass();
            exampleClass.OzellikYazdir();

            InheritancesVirtual.Insan insan = new InheritancesVirtual.Insan();
            insan.Beslenme();
        }

        private static void InterfaceInheritanceClass()
        {
            InterfaceInheritance.DatabaseOperations databaseOperations = new InterfaceInheritance.DatabaseOperations();
            databaseOperations.number1 = 14;
            Console.WriteLine(databaseOperations.number1);
            databaseOperations.Add();
        }

        private static void GenericTypeClass()
        {
            Classes.GenericType<string> genericType = new Classes.GenericType<string>();
            genericType.Insert("Generic type kontrolü");
        }

        private static void OnlyInheritanceClass()
        {
            OnlyInheritance.BaseCanli baseCanli = new OnlyInheritance.BaseCanli();
            baseCanli.Beslenme();
            baseCanli.Hareket();
            baseCanli.Bosaltim();

            Console.WriteLine("----------");

            OnlyInheritance.Bitkiler bitkiler = new OnlyInheritance.Bitkiler();
            baseCanli.Beslenme();
            baseCanli.Hareket();
            baseCanli.Bosaltim();
            bitkiler.GuneseYonelme();

            Console.WriteLine("----------");

            OnlyInheritance.Hayvanlar hayvanlar = new OnlyInheritance.Hayvanlar();
            hayvanlar.Beslenme();
            baseCanli.Hareket();
            baseCanli.Bosaltim();
            hayvanlar.Kosma();

            Console.WriteLine("----------");

            OnlyInheritance.Kus kus = new OnlyInheritance.Kus();
            hayvanlar.Beslenme();
            baseCanli.Hareket();
            baseCanli.Bosaltim();
            hayvanlar.Kosma();
            kus.KusOlmak();
        }

        private static void CoderYouTubeOOP()
        {
            /* OOP (Nesne Yönelimli Programlama) Temel Prensipleri
             * 1. Encapsulation (Kapsüllemek)
             * 2. Inheritance (Kalıtım)
             * 3. Polymorphism (Çok biçimlilik)
             */

            /* Abstraction : 
             * ((abstract class)) : - Kensisinden kalıtımı(inheritance) yapılabilen fakat 
             *                      örneği(Instance) alınamayan sınıflar tanımlamak için kullanılır.
             *                      - Abstract bir sınıf içerisinde abstract metotlarda geliştirebiliriz.    
             *                      - Abstract olmayan bir sınıfta kesinlikle abstract metot yazılmaz.
             * 
             * ((sealed class)) : Kensisinden kalıtımı yapılmayan fakat örnek alınarak kullanılabilen 
             *                    sınıflar tanımlamak için kullanılır.
             *                    
             * ((polymorphism)) : Absctract olmayan bir metot olduğunda ve abstract bir sınıfın içinde değiliz ama
             *                    polymorphism'i kullanmak istiyoruz. Bunun için : 'virtual' keyword'ünü kullanırız.  
             * 
             * ((virtual method)) : Abstract olmayan bir sınıfta polymorphism'e temel sağlamak amaçlı
             *                      virtual method oluşturulabilir.
             */

            #region Temp
            //Coder_YouTube.Hasta h = new Coder_YouTube.Hasta(); // Intance (örnek almak)
            //h.Ad = "Kamil";
            //h.Soyad = "KAPLAN";
            /* 
             * Yanlış kontrol mekanizmazsı. 
             * string tc = Console.ReadLine();
               if (tc.Length == 11) 
               { 
                  if (!tc.StartsWith("0")) 
                  { 
                     h.TCNO = tc; 
                  } 
               }
             * bu kullanım şekli şundan dolayı hatalıdır. Code tekrarını arttırır. Eğer böyle bir mekanizma 
             * yazarsak. Bu işlemi yapan bir çok yerde code tekrarı yapılması gerekecektir.
             */
            // h.Set_TCNO("55661111233");
            // Console.WriteLine(h.Get_TCNO());

            //h.TCNO = "11111111111";
            //Console.WriteLine(h.TCNO);
            //Console.WriteLine(h.DefaultValue);
            //Console.WriteLine(h.AdSoyad);

            //Coder_YouTube.Hasta h1 = new Coder_YouTube.Hasta("Melih", "KAPLAN", "2222");
            //Console.WriteLine(h1.AdSoyad);

            Coder_YouTube.Hasta h = new Coder_YouTube.Hasta();

            Coder_YouTube.Doktor doktor = new Coder_YouTube.Doktor();
            #endregion

            #region personels
            //Coder_YouTube.Doktor d = new Coder_YouTube.Doktor();
            //d.Ad = "Kamil";
            //d.Soyad = "KAPLAN";
            //d.Maas = 3500;
            //d.TCNO = "2345678123";
            //d.Brans = "Android";

            //Coder_YouTube.Mudur s = new Coder_YouTube.Mudur
            //{
            //    // ctrl + space
            //    Ad = "İlyas",
            //    Soyad = "Bural",
            //    TCNO = "23456670534",
            //    Maas = 5000
            //};

            //Coder_YouTube.Memur m = new Coder_YouTube.Memur
            //{
            //    Ad = "Erkan",
            //    Soyad = "Selmo",
            //    TCNO = "23122312231",
            //    Maas = 3700
            //};

            //Coder_YouTube.Personel[] personeller = new Coder_YouTube.Personel[3];
            //personeller[0] = d;
            //personeller[1] = s;
            //personeller[2] = m;

            //// IkramiyeRaporu(personeller);

            //Console.WriteLine(d.ToString());
            #endregion

            Coder_YouTube.Bardak<Coder_YouTube.Kahve> b = new Coder_YouTube.Bardak<Coder_YouTube.Kahve>();
            b.Doldur(new Coder_YouTube.Kahve());
        }

        static void IkramiyeRaporu(Coder_YouTube.Personel[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine($"Personel : {p[i].Ad} {p[i].Soyad} Maaşı : {p[i].Maas} İkramiye tutarı : {p[i].IkramiyeHesapla()}");
            }
        }
    }
}
