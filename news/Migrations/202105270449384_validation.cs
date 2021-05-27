namespace news.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.users", "Fname", c => c.String(nullable: false));
            AlterColumn("dbo.users", "Lname", c => c.String(nullable: false));
            AlterColumn("dbo.users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.users", "password", c => c.String(nullable: false));
            AlterColumn("dbo.users", "phoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.users", "photo", c => c.String(nullable: false, maxLength: 2000));
            AlterColumn("dbo.users", "userRole", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.users", "userRole", c => c.String());
            AlterColumn("dbo.users", "photo", c => c.String(maxLength: 2000));
            AlterColumn("dbo.users", "phoneNumber", c => c.String());
            AlterColumn("dbo.users", "password", c => c.String());
            AlterColumn("dbo.users", "Email", c => c.String());
            AlterColumn("dbo.users", "Lname", c => c.String());
            AlterColumn("dbo.users", "Fname", c => c.String());
        }
    }
}
