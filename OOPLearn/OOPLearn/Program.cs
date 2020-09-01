using System;
using TaksiDuragiPaketi;
namespace OOPLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            TaksiSoforu taksici = new TaksiSoforu();
            taksici.adSoyad = "ALİ";
            taksici.dogumTarihi = new DateTime(2019,01,01);
            Console.WriteLine(taksici.getYas());

            Futbolcu f = new Futbolcu();
            f.SutCek();

        }
    }
}
