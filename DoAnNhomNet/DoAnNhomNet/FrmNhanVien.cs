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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadMaCH();
            LoadNV();
        }
        public void LoadMaCH()
        {
            BUSNhanVien.Instance.LoadMaCH(cboMaCH);
        }

        public void LoadNV()
        {
            BUSNhanVien.Instance.LoadNV(dgvDanhSachNhanVien);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            BUSNhanVien.Instance.ThemNhanVien(txtMaNV, txtTenNV, radNam, radNu, dtpNgaySinh, txtSDT, txtDiaChi, txtLuong, cboMaCH);
            LoadNV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BUSNhanVien.Instance.SuaNV(txtMaNV, txtTenNV, radNam, radNu, dtpNgaySinh, txtSDT, txtDiaChi, txtLuong, cboMaCH);
            LoadNV();
        }

        private void dgvDanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BUSNhanVien.Instance.LoadDgvLenForm(txtMaNV, txtTenNV, radNam, radNu, dtpNgaySinh, txtSDT, txtDiaChi, txtLuong, cboMaCH, dgvDanhSachNhanVien);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUSNhanVien.Instance.XoaNV(txtMaNV);
            LoadNV();
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
