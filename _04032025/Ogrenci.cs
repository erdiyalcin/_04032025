using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04032025
{
    internal class Ogrenci
    {
        public int numara { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }

        public string Yaz()
        {
            string deger = ad + " " + soyad + "\n" + "Numara : " + numara;
            return deger;
        }
    }
}
