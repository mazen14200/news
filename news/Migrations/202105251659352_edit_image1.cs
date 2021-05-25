namespace news.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit_image1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.posts", "artical_Body", c => c.String(maxLength: 2000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.posts", "artical_Body", c => c.String());
        }
    }
}
