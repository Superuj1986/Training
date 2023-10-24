using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Training3.Models;

namespace Training3
{
    public class mapTaiKhoan
    {
        QLSVEntities db = new QLSVEntities();
        public NguoiDung TimKiem(string username,string password)
        {
            var user = db.NguoiDungs.Where(m=>m.TaiKhoan == username & m.MatKhau == password).ToList();
            if ( user.Count > 0)
            {
                return user[0];
            }
            else
            {
                return null;
            }
        }
        public List<NguoiDung> DanhSach()
        {
            var user = db.NguoiDungs.ToList();
            return user;
        }
        public void Add(string username, string password)
        {
            NguoiDung us = new NguoiDung();
            us.TaiKhoan = username;
            us.MatKhau = password;
            db.NguoiDungs.Add(us);
            db.SaveChanges();
        }
        public void Add(NguoiDung nd)
        {
            db.NguoiDungs.Add(nd);
            db.SaveChanges();
        }
    }
}