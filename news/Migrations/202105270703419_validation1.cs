namespace news.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validation1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.users", "photo", c => c.String(maxLength: 2000));
            AlterColumn("dbo.users", "userRole", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.users", "userRole", c => c.String(nullable: false));
            AlterColumn("dbo.users", "photo", c => c.String(nullable: false, maxLength: 2000));
        }
    }
}
