using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhomNet
{
    public partial class FrmrptThongKeSanPhamDaBanTheoMaCH : Form
    {
        public FrmrptThongKeSanPhamDaBanTheoMaCH()
        {
            InitializeComponent();
        }

        private void FrmrptThongKeSanPhamDaBanTheoMaCH_Load(object sender, EventArgs e)
        {
            BUSNhanVien.Instance.LoadMaCH(cboMaCH);
            cboMaCH.SelectedIndex = -1;
        }

        private void cboMaCH_TextChanged(object sender, EventArgs e)
        {
            DateTime tuNgay, denNgay;
            if (!DateTime.TryParseExact(dtpTuNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tuNgay) ||
                !DateTime.TryParseExact(dtpDenNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out denNgay))
            {
                // Xử lý trường hợp người dùng nhập không đúng định dạng ngày tháng
                MessageBox.Show("Vui lòng chọn ngày bắt đầu và ngày kết thúc hợp lệ (dd/MM/yyyy).");
                return;
            }
            // TODO: This line of code loads data into the 'TheGioiDiDongDataSet.ThongKeSanPhamDaBanCuaCuaHang' table. You can move, or remove it, as needed.
            this.ThongKeSanPhamDaBanCuaCuaHangTableAdapter.Fill(this.TheGioiDiDongDataSet.ThongKeSanPhamDaBanCuaCuaHang, cboMaCH.Text, tuNgay, denNgay);

            this.reportViewer1.RefreshReport();
        }
    }
}
