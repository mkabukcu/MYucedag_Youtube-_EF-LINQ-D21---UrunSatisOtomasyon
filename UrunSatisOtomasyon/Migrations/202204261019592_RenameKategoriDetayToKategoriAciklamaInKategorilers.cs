namespace UrunSatisOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameKategoriDetayToKategoriAciklamaInKategorilers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.M_Kategoriler", "KategoriAciklama", c => c.String());
            Sql("Update M_Kategoriler Set KategoriAciklama = KategoriDetay");
            DropColumn("dbo.M_Kategoriler", "KategoriDetay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.M_Kategoriler", "KategoriDetay", c => c.String());
            Sql("Update M_Kategoriler Set KategoriDetay = KategoriAciklama");
            DropColumn("dbo.M_Kategoriler", "KategoriAciklama");
        }
    }
}
