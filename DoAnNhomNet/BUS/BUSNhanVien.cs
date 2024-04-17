using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSNhanVien
    {
        private static BUSNhanVien instance;

        public static BUSNhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUSNhanVien();
                return instance;
            }
        }
        private BUSNhanVien() { }
        public void LoadMaCH(ComboBox mach)
        {
            List<string> listmach = new List<string>();
            listmach = DAONhanVien.Instance.LoadMaCH();
            mach.DataSource = listmach;
        }

        public void ThemNhanVien(TextBox manv, TextBox tennv, RadioButton gtnam, RadioButton gtnu, DateTimePicker ngaysinh, TextBox sdt, TextBox diachi, TextBox luong, ComboBox mach)
        {
            string gioitinh;
            if(gtnam.Checked == true)
            {
                gioitinh = gtnam.Text;
            }
            else
            {
                gioitinh = gtnu.Text;
            }
            NhanVien nhanVien = new NhanVien
            {
                MaNV = manv.Text,
                TenNV = tennv.Text,
                GioiTinh = gioitinh,
                NgaySinh = Convert.ToDateTime(ngaysinh.Text),
                SDT = sdt.Text,
                DiaChi = diachi.Text,
                Luong = int.Parse(luong.Text),
                MaCH = mach.Text
            };
            DAONhanVien.Instance.ThemNhanVien(nhanVien);
        }

        public void LoadNV(DataGridView data)
        {
            data.DataSource = DAONhanVien.Instance.LoadNV();
        }

        public void LoadDgvLenForm(TextBox manv, TextBox tennv, RadioButton gtnam, RadioButton gtnu, DateTimePicker ngaysinh, TextBox sdt, TextBox diachi, TextBox luong, ComboBox mach, DataGridView data)
        {
            DAO.DAONhanVien.Instance.LoadDgvLenForm(manv, tennv, gtnam, gtnu, ngaysinh, sdt, diachi, luong, mach, data);
        }

        public void SuaNV(TextBox manv, TextBox tennv, RadioButton gtnam, RadioButton gtnu, DateTimePicker ngaysinh, TextBox sdt, TextBox diachi, TextBox luong, ComboBox mach)
        {
            string gioitinh;
            if (gtnam.Checked == true)
            {
                gioitinh = gtnam.Text;
            }
            else
            {
                gioitinh = gtnu.Text;
            }
            NhanVien nhanVien = new NhanVien
            {
                MaNV = manv.Text,
                TenNV = tennv.Text,
                GioiTinh = gioitinh,
                NgaySinh = Convert.ToDateTime(ngaysinh.Text),
                SDT = sdt.Text,
                DiaChi = diachi.Text,
                Luong = int.Parse(luong.Text),
                MaCH = mach.Text
            };
            DAONhanVien.Instance.SuaNV(nhanVien);
        }

        public void XoaNV(TextBox manv)
        {
            DAONhanVien.Instance.XoaNV(manv.Text);
        }
    }
}
