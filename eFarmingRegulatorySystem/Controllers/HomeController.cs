using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using eFarmingRegulatorySystem.Models;
using Microsoft.AspNet.Identity.Owin;

namespace eFarmingRegulatorySystem.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET /home/index
        [Authorize]
        [MyLoggingFilter]
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var personId = db.Persons.Where(c => c.ApplicationUserId == userId).First().Id;
            ViewBag.PersonId = personId;
            //throw new StackOverflowException();
   


            var manager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = manager.FindById(userId);
            //ViewBag.Pin = user.Pin;


            return View();
        }

        //GET /home/about
        //[ActionName("about-this-efrs")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            
            //return View();
            return View("About");
        }

        //GET /home/team
        public ActionResult Team()
        {
            ViewBag.Message = "Your application description page.";

            return View("Team");
        }

        //[Route("/home/contact")]
        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble? Send us a message.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            // TODO: send the message to HQ
            ViewBag.TheMessage = "Thanks, we got your message!";

            return PartialView("_ContactThanks");
        }

        public ActionResult Foo()
        {
            return View("About");
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "EFRS version 1.0";
            if (letterCase =="lower")
            {
                return Content(serial.ToLower());
            }
            //return Content(serial);

            //return new HttpStatusCodeResult(403);

            //return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);

            return RedirectToAction("Index");
        }

    }
}