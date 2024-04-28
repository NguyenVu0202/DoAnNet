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
    public partial class FrmrptHoaDon : Form
    {
        public FrmrptHoaDon()
        {
            InitializeComponent();
        }

        private void FrmrptHoaDon_Load(object sender, EventArgs e)
        {           
            BUSChiTietHoaDon.Instance.LoadMaHD(cboMaHD);
            cboMaHD.SelectedIndex = -1;
        }

        private void cboMaHD_TextChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TheGioiDiDongDataSet1.HienThiHoaDonTheoMa' table. You can move, or remove it, as needed.
            this.HienThiHoaDonTheoMaTableAdapter.Fill(this.TheGioiDiDongDataSet.HienThiHoaDonTheoMa, cboMaHD.Text);

            this.rptHoaDon.RefreshReport();
        }
    }
}
