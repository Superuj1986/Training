using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Training3.Models;
namespace Training3.Controllers
{
    public class GVHDController : Controller
    {
        QLSVEntities db = new QLSVEntities();
        // GET: GVHD
        public ActionResult Index()
        {
            List<GVHD> DSGV = db.GVHDs.ToList(); 
            return View(DSGV);
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
        public ActionResult Create(GVHD model)
        {
            db.GVHDs.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: GVHD/Edit/5
        public ActionResult Edit(int id)
        {
            GVHD model = db.GVHDs.Find(id);
            return View(model);
        }

        // POST: GVHD/Edit/5
        [HttpPost]
        public ActionResult Edit(GVHD model)
        {
            var updateModel = db.GVHDs.Find(model.MaGV);
            updateModel.Ten = model.Ten;
            updateModel.NgaySinh = model.NgaySinh;
            updateModel.Khoa = model.Khoa;
            updateModel.Nganh = model.Nganh;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: GVHD/Delete/5
        public ActionResult Delete(int id)
        {
            var updateModel = db.GVHDs.Find(id);
            db.GVHDs.Remove(updateModel);
            db.SaveChanges();
            return RedirectToAction("Index");
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
