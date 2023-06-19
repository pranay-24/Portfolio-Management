using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pm3.Models
{
    public class ETF
    {
        public int ETFID { get; set; }
        public string ETFName { get; set; }
        public int ETFBuyPrice { get; set; }

        public int ETFSellPrice { get; set; }

        public int ETFQty { get; set; }

        //An ETF can be part of many portfolios
        public ICollection<Portfolio> Portfolios { get; set; }  

    }

    public class ETFDto
    {
        public int ETFID { get; set; }
        public string ETFName { get; set; }
        public int ETFBuyPrice { get; set; }

        public int ETFSellPrice { get; set; }

        public int ETFQty { get; set; }



    }
}