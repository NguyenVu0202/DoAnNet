using BUS;
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
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        public void XemKH()
        {
            BUSKhachHang.Instance.XemKH(dgvDanhSachKH);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BUSKhachHang.Instance.RegisterKH(txtMaKH, radNam, radNu, txtSDT, txtTenKH, txtDiaChi);
            XemKH();
        }       

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            XemKH();
        }

        private void dgvDanhSachKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BUSKhachHang.Instance.LoadDgvLenForm(txtMaKH, radNam, radNu, txtSDT, txtTenKH, txtDiaChi, dgvDanhSachKH);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BUSKhachHang.Instance.SuaKH(txtMaKH, radNam, radNu, txtSDT, txtTenKH, txtDiaChi);
            XemKH();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUSKhachHang.Instance.XoaKH(txtMaKH);
            XemKH();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn Thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
