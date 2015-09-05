using eFarmingRegulatorySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eFarmingRegulatorySystem.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Person/Details
        public ActionResult Details()
        {
            //in-memory test account as no database 
            var person = new Person
            {
                AccountNumber = "0000123456",
                FirstName = "Arvind",
                LastName = "Kumar",
                Address = "25 Oxford Street, Homebush, Sydney, NSW 2000",
                MobileNo = "0422333444",
                Landline = "91114343",
                OtherNo = "",
                Email = "arvind.efarming@gmail.com",
                FaxNo = "92223232",
                FacebookId = "efarming",
                ViberNo = "0422333444",
                WhatsAppNo = "0422333444",
                Picture = "~/images/member/1.jpg",
                JoinDate = "12/11/2012",
                EndDate = "",
                AlternateContactFirstName = "Arvind",
                AlternateContactLastName = "Kumar",
                IsCoreTeamMember = true,
                IsActive = true,
                Comment = "This is core team member",

                VechileRegoNo = "UP32 3232",
                VechileMake = "Fiat",
                AveragePerKM = "7",

                IsChowkidar = false,
                IsSupplier = false,

                IsMember = true,
                MemberNo = "",
                IsResidentialProofChecked = true,
                SupportingDocuments = "" 
            };
            return View(person);
        }

        //
        // GET: /Person/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Person/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
