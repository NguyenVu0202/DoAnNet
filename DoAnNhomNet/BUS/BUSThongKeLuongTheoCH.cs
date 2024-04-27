using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSThongKeLuongTheoCH
    {
        private static BUSThongKeLuongTheoCH instance;

        public static BUSThongKeLuongTheoCH Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUSThongKeLuongTheoCH();
                return instance;
            }
        }
        private BUSThongKeLuongTheoCH() { }

        public void ThongKeLuongNVTheoCH(ComboBox maCH, DataGridView data)
        {
            var dt = DAOThongKeLuongTheoCuaHang.Instance.ThongKeLuongNVTheoCH(maCH.Text).Select(t =>
            {
                return new
                {
                    MaNV = t.MaNV,
                    TenNV = t.TenNV,
                    GioiTinh = t.GioiTinh,
                    NgaySinh = t.NgaySinh,
                    SDT = t.SDT,
                    Luong = t.Luong,
                    DiaChi = t.DiaChi,
                    MaCH = t.MaCH,
                };
            }).ToList();
            data.DataSource = dt;
        }

        public void LoadMaCH(ComboBox cb)
        {
            cb.DataSource = DAOThongKeLuongTheoCuaHang.Instance.LoadMaCH();
        }
    }
}
