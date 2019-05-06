namespace EfRipositpry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _02addBodPersionfildtouserentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserEntities", "BodPersion", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserEntities", "BodPersion");
        }
    }
}
