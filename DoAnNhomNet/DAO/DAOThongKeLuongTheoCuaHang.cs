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
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var luong1 = db.NhanViens.Where(p=>p.MaCH == maCH).ToList();
            if (luong1.Any())
            {
                int totalSalary = (int)luong1.Sum(e => e.Luong);

                NhanVien nhanVien = new NhanVien();
                nhanVien.MaCH = maCH;
                nhanVien.Luong = totalSalary;

                // Add the summary employee to the list
                list.Add(nhanVien);
            }   
            else
            {
                MessageBox.Show("Cửa Hàng Chưa Có Nhân Viên");
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
