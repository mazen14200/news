namespace news.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_post1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.posts", "NumberOfViewers", c => c.Int());
            DropColumn("dbo.posts", "Editor_userNameFK");
        }
        
        public override void Down()
        {
            AddColumn("dbo.posts", "Editor_userNameFK", c => c.String());
            AlterColumn("dbo.posts", "NumberOfViewers", c => c.Int(nullable: false));
        }
    }
}
