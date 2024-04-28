using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_ThongKeSanPham
    {
        private static DAO_ThongKeSanPham instance;

        public static DAO_ThongKeSanPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO_ThongKeSanPham();
                return instance;
            }
        }
        private DAO_ThongKeSanPham() { }




        public string LayHinhAnhBangMaSP(TextBox masp)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var sanpham = db.SanPhams.SingleOrDefault(sp => sp.MaSP == masp.Text);
                return sanpham.HinhAnh;
            }
        }

        public void LoadDgvLenForm(TextBox masp, TextBox tensp, ComboBox tenloai, ComboBox tenhang, TextBox giaban, PictureBox picHinhAnh, TextBox ghichu, DataGridView data)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var rowIndex = data.SelectedCells[0].RowIndex;
                var row = data.Rows[rowIndex];
                masp.Text = row.Cells[0].Value.ToString().Trim();
                tensp.Text = row.Cells[1].Value.ToString().Trim();
                var loai = (from l in db.Loais
                            where l.MaLoai == row.Cells[2].Value.ToString().Trim()
                            select l.TenLoai).FirstOrDefault();
                tenloai.Text = loai.ToString();
                var hang = (from h in db.Hangs
                            where h.MaHang == row.Cells[3].Value.ToString().Trim()
                            select h.TenHang).FirstOrDefault();
                tenhang.Text = hang.ToString();
                giaban.Text = row.Cells[4].Value.ToString().Trim();
                var anh = row.Cells[5].Value as Image;
                picHinhAnh.Image = anh;
                ghichu.Text = row.Cells[6].Value.ToString().Trim();
            }
        }
        public void LoadComBoBoxMaSP(ComboBox cb)
        {
            List<string> lst = new List<string>();
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var maSP = from sp in db.SanPhams
                           select new { sp.MaSP };
                foreach (var item in maSP)
                {
                    lst.Add(item.MaSP);
                }
                cb.DataSource = lst;
            }
        }
        public void LoadComBoBoxMaCH(ComboBox cb)
        {
            List<string> lst = new List<string>();
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var maCH = from sp in db.CuaHangs
                           select new { sp.MaCH };
                foreach (var item in maCH)
                {
                    lst.Add(item.MaCH);
                }
                cb.DataSource = lst;
            }
        }
        public string LoadTenSP(string maSP)
        {
            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var tenSP = (from sp in db.SanPhams
                             where sp.MaSP == maSP
                             select sp.TenSP).FirstOrDefault();

                return tenSP;
            }
        }
        public DataTable TimKiemTheoMaSPMaCH(string maCH, string maSP, string tuNgay, string denNgay)
        {
            DataTable table = new DataTable();

            // Define the columns of the DataTable
            table.Columns.Add("MaCuaHang", typeof(string));
            table.Columns.Add("MaHD", typeof(string));
            table.Columns.Add("MaSP", typeof(string));
            table.Columns.Add("TenSP", typeof(string));
            table.Columns.Add("DaBan", typeof(decimal));
            table.Columns.Add("TuNgay", typeof(string));
            table.Columns.Add("DenNgay", typeof(string));

            using (TheGioiDiDongDataContext db = new TheGioiDiDongDataContext())
            {
                var tuNgayFormatted = Convert.ToDateTime(tuNgay);
                var toiNgayFormatted = Convert.ToDateTime(denNgay);
                var thongke = from sp in db.SanPhams
                              join cthd in db.ChiTietHoaDons on sp.MaSP equals cthd.MaSP
                              join hd in db.HoaDons on cthd.MaHD equals hd.MaHD
                              join nv in db.NhanViens on hd.MaNV equals nv.MaNV
                              join ch in db.CuaHangs on nv.MaCH equals ch.MaCH
                              where ch.MaCH == maCH && sp.MaSP == maSP && hd.NgayBan >= tuNgayFormatted && hd.NgayBan <= toiNgayFormatted
                              group cthd by new { ch.MaCH, hd.MaHD, sp.MaSP, sp.TenSP, tuNgayFormatted, toiNgayFormatted } into g
                              select new
                              {
                                  MaCuaHang = g.Key.MaCH,
                                  maHD = g.Key.MaHD,
                                  maSP = g.Key.MaSP,
                                  tenSP = g.Key.TenSP,
                                  DaBan = g.Sum(cthd => cthd.SoLuong), // Sum of quantity
                                  TuNgay = g.Key.tuNgayFormatted,
                                DenNgay = g.Key.toiNgayFormatted,
                            };
                foreach (var item in thongke)
                {
                    // Create a new row for each item in the result
                    DataRow row = table.NewRow();
                    row["MaCuaHang"] = item.MaCuaHang;
                    row["MaHD"] = item.maHD;
                    row["MaSP"] = item.maSP;
                    row["TenSP"] = item.tenSP;
                    row["DaBan"] = item.DaBan;
                    row["TuNgay"] = item.TuNgay.ToString("yyyy/MM/dd");
                    row["DenNgay"] = item.DenNgay.ToString("yyyy/MM/dd");
                    table.Rows.Add(row);
                }
            }
            return table;
        }
      

        

    }
}
