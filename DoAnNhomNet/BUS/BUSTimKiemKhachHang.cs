using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSTimKiemKhachHang
    {
        private static BUSTimKiemKhachHang instance;

        public static BUSTimKiemKhachHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUSTimKiemKhachHang();
                return instance;
            }
        }

        private BUSTimKiemKhachHang() { }

        public void TimKiemKHTheoMaKH(TextBox maKH, DataGridView data)
        {
            data.DataSource = DAOTimKiemKhachHang.Instance.TimKiemKHTheoMaKH(maKH.Text);
        }

        public void TimKiemKHTheoTenKH(TextBox tenKH, DataGridView data)
        {
            data.DataSource = DAOTimKiemKhachHang.Instance.TimKiemKHTheoTenKH(tenKH.Text);
        }

        public void TimKiemKHTheoSDT(TextBox SDT, DataGridView data)
        {
            data.DataSource = DAOTimKiemKhachHang.Instance.TimKiemKHTheoSDT(SDT.Text);
        }
    }
}
