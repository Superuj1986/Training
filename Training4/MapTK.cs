using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Training4
{
    public class MapTK
    {
        Training4Entities db = new Training4Entities();
        //1: Tìm kiếm
        public TaiKhoan TimKiem(string username, string password)
        {
            var user = db.TaiKhoans.Where(m => m.Username == username & m.Password == password).ToList();
            if ( user.Count > 0)
            {
                return user[0];
            }
            else
            {
                return null;
            }
        }
        //2: Danh sách
        public List<TaiKhoan> DanhSach()
        {
            var user = db.TaiKhoans.ToList();
            return user;
        }
        //3: Thêm mới
        public void Add(string Hoten, string SDT)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.SDT = SDT;
            tk.Username = Hoten;
            db.TaiKhoans.Add(tk);
            db.SaveChanges();
        }
        public bool Add(TaiKhoan tk)
        {
            try
            {
                db.TaiKhoans.Add(tk);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}