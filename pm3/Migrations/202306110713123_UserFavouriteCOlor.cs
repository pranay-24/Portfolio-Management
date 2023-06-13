namespace pm3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserFavouriteCOlor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FavouriteColor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "FavouriteColor");
        }
    }
}
