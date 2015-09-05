using eFarmingRegulatorySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eFarmingRegulatorySystem.Controllers
{
    public class PlotController : Controller
    {
        //
        // GET: /Plot/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Plot/Details
        public ActionResult Details()
        {
            var plot = new Plot { PlotNo = 1, PlotArea = "238sqm", PlotMapPicture = "~/plot/map/1.jpg", PlotActualPicture = "~/plot/actual/1.jpg", Comment = "This is plot comment" };
            return View(plot);
        }

        //
        // GET: /Plot/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Plot/Create
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
        // GET: /Plot/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Plot/Edit/5
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
        // GET: /Plot/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Plot/Delete/5
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
