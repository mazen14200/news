namespace news.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTabe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.users",
                c => new
                    {
                        id = c.Int(),
                        Fname = c.String(),
                        Lname = c.String(),
                        username = c.String(nullable: false),
                        Email = c.String(),
                        password = c.String(),
                        phoneNumber = c.String(),
                        photo = c.String(),
                        userRole = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.users");
        }
    }
}
