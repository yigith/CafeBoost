using System;
using System.Collections.Generic;
using System.Text;

namespace CafeBoost.Data
{
    public class KafeVeri
    {
        public int MasaAdet { get; set; } = 20; // default değer
        public List<Urun> Urunler { get; set; }
        public List<Siparis> AktifSiparisler { get; set; }
        public List<Siparis> GecmisSiparisler { get; set; }

        public KafeVeri()
        {
            Urunler = new List<Urun>();
            AktifSiparisler = new List<Siparis>();
            GecmisSiparisler = new List<Siparis>();
            // MasaAdet = 20;
        }
    }
}
