using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRendevu
{
    public class Brans
    {
        public Brans(string isim) //Consturoctor 
        {
            bransAd=isim;
        } 

        public string bransAd { get; set; }


        public override string ToString()  //Sınıfdaki propertyleri komple ekrana yazılı olarak "override" komutu kullanılır.
        {
            return bransAd;

        }
    }
}
