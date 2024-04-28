using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSHoaDon
    {
        private static BUSHoaDon instance;

        public static BUSHoaDon Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new BUSHoaDon();
                }
                return instance;
            }
        }
        public BUSHoaDon() { }

        public void ThemHoaDon(TextBox maHD, DateTimePicker ngayBan, ComboBox maNV, ComboBox maKH)
        {
            HoaDon hoaDon = new HoaDon
            {
                MaHD = maHD.Text,
                NgayBan = Convert.ToDateTime(ngayBan.Text),
                MaNV = maNV.Text,
                MaKH = maKH.Text,
                TongTien = 0
            };

            DAOHoaDon.Instance.ThemHoaDon(hoaDon);
        }

        public void LoadMaKH(ComboBox maKH)
        {
            maKH.DataSource = DAOHoaDon.Instance.LoadMaKH();
        }

        public void LoadMaNV(ComboBox maNV)
        {
            maNV.DataSource = DAOHoaDon.Instance.LoadMaNV();
        }

        public void LoadThongTinNV(TextBox tenNV, TextBox maCH ,ComboBox maNV)
        {
            List<string> list = new List<string>();
            list = DAOHoaDon.Instance.LoadThongTinNV(maNV.Text);
            tenNV.Text = list[0];
            maCH.Text = list[1];
        }

        public void LoadThongTinKH(TextBox tenKH, TextBox diachiKH, TextBox sdtKH,ComboBox maKH)
        {
            List<string> list = new List<string>();
            list = DAOHoaDon.Instance.LoadThongTinKH(maKH.Text);
            tenKH.Text = list[0];
            diachiKH.Text = list[1];
            sdtKH.Text = list[2];
        }

        public void XemHoaDon(DataGridView data)
        {
            var hd = DAOHoaDon.Instance.XemHoaDon().Select(x =>
            {
                return new
                {
                    x.MaHD,
                    x.NgayBan,
                    x.TongTien,
                    x.MaKH,
                    x.MaNV
                };
            }).ToList();
            data.DataSource = hd;
        }

        public void LoadDgvLenForm(TextBox maHD, DateTimePicker ngayBan, ComboBox maNV, ComboBox maKH, DataGridView data)
        {
            DAOHoaDon.Instance.LoadDgvLenForm(maHD, ngayBan, maNV, maKH, data);
        }

        public void SuaHoaDon(TextBox maHD, DateTimePicker ngayBan, ComboBox maNV, ComboBox maKH)
        {
            HoaDon hoaDon = new HoaDon
            {
                MaHD = maHD.Text,
                NgayBan = Convert.ToDateTime(ngayBan.Text),
                TongTien = 0,
                MaNV = maNV.Text,
                MaKH = maKH.Text,
            };

            DAOHoaDon.Instance.SuaHoaDon(hoaDon);
        }

        public void XoaHoaDon(TextBox maHD)
        {
            DAOHoaDon.Instance.XoaHoaDon(maHD.Text);
        }
    }
}
