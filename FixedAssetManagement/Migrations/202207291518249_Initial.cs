namespace FixedAssetManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FixedAssets",
                c => new
                    {
                        FixedAssetId = c.Int(nullable: false, identity: true),
                        FixedAssetCode = c.String(),
                        Description = c.String(),
                        Location = c.String(),
                        Amount = c.Int(nullable: false),
                        PUrchaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FixedAssetId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FixedAssets");
        }
    }
}
