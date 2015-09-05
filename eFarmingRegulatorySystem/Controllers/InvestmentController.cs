using CrystalDecisions.CrystalReports.Engine;
using eFarmingRegulatorySystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eFarmingRegulatorySystem.Controllers
{
    public class InvestmentController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
 
        // GET: Investment
        public ActionResult Index()
        {
            return View();
        }

        // GET: Investment/ReportsInvestment
        public ActionResult ReportsInvestment()
        {
            try
            {
                // TODO: Add update logic here
                List<Investment> allInvestment = new List<Investment>();
                allInvestment = db.Investments.ToList();
                return View(allInvestment);
            }
            catch
            {
                return View();
            }
        }


        public ActionResult ExportReport()
        {
            List<Investment> allInvestment = new List<Investment>();

            
                allInvestment = db.Investments.ToList();
            

            ReportDocument rd = new ReportDocument();
            rd.Load(Path.Combine(Server.MapPath("~/Reports"), "rpt_InvestmentList.rpt"));
            rd.SetDataSource(allInvestment);

            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();


            try
            {
                Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                stream.Seek(0, SeekOrigin.Begin);
                return File(stream, "application/pdf", "InvestmentList.pdf");
            }
            catch (Exception)
            {

                throw;
            }

        }

        // GET: Investment/Details
        public ActionResult Details()
        {
            var investment = new Investment
            {
                InvestmentNo = "0000123456",
                FirstName = "Ajit",
                LastName = "Sahu",
                Address = "101 Sine Street, Homebush, Sydney, NSW 2000",
                MobileNo = "0422333444",
                Landline = "91114343",
                OtherNo = "91114343",
                Email = "arvind.efarming@gmail.com",
                InvestmentAmount = 5441.50M,
                InvestmentDate = "19/11/2012",
                IsActive = true,
                Comment = "This is investment"
            };
            return View(investment);
        }

        // GET: Investment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Investment/Create
        [HttpPost]
        public ActionResult Create(Investment investment)
        {
            try
            {
                //Note 123456 seed number should be avoided or stored in config file. If I delete any account then I might end up duplicating the account number.
                var accountNumber = (123456 + db.Investments.Count()).ToString().PadLeft(10, '0');
                investment.InvestmentNo = accountNumber;

                // TODO: Add insert logic here
                db.Investments.Add(investment);
                db.SaveChanges();

                return PartialView("_InvestmentThanks");
            }
            catch
            {
                return View();
            }
        }

        // GET: Investment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Investment/Edit/5
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

        // GET: Investment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Investment/Delete/5
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
