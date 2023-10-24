using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Training3.Models;
using Training3;

namespace Training3.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string name, string pass)
        {
            mapTaiKhoan map = new mapTaiKhoan();
            var user = map.TimKiem(name,pass);
            if ( user != null)
            {
                return RedirectToAction("Index","DashBoard",new { area ="Admin"});
            }
            ViewBag.Error = "Tên đăng nhập hoặc mật khẩu sai";
            return View();
        }
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(NguoiDung model)
        {
            mapTaiKhoan map = new mapTaiKhoan();
            map.Add(model);
            return View();
        }
    }
}