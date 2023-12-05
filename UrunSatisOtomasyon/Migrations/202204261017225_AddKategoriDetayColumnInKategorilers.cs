namespace UrunSatisOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKategoriDetayColumnInKategorilers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.M_Kategoriler", "KategoriDetay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.M_Kategoriler", "KategoriDetay");
        }
    }
}
