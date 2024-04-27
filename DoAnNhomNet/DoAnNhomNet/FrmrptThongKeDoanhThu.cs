using BUS;
using DAO;
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
    public partial class FrmrptThongKeDoanhThu : Form
    {
        public FrmrptThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void FrmrptThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            BUSThongKeDoanhThu.Instance.LoadMaCH(cboMaCH);
        }

        private void cboMaCH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime tuNgay, denNgay;
            if (!DateTime.TryParseExact(dtpTuNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tuNgay) ||
                !DateTime.TryParseExact(dtpDenNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out denNgay))
            {
                // Xử lý trường hợp người dùng nhập không đúng định dạng ngày tháng
                MessageBox.Show("Vui lòng chọn ngày bắt đầu và ngày kết thúc hợp lệ (dd/MM/yyyy).");
                return;
            }

            // Load dữ liệu vào bảng từ cơ sở dữ liệu
            this.ThongKeDoanhThuTheoCHTableAdapter.Fill(this.TheGioiDiDongDataSet1.ThongKeDoanhThuTheoCH, cboMaCH.Text, tuNgay, denNgay);

            // Cập nhật báo cáo để hiển thị dữ liệu mới
            this.rptThongKeDoanhThu.RefreshReport();
        }
    }
}
