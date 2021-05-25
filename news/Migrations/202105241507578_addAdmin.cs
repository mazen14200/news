namespace news.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAdmin : DbMigration
    {
        public override void Up()
        {
            Sql("insert into users values('mazen','essam','admin','mazen142000@yahoo.com','1234','01112847004','','admin')");
        }
        
        public override void Down()
        {
        }
    }
}
