using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetStore.Models;
using System.Data.Entity.Validation;

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

      //  public ActionResult AddAnimal()
      //  {
      //      var Animal = new Animal();
      //      return View(Animal);
      //  }

        public ActionResult AddAnimal(Animal newAnimal)
        {
            if (newAnimal != null)
            {
                try
                {
                    Entities context = new Entities();
                    context.Animals.Add(newAnimal);
                    context.SaveChanges();

                    return View(newAnimal);
                }
                catch (Exception e)
                {
                    return View();
                }
            }
            else
            {
                      var Animal = new Animal();
                      return View(Animal);
            }
        }

        public ActionResult EODReport()
        {
            //Error if no Animals exist
            Entities context = new Entities();
            var EODReport =
                context.Animals.GroupBy(a => a.TypeID)
                .Select(g => new EODReport(){ 
                    TypeID = g.Key,
                    InStock = g.Select(s => s.TypeID).Count(),
                    SoldToday = g.Select(s => s.Owner).Where(a => a.Date_Sold == DateTime.Today).Count()
                });

               

            return View(EODReport.ToList());
        }

        public ActionResult SellAnimal(int id)
        {
            Entities context = new Entities();
            var Animal = context.Animals.Find(id);
            return View(Animal);
        }

        public ActionResult AnimalSold(string id, string title, string forename, string surname)
        {
            try
            {
                var newOwner = new Owner();
                newOwner.Title = title;
                newOwner.Forename = forename;
                newOwner.Surname = surname;
                newOwner.Date_Sold = DateTime.Now;

                Entities context = new Entities();
                context.Owners.Add(newOwner);
                context.SaveChanges();

                int petID = Convert.ToInt32(id);
                var Animal = context.Animals.Find(petID);
                Animal.OwnerID = newOwner.Id;
                context.SaveChanges();

                return View(Animal);
            }
            catch (Exception e)
            {
                return View();
            }
            
        }

        public ActionResult StockUpAnimal (int? id)
        {
            try { 
            //Add Random num and name gens?
            var newAnimal = new Animal();
            newAnimal.Name = "Generic Name";
            newAnimal.Sex = 0;
            newAnimal.TypeID = id;
            newAnimal.Date_Arrived = DateTime.Now;

            Entities context = new Entities();
            context.Animals.Add(newAnimal);
            context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

            }
            return RedirectToAction("EODReport");
        }

    }
}
