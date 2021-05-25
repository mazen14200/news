namespace news.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_post : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.posts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true ),
                        artical_Title = c.String(),
                        artical_Body = c.String(),
                        postCreationDate = c.DateTime(nullable: false),
                        artical_Type = c.String(),
                        NumberOfViewers = c.Int(nullable: false),
                        artical_image = c.String(),
                        Editor_userNameFK = c.String(),
                        editor_name_username = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.users", t => t.editor_name_username)
                .Index(t => t.editor_name_username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.posts", "editor_name_username", "dbo.users");
            DropIndex("dbo.posts", new[] { "editor_name_username" });
            DropTable("dbo.posts");
        }
    }
}
