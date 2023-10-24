using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Training3.Models;
namespace Training3.Controllers
{
    public class DeTaiController : Controller
    {
        QLSVEntities db = new QLSVEntities();
        // GET: DeTai
        public ActionResult Index()
        {
            List<DeTai> DSDT = db.DeTais.ToList();
            return View(DSDT);
        }

        // GET: DeTai/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeTai/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeTai/Create
        [HttpPost]
        public ActionResult Create(DeTai model)
        {
            db.DeTais.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: DeTai/Edit/5
        public ActionResult Edit(int id)
        {
            DeTai model = db.DeTais.Find(id);
            return View(model);
        }

        // POST: DeTai/Edit/5
        [HttpPost]
        public ActionResult Edit(DeTai model)
        {
            var updateModel = db.DeTais.Find(model.MaSoDT);
            updateModel.TenDT = model.TenDT;
            updateModel.TGTH = model.TGTH;
            updateModel.TienDo = model.TienDo;
            updateModel.MaGV = model.MaGV;
            updateModel.KinhPhi = model.KinhPhi;
            updateModel.MaSV = model.MaSV;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: DeTai/Delete/5
        public ActionResult Delete(int id)
        {
            var updateModel = db.DeTais.Find(id);
            db.DeTais.Remove(updateModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: DeTai/Delete/5
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
