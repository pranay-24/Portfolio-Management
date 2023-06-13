namespace pm3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class portfolio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Portfolios",
                c => new
                    {
                        PortfolioID = c.Int(nullable: false, identity: true),
                        PortfolioName = c.String(),
                    })
                .PrimaryKey(t => t.PortfolioID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Portfolios");
        }
    }
}
