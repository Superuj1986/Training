using System.Linq;
using System.Web.Mvc;
using Training2.Models;

namespace Training2.Controllers
{
    public class SinhvienController : Controller
    {
        // GET: Sinhvien
        public ActionResult Index()
        {
            var listSV = new QLSVEntities().SinhViens.ToList();

            return View(listSV);
        }

        // GET: Sinhvien/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sinhvien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sinhvien/Create
        [HttpPost]
        public ActionResult Create(SinhVien model)
        {
            QLSVEntities db = new QLSVEntities();
            db.SinhViens.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Sinhvien/Edit/5
        public ActionResult Edit(int id)
        {
            QLSVEntities db = new QLSVEntities();
            SinhVien model = db.SinhViens.Find(id);
            return View(model);
        }

        // POST: Sinhvien/Edit/5
        [HttpPost]
        public ActionResult Edit(SinhVien model)
        {
            QLSVEntities db = new QLSVEntities();
            var updateModel = db.SinhViens.Find(model.MaSV);
            updateModel.HoTen = model.HoTen;
            updateModel.NgaySinh = model.NgaySinh;
            updateModel.MaLop = model.MaLop;
            updateModel.Khoa = model.Khoa;
            updateModel.Nganh = model.Nganh;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Sinhvien/Delete/5
        public ActionResult Delete(int id)
        {
            QLSVEntities db = new QLSVEntities();
            var updateModel = db.SinhViens.Find(id);
            db.SinhViens.Remove(updateModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: Sinhvien/Delete/5
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
