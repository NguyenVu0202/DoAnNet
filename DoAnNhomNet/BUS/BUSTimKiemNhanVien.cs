using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSTimKiemNhanVien
    {
        private static BUSTimKiemNhanVien instance;

        public static BUSTimKiemNhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUSTimKiemNhanVien();
                return instance;
            }
        }
        private BUSTimKiemNhanVien() { }

        public void TimKiemNVTheoMaNV(TextBox maNV, DataGridView data)
        {
            var dt = DAOTimKiemNhanVien.Instance.TimKiemNVTheoMaNV(maNV.Text).Select(t =>
            {
                return new
                {
                    t.MaNV,
                    t.TenNV,
                    t.NgaySinh,
                    t.GioiTinh,
                    t.DiaChi,
                    t.SDT,
                    t.Luong,
                    t.MaCH
                };
            }).ToList();
            data.DataSource = dt;
        }

        public void TimKiemNVTheoTenNV(TextBox tenNV, DataGridView data)
        {
            var dt = DAOTimKiemNhanVien.Instance.TimKiemNVTheoTenNV(tenNV.Text).Select(t =>
            {
                return new
                {
                    t.MaNV,
                    t.TenNV,
                    t.NgaySinh,
                    t.GioiTinh,
                    t.DiaChi,
                    t.SDT,
                    t.Luong,
                    t.MaCH
                };
            }).ToList();
            data.DataSource = dt;
        }

        public void TimKiemNVTheoMaCH(TextBox maCH, DataGridView data)
        {
            var dt = DAOTimKiemNhanVien.Instance.TimKiemNVTheoMaCH(maCH.Text).Select(t =>
            {
                return new
                {
                    t.MaNV,
                    t.TenNV,
                    t.NgaySinh,
                    t.GioiTinh,
                    t.DiaChi,
                    t.SDT,
                    t.Luong,
                    t.MaCH
                };
            }).ToList();
            data.DataSource = dt;
        }
    }
}
