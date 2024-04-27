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
    public partial class FrmrptInLuongNVCuaCH : Form
    {
        public FrmrptInLuongNVCuaCH()
        {
            InitializeComponent();
        }

        private void FrmrptInTongLuongNVCuaCH_Load(object sender, EventArgs e)
        {
            BUSNhanVien.Instance.LoadMaCH(cboMaCH);
            cboMaCH.SelectedIndex = -1;
        }

        private void cboMaCH_TextChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TheGioiDiDongDataSet1.ThongKeLuongNVTheoMaCH' table. You can move, or remove it, as needed.
            this.ThongKeLuongNVTheoMaCHTableAdapter.Fill(this.TheGioiDiDongDataSet1.ThongKeLuongNVTheoMaCH, cboMaCH.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
