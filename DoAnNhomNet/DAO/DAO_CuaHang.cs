using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_CuaHang
    {

        private static DAO_CuaHang instance;
        public static DAO_CuaHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_CuaHang();
                }
                return instance;
            }
        }


        private DAO_CuaHang() { }


        public List<CuaHang> Xem()
        {
            List<CuaHang> cuaHang = new List<CuaHang>();
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                cuaHang = db.CuaHangs.Select(a => a).ToList();
            }
            return cuaHang;
        }
        public void Them(CuaHang ch)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                db.CuaHangs.InsertOnSubmit(ch);
                db.SubmitChanges();
            }
        }
        public void Xoa(TextBox cuaHang)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var ch = db.CuaHangs.FirstOrDefault(a => a.MaCH == cuaHang.Text);
                if (ch != null)
                {
                    db.CuaHangs.DeleteOnSubmit(ch);
                    db.SubmitChanges();

                }

            }
        }
        public bool Sua(string maCH, CuaHang ch)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var chupdate = db.CuaHangs.SingleOrDefault(a => a.MaCH == maCH);
                if (chupdate != null)
                {
                    chupdate.MaCH = ch.MaCH;
                    chupdate.DiaChi = ch.DiaChi;
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
