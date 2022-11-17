using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRendevu
{
    public class Doktor
    {
        public Doktor (string isim) //Doktor Adımız isim, vereceğimiz isim bizim doktorAd'ımız olur. Constructor yaparız
        {
            doktorAd = isim;
        }
        public string doktorAd { get; set; }

        public Brans bransAd { get; set; }

        public static List<Doktor> doktorlarListesi=new List<Doktor>(); //static komutunu yazarsak heryerden çekebiliriz.




    }
}
