namespace CafeBoost.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SiparisDetayUrunCascadeOff : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SiparisDetaylar", "UrunId", "dbo.Urunler");
            AddForeignKey("dbo.SiparisDetaylar", "UrunId", "dbo.Urunler", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SiparisDetaylar", "UrunId", "dbo.Urunler");
            AddForeignKey("dbo.SiparisDetaylar", "UrunId", "dbo.Urunler", "Id", cascadeDelete: true);
        }
    }
}
