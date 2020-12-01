using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace CafeBoost.Data
{
    public class CafeBoostContext : DbContext
    {
        public CafeBoostContext() : base("name=CafeBoostContext")
        {

        }

        public int MasaAdet { get; set; } = 20; // default değer
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylar { get; set; }
    }
}
