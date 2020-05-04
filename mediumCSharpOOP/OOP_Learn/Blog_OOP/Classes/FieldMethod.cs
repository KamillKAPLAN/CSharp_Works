using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class FieldMethod
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public FieldMethod()
        { }

        public FieldMethod(string FirstName, string LastName, int Age)
        {
            Console.WriteLine("Constructor Method : " + FirstName + " " + LastName + " " + Age);
        }

        public void InformationWrtie()
        {
            Console.WriteLine(FirstName + " " + LastName + " " + Age);
        }

        public int BirthDateWrite(int _Age)
        {
            Age = (DateTime.Now).Year - _Age;
            return Age;
        }
    }
}
