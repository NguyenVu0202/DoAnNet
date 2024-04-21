using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAONhanVien
    {
        private static DAONhanVien instance;

        public static DAONhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAONhanVien();
                return instance;
            }
        }

        private DAONhanVien() { }

        public List<string> LoadMaCH()
        {
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var mach = (from ch in db.CuaHangs
                        select ch.MaCH).ToList();
            return mach;
        }

        public void ThemNhanVien(NhanVien nhanVien)
        {
            try
            {
                TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
                db.NhanViens.InsertOnSubmit(nhanVien);
                db.SubmitChanges();
                MessageBox.Show("Thêm Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Thất Bại" + ex.Message);
            }
        }

        public List<NhanVien> LoadNV()
        {
            List<NhanVien> listnv = new List<NhanVien>();

            try
            {
                TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
                var nv = (from s in db.NhanViens
                          select s).ToList();
                foreach(var item in nv)
                {
                    NhanVien nhanVien = new NhanVien();
                    nhanVien.MaNV = item.MaNV;
                    nhanVien.TenNV = item.TenNV;
                    nhanVien.GioiTinh = item.GioiTinh;
                    nhanVien.NgaySinh = item.NgaySinh;
                    nhanVien.SDT = item.SDT;
                    nhanVien.DiaChi = item.DiaChi;
                    nhanVien.Luong = item.Luong;
                    nhanVien.MaCH = item.MaCH;
                    listnv.Add(nhanVien);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            return listnv;
        }

        public void LoadDgvLenForm(TextBox manv, TextBox tennv, RadioButton gtnam, RadioButton gtnu, DateTimePicker ngaysinh, TextBox sdt, TextBox diachi, TextBox luong, ComboBox mach, DataGridView data)
        {
            var rowIndex = data.SelectedCells[0].RowIndex;
            var row = data.Rows[rowIndex];
            manv.Text = row.Cells["MaNV"].Value.ToString().Trim();
            tennv.Text = row.Cells["TenNV"].Value.ToString().Trim();
            if(row.Cells["GioiTinh"].Value.ToString().Trim() == "Nam")
            {
                gtnam.Checked = true;
            }
            else
            {
                gtnu.Checked = true;
            }
            ngaysinh.Text = ((DateTime)row.Cells["NgaySinh"].Value).ToString("yyyy-MM-dd");
            sdt.Text = row.Cells["SDT"].Value.ToString().Trim();
            luong.Text = row.Cells["Luong"].Value.ToString().Trim();
            diachi.Text = row.Cells["DiaChi"].Value.ToString().Trim();
            mach.Text = row.Cells["MaCH"].Value.ToString().Trim();
        }

        public void SuaNV(NhanVien nhanVien)
        {
            try
            {
                TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
                NhanVien nv = db.NhanViens.SingleOrDefault(p=>p.MaNV == nhanVien.MaNV);
                nv.TenNV = nhanVien.TenNV;
                nv.GioiTinh = nhanVien.GioiTinh;
                nv.NgaySinh = nhanVien.NgaySinh;
                nv.SDT = nhanVien.SDT;
                nv.Luong = nhanVien.Luong;
                nv.DiaChi = nhanVien.DiaChi;
                nv.MaCH = nhanVien.MaCH;
                db.SubmitChanges();
                MessageBox.Show("Sửa Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa Thất Bại" + ex.Message);
            }
        }

        public void XoaNV(string maNV)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa khách hàng này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                try
                {
                    TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
                    var nv = db.NhanViens.FirstOrDefault(p=>p.MaNV == maNV);
                    db.NhanViens.DeleteOnSubmit(nv);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa Thành Công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa Thất Bại" + ex.Message);
                }
            }
        }
    }
}
