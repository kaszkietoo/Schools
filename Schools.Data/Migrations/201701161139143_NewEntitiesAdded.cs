namespace Schools.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewEntitiesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        UserId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        ClassId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: true)
                .Index(t => t.ClassId);
            
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FinalScore = c.String(nullable: false),
                        SubjectId = c.Long(nullable: false),
                        StudentId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.SubjectId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classes", "UserId", "dbo.Users");
            DropForeignKey("dbo.Scores", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Scores", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "ClassId", "dbo.Classes");
            DropIndex("dbo.Scores", new[] { "StudentId" });
            DropIndex("dbo.Scores", new[] { "SubjectId" });
            DropIndex("dbo.Students", new[] { "ClassId" });
            DropIndex("dbo.Classes", new[] { "UserId" });
            DropTable("dbo.Subjects");
            DropTable("dbo.Scores");
            DropTable("dbo.Students");
            DropTable("dbo.Classes");
        }
    }
}
