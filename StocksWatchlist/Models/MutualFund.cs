using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StocksWatchlist.Models
{
    public class MutualFund
    {
        public string Ticker { get; set; }

        public string Sector { get; set; }

        public string StockExchange { get; set; }

        public decimal Price { get; set; }

        public List<Investor> Investors { get; set; }
    }

}