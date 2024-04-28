using DAO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_TimKiemSanPham
    {
        private static BUS_TimKiemSanPham instance;

        public static BUS_TimKiemSanPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_TimKiemSanPham();
                return instance;
            }
        }
        private BUS_TimKiemSanPham() { }

        public void TimKiemSPTheoMaSP(TextBox maSP, DataGridView data)
        {
            var dt = DAO_TimKiemSanPham.Instance.TimKiemSanPhamTheoMaSP(maSP.Text).Select(t =>
            {
                return new
                {
                    t.MaSP,
                    t.MaLoai,
                    t.MaHang,
                    t.TenSP,
                    t.GiaBan,
                    t.HinhAnh,
                    t.GhiChu
                };
            }).ToList();
            data.DataSource = dt;
        }
        public void TimKiemSPTheoMaLoai(TextBox maLoai, DataGridView data)
        {
            var dt = DAO_TimKiemSanPham.Instance.TimKiemSanPhamTheoMaLoai(maLoai.Text).Select(t =>
            {
                return new
                {
                    t.MaSP,
                    t.MaLoai,
                    t.MaHang,
                    t.TenSP,
                    t.GiaBan,
                    t.HinhAnh,
                    t.GhiChu
                };
            }).ToList();
            data.DataSource = dt;
        }
        public void TimKiemSPTheoMaHang(TextBox maHang, DataGridView data)
        {
            var dt = DAO_TimKiemSanPham.Instance.TimKiemSanPhamTheoMaHang(maHang.Text).Select(t =>
            {
                return new
                {
                    t.MaSP,
                    t.MaLoai,
                    t.MaHang,
                    t.TenSP,
                    t.GiaBan,
                    t.HinhAnh,
                    t.GhiChu
                };
            }).ToList();
            data.DataSource = dt;
        }
        public void TimKiemSPTheoTenSP(TextBox tenSP, DataGridView data)
        {
            var dt = DAO_TimKiemSanPham.Instance.TimKiemSanPhamTheoTenSP(tenSP.Text).Select(t =>
            {
                return new
                {
                    t.MaSP,
                    t.MaLoai,
                    t.MaHang,
                    t.TenSP,
                    t.GiaBan,
                    t.HinhAnh,
                    t.GhiChu
                };
            }).ToList();
            data.DataSource = dt;
        }
        public void TimKiemSPTheoGiaDuoi2TR(CheckBox gia, DataGridView data)
        {
            var dt = DAO_TimKiemSanPham.Instance.TimKiemSanPhamCoGiaDuoi2TR(gia.Text).Select(t =>
            {
                return new
                {
                    t.MaSP,
                    t.MaLoai,
                    t.MaHang,
                    t.TenSP,
                    t.GiaBan,
                    t.HinhAnh,
                    t.GhiChu
                };
            }).ToList();
            data.DataSource = dt;
        }
        public void TimKiemSPTheoGiaDuoi10TR(CheckBox gia, DataGridView data)
        {
            var dt = DAO_TimKiemSanPham.Instance.TimKiemSanPhamCoGiaDuoi10TR(gia.Text).Select(t =>
            {
                return new
                {
                    t.MaSP,
                    t.MaLoai,
                    t.MaHang,
                    t.TenSP,
                    t.GiaBan,
                    t.HinhAnh,
                    t.GhiChu
                };
            }).ToList();
            data.DataSource = dt;
        }
        public void TimKiemSPTheoGiaDuoi15TR(CheckBox gia, DataGridView data)
        {
            var dt = DAO_TimKiemSanPham.Instance.TimKiemSanPhamCoGiaDuoi15TR(gia.Text).Select(t =>
            {
                return new
                {
                    t.MaSP,
                    t.MaLoai,
                    t.MaHang,
                    t.TenSP,
                    t.GiaBan,
                    t.HinhAnh,
                    t.GhiChu
                };
            }).ToList();
            data.DataSource = dt;
        }
        public void TimKiemSPTheoGiaDuoi20TR(CheckBox gia, DataGridView data)
        {
            var dt = DAO_TimKiemSanPham.Instance.TimKiemSanPhamCoGiaDuoi20TR(gia.Text).Select(t =>
            {
                return new
                {
                    t.MaSP,
                    t.MaLoai,
                    t.MaHang,
                    t.TenSP,
                    t.GiaBan,
                    t.HinhAnh,
                    t.GhiChu
                };
            }).ToList();
            data.DataSource = dt;
        }
        public void TimKiemSPTheoGiaTren20TR(CheckBox gia, DataGridView data)
        {
            var dt = DAO_TimKiemSanPham.Instance.TimKiemSanPhamCoGiaTren20TR(gia.Text).Select(t =>
            {
                return new
                {
                    t.MaSP,
                    t.MaLoai,
                    t.MaHang,
                    t.TenSP,
                    t.GiaBan,
                    t.HinhAnh,
                    t.GhiChu
                };
            }).ToList();
            data.DataSource = dt;

        }
        public void TimKiemSPTheoGiaDuoi5TR(CheckBox gia, DataGridView data)
        {
            var dt = DAO_TimKiemSanPham.Instance.TimKiemSanPhamCoGiaDuoi5TR(gia.Text).Select(t =>
            {
                return new
                {
                    t.MaSP,
                    t.MaLoai,
                    t.MaHang,
                    t.TenSP,
                    t.GiaBan,
                    t.HinhAnh,
                    t.GhiChu
                };
            }).ToList();
            data.DataSource = dt;

        }

        public void LoadHinhSP(ComboBox masp)
        {
            Image image = Image.FromFile(DAOChiTietHoaDon.Instance.LoadHinhSP(masp.Text));
        }
        public void LoadDgvLenForm(TextBox masp, TextBox tensp, ComboBox tenloai, ComboBox tenhang, TextBox giaban, PictureBox picHinhAnh, TextBox ghichu, DataGridView data)
        {
            DAO_SanPham.Instance.LoadDgvLenForm(masp, tensp, tenloai, tenhang, giaban, picHinhAnh, ghichu, data);
        }
    }
}
