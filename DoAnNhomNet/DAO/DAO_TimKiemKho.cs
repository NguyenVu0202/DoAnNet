using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_TimKiemKho
    {
        private static DAO_TimKiemKho instance;

        public static DAO_TimKiemKho Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new DAO_TimKiemKho();
                }
                return instance;
            }
        }
        public DAO_TimKiemKho() { }

       
        public List<Kho> TimKiemMaKho(string ma)
        {
            List<Kho> list = new List<Kho>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var kh = db.Khos.SingleOrDefault(p => p.MaCH == ma);
            if (kh != null)
            {
                Kho k = new Kho
                {
                    MaKho = kh.MaKho,
                    MaCH = kh.MaCH,
                    MaSP = kh.MaSP,
                };
                list.Add(k);
            }
            else
            {
                MessageBox.Show("Không Có tim thay ma kho");
            }
            return list;
        }
        public List<CuaHang> TimKiemMaCH(string ma)
        {
            List<CuaHang> list = new List<CuaHang>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var kh = db.CuaHangs.SingleOrDefault(p => p.MaCH == ma);
            if (kh != null)
            {
                CuaHang cuaHang = new CuaHang
                {
                    MaCH = kh.MaCH,
                    DiaChi = kh.DiaChi,
                };
                list.Add(cuaHang);
            }
            else
            {
                MessageBox.Show("Không Có tim thay ma cua hang");
            }
            return list;
        }
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
    }
}
