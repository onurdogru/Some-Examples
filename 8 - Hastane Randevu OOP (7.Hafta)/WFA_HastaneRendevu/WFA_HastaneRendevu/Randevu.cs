using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRendevu
{
    public class Randevu
    {
        public string TCKN { get; set; }
        public string hastaAd { get; set; }

        public string hastaSoyad { get; set; }
        public Brans bransAd { get; set; }

        public Doktor doktorAd { get; set; }

        public DateTime randevuSaat { get; set; }

    }
}
