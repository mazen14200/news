namespace news.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTabe1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.users");
            AlterColumn("dbo.users", "username", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.users", "username");
            DropColumn("dbo.users", "id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.users", "id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.users");
            AlterColumn("dbo.users", "username", c => c.String());
            AddPrimaryKey("dbo.users", "id");
        }
    }
}
