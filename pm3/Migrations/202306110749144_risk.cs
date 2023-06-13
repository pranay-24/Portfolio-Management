namespace pm3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class risk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Portfolios", "Risk", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Portfolios", "Risk");
        }
    }
}
