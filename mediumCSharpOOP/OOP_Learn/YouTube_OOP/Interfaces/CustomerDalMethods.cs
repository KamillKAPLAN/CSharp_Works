using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class CustomerDalManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }

    class SqlServerCustomerDal : Interfaces.ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SqlServer added");
        }
        public void Update()
        {
            Console.WriteLine("SqlServer updated");
        }
        public void Delete()
        {
            Console.WriteLine("SqlServer deleted");
        }
    }

    class OracleCustomerDal : Interfaces.ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }
        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }
    }

    class MySqlCustomerDal : Interfaces.ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");
        }
        public void Update()
        {
            Console.WriteLine("MySql updated");
        }
        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }
    }
}
