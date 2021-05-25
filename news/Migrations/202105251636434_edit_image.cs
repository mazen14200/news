namespace news.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit_image : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.posts", "artical_image", c => c.String(maxLength: 2000));
            AlterColumn("dbo.users", "photo", c => c.String(maxLength: 2000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.users", "photo", c => c.String());
            AlterColumn("dbo.posts", "artical_image", c => c.String());
        }
    }
}
