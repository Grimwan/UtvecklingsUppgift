namespace DomänModellen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTävlingAndDeltagare : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deltagares",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Namn = c.String(),
                        Tävling_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tävling", t => t.Tävling_ID)
                .Index(t => t.Tävling_ID);
            
            CreateTable(
                "dbo.Tävling",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Namn = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Deltagares", "Tävling_ID", "dbo.Tävling");
            DropIndex("dbo.Deltagares", new[] { "Tävling_ID" });
            DropTable("dbo.Tävling");
            DropTable("dbo.Deltagares");
        }
    }
}
