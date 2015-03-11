using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetStore.Models;

namespace PetStore.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult Index()
        {

            Entities context = new Entities();
            var Stock = context.Stocks;
            return View(Stock);
        }

        public ActionResult Sell(int id)
        {

            Entities context = new Entities();
            var Stock = context.Stocks;

            Stock = Stocks.Find(id);
            return View();
        }

        public ActionResult Buy(int id)
        {

            Entities context = new Entities();
            var Stock = context.Stocks;
            return View(Stock);
        }
    }
}