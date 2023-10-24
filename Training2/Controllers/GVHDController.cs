using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Training2.Models;

namespace Training2.Controllers
{
    public class GVHDController : Controller
    {
        // GET: GVHD
        public ActionResult Index()
        {
            var listGVHD = new QLSVEntities().GVHDs.ToList();
            return View(listGVHD);
        }

        // GET: GVHD/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GVHD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GVHD/Create
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

        // GET: GVHD/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GVHD/Edit/5
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

        // GET: GVHD/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GVHD/Delete/5
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
