using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Manager : Interfaces.IEat, Interfaces.IWork, Interfaces.ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager eat");
        }

        public void Salary()
        {
            Console.WriteLine("Manager salary");
        }

        public void Work()
        {
            Console.WriteLine("Manager work");
        }
    }

    class Worker : Interfaces.IEat, Interfaces.IWork, Interfaces.ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker eat");
        }

        public void Salary()
        {
            Console.WriteLine("Worker salary");
        }

        public void Work()
        {
            Console.WriteLine("Worker work");
        }
    }

    class Robot : Interfaces.IWork
    {
        public void Work()
        {
            Console.WriteLine("Robot work");
        }
    }
}
