using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAOChiTietHoaDon
    {
        private static DAOChiTietHoaDon instance;

        public static DAOChiTietHoaDon Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new DAOChiTietHoaDon();
                }
                return instance;
            }
        }
        public DAOChiTietHoaDon() { }

        public List<string> LoadMaHD()
        {
            List<string> list = new List<string>();
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var mahd = (from hd in db.HoaDons
                            select new
                            {
                                hd.MaHD
                            }).ToList();
                foreach (var item in mahd)
                {
                    list.Add(item.MaHD);
                }
            }
            return list;
        }

        public List<string> LoadMaSPTheoCH(string mahd)
        {
            List<string> list = new List<string>();
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var mach = (from chh in db.CuaHangs
                            join nv in db.NhanViens on chh.MaCH equals nv.MaCH
                            join hoadon in db.HoaDons on nv.MaNV equals hoadon.MaNV
                            where hoadon.MaHD == mahd
                            select chh.MaCH).FirstOrDefault();

                if (mach != null)
                {
                    var masp = (from sp in db.SanPhams
                                join k in db.Khos on sp.MaSP equals k.MaSP
                                join ch in db.CuaHangs on k.MaCH equals ch.MaCH
                                where ch.MaCH == mach // Sử dụng Contains để kiểm tra
                                select new
                                {
                                    sp.MaSP
                                });

                    foreach (var item in masp)
                    {
                        list.Add(item.MaSP);
                    }
                }
            }
            return list;
        }

        public string LoadTenSP(string masp)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var ten = db.SanPhams.FirstOrDefault(p => p.MaSP == masp);
                if (ten != null)
                {
                    return ten.TenSP;
                }
                return "";
            }
        }

        public string LoadGiaSP(string masp)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var ten = db.SanPhams.FirstOrDefault(p => p.MaSP == masp);
                if (ten != null)
                {
                    return (ten.GiaBan).ToString();
                }
                return "";
            }
        }

        public string LoadHinhSP(string masp)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var hinh = db.SanPhams.FirstOrDefault(p => p.MaSP == masp);
                if (hinh != null)
                {
                    return hinh.HinhAnh;
                }
                return "C:\\Users\\NGUYEN VU\\Desktop\\DoAnNhomNet\\DoAnNhomNet\\bin\\Debug\\Image\\chuacoanh.png";
            }
        }

        public void ThemChiTietHoaDon(ChiTietHoaDon cthd)
        {
            try
            {
                using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
                {
                    db.ChiTietHoaDons.InsertOnSubmit(cthd);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm Thành Công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex);
            }
        }

        public void TruSoLuongSPTrongKho(string mahd, string masp, int soluong)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var kho = (from k in db.Khos
                           join ch in db.CuaHangs on k.MaCH equals ch.MaCH
                           join nv in db.NhanViens on ch.MaCH equals nv.MaCH
                           join hd in db.HoaDons on nv.MaNV equals hd.MaNV
                           join cthd in db.ChiTietHoaDons on hd.MaHD equals cthd.MaHD
                           where cthd.MaHD == mahd && k.MaSP == masp
                           select k).FirstOrDefault();
                if (kho != null)
                {
                    kho.SoLuong -= soluong;
                    db.SubmitChanges();
                }
            }
        }

        public void CongSoLuongSPTrongKho(string mahd, string masp, int soluong)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var kho = (from k in db.Khos
                           join ch in db.CuaHangs on k.MaCH equals ch.MaCH
                           join nv in db.NhanViens on ch.MaCH equals nv.MaCH
                           join hd in db.HoaDons on nv.MaNV equals hd.MaNV
                           join cthd in db.ChiTietHoaDons on hd.MaHD equals cthd.MaHD
                           where cthd.MaHD == mahd && k.MaSP == masp
                           select k).FirstOrDefault();
                if (kho != null)
                {
                    kho.SoLuong += soluong;
                    db.SubmitChanges();
                }
            }
        }

        public List<ChiTietHoaDon> XemChiTietHoaDon(string macthd)
        {
            List<ChiTietHoaDon> list = new List<ChiTietHoaDon> ();
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var chitiethoadon =  (from cthd in db.ChiTietHoaDons
                                      where cthd.MaChiTietHD == macthd
                                      select cthd).ToList();
                foreach(var item in chitiethoadon)
                {
                    ChiTietHoaDon chiTiet = new ChiTietHoaDon();
                    
                    chiTiet.MaChiTietHD = item.MaChiTietHD;
                    chiTiet.MaHD = item.MaHD;
                    chiTiet.MaSP = item.MaSP;
                    chiTiet.SoLuong = item.SoLuong;
                    chiTiet.GiaSP = item.GiaSP;
                    chiTiet.GiamGia = item.GiamGia;
                    chiTiet.ThanhTien = item.ThanhTien;

                    list.Add(chiTiet);
                }
            }
            return list;
        }

        public void LoadDgvLenForm(TextBox macthd, ComboBox mahd, ComboBox masp, TextBox giasp, TextBox soluong, TextBox giamgia, TextBox thanhtien, DataGridView data)
        {
            var rowIndex = data.SelectedCells[0].RowIndex;
            var row = data.Rows[rowIndex];
            macthd.Text = row.Cells[0].Value.ToString().Trim();
            mahd.Text = row.Cells[1].Value.ToString().Trim();
            masp.Text = row.Cells[2].Value.ToString().Trim();
            soluong.Text = row.Cells[3].Value.ToString().Trim();
            giasp.Text = row.Cells[4].Value.ToString().Trim();
            giamgia.Text = row.Cells[5].Value.ToString().Trim();
            thanhtien.Text = row.Cells[6].Value.ToString().Trim();
        }

        public void XoaCTHD(string macthd)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var cthd = db.ChiTietHoaDons.FirstOrDefault(a => a.MaChiTietHD == macthd);
                if (cthd != null)
                {
                    db.ChiTietHoaDons.DeleteOnSubmit(cthd);
                    db.SubmitChanges();
                }
            }
        }

        public void CongTongTienHD(string macthd, string mahd)
        {

            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                int tongtien = 0;
                var chitiethd = (from cthd in db.ChiTietHoaDons
                               where cthd.MaChiTietHD == macthd
                               select new
                               {
                                   cthd.ThanhTien

                               }).ToList();
                if(chitiethd != null)
                {
                    foreach (var item in chitiethd)
                    {
                        tongtien += item.ThanhTien??0;
                    }
                }

                var hoadon = (from hd in db.HoaDons
                                 where hd.MaHD == mahd
                                 select hd).FirstOrDefault();

                if(hoadon != null)
                {
                    hoadon.TongTien = tongtien;
                    db.SubmitChanges();
                }
            }    
        }
    }
}
