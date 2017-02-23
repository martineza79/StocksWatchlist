using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StocksWatchlist.Models
{
    public class RetirementAccount
    {
        public static List<MutualFund> GetMutualFund() {
            return new List<MutualFund>
            {
                new MutualFund { Ticker = "VITAX", Sector = "Information Technology", StockExchange = "NASDAQ", Price = 66.35M, Investors = new List<Investor> { new Investor { InvestorId = 1, InvestorName = "Axel Roads" } } },

                new MutualFund { Ticker = "VFAIX", Sector = "Financials", StockExchange = "NYSE", Price = 29.88M, Investors = new List<Investor> { new Investor { InvestorId = 2, InvestorName = "Jessica Vera" } } },

                new MutualFund { Ticker = "VGENX", Sector = "Energy", StockExchange = "NYSE", Price = 51.86M, Investors = new List<Investor> { new Investor { InvestorId = 3, InvestorName = "Jimmy Jones" } } }

            };
        } 
    }
}