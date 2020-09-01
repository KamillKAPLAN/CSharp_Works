using System;
using System.Collections.Generic;
using System.Text;

namespace TaksiDuragiPaketi
{
    class TaksiSoforu
    {
        public string adSoyad { get; set; }
        public DateTime dogumTarihi { get; set; }
        public int getYas()
        {
            return DateTime.Today.Year - dogumTarihi.Year;
        }
    }
}
