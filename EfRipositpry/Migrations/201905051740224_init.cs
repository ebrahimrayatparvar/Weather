namespace EfRipositpry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserEntities", "Bod", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserEntities", "Mobile", c => c.String(maxLength: 11));
            AddColumn("dbo.UserEntities", "Command", c => c.String(maxLength: 150));
            AlterColumn("dbo.UserEntities", "Name", c => c.String(maxLength: 20));
            AlterColumn("dbo.UserEntities", "family", c => c.String(maxLength: 30));
            AlterColumn("dbo.UserEntities", "Username", c => c.String(maxLength: 30));
            AlterColumn("dbo.UserEntities", "Password", c => c.String(maxLength: 30));
            AlterColumn("dbo.UserEntities", "Email", c => c.String(maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserEntities", "Email", c => c.String());
            AlterColumn("dbo.UserEntities", "Password", c => c.String());
            AlterColumn("dbo.UserEntities", "Username", c => c.String());
            AlterColumn("dbo.UserEntities", "family", c => c.String());
            AlterColumn("dbo.UserEntities", "Name", c => c.String());
            DropColumn("dbo.UserEntities", "Command");
            DropColumn("dbo.UserEntities", "Mobile");
            DropColumn("dbo.UserEntities", "Bod");
        }
    }
}
