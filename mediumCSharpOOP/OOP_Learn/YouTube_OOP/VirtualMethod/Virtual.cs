using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class VDatabase
    {
        /* 
         * Virtual (sanal metod) ‘lar kalıtıldığı sınıflarda içeriği değiştirilebilen metodlardır. Yani 
         * temel sınfımız da bir method oluşturuyoruz. Bu methodun içeriğini ileride değiştirme ihtiyacı 
         * duyuyoruz bu gibi durumlarda methodumuza virtual anahtar kelimesini ekleyerek override (ezmek) 
         * etmeye olanak tanımış oluyoruz.
         * 
         * Sadece metod isimlerini belirteceğimiz bir classımız olsun, metodların ne işlev yapacağını diğer 
         * classlarda belirtecek isek Virtual metod kullanırız.
         * 
         * Birden çok Class larımızın, aynı anlama gelen metodları varsa, bu metodu Virtual olarak tanımlarız.
         * 
         * Yazılımda standartlaşmak önemlidir, eğer geliştirilen uygulamamızın farklı modüllerinde, metod
         * isimlerimizin aynı olması isteniyorsa, yine Virtual metod kullanırız.
         */

        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class VSqlServer : VDatabase
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            // base.Add();
        }
    }

    class VMySql : VDatabase
    {

    }
}
