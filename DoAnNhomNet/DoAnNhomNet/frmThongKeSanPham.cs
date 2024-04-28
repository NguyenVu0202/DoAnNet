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
    public partial class frmThongKeSanPham : Form
    {
        public frmThongKeSanPham()
        {
            InitializeComponent();
        }
        
        public void LoadComBoBoxMaCH()
        {
            BUS_ThongKeSanPham.Instance.LoadComBoBoxMaCH(cboMaCH);
        }
        public void LoadComBoBoxMaSP()
        {
            BUS_ThongKeSanPham.Instance.LoadComBoBoxMaSP(cboMaSP);
        }
        private void btnThongKeTheoSP_Click(object sender, EventArgs e)
        {
            BUS_ThongKeSanPham.Instance.TimKiemTheoMaSPMaCH(cboMaCH, cboMaSP, dtpTuNgay, dtpToiNgay, dgvBanSP);
        }

        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
           
            LoadComBoBoxMaSP();
            LoadComBoBoxMaCH();
            cboMaCH.SelectedIndex = -1;
            cboMaSP.SelectedIndex = -1;
        }
        private void LoadTenSP()
        {
            if (cboMaSP.Text.Length > 0)
            {
                string maSP = cboMaSP.SelectedValue.ToString().Trim();
                string tenSP = BUS_ThongKeSanPham.Instance.LoadTen(maSP);

                txtTenSP.Text = tenSP;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FrmrptThongKeSanPhamDaBanTheoMaCH frm = new FrmrptThongKeSanPhamDaBanTheoMaCH();
            frm.ShowDialog();
        }

        private void cboMaSP_Leave(object sender, EventArgs e)
        {
            LoadTenSP();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboMaCH.SelectedIndex = -1;
            cboMaCH.Text = "";

            txtTenSP.Text = "";
            cboMaSP.SelectedIndex = -1;
            cboMaSP.Text = "";
        }
    }
}
