using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetStore.Models;

namespace PetStore.Controllers
{
    public class VaccinationCheckController : Controller
    {
        // GET: VaccinationCheck
        public ActionResult Index()
        {
            Entities context = new Entities();
            var Animals =
                from a in context.Animals
                where a.OwnerID == null
                select a;

            return View(context.Animals);
        }

        public ActionResult VaccinateAnimal(int id)
        {
           Entities context = new Entities();
          
            Vaccination newVac = new Vaccination();
            newVac.PetID = id;
            newVac.Date_ = DateTime.Now;
            newVac.Vac_Type = "vac jabs";

           context.Vaccinations.Add(newVac);
           context.SaveChanges();
            return View();
        }
    }
}