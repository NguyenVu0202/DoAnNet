using BUS;
using DAO;
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
    public partial class frmDanhSachKho : Form
    {
        public frmDanhSachKho()
        {
            InitializeComponent();
            LoadForm();
       }
        public void LoadForm()
        {
            LoadKho();
            LoadCoBoBoxMaCH();
            LoadCoBoBoxMaSP();
            LoadComboBoxMaCH();
        }
        private void dgvDanhSachKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BUS_Kho.Instance.LoadDgvLenForm(txtMaKho, cboMaCH, cboMaSP, txtSoLuong, dgvDanhSachKho);  
        }
        public void LoadKho()
        {
            BUS_Kho.Instance.Xem(dgvDanhSachKho);
        }
        public void LoadCoBoBoxMaSP()
        {
            BUS_Kho.Instance.LoadSanPham(cboMaSP);

        }
        public void LoadCoBoBoxMaCH()
        {
            BUS_Kho.Instance.LoadCuaHang(cboMaCH);

        }

        private void LoadComboBoxMaCH()
        {
            BUS_Kho.Instance.LoadCuaHang(cboMaCH);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BUS_Kho.Instance.ThemKho(txtMaKho, cboMaCH, cboMaSP, txtSoLuong);
            LoadKho();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS_Kho.Instance.XoaKho(txtMaKho);
            LoadKho();
        }
    }
}
