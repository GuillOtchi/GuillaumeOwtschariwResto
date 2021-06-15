using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Resto.Models;

namespace Resto.Controllers
{
    public class CarteController : Controller
    {
        Carte carte = new Carte();
        // GET: Carte
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