using System;
using System.Collections.Generic;
using System.Text;

namespace CafeBoost.Data
{
    public class Urun
    {
        public string UrunAd { get; set; }
        public decimal BirimFiyat { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1:0.00}₺)", UrunAd, BirimFiyat); 
        }
    }
}
