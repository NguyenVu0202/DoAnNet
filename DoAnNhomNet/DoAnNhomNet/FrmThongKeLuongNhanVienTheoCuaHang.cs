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
    public partial class FrmThongKeLuongNhanVienTheoCuaHang : Form
    {
        public FrmThongKeLuongNhanVienTheoCuaHang()
        {
            InitializeComponent();
        }

        private void FrmThongKeLuongNhanVienTheoCuaHang_Load(object sender, EventArgs e)
        {
            LoadMaCH();
            cboMaCH.SelectedIndex = -1;
        }

        private void LoadMaCH()
        {
            BUSThongKeLuongTheoCH.Instance.LoadMaCH(cboMaCH);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            BUSThongKeLuongTheoCH.Instance.ThongKeLuongNVTheoCH(cboMaCH, dgvLuongNhanVien);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboMaCH.SelectedIndex = -1;
        }
    }
}
