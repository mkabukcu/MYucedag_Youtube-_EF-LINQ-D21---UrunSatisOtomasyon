namespace UrunSatisOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UrunSatisInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.M_Kategoriler",
                c => new
                    {
                        KategoriID = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(),
                    })
                .PrimaryKey(t => t.KategoriID);
            
            CreateTable(
                "dbo.M_Urunler",
                c => new
                    {
                        UrunID = c.Int(nullable: false, identity: true),
                        UrunAd = c.String(),
                        UrunMarka = c.String(),
                        Aciklama = c.String(),
                        UrunStok = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UrunID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.M_Urunler");
            DropTable("dbo.M_Kategoriler");
        }
    }
}
