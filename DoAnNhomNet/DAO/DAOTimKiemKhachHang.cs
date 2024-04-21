using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAOTimKiemKhachHang
    {
        private static DAOTimKiemKhachHang instance;

        public static DAOTimKiemKhachHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAOTimKiemKhachHang();
                return instance;
            }
        }

        private DAOTimKiemKhachHang() { }

        public List<KhachHang> TimKiemKHTheoMaKH(string MaKH)
        {
            List<KhachHang> list = new List<KhachHang>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var kh = db.KhachHangs.SingleOrDefault(p=>p.MaKH == MaKH);
            if (kh != null)
            {
                KhachHang khachHang = new KhachHang
                {
                    MaKH = kh.MaKH,
                    TenKH = kh.TenKH,
                    GioiTinh = kh.GioiTinh,
                    DiaChi = kh.DiaChi,
                    SDT = kh.SDT,
                };
                list.Add(khachHang);
            }    
            else
            {
                MessageBox.Show("Không Có Mã Khách Hàng Này");
            }    
            return list;
        }

        public List<KhachHang> TimKiemKHTheoTenKH(string TenKH)
        {
            List<KhachHang> list = new List<KhachHang>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var kh = db.KhachHangs.SingleOrDefault(p => p.TenKH == TenKH);
            if (kh != null)
            {
                KhachHang khachHang = new KhachHang
                {
                    MaKH = kh.MaKH,
                    TenKH = kh.TenKH,
                    GioiTinh = kh.GioiTinh,
                    DiaChi = kh.DiaChi,
                    SDT = kh.SDT,
                };
                list.Add(khachHang);
            }
            else
            {
                MessageBox.Show("Không Có Tên Khách Hàng Này");
            }    
            return list;
        }

        public List<KhachHang> TimKiemKHTheoSDT(string SDT)
        {
            List<KhachHang> list = new List<KhachHang>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var kh = db.KhachHangs.SingleOrDefault(p => p.SDT == SDT);
            if(kh != null)
            {
                KhachHang khachHang = new KhachHang
                {
                    MaKH = kh.MaKH,
                    TenKH = kh.TenKH,
                    GioiTinh = kh.GioiTinh,
                    DiaChi = kh.DiaChi,
                    SDT = kh.SDT,
                };
                list.Add(khachHang);
            }
            else
            {
                MessageBox.Show("Không Có Khách Hàng Nào Có SĐT Này");
            }
            return list;
        }
    }
}
