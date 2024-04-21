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
            FormDanhMucHang formDanhMucHang = new FormDanhMucHang();
            formDanhMucHang.MdiParent = this;
            formDanhMucHang.Show();
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
    }
}
