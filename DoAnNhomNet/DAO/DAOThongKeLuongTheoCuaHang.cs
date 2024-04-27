using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAOThongKeLuongTheoCuaHang
    {
        private static DAOThongKeLuongTheoCuaHang instance;

        public static DAOThongKeLuongTheoCuaHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAOThongKeLuongTheoCuaHang();
                return instance;
            }
        }
        private DAOThongKeLuongTheoCuaHang() { }

        public List<NhanVien> ThongKeLuongNVTheoCH(string maCH)
        {          
            List<NhanVien> list = new List<NhanVien>();
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var nhanvien = (from nv in db.NhanViens
                                where nv.MaCH == maCH
                                select new
                                {
                                    nv.MaNV,
                                    nv.TenNV,
                                    nv.GioiTinh,
                                    nv.NgaySinh,
                                    nv.SDT,
                                    nv.Luong,
                                    nv.DiaChi,
                                    nv.MaCH
                                }).ToList();

                if (nhanvien.Count > 0)
                {
                    foreach (var nv in nhanvien)
                    {
                        NhanVien nhanVien = new NhanVien();
                        nhanVien.MaNV = nv.MaNV;
                        nhanVien.TenNV = nv.TenNV;
                        nhanVien.GioiTinh = nv.GioiTinh;
                        nhanVien.SDT = nv.SDT;
                        nhanVien.Luong = nv.Luong;
                        nhanVien.DiaChi = nv.DiaChi;
                        nhanVien.MaCH = nv.MaCH;
                        list.Add(nhanVien);
                    }
                }
            }              
            return list;
        }

        public List<string> LoadMaCH()
        {
            List<string> list = new List<string>();
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var mach = from ch in db.CuaHangs
                       select ch.MaCH;
            foreach (var item in mach)
            {
                list.Add(item);
            }
            return list;
        }
    }
}
