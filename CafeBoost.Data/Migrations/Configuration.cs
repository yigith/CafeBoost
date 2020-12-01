namespace CafeBoost.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CafeBoost.Data.CafeBoostContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CafeBoost.Data.CafeBoostContext context)
        {
            if (!context.Urunler.Any())
            {
                context.Urunler.Add(new Urun() { UrunAd = "Çay", BirimFiyat = 4m });
                context.Urunler.Add(new Urun() { UrunAd = "Simit", BirimFiyat = 3.5m });
            }
        }
    }
}
