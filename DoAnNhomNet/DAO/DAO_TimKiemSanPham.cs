using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_TimKiemSanPham
    {
        private static DAO_TimKiemSanPham instance;

        public static DAO_TimKiemSanPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO_TimKiemSanPham();
                return instance;
            }
        }
        private DAO_TimKiemSanPham() { }

        public List<SanPham> TimKiemSanPhamTheoMaSP(string MaSP)
        {
            List<SanPham> list = new List<SanPham>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var sp = db.SanPhams.SingleOrDefault(p => p.MaSP == MaSP);
            if (sp != null)
            {
                SanPham sanPham = new SanPham
                {
                    MaSP = sp.MaSP,
                    MaLoai = sp.MaLoai,
                    MaHang = sp.MaHang,
                    TenSP = sp.TenSP,
                    GiaBan = sp.GiaBan,
                    HinhAnh = sp.HinhAnh,
                    GhiChu = sp.GhiChu,
                };
                list.Add(sanPham);
            }
            else
            {
                MessageBox.Show("Không Có Mã san pham");
            }
            return list;
        }
        public List<SanPham> TimKiemSanPhamTheoMaLoai(string MaLoai)
        {
            List<SanPham> list = new List<SanPham>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var sp = db.SanPhams.SingleOrDefault(p => p.MaLoai == MaLoai);
            if (sp != null)
            {
                SanPham sanPham = new SanPham
                {
                    MaSP = sp.MaSP,
                    MaLoai = sp.MaLoai,
                    MaHang = sp.MaHang,
                    TenSP = sp.TenSP,
                    GiaBan = sp.GiaBan,
                    HinhAnh = sp.HinhAnh,
                    GhiChu = sp.GhiChu,

                };
                list.Add(sanPham);
            }
            else
            {
                MessageBox.Show("Không Có Mã Loai");
            }
            return list;
        }
        public List<SanPham> TimKiemSanPhamTheoMaHang(string MaHang)
        {
            List<SanPham> list = new List<SanPham>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var sp = db.SanPhams.SingleOrDefault(p => p.MaHang == MaHang);
            if (sp != null)
            {
                SanPham sanPham = new SanPham
                {
                    MaSP = sp.MaSP,
                    MaLoai = sp.MaLoai,
                    MaHang = sp.MaHang,
                    TenSP = sp.TenSP,
                    GiaBan = sp.GiaBan,
                    HinhAnh = sp.HinhAnh,
                    GhiChu = sp.GhiChu,

                };
                list.Add(sanPham);
            }
            else
            {
                MessageBox.Show("Không Có Mã Hang");
            }
            return list;
        }
        public List<SanPham> TimKiemSanPhamTheoTenSP(string TenSP)
        {
            List<SanPham> list = new List<SanPham>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var sp = db.SanPhams.SingleOrDefault(p => p.TenSP == TenSP);
            if (sp != null)
            {
                SanPham sanPham = new SanPham
                {
                    MaSP = sp.MaSP,
                    MaLoai = sp.MaLoai,
                    MaHang = sp.MaHang,
                    TenSP = sp.TenSP,
                    GiaBan = sp.GiaBan,
                    HinhAnh = sp.HinhAnh,
                    GhiChu = sp.GhiChu,

                };
                list.Add(sanPham);
            }
            else
            {
                MessageBox.Show("Không Có TenSP");
            }
            return list;
        }
        public List<SanPham> TimKiemSanPhamCoGiaDuoi2TR(string Gia)
        {
            List<SanPham> list = new List<SanPham>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var sp = db.SanPhams.SingleOrDefault(p => p.GiaBan < 2000);
            if (sp != null)
            {
                SanPham sanPham = new SanPham
                {
                    MaSP = sp.MaSP,
                    MaLoai = sp.MaLoai,
                    MaHang = sp.MaHang,
                    TenSP = sp.TenSP,
                    GiaBan = sp.GiaBan,
                    HinhAnh = sp.HinhAnh,
                    GhiChu = sp.GhiChu,
                };
                list.Add(sanPham);
            }
            else
            {
                MessageBox.Show("Không Có gia duoi 2 tr");
            }
            return list;
        }
        public List<SanPham> TimKiemSanPhamCoGiaDuoi5TR(string Gia)
        {
            List<SanPham> list = new List<SanPham>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var sp = db.SanPhams.SingleOrDefault(p => p.GiaBan < 5000);
            if (sp != null)
            {
                SanPham sanPham = new SanPham
                {
                    MaSP = sp.MaSP,
                    MaLoai = sp.MaLoai,
                    MaHang = sp.MaHang,
                    TenSP = sp.TenSP,
                    GiaBan = sp.GiaBan,
                    HinhAnh = sp.HinhAnh,
                    GhiChu = sp.GhiChu,
                };
                list.Add(sanPham);
            }
            else
            {
                MessageBox.Show("Không Có gia duoi 5 tr");
            }
            return list;
        }
        public List<SanPham> TimKiemSanPhamCoGiaDuoi10TR(string Gia)
        {
            List<SanPham> list = new List<SanPham>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var sp = db.SanPhams.SingleOrDefault(p => p.GiaBan < 10000);
            if (sp != null)
            {
                SanPham sanPham = new SanPham
                {
                    MaSP = sp.MaSP,
                    MaLoai = sp.MaLoai,
                    MaHang = sp.MaHang,
                    TenSP = sp.TenSP,
                    GiaBan = sp.GiaBan,
                    HinhAnh = sp.HinhAnh,
                    GhiChu = sp.GhiChu,
                };
                list.Add(sanPham);
            }
            else
            {
                MessageBox.Show("Không Có gia duoi 10 tr");
            }
            return list;
        }
        public List<SanPham> TimKiemSanPhamCoGiaDuoi15TR(string Gia)
        {
            List<SanPham> list = new List<SanPham>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var sp = db.SanPhams.SingleOrDefault(p => p.GiaBan < 15000);
            if (sp != null)
            {
                SanPham sanPham = new SanPham
                {
                    MaSP = sp.MaSP,
                    MaLoai = sp.MaLoai,
                    MaHang = sp.MaHang,
                    TenSP = sp.TenSP,
                    GiaBan = sp.GiaBan,
                    HinhAnh = sp.HinhAnh,
                    GhiChu = sp.GhiChu,
                };
                list.Add(sanPham);
            }
            else
            {
                MessageBox.Show("Không Có gia duoi 15 tr");
            }
            return list;
        }
        public List<SanPham> TimKiemSanPhamCoGiaDuoi20TR(string Gia)
        {
            List<SanPham> list = new List<SanPham>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var sp = db.SanPhams.SingleOrDefault(p => p.GiaBan < 20000);
            if (sp != null)
            {
                SanPham sanPham = new SanPham
                {
                    MaSP = sp.MaSP,
                    MaLoai = sp.MaLoai,
                    MaHang = sp.MaHang,
                    TenSP = sp.TenSP,
                    GiaBan = sp.GiaBan,
                    HinhAnh = sp.HinhAnh,
                    GhiChu = sp.GhiChu,
                };
                list.Add(sanPham);
            }
            else
            {
                MessageBox.Show("Không Có gia duoi 20 tr");
            }
            return list;
        }
        public List<SanPham> TimKiemSanPhamCoGiaTren20TR(string Gia)
        {
            List<SanPham> list = new List<SanPham>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var sp = db.SanPhams.SingleOrDefault(p => p.GiaBan > 20000);
            if (sp != null)
            {
                SanPham sanPham = new SanPham
                {
                    MaSP = sp.MaSP,
                    MaLoai = sp.MaLoai,
                    MaHang = sp.MaHang,
                    TenSP = sp.TenSP,
                    GiaBan = sp.GiaBan,
                    HinhAnh = sp.HinhAnh,
                    GhiChu = sp.GhiChu,
                };
                list.Add(sanPham);
            }
            else
            {
                MessageBox.Show("Không Có gia tren 20 tr");
            }
            return list;
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
        public string LoadHinhSP(string masp)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var hinh = db.SanPhams.FirstOrDefault(p => p.MaSP == masp);
                if (hinh != null)
                {
                    return hinh.HinhAnh;
                }
                return "C:\\DoAnNhomNet\\DoAnNhomNet\\bin\\Debug\\Image\\OPPO A95.png";
            }
        }

    }
}
