using eFarmingRegulatorySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eFarmingRegulatorySystem.Controllers
{
    [Authorize]
    public class RegulateController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //
        // GET: /Regulate/Supervison
        public ActionResult Supervision(int personId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Supervision(Regulate regulate)
        {
            if (ModelState.IsValid)
            {
                db.Regulates.Add(regulate);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
	}
}