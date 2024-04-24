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
    public partial class FrmTimKiemKhachHang : Form
    {
        public FrmTimKiemKhachHang()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTenKH.ReadOnly == true && txtSDT.ReadOnly == true)
            {
                BUSTimKiemKhachHang.Instance.TimKiemKHTheoMaKH(txtMaKH, dgvTimKiemKH);
            }
            else if (txtMaKH.ReadOnly == true && txtSDT.ReadOnly == true)
            {
                BUSTimKiemKhachHang.Instance.TimKiemKHTheoTenKH(txtTenKH, dgvTimKiemKH);
            }
            else if (txtTenKH.ReadOnly == true && txtMaKH.ReadOnly == true)
            {
                BUSTimKiemKhachHang.Instance.TimKiemKHTheoSDT(txtSDT, dgvTimKiemKH);
            }

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Length > 0)
            {
                txtSDT.ReadOnly = true;
                txtTenKH.ReadOnly = true;
            }
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            if (txtTenKH.Text.Length > 0)
            {
                txtSDT.ReadOnly = true;
                txtMaKH.ReadOnly = true;
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length > 0)
            {
                txtMaKH.ReadOnly = true;
                txtTenKH.ReadOnly = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            dgvTimKiemKH.DataSource = null;
            txtMaKH.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtTenKH.ReadOnly = false;
        }
    }
}
