namespace pm3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class etf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ETFs", "ETFBuyPrice", c => c.Int(nullable: false));
            AddColumn("dbo.ETFs", "ETFSellPrice", c => c.Int(nullable: false));
            AddColumn("dbo.ETFs", "ETFQty", c => c.Int(nullable: false));
            DropColumn("dbo.ETFs", "StockBuyPrice");
            DropColumn("dbo.ETFs", "StockSellPrice");
            DropColumn("dbo.ETFs", "StockQty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ETFs", "StockQty", c => c.Int(nullable: false));
            AddColumn("dbo.ETFs", "StockSellPrice", c => c.Int(nullable: false));
            AddColumn("dbo.ETFs", "StockBuyPrice", c => c.Int(nullable: false));
            DropColumn("dbo.ETFs", "ETFQty");
            DropColumn("dbo.ETFs", "ETFSellPrice");
            DropColumn("dbo.ETFs", "ETFBuyPrice");
        }
    }
}
