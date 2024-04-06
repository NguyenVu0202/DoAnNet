using BUS;
using DAO;
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
    public partial class FormDanhMucHang : Form
    {
        BUS_Hang busHang = new BUS_Hang();
        public FormDanhMucHang()
        {
            InitializeComponent();
            LoadForm();
        }
        public void LoadForm()
        {
            BUS_Hang.Instance.Xem(dgvHang);
        }

        private void dgvHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            txtMaHang.Text = dgvHang.Rows[row].Cells[0].Value.ToString();
            txtTenHang.Text = dgvHang.Rows[row].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Hang h = new Hang
                {
                    MaHang = txtMaHang.Text,
                    TenHang = txtTenHang.Text,
                };
                busHang.Them(h);
                MessageBox.Show("Them thanh cong");
                BUS_Hang.Instance.Xem(dgvHang);
            }
            catch (Exception)
            {
                MessageBox.Show("Them khong thanh cong");
            }
        }
    }
}
