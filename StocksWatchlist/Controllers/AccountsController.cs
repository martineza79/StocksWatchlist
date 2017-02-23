using StocksWatchlist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StocksWatchlist.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Accounts()
        {
            var ira = RetirementAccount.GetMutualFund();
            return View(ira);
        }
    }
}