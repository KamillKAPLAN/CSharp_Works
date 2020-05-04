using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder_YouTube
{
    public sealed class Hasta : Insan
    {
        #region Encapsulation ve Constructor Örneği

        //# region Yapıcı Method (ctor)
        //public Hasta()
        //{ }

        //public Hasta(string _ad, string _soyad, string _tc)
        //{
        //    Ad = _ad;
        //    Soyad = _soyad;
        //    TCNO = _tc;
        //}
        //#endregion

        ///* Hasta takip uygulamasını OOP kullanarak gerçekleştirmeye çalışacapız. */
        //public string Ad { get; set; }
        //public string Soyad { get; set; }
        //public Muayene[] muayene;

        //// sadece 'get' işlemi yapar 'set tanımsız.'
        //public string AdSoyad
        //{ get { return Ad + " " + Soyad; } }

        //#region Encapsulation en eski yaklaşımn.
        ///*  
        //private string _TCNO;
        //public void Set_TCNO(string tc)
        //{
        //    if (tc.Length == 11)
        //    {
        //        if (!tc.StartsWith("0"))
        //        {
        //            _TCNO = tc;
        //            return;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("TC değeri hatalı!!!");
        //    }
        //}
        //public string Get_TCNO()
        //{
        //    return _TCNO;
        //}*/
        //#endregion

        //#region Property : Özellik .NET 2.0
        //private string _TCNO;
        ///* Doğru kontrol mekanizması. */
        //public string TCNO
        //{
        //    get { return _TCNO; }
        //    set
        //    {
        //        if (value.Length < 11 || value.Length > 11 || value.StartsWith("0"))
        //        {
        //            _TCNO = "-----------";
        //        }
        //        else
        //        {
        //            if (!value.StartsWith("0"))
        //            {
        //                _TCNO = value;
        //            }
        //        }
        //    }
        //}
        //#endregion

        //#region .NET 3.5
        //public string NotRead { private get; set; }
        //public string NotEdit { get; private set; }
        //public string DefaultValue { get; set; } = "Default değer";
        //#endregion

        #endregion

        public Muayene[] Muayeneler { get; set; }
    }
}
