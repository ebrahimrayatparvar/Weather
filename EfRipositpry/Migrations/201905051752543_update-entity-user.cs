namespace EfRipositpry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateentityuser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserEntities", "FavoritesCity", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserEntities", "FavoritesCity");
        }
    }
}
