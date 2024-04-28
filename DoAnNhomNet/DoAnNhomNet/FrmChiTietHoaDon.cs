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
    public partial class FrmChiTietHoaDon : Form
    {
        public FrmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void FrmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            LoadMaHD();
            cboMaHD.SelectedIndex = -1;
        }

        private void LoadMaHD()
        {
            BUSChiTietHoaDon.Instance.LoadMaHD(cboMaHD);
        }

        private void LoadMaSP()
        {
            BUSChiTietHoaDon.Instance.LoadMaSPTheoCH(cboMaSP, cboMaHD);
        }

        private void LoadTenSP()
        {
            BUSChiTietHoaDon.Instance.LoadTenSP(cboMaSP, txtTenSP);
        }

        private void LoadGiaSP()
        {
            BUSChiTietHoaDon.Instance.LoadGiaSP(cboMaSP, txtGiaSP);
        }

        private void LoadHinhAnh()
        {
            BUSChiTietHoaDon.Instance.LoadHinhSP(cboMaSP, picHinhAnh);
        }

        private void cboMaSP_Leave(object sender, EventArgs e)
        {
            LoadTenSP();
            LoadGiaSP();
            LoadHinhAnh();
        }

        private void cboMaHD_Leave(object sender, EventArgs e)
        {
            LoadMaSP();
        }
        
        private void tinhThanhTien()
        {
            double thanhtien = 0;
            double soLuong = double.Parse(txtSoLuong.Text);
            double giamGia = double.Parse(txtGiamGia.Text) / 100;
            double donGia = double.Parse(txtGiaSP.Text);
            thanhtien = (donGia * soLuong) - (donGia * giamGia * soLuong);
            txtThanhTien.Text = thanhtien.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BUSChiTietHoaDon.Instance.ThemChiTietHoaDon(txtMaChiTietHD, cboMaHD, cboMaSP, txtGiaSP, txtSoLuong, txtGiamGia, txtThanhTien);
            TruSoLuongSPTrongKho();
            CongTongTienHD();
            XemChiTietHoaDon();
            LoadLaiForm();
        }

        private void txtGiamGia_Leave(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "" && txtGiamGia.Text == "" || txtGiamGia.Text == "" || txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Số Lượng và Đơn Giá");
            }
            else
            {
                tinhThanhTien();
            }
        }       
        private void TruSoLuongSPTrongKho()
        {
            BUSChiTietHoaDon.Instance.TruSoLuongSPTrongKho(cboMaHD, cboMaSP, txtSoLuong);
        }

        private void CongSoLuongSPTrongKho()
        {
            BUSChiTietHoaDon.Instance.CongSoLuongSPTrongKho(cboMaHD, cboMaSP, txtSoLuong);
        }

        private void XemChiTietHoaDon()
        {
            BUSChiTietHoaDon.Instance.XemChiTietHoaDon(dgvDanhSachChiTietHoaDon, txtMaChiTietHD);
        }

        private void dgvDanhSachChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BUSChiTietHoaDon.Instance.LoadDgvLenForm(txtMaChiTietHD, cboMaHD, cboMaSP, txtGiaSP, txtSoLuong, txtGiamGia, txtThanhTien, dgvDanhSachChiTietHoaDon);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                BUSChiTietHoaDon.Instance.XoaCTHD(txtMaChiTietHD);
                CongSoLuongSPTrongKho();
                CongTongTienHD();
                XemChiTietHoaDon();
                LoadLaiForm();
            }
        }

        private void CongTongTienHD()
        {
            BUSChiTietHoaDon.Instance.CongTongTienHD(txtMaChiTietHD, cboMaHD);
        }

        private void LoadLaiForm()
        {
            cboMaSP.SelectedIndex = -1;
            txtTenSP.Text = "";
            txtGiaSP.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "";
            txtThanhTien.Text = "";
        }
    }
}
