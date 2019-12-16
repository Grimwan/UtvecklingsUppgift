namespace DomänModellen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialiseDeltagareAndTävling : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deltagares",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Namn = c.String(),
                        TävlingsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tävling", t => t.TävlingsId, cascadeDelete: true)
                .Index(t => t.TävlingsId);
            
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
            DropForeignKey("dbo.Deltagares", "TävlingsId", "dbo.Tävling");
            DropIndex("dbo.Deltagares", new[] { "TävlingsId" });
            DropTable("dbo.Tävling");
            DropTable("dbo.Deltagares");
        }
    }
}
