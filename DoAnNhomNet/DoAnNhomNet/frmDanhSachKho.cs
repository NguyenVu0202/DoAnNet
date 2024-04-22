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
        }
        private void dgvDanhSachKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvDanhSachKho.Rows[dgvDanhSachKho.CurrentCell.RowIndex];
            txtMaKho.Text = row.Cells["MaKHo"].Value.ToString();
            cboMaCH.Text = row.Cells["MaCH"].Value.ToString();
            cboMaSP.Text = row.Cells["MaSP"].Value.ToString();
            txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
           
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

        private void frmDanhSachKho_Load(object sender, EventArgs e)
        {
            
        }
    }
}
