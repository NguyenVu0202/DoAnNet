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
    public class BUSChiTietHoaDon
    {
        private static BUSChiTietHoaDon instance;

        public static BUSChiTietHoaDon Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new BUSChiTietHoaDon();
                }
                return instance;
            }
        }
        public BUSChiTietHoaDon() { }

        public void LoadMaHD(ComboBox cb)
        {
            cb.DataSource = DAOChiTietHoaDon.Instance.LoadMaHD();
        }

        public void LoadMaSPTheoCH(ComboBox cbmasp, ComboBox mahd)
        {
            cbmasp.DataSource = DAOChiTietHoaDon.Instance.LoadMaSPTheoCH(mahd.Text);
        }

        public void LoadTenSP(ComboBox cb, TextBox tensp)
        {
            tensp.Text = DAOChiTietHoaDon.Instance.LoadTenSP(cb.Text);
        }

        public void LoadGiaSP(ComboBox cb, TextBox giasp)
        {
            giasp.Text = DAOChiTietHoaDon.Instance.LoadGiaSP(cb.Text);
        }

        public void LoadHinhSP(ComboBox masp, PictureBox pic)
        {
                Image image = Image.FromFile(DAOChiTietHoaDon.Instance.LoadHinhSP(masp.Text));
                pic.Image = image;
        }

        public void ThemChiTietHoaDon(TextBox macthd, ComboBox mahd, ComboBox masp, TextBox giasp, TextBox soluong, TextBox giamgia, TextBox thanhtien)
        {
            ChiTietHoaDon cthd = new ChiTietHoaDon
            {
                MaChiTietHD = macthd.Text,
                MaHD = mahd.Text,
                MaSP = masp.Text,
                GiaSP = int.Parse(giasp.Text),
                SoLuong = int.Parse(soluong.Text),
                GiamGia = int.Parse(giamgia.Text),
                ThanhTien = int.Parse(thanhtien.Text)
            };
            DAOChiTietHoaDon.Instance.ThemChiTietHoaDon(cthd);
        }

        public void TruSoLuongSPTrongKho(ComboBox mahd, ComboBox masp, TextBox soluong)
        {
            DAOChiTietHoaDon.Instance.TruSoLuongSPTrongKho(mahd.Text, masp.Text, int.Parse(soluong.Text));
        }

        public void CongSoLuongSPTrongKho(ComboBox mahd, ComboBox masp, TextBox soluong)
        {
            DAOChiTietHoaDon.Instance.CongSoLuongSPTrongKho(mahd.Text, masp.Text, int.Parse(soluong.Text));
        }

        public void XemChiTietHoaDon(DataGridView data, TextBox macthd)
        {
            var cthd = DAOChiTietHoaDon.Instance.XemChiTietHoaDon(macthd.Text).Select(t =>
            {
                return new
                {
                    t.MaChiTietHD,
                    t.MaHD,
                    t.MaSP,
                    t.SoLuong,
                    t.GiaSP,
                    t.GiamGia,
                    t.ThanhTien
                };
            }).ToList();
            data.DataSource = cthd;
        }

        public void LoadDgvLenForm(TextBox macthd, ComboBox mahd, ComboBox masp, TextBox giasp, TextBox soluong, TextBox giamgia, TextBox thanhtien, DataGridView data)
        {
            DAOChiTietHoaDon.Instance.LoadDgvLenForm(macthd, mahd, masp, giasp, soluong, giamgia, thanhtien, data);
        }

        public void XoaCTHD(TextBox macthd)
        {
            DAOChiTietHoaDon.Instance.XoaCTHD(macthd.Text);
        }

        public void CongTongTienHD(TextBox macthd, ComboBox mahd)
        {
            DAOChiTietHoaDon.Instance.CongTongTienHD(macthd.Text, mahd.Text);
        }
    }
}
