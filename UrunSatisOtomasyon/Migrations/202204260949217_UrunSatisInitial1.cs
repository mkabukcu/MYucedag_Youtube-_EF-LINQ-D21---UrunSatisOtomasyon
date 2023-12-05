namespace UrunSatisOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UrunSatisInitial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.M_Urunler", "Kategori_KategoriID", c => c.Int());
            CreateIndex("dbo.M_Urunler", "Kategori_KategoriID");
            AddForeignKey("dbo.M_Urunler", "Kategori_KategoriID", "dbo.M_Kategoriler", "KategoriID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.M_Urunler", "Kategori_KategoriID", "dbo.M_Kategoriler");
            DropIndex("dbo.M_Urunler", new[] { "Kategori_KategoriID" });
            DropColumn("dbo.M_Urunler", "Kategori_KategoriID");
        }
    }
}
