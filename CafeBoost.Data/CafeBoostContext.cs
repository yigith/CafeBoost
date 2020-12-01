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
            // output penceresinde çalışan sorguları göster
            // https://stackoverflow.com/questions/1412863/how-do-i-view-the-sql-generated-by-the-entity-framework
            // Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // fluent api mapping
            // bir SiparisDetay ki
            // zorunlu bir Urun'u vardır
            // ki o Urun un birden çok SiparisDetay'ı vardır
            // ki o SiparisDetay lar UrunId alanı üzerinde foreign key ile Urun le ilişki kurar
            // ki o Urun u siler ise ona bağlı sipariş detaylar da silinMEsin
            modelBuilder
                .Entity<SiparisDetay>()
                //.ToTable("SiparisDetaylar")
                .HasRequired(x => x.Urun)
                .WithMany(x => x.SiparisDetaylar)
                //.HasForeignKey(x => x.UrunId)
                .WillCascadeOnDelete(false);
        }

        public int MasaAdet { get; set; } = 20; // default değer
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylar { get; set; }
    }
}
