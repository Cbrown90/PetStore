using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetStore.Models;

namespace PetStore.Controllers
{
    public class AnimalStockController : Controller
    {
        //
        // GET: /AnimalStock/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddAnimal()
        {
            var Animal = new Animal();
            return View(Animal);
        }

        public ActionResult EODReport()
        {
            Entities context = new Entities();
            var Animals = context.Animals.ToList();

            return View(Animals);
        }

        public ActionResult SellAnimal()
        {
            return View();
        }

    }
}
