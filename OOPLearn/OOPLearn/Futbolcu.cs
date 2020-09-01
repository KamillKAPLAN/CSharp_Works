using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLearn
{
    class Futbolcu: Insan
    {
        public List<string> OynadigiTakimlar;

        public virtual string SutCek()
        {
            return "Ortalama bir şut çekebilirim.";
        }
    }
}
