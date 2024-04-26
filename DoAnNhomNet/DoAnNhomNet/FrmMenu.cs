using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhomNet
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang frmKhachHang = new FrmKhachHang();
            frmKhachHang.MdiParent = this;
            frmKhachHang.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien frmNhanVien = new FrmNhanVien();
            frmNhanVien.MdiParent = this;
            frmNhanVien.Show();
        }

        private void mnuDanhMucHang_Click(object sender, EventArgs e)
        {
            FormDanhMucHang frm = new FormDanhMucHang();
            frm.Show();
            frm.MdiParent = this;
        }

        private void mnuTimKiemKhachHang_Click(object sender, EventArgs e)
        {
            FrmTimKiemKhachHang frmTimKiemKhachHang = new FrmTimKiemKhachHang();
            frmTimKiemKhachHang.MdiParent = this;
            frmTimKiemKhachHang.Show();
        }

        private void mnuTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            FrmTimKiemNhanVien frmTimKiemNhanVien = new FrmTimKiemNhanVien();
            frmTimKiemNhanVien.MdiParent = this;
            frmTimKiemNhanVien.Show();
        }

        private void mnuThongKeLuongNV_Click(object sender, EventArgs e)
        {
            FrmThongKeLuongNhanVienTheoCuaHang frm = new FrmThongKeLuongNhanVienTheoCuaHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            frmDanhSachSanPham fr = new frmDanhSachSanPham();
            fr.MdiParent = this;
            fr.Show();
        }

        private void mnuDanhMucLoai_Click(object sender, EventArgs e)
        {
            frmDanhSachLoai frm = new frmDanhSachLoai();
            frm.Show();
            frm.MdiParent = this;
        }

        private void mnuCuaHang_Click(object sender, EventArgs e)
        {
            frmDanhSachCuaHang frm = new frmDanhSachCuaHang();
            frm.Show();
            frm.MdiParent = this;
        }

        private void mnuKho_Click(object sender, EventArgs e)
        {
            frmDanhSachKho frm = new frmDanhSachKho();
            frm.Show();
            frm.MdiParent = this;
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            FrmHoaDon frm = new FrmHoaDon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void chiTiếtHĐToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChiTietHoaDon frm = new FrmChiTietHoaDon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuTimKiemHoaDon_Click(object sender, EventArgs e)
        {
            FrmTimKiemHoaDon frm = new FrmTimKiemHoaDon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuThongKeDanhThu_Click(object sender, EventArgs e)
        {
            FrmThongKeDoanhThu frm = new FrmThongKeDoanhThu();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
