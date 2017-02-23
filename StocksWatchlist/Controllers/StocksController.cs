using StocksWatchlist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StocksWatchlist.Controllers
{
    public class StocksController : Controller
    {
        // GET: Stocks
        public ActionResult Detail(string id)
        {
            var stocks = RetirementAccount.GetMutualFund();
            return View(stocks);
        }
    }
}