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

    public class BUS_SanPham
    {
       

        private static BUS_SanPham instance;

        public static BUS_SanPham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_SanPham();
                }
                return instance;
            }


        }
        private BUS_SanPham() { }


        public void Xem(DataGridView data)
        {
            var dt = DAO_SanPham.Instance.Xem().Select(t =>
            {
                var HinhAnh = Image.FromFile(t.HinhAnh);

                return new
                {
                    t.MaSP,
                    t.TenSP,
                    t.MaLoai,
                    t.MaHang,
                    t.GiaBan,
                    HinhAnh,
                    t.GhiChu

                };
            }).ToList();
            data.DataSource = dt;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)data.Columns[5];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        public void Them(TextBox masp, TextBox tensp, ComboBox tenloai, ComboBox tenhang, TextBox giaban, TextBox hinhanh, TextBox ghichu)
        {
            DAO_SanPham.Instance.Them(masp, tensp, tenloai, tenhang, giaban, hinhanh, ghichu);
        }
        public void LoadTenLoai(ComboBox cb)
        {
            DAO_SanPham.Instance.LoadComBoBox(cb);
        }
        public void LoadTenHang(ComboBox cb)
        {
            DAO_SanPham.Instance.LoadComBoxTenHang(cb);
        }
        public void Sua(TextBox masp, TextBox tensp, ComboBox tenloai, ComboBox tenhang, TextBox giaban, TextBox hinhanh, TextBox ghichu)
        {
            if (!string.IsNullOrEmpty(hinhanh.Text))
            {
                SanPham sp = new SanPham
                {
                    MaSP = masp.Text,
                    TenSP = tensp.Text,
                    MaLoai = tenloai.SelectedValue.ToString(),
                    MaHang = tenhang.SelectedValue.ToString(),
                    GiaBan = int.Parse(giaban.Text),
                    HinhAnh = hinhanh.Text,
                    GhiChu = ghichu.Text,

                };
                DAO_SanPham.Instance.Sua(sp);
            }
            else
            {
                SanPham sp = new SanPham
                {
                    MaSP = masp.Text,
                    TenSP = tensp.Text,
                    MaLoai = tenloai.SelectedValue.ToString(),
                    MaHang = tenhang.SelectedValue.ToString(),
                    GiaBan = int.Parse(giaban.Text),
                    HinhAnh = LayHinhAnhBangMaSP(masp),
                    GhiChu = ghichu.Text,

                };
                DAO_SanPham.Instance.Sua(sp);
            }
        }
        public string LayHinhAnhBangMaSP(TextBox masp)
        {
            return DAO_SanPham.Instance.LayHinhAnhBangMaSP(masp);
        }

        public void Xoa(TextBox masp)
        {
            DAO_SanPham.Instance.Xoa(masp.Text);
        }

        public void LoadDgvLenForm(TextBox masp, TextBox tensp, ComboBox tenloai, ComboBox tenhang, TextBox giaban, PictureBox picHinhAnh, TextBox ghichu, DataGridView data)
        {
            DAO_SanPham.Instance.LoadDgvLenForm(masp, tensp, tenloai, tenhang, giaban, picHinhAnh, ghichu, data);
        }
    }
}
