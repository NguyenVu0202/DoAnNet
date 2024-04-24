using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_Hang
    {
        private string maHang, tenHang;

        private static DAO_Hang instance;
        public static DAO_Hang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_Hang();
                }
                return instance;
            }
        }

        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }

        private DAO_Hang() { }

        public DAO_Hang(string maHang, string tenHang)
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
        }

        public List<Hang> Xem()
        {
            List<Hang> hangs = new List<Hang>();
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                hangs = db.Hangs.Select(a => a).ToList();
            }
            return hangs;
        }
        public void Them(Hang hang)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                db.Hangs.InsertOnSubmit(hang);
                db.SubmitChanges();
            }
        }
        public void Xoa(TextBox hang)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var hangdd = db.Hangs.FirstOrDefault(a => a.MaHang == hang.Text);
                if (hangdd!=null)
                {
                    db.Hangs.DeleteOnSubmit(hangdd);
                    db.SubmitChanges();
                  
                }
               
            }
        }
        public bool Sua(string hang,Hang hang1)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var hangupdate = db.Hangs.SingleOrDefault(a => a.MaHang == hang);
                if (hangupdate != null)
                {
                    hangupdate.MaHang = hang1.MaHang;
                    hangupdate.TenHang = hang1.TenHang;
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
        }
    }
}