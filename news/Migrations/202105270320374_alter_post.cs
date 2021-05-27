namespace news.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alter_post : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.posts", "editor_username", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.posts", "editor_username");
        }
    }
}
