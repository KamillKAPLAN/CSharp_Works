using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    interface IDatabaseOperations
    {
        int number1 { get; set; }
        int Add();
        void Delete();
        void Update();
        void getById();
    }

    class DatabaseOperations : IDatabaseOperations
    {
        public int number1 { get; set; }

        public int Add()
        { return 0; }

        public void Delete()
        { }

        public void Update()
        { }

        public void getById()
        { }
    }
}
