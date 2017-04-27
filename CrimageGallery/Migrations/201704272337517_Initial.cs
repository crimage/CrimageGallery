namespace CrimageGallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        FileId = c.Int(nullable: false, identity: true),
                        FileName = c.String(maxLength: 255),
                        ContentType = c.String(maxLength: 100),
                        Content = c.Binary(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.FileId);
            
            AlterColumn("dbo.Categories", "Image_FileId", c => c.Int());
            AlterColumn("dbo.Images", "UserImage_FileId", c => c.Int());
            CreateIndex("dbo.Categories", "Image_FileId");
            CreateIndex("dbo.Images", "UserImage_FileId");
            AddForeignKey("dbo.Categories", "Image_FileId", "dbo.Files", "FileId");
            AddForeignKey("dbo.Images", "UserImage_FileId", "dbo.Files", "FileId");
            DropColumn("dbo.Categories", "Image_FileName");
            DropColumn("dbo.Categories", "Image_ContentType");
            DropColumn("dbo.Categories", "Image_Content");
            DropColumn("dbo.Images", "UserImage_FileName");
            DropColumn("dbo.Images", "UserImage_ContentType");
            DropColumn("dbo.Images", "UserImage_Content");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Images", "UserImage_Content", c => c.Binary());
            AddColumn("dbo.Images", "UserImage_ContentType", c => c.String(maxLength: 100));
            AddColumn("dbo.Images", "UserImage_FileName", c => c.String(maxLength: 255));
            AddColumn("dbo.Categories", "Image_Content", c => c.Binary());
            AddColumn("dbo.Categories", "Image_ContentType", c => c.String(maxLength: 100));
            AddColumn("dbo.Categories", "Image_FileName", c => c.String(maxLength: 255));
            DropForeignKey("dbo.Images", "UserImage_FileId", "dbo.Files");
            DropForeignKey("dbo.Categories", "Image_FileId", "dbo.Files");
            DropIndex("dbo.Images", new[] { "UserImage_FileId" });
            DropIndex("dbo.Categories", new[] { "Image_FileId" });
            AlterColumn("dbo.Images", "UserImage_FileId", c => c.Int(nullable: false));
            AlterColumn("dbo.Categories", "Image_FileId", c => c.Int(nullable: false));
            DropTable("dbo.Files");
        }
    }
}
