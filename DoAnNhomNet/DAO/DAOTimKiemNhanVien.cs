using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAOTimKiemNhanVien
    {
        private static DAOTimKiemNhanVien instance;

        public static DAOTimKiemNhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAOTimKiemNhanVien();
                return instance;
            }
        }
        private DAOTimKiemNhanVien() { }

        public List<NhanVien> TimKiemNVTheoMaNV(string MaNV)
        {
            List<NhanVien> list = new List<NhanVien>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var nv = db.NhanViens.SingleOrDefault(p => p.MaNV == MaNV);
            if (nv != null)
            {
                NhanVien nhanvien = new NhanVien
                {
                    MaNV = nv.MaNV,
                    TenNV = nv.TenNV,
                    GioiTinh = nv.GioiTinh,
                    DiaChi = nv.DiaChi,
                    SDT = nv.SDT,
                    NgaySinh = nv.NgaySinh,
                    Luong = nv.Luong,
                    MaCH = nv.MaCH
                };
                list.Add(nhanvien);               
            }
            else
            {
                MessageBox.Show("Không Có Mã Nhân Viên");
            }
            return list;
        }

        public List<NhanVien> TimKiemNVTheoTenNV(string tenNV)
        {
            List<NhanVien> list = new List<NhanVien>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var nv = db.NhanViens.SingleOrDefault(p => p.TenNV == tenNV);
            if (nv != null)
            {
                NhanVien nhanvien = new NhanVien
                {
                    MaNV = nv.MaNV,
                    TenNV = nv.TenNV,
                    GioiTinh = nv.GioiTinh,
                    DiaChi = nv.DiaChi,
                    SDT = nv.SDT,
                    NgaySinh = nv.NgaySinh,
                    Luong = nv.Luong,
                    MaCH = nv.MaCH
                };
                list.Add(nhanvien);
            }
            else
            {
                MessageBox.Show("Không Có Tên Nhân Viên");
            }
            return list;
        }

        public List<NhanVien> TimKiemNVTheoMaCH(string maCH)
        {
            List<NhanVien> list = new List<NhanVien>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var nv = db.NhanViens.SingleOrDefault(p => p.MaCH == maCH);
            if (nv != null)
            {
                NhanVien nhanvien = new NhanVien
                {
                    MaNV = nv.MaNV,
                    TenNV = nv.TenNV,
                    GioiTinh = nv.GioiTinh,
                    DiaChi = nv.DiaChi,
                    SDT = nv.SDT,
                    NgaySinh = nv.NgaySinh,
                    Luong = nv.Luong,
                    MaCH = nv.MaCH
                };
                list.Add(nhanvien);
            }
            else
            {
                MessageBox.Show("Cửa Hàng Chưa Có Nhân Viên");
            }
            return list;
        }
    }
}
