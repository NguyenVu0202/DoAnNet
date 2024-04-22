using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_Loai
    {

        private static DAO_Loai instance;
        public static DAO_Loai Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_Loai();
                }
                return instance;
            }
        }
     
       // private DAO_Loai() { }
 
        public List<Loai> Xem()
        {
            List<Loai> loai = new List<Loai>();
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                loai = db.Loais.Select(a => a).ToList();
            }
            return loai;
        }
        public void Them(Loai loai)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                db.Loais.InsertOnSubmit(loai);
                db.SubmitChanges();
            }
        }
        public void Xoa(TextBox loai)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var loaidd = db.Loais.FirstOrDefault(a => a.MaLoai == loai.Text);
                if (loaidd != null)
                {
                    db.Loais.DeleteOnSubmit(loaidd);
                    db.SubmitChanges();

                }

            }
        }
        public bool Sua(string maLoai,Loai loai)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var loaiupdtae = db.Loais.SingleOrDefault(a => a.MaLoai==maLoai);
                if (loaiupdtae != null)
                {
                    loaiupdtae.MaLoai = loai.MaLoai;
                    loaiupdtae.TenLoai = loai.TenLoai;
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
