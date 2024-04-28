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
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }               

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            LoadMaNV();
            LoadMaKH();
            cboMaNV.SelectedIndex = -1;
            cboMaKH.SelectedIndex = -1;
            XemHD();
        }

        private void XemHD()
        {
            BUSHoaDon.Instance.XemHoaDon(dgvDanhSachHoaDon);
        }

        private void LoadMaNV()
        {
            BUSHoaDon.Instance.LoadMaNV(cboMaNV);
        }

        private void cboMaNV_Leave(object sender, EventArgs e)
        {
            if(cboMaNV != null)
            {
                BUSHoaDon.Instance.LoadThongTinNV(txtTenNV, txtMaCH,cboMaNV);
            }
            else
            {
                txtTenNV.Text = "";
                txtMaCH.Text = "";
            }    
        }

        private void LoadMaKH()
        {
            BUSHoaDon.Instance.LoadMaKH(cboMaKH);
        }

        private void cboMaKH_Leave(object sender, EventArgs e)
        {
            if (cboMaKH != null)
            {
                BUSHoaDon.Instance.LoadThongTinKH(txtTenKH, txtDiaChiKH, txtSDTKH, cboMaKH);
            }
            else
            {
                txtTenNV.Text = "";
                txtDiaChiKH.Text = "";
                txtSDTKH.Text = "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BUSHoaDon.Instance.ThemHoaDon(txtMaHD, dtpNgayBan, cboMaNV, cboMaKH);
            XemHD();
        }

        private void dgvDanhSachHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BUSHoaDon.Instance.LoadDgvLenForm(txtMaHD, dtpNgayBan, cboMaNV, cboMaKH, dgvDanhSachHoaDon);
        }

        private void dgvDanhSachHoaDon_Leave(object sender, EventArgs e)
        {
            if (cboMaKH != null && cboMaNV != null)
            {
                BUSHoaDon.Instance.LoadThongTinKH(txtTenKH, txtDiaChiKH, txtSDTKH, cboMaKH);
                BUSHoaDon.Instance.LoadThongTinNV(txtTenNV, txtMaCH, cboMaNV);
            }
            else
            {
                txtTenNV.Text = "";
                txtDiaChiKH.Text = "";
                txtSDTKH.Text = "";
                txtTenNV.Text = "";
                txtMaCH.Text = "";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BUSHoaDon.Instance.SuaHoaDon(txtMaHD, dtpNgayBan, cboMaNV, cboMaKH);
            XemHD();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUSHoaDon.Instance.XoaHoaDon(txtMaHD);
            XemHD();
        }

        private void txtLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            dtpNgayBan.Text = DateTime.Now.ToString();
            cboMaNV.SelectedIndex = -1;
            txtTenNV.Text = "";
            txtMaCH.Text = "";
            cboMaKH.SelectedIndex = -1;
            txtTenKH.Text = "";
            txtDiaChiKH.Text = "";
            txtSDTKH.Text = "";
        }
    }
}
