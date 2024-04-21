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
    public partial class FrmTimKiemNhanVien : Form
    {
        public FrmTimKiemNhanVien()
        {
            InitializeComponent();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if(txtMaNV.Text.Length > 0)
            {
                txtTenNV.ReadOnly = true;
                txtMaCH.ReadOnly = true;
            }    
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            if (txtTenNV.Text.Length > 0)
            {
                txtMaNV.ReadOnly = true;
                txtMaCH.ReadOnly = true;
            }
        }

        private void txtMaCH_TextChanged(object sender, EventArgs e)
        {
            if (txtMaCH.Text.Length > 0)
            {
                txtTenNV.ReadOnly = true;
                txtMaNV.ReadOnly = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTenNV.ReadOnly == true && txtMaCH.ReadOnly == true)
            {
                BUSTimKiemNhanVien.Instance.TimKiemNVTheoMaNV(txtMaNV, dgvTimKiemNhanVien);
            }
            else if (txtMaNV.ReadOnly == true && txtMaCH.ReadOnly == true)
            {
                BUSTimKiemNhanVien.Instance.TimKiemNVTheoTenNV(txtTenNV, dgvTimKiemNhanVien);
            }
            else if (txtTenNV.ReadOnly == true && txtMaNV.ReadOnly == true)
            {
                BUSTimKiemNhanVien.Instance.TimKiemNVTheoMaCH(txtMaCH, dgvTimKiemNhanVien);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaCH.Text = "";
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            dgvTimKiemNhanVien.DataSource = null;
            txtMaCH.ReadOnly = false;
            txtMaNV.ReadOnly = false;
            txtTenNV.ReadOnly = false;
        }
    }
}
