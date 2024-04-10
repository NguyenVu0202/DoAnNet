using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class BUSKhachHang
    {
        private static BUSKhachHang instance;

        public static BUSKhachHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUSKhachHang();
                return instance;
            }
        }
        private BUSKhachHang() { }

        public void RegisterKH(TextBox maKH, RadioButton gtNam, RadioButton gtNu, TextBox sdt, TextBox tenKH, TextBox diaChi)
        {
            string gioitinh;
            if (gtNam.Checked == true)
            {
                gioitinh = gtNam.Text;
            }
            else
            {
                gioitinh = gtNu.Text;
            }

            KhachHang khachHang = new KhachHang
            {
                MaKH = maKH.Text,
                GioiTinh = gioitinh,
                SDT = sdt.Text,
                TenKH = tenKH.Text,
                DiaChi = diaChi.Text
            };

            DAOKhachHang.Instance.RegisterKh(khachHang);
        }

        public void XemKH(DataGridView data)
        {
            data.DataSource = DAOKhachHang.Instance.XemKH();
        }

        public void LoadDgvLenForm(TextBox maKH, RadioButton gtNam, RadioButton gtNu, TextBox sdt, TextBox tenKH, TextBox diaChi, DataGridView data)
        {
            DAOKhachHang.Instance.LoadDgvLenForm(maKH,gtNam,gtNu,sdt,tenKH,diaChi,data);
        }

        public void SuaKH(TextBox maKH, RadioButton gtNam, RadioButton gtNu, TextBox sdt, TextBox tenKH, TextBox diaChi)
        {
            string gioitinh;
            if (gtNam.Checked == true)
            {
                gioitinh = gtNam.Text;
            }
            else
            {
                gioitinh = gtNu.Text;
            }
            KhachHang khachHang = new KhachHang
            {
                MaKH = maKH.Text,
                GioiTinh = gioitinh,
                SDT = sdt.Text,
                TenKH = tenKH.Text,
                DiaChi = diaChi.Text
            };
            DAOKhachHang.Instance.SuaKH(khachHang);
        }

        public void XoaKH(TextBox maKH)
        {
            DAOKhachHang.Instance.XoaKH(maKH.Text);
        }
    }
}
