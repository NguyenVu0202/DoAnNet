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

        public void LoadComBoBoxMaCH(ComboBox cb)
        {
            List<string> lst = new List<string>();
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var mach = from k in db.CuaHangs
                           select new { k.MaCH };
                foreach (var item in mach)
                {
                    lst.Add(item.MaCH);
                }
                cb.DataSource = lst;
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

        public void ThemKho(Kho kho)
        {
            try
            {
                using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
                {
                    db.Khos.InsertOnSubmit(kho);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm Thành Công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Thất Bại" + ex.Message);
            }
        }

        public void XoaKho(string maKho)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa khách hàng này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    using(TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
                    {
                        var kho = db.Khos.FirstOrDefault(p => p.MaKho == maKho);
                        db.Khos.DeleteOnSubmit(kho);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa Thành Công");
                    }    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa Thất Bại" + ex.Message);
                }
            }
        }

        public void LoadDgvLenForm(TextBox maKho, ComboBox maCH, ComboBox maSP, TextBox soLuong, DataGridView data)
        {
            using(TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var rowIndex = data.SelectedCells[0].RowIndex;
                var row = data.Rows[rowIndex];
                maKho.Text = row.Cells[0].Value.ToString().Trim();
                maCH.Text = row.Cells[1].Value.ToString().Trim();
                var sp = (from s in db.SanPhams
                         where s.MaSP == row.Cells[2].Value.ToString().Trim()
                         select s.TenSP).FirstOrDefault();
                maSP.Text = sp.ToString();
                soLuong.Text = row.Cells[3].Value.ToString().Trim();
            }               
        }
    }
}
