using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetStore.Models;

namespace PetStore.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Entities context = new Entities();
            var Animals = 
                from a in context.Animals
                where a.OwnerID == null
                 select a;

            return View(Animals);
        }

    }
}
