﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pm3.Models.ViewModels
{
    public class DetailsPortfolio
    {
        public PortfolioDto SelectedPortfolio { get; set; }
        public IEnumerable<StockDto> PartStocks { get; set; }
    }
}