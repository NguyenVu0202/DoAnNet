using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAOHoaDon
    {
        private static DAOHoaDon instance;

        public static DAOHoaDon Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new DAOHoaDon();
                }
                return instance;
            }
        }
        public DAOHoaDon() { }

        public void ThemHoaDon(HoaDon hoaDon)
        {
            using(TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                try
                {
                    db.HoaDons.InsertOnSubmit(hoaDon);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm Thành Công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm Thất Bại" + ex.Message);
                }
            }
        }

        public List<string> LoadMaNV()
        {
            List<string> lst = new List<string>();
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var manv = (from nv in db.NhanViens
                            select new
                            {
                                nv.MaNV
                            }).ToList();
                foreach(var nv in manv)
                {
                    lst.Add(nv.MaNV);
                }                
            }
            return lst;
        }

        public List<string> LoadThongTinNV(string maNV)
        {
            List<string> lst = new List<string>();
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var nhanvien = (from nv in db.NhanViens
                             where nv.MaNV.ToString() == maNV
                             select new
                             {
                                 nv.TenNV,
                                 nv.MaCH
                             }).FirstOrDefault();
                lst.Add(nhanvien.TenNV);
                lst.Add(nhanvien.MaCH);
            }
            return lst;
        }

        public List<string> LoadMaKH()
        {
            List<string> lst = new List<string>();

            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var makh = (from kh in db.KhachHangs
                            select new
                            {
                                kh.MaKH
                            }).ToList();
                foreach(var kh in makh)
                {
                    lst.Add(kh.MaKH);
                }    
            }
            return lst;
        }

        public List<string> LoadThongTinKH(string maKH)
        {
            List<string> lst = new List<string>();

            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var khachhang = (from kh in db.KhachHangs
                             where kh.MaKH.ToString() == maKH
                             select new
                             {
                                 kh.TenKH,
                                 kh.DiaChi,
                                 kh.SDT
                             }).FirstOrDefault();
                lst.Add(khachhang.TenKH);
                lst.Add(khachhang.DiaChi);
                lst.Add(khachhang.SDT);                    
            }
            return lst;
        }

        public List<HoaDon> XemHoaDon()
        {
            List<HoaDon> lst = new List<HoaDon>();

            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var hoadon = (from hd in db.HoaDons
                              select hd).ToList();
                foreach(var hd in hoadon)
                {
                    HoaDon hoaDon = new HoaDon
                    {
                        MaHD = hd.MaHD,
                        NgayBan = hd.NgayBan,
                        TongTien = hd.TongTien,
                        MaKH = hd.MaKH,
                        MaNV = hd.MaNV
                    };
                    lst.Add(hoaDon);
                }
            }
            return lst;
        }

        public void LoadDgvLenForm(TextBox maHD, DateTimePicker ngayBan, ComboBox maNV, ComboBox maKH, DataGridView data)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var rowIndex = data.SelectedCells[0].RowIndex;
                var row = data.Rows[rowIndex];
                maHD.Text = row.Cells[0].Value.ToString().Trim();
                ngayBan.Text = row.Cells[1].Value.ToString().Trim();
                maKH.Text = row.Cells[3].Value.ToString().Trim();
                maNV.Text = row.Cells[4].Value.ToString().Trim();
            }
        }

        public void SuaHoaDon(HoaDon hoaDon)
        {
            try
            {
                using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
                {
                    var updatehoadon = db.HoaDons.SingleOrDefault(p => p.MaHD == hoaDon.MaHD);
                    if (updatehoadon != null)
                    {
                        updatehoadon.NgayBan = hoaDon.NgayBan;
                        updatehoadon.TongTien = hoaDon.TongTien;
                        updatehoadon.MaKH = hoaDon.MaKH;
                        updatehoadon.MaNV = hoaDon.MaNV;
                        db.SubmitChanges();
                        MessageBox.Show("Sửa Thành Công");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa Thất Bại");
            }
        }

        public void XoaHoaDon(string maHD)
        {
            DialogResult r = MessageBox.Show("Bạn Có Muốn Xóa", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                try
                {
                    using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
                    {
                        var hoadon = db.HoaDons.FirstOrDefault(p => p.MaHD == maHD);
                        db.HoaDons.DeleteOnSubmit(hoadon);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa Thành Công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa Thất Bại");
                }
            }                
        }
    }
}
