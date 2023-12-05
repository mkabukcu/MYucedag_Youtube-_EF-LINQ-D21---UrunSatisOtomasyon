namespace UrunSatisOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMusteriSehirColumnInMusterilers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.M_Musteriler", "MusteriSehir", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.M_Musteriler", "MusteriSehir");
        }
    }
}
