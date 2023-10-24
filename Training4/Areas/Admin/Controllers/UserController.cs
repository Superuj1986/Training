using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Training4.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string name, string pass)
        {
            MapTK map = new MapTK();
            var user = map.TimKiem(name, pass);
            if ( user != null)
            {
                return RedirectToAction("Index", "DashBoard", new { area = "Admin" });
            }
            ViewBag.error = "Tên đăng nhập hoặc mật khẩu không đúng";
            return View();
        }
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy( TaiKhoan model )
        {
            MapTK map = new MapTK();
            if ( map.Add(model) == true)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View(model);
            }
        }
    }
}