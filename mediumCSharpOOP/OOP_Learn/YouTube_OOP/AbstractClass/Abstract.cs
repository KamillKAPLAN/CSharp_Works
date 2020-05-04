using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Database
    {
        /* Tamamlanmış method */
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        /* Tamamlanmamış method. 
         * Abstract içi dolu olmayan virtual method'dur. 
         */
        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
