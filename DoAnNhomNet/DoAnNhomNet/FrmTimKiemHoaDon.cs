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
    public partial class FrmTimKiemHoaDon : Form
    {
        public FrmTimKiemHoaDon()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtMaKH.ReadOnly == true)
            {
                BUSTimKiemHoaDon.Instance.TimKiemHoaDonTheoMaHD(txtMaHD, dgvTimKiemHoaDon);
            }
            else if (txtMaHD.ReadOnly == true)
            {
                BUSTimKiemHoaDon.Instance.TimKiemHoaDonTheoMaKH(txtMaKH, dgvTimKiemHoaDon);
            }
            else
            {
                BUSTimKiemHoaDon.Instance.TimKiemHoaDonTheoNgayBan(dtpNgay, dgvTimKiemHoaDon);
            }    
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtMaKH.Text = "";
            txtMaHD.ReadOnly = false;
            txtMaKH.ReadOnly = false;
            dtpNgay.Text = DateTime.Now.ToString();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Length > 0)
            {
                txtMaKH.ReadOnly = true;
            }
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Length > 0)
            {
                txtMaHD.ReadOnly = true;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FrmrptHoaDon frm = new FrmrptHoaDon();
            frm.ShowDialog();
        }
    }
}
