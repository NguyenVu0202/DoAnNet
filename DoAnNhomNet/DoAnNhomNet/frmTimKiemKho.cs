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
    public partial class frmTimKiemKho : Form
    {
        public frmTimKiemKho()
        {
            InitializeComponent();
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

            if (txtMaSP.Text.Length > 0)
            {
                txtMaCH.ReadOnly = true;
                txtMaCH.Text = "";
                txtMaKho.ReadOnly = true;
                txtMaKho.Text = "";

            
            }
        }

        private void txtMaCH_TextChanged(object sender, EventArgs e)
        {
            if (txtMaCH.Text.Length > 0)
            {
                txtMaSP.ReadOnly = true;
                txtMaSP.Text = "";
                txtMaKho.ReadOnly = true;
                txtMaKho.Text = "";


            }
        }

        private void txtMaKho_TextChanged(object sender, EventArgs e)
        {
            if (txtMaKho.Text.Length > 0)
            {
                txtMaCH.ReadOnly = true;
                txtMaCH.Text = "";
                txtMaSP.ReadOnly = true;
                txtMaSP.Text = "";


            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.ReadOnly == true && txtMaKho.ReadOnly == true )
            {
                BUS_TimKiemKho.Instance.TimKiemMaCuaHang(txtMaCH, dgvTimKiemSP);
            }
            else if(txtMaCH.ReadOnly == true && txtMaKho.ReadOnly == true)
            {
                BUS_TimKiemKho.Instance.TimKiemSPTheoMaSP(txtMaSP, dgvTimKiemSP);
            }
            else if (txtMaCH.ReadOnly == true && txtMaSP.ReadOnly == true)
            {
                BUS_TimKiemKho.Instance.TimKiemSPTheoMaSP(txtMaKho, dgvTimKiemSP);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtMaCH.Text = "";
            txtMaKho.Text = "";
        }
    }
}
