namespace pm3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class etfstocks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ETFs",
                c => new
                    {
                        ETFID = c.Int(nullable: false, identity: true),
                        ETFName = c.String(),
                        StockBuyPrice = c.Int(nullable: false),
                        StockSellPrice = c.Int(nullable: false),
                        StockQty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ETFID);
            
            CreateTable(
                "dbo.ETFPortfolios",
                c => new
                    {
                        ETF_ETFID = c.Int(nullable: false),
                        Portfolio_PortfolioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ETF_ETFID, t.Portfolio_PortfolioID })
                .ForeignKey("dbo.ETFs", t => t.ETF_ETFID, cascadeDelete: true)
                .ForeignKey("dbo.Portfolios", t => t.Portfolio_PortfolioID, cascadeDelete: true)
                .Index(t => t.ETF_ETFID)
                .Index(t => t.Portfolio_PortfolioID);
            
            CreateTable(
                "dbo.StockPortfolios",
                c => new
                    {
                        Stock_StocksID = c.Int(nullable: false),
                        Portfolio_PortfolioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Stock_StocksID, t.Portfolio_PortfolioID })
                .ForeignKey("dbo.Stocks", t => t.Stock_StocksID, cascadeDelete: true)
                .ForeignKey("dbo.Portfolios", t => t.Portfolio_PortfolioID, cascadeDelete: true)
                .Index(t => t.Stock_StocksID)
                .Index(t => t.Portfolio_PortfolioID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockPortfolios", "Portfolio_PortfolioID", "dbo.Portfolios");
            DropForeignKey("dbo.StockPortfolios", "Stock_StocksID", "dbo.Stocks");
            DropForeignKey("dbo.ETFPortfolios", "Portfolio_PortfolioID", "dbo.Portfolios");
            DropForeignKey("dbo.ETFPortfolios", "ETF_ETFID", "dbo.ETFs");
            DropIndex("dbo.StockPortfolios", new[] { "Portfolio_PortfolioID" });
            DropIndex("dbo.StockPortfolios", new[] { "Stock_StocksID" });
            DropIndex("dbo.ETFPortfolios", new[] { "Portfolio_PortfolioID" });
            DropIndex("dbo.ETFPortfolios", new[] { "ETF_ETFID" });
            DropTable("dbo.StockPortfolios");
            DropTable("dbo.ETFPortfolios");
            DropTable("dbo.ETFs");
        }
    }
}
