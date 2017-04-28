using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemav1
{
    class İndirimliBilet:Bilet
    {
        private string[] indirimKod = { "DEMİR", "DOĞAN", "HASAN" };
        public string[] IndirimKod
        {
            get
            {
                return indirimKod;
            }
            private set
            {

            }
        }
        public double İndirimMiktari(string kod)
        {
            
            if (kod == indirimKod[1])
                return say*FiyatTam*0.85;
            else if (kod == indirimKod[2])
                return say*FiyatTam*0.80;
            else if (kod == indirimKod[0])
                return say*FiyatTam*0.95;
            else if (kod == "")
                return say*FiyatTam;
            else
                return -1;
        }
    }
}
