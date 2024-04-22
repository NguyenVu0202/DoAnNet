using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_Kho
    {
        private static DAO_Kho instance;

        public static DAO_Kho Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_Kho();
                }
                return instance;
            }


        }
        public DAO_Kho() { }

        public void LoadComBoBox(ComboBox cb)
        {
            Dictionary<string, string> lst = new Dictionary<string, string>();
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var tenSP = from sp in db.SanPhams
                            select new
                            {
                                sp.MaSP,
                                sp.TenSP, 
                            };
                foreach (var item in tenSP)
                {
                    lst.Add(item.MaSP, item.TenSP);
                }
                cb.DataSource = new BindingSource(lst, null);
                cb.DisplayMember = "Value";
                cb.ValueMember = "Key";

            }
        }
       
        public List<Kho> Xem()
        {
            List<Kho> sp = new List<Kho>();

            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var kho = (from kh in db.Khos
                                      select new
                                      {
                                          kh.MaKho,
                                          kh.MaCH,
                                          kh.MaSP,
                                          kh.SoLuong,
                                      }).ToList();

                foreach (var item in kho)
                {
                   Kho khos = new Kho();
                    khos.MaKho = item.MaKho;
                    khos.MaCH = item.MaCH;
                    khos.MaSP = item.MaSP;
                    khos.SoLuong = item.SoLuong;
                    sp.Add(khos);
                }
            }
            return sp;
        }
    }
}
