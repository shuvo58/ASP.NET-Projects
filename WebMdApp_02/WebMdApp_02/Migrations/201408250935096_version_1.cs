namespace WebMdApp_02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advertises",
                c => new
                    {
                        AdvertiseId = c.Int(nullable: false, identity: true),
                        AdvertiseTitle = c.String(),
                        AdvertiseContent = c.String(),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.AdvertiseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Advertises");
        }
    }
}
