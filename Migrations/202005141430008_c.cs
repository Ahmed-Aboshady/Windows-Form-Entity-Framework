namespace CoursesCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.course",
                c => new
                    {
                        crsid = c.Int(nullable: false),
                        crsname = c.String(nullable: false, maxLength: 50),
                        duration = c.Int(),
                    })
                .PrimaryKey(t => t.crsid);
            
            CreateTable(
                "dbo.student",
                c => new
                    {
                        stuid = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        emali = c.String(nullable: false, maxLength: 50),
                        password = c.Int(nullable: false),
                        cid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.stuid);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.student");
            DropTable("dbo.course");
        }
    }
}
