using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_TimKiemKho
    {
        private static BUS_TimKiemKho instance;

        public static BUS_TimKiemKho Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new BUS_TimKiemKho();
                }
                return instance;
            }
        }
        public BUS_TimKiemKho() { }

        public void TimKiemMaKho(TextBox makho, DataGridView data)
        {
            var dt = DAO_TimKiemKho.Instance.TimKiemMaKho(makho.Text).Select(x =>
            {
                return new
                {
                    x.MaKho,
                    x.MaCH,
                    x.MaSP,

                };
            }).ToList();
            data.DataSource = dt;
        }
        public void TimKiemMaCuaHang(TextBox maCH, DataGridView data)
        {
            var dt = DAO_TimKiemKho.Instance.TimKiemMaCH(maCH.Text).Select(x =>
            {
                return new
                {
                   
                    x.MaCH,
                    x.DiaChi,

                };
            }).ToList();
            data.DataSource = dt;
        }
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
    }
}
