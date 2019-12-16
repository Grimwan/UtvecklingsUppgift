namespace DomänModellen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedDeltagareAndTävling : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deltagares",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Namn = c.String(),
                        TävlingsID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tävling", t => t.TävlingsID, cascadeDelete: true)
                .Index(t => t.TävlingsID);
            
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
            DropForeignKey("dbo.Deltagares", "TävlingsID", "dbo.Tävling");
            DropIndex("dbo.Deltagares", new[] { "TävlingsID" });
            DropTable("dbo.Tävling");
            DropTable("dbo.Deltagares");
        }
    }
}
