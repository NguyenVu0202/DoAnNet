using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAOKhachHang
    {
        private static DAOKhachHang instance;

        public static DAOKhachHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAOKhachHang();
                return instance;
            }
        }

        private DAOKhachHang() { }

        public List<KhachHang> XemKH()
        {
            List<KhachHang> list = new List<KhachHang>();

            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var kh = (from s in db.KhachHangs
                      select new {s.MaKH, s.TenKH, s.GioiTinh, s.SDT, s.DiaChi}).ToList();
            
            foreach(var s in kh)
            {
                KhachHang khachHang = new KhachHang();
                khachHang.MaKH = s.MaKH;
                khachHang.TenKH = s.TenKH;
                khachHang.GioiTinh = s.GioiTinh;
                khachHang.SDT = s.SDT;
                khachHang.DiaChi = s.DiaChi;
                list.Add(khachHang);
            }
            return list;
        }
        public void RegisterKh(KhachHang khachHang)
        {
            try
            {
                TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
                db.KhachHangs.InsertOnSubmit(khachHang);
                db.SubmitChanges();
                MessageBox.Show("Thêm Khách Hàng Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Khách Hàng Thất Bại" + ex.Message);
            }
        }

        public void LoadDgvLenForm(TextBox maKH, RadioButton gtNam, RadioButton gtNu, TextBox sdt, TextBox tenKH, TextBox diaChi, DataGridView data)
        {
            var rowIndex = data.SelectedCells[0].RowIndex;
            var row = data.Rows[rowIndex];
            maKH.Text = row.Cells["MaKH"].Value.ToString().Trim();
            tenKH.Text = row.Cells["TenKH"].Value.ToString().Trim();
            if (row.Cells["GioiTinh"].Value.ToString().Trim() == "Nam")
            {
                gtNam.Checked = true;
            }
            else
            {
                gtNu.Checked = true;
            }
            sdt.Text = row.Cells["SDT"].Value.ToString().Trim();
            diaChi.Text = row.Cells["DiaChi"].Value.ToString().Trim();
        }

        public void SuaKH(KhachHang khachHang)
        {
            try
            {
                TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
                KhachHang kh = db.KhachHangs.SingleOrDefault(p => p.MaKH == khachHang.MaKH);
                kh.TenKH = khachHang.TenKH;
                kh.SDT = khachHang.SDT;
                kh.GioiTinh = khachHang.GioiTinh;
                kh.DiaChi = khachHang.DiaChi;
                db.SubmitChanges();
                MessageBox.Show("Sửa Khách Hàng Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa Khách Hàng Thất Bại" + ex.Message);
            }
        }

        public void XoaKH(string maKH)
        {
           DialogResult r = MessageBox.Show("Bạn có muốn xóa khách hàng này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
                    var kh = db.KhachHangs.FirstOrDefault(p => p.MaKH == maKH);
                    db.KhachHangs.DeleteOnSubmit(kh);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa Khách Hàng Thành Công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa Khách Hàng Thất Bại" + ex.Message);
                }
            }
        }
    }
}
