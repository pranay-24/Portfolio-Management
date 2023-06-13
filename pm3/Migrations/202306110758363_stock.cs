namespace pm3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stock : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        StocksID = c.Int(nullable: false, identity: true),
                        StockName = c.String(),
                        StockBuyPrice = c.Int(nullable: false),
                        StockSellPrice = c.Int(nullable: false),
                        StockQty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StocksID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stocks");
        }
    }
}
