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
    public partial class FrmThongKeDoanhThu : Form
    {
        public FrmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void LoadMaCH()
        {
            BUSThongKeDoanhThu.Instance.LoadMaCH(cboMaCH);
        }

        private void FrmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            LoadMaCH();
            cboMaCH.SelectedIndex = -1;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            BUSThongKeDoanhThu.Instance.ThongKeDoanhThu(cboMaCH, dtpTuNgay, dtpToiNgay, dgvDoanhThu);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboMaCH.SelectedIndex = -1;
            dtpTuNgay.Text = DateTime.Now.ToString();
            dtpToiNgay.Text = DateTime.Now.ToString();
            dgvDoanhThu.DataSource = null;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FrmrptThongKeDoanhThu frm = new FrmrptThongKeDoanhThu();
            frm.ShowDialog();
        }
    }
}
