using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder_YouTube
{
    public class Muayene
    {
        public DateTime Tarih { get; set; }
        public string Tani { get; set; }
        public Doktor Doktor { get; set; }
        public Hasta Hasta { get; set; }
    }
}
