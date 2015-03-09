using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetStore.Controllers
{
    public class VaccinationCheckController : Controller
    {
        // GET: VaccinationCheck
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VaccinateAnimal()
        {
            return View();
        }
    }
}