using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DAO
{
    public class DAO_SanPham
    {
        private static DAO_SanPham instance;

        public static DAO_SanPham Instance {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_SanPham();
                }
                return instance;
            }

        
        }
        public DAO_SanPham() { }

        public List<SanPham> Xem()
        {
            List<SanPham> sp = new List<SanPham>();

            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var sanPhamsFromDB = (from sp1 in db.SanPhams
                                      select new
                                      {
                                          sp1.MaSP,
                                          sp1.TenSP,
                                          sp1.MaLoai,
                                          sp1.MaHang,
                                          sp1.GiaBan,
                                          sp1.HinhAnh, // Assuming HinhAnh is of type Binary in the database
                                          sp1.GhiChu
                                      }).ToList();

                foreach (var item in sanPhamsFromDB)
                {
                    SanPham sanPham = new SanPham();
                    sanPham.MaSP = item.MaSP;
                    sanPham.MaLoai = item.MaLoai;
                    sanPham.MaHang = item.MaHang;
                    sanPham.TenSP = item.TenSP;
                    sanPham.GiaBan = item.GiaBan;
                    sanPham.GhiChu = item.GhiChu;
                    sanPham.HinhAnh = item.HinhAnh;

                    sp.Add(sanPham);
                }
            }
            return sp;
        }
        public void LoadComBoBox(ComboBox cb)
        {
            Dictionary<string, string> lst = new Dictionary<string, string>();
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var tenloai = from loai in db.Loais
                              select new { loai.MaLoai, loai.TenLoai, };
                foreach (var item in tenloai)
                {
                    lst.Add(item.MaLoai, item.TenLoai);
                }
                cb.DataSource = new BindingSource(lst, null);
                cb.DisplayMember = "Value";
                cb.ValueMember = "Key";

            }
        }
        public void LoadComBoxTenHang(ComboBox cb)
        {
            Dictionary<string, string> lst = new Dictionary<string, string>();
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var tenHang = from sp in db.Hangs
                              select new { sp.MaHang, sp.TenHang, };
                foreach (var item in tenHang)
                {
                    lst.Add(item.MaHang, item.TenHang);
                }
                cb.DataSource = new BindingSource(lst, null);
                cb.DisplayMember = "Value";
                cb.ValueMember = "Key";
            }
        }
        public void Them(TextBox masp, TextBox tensp, ComboBox tenloai, ComboBox tenhang, TextBox giaban, TextBox hinhanh, TextBox ghichu)
        {
            try
            {
                using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
                {
                    string [] cattenanh = hinhanh.Text.Split('\\');
                    int lastIndex = cattenanh.Length - 1;
                    string tenanh = cattenanh[lastIndex];
                    string duongdan = Path.Combine(Application.StartupPath, "Image");
                    string duongdanmoi = duongdan + "\\" + tenanh;
                    SanPham sp = new SanPham();
                    sp.MaSP = masp.Text;
                    sp.TenSP = tensp.Text;
                    sp.MaLoai = tenloai.SelectedValue.ToString().Trim();
                    sp.MaHang = tenhang.SelectedValue.ToString().Trim();
                    sp.GiaBan = int.Parse(giaban.Text);
                    sp.HinhAnh = duongdanmoi;
                    sp.GhiChu = ghichu.Text;
                    db.SanPhams.InsertOnSubmit(sp);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm Sản Phẩm Thành Công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex);
            }
        }
        public void Xoa(string masp)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var spdelete = db.SanPhams.FirstOrDefault(a => a.MaSP == masp);
                if (spdelete != null)
                {
                    db.SanPhams.DeleteOnSubmit(spdelete);
                    db.SubmitChanges();
                }
            }
        }
        public bool Sua(SanPham sp)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var spupdate = db.SanPhams.SingleOrDefault(a => a.MaSP == sp.MaSP);
                if (spupdate != null)
                {
                    spupdate.MaLoai = sp.MaLoai;
                    spupdate.MaHang = sp.MaHang;
                    spupdate.TenSP = sp.TenSP;
                    spupdate.GiaBan = sp.GiaBan;
                    spupdate.HinhAnh = sp.HinhAnh;
                    spupdate.GhiChu = sp.GhiChu;
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
        }
        public string LayHinhAnhBangMaSP(TextBox masp)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var sanpham = db.SanPhams.SingleOrDefault(sp => sp.MaSP == masp.Text);
                return sanpham.HinhAnh;
            }
        }

        public void LoadDgvLenForm(TextBox masp, TextBox tensp, ComboBox tenloai, ComboBox tenhang, TextBox giaban, PictureBox picHinhAnh, TextBox ghichu, DataGridView data)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var rowIndex = data.SelectedCells[0].RowIndex;
                var row = data.Rows[rowIndex];
                masp.Text = row.Cells[0].Value.ToString().Trim();
                tensp.Text = row.Cells[1].Value.ToString().Trim();
                var loai = (from l in db.Loais
                          where l.MaLoai == row.Cells[2].Value.ToString().Trim()
                          select l.TenLoai).FirstOrDefault();
                tenloai.Text = loai.ToString();
                var hang = (from h in db.Hangs
                            where h.MaHang == row.Cells[3].Value.ToString().Trim()
                            select h.TenHang).FirstOrDefault();
                tenhang.Text = hang.ToString();
                giaban.Text = row.Cells[4].Value.ToString().Trim();
                var anh = row.Cells[5].Value as Image;
                picHinhAnh.Image = anh;
                ghichu.Text = row.Cells[6].Value.ToString().Trim();
            }
        }
    }
}
