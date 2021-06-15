using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Resto.Models;

namespace Resto.Controllers
{
    public class HomeController : Controller
    {
        Carte carte = new Carte();
        // GET: Home
        public ActionResult Index()
        {
            var model = new SectionViewModel
            {
                Sections = carte.Sections
            };

            return View(model);
          
        }
    }
}