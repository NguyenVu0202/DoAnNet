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
    public partial class frmDanhSachCuaHang : Form
    {
        public frmDanhSachCuaHang()
        {
            InitializeComponent();
            LoadForm();
        }
        public void LoadForm()
        {
            BUS_CuaHang.Instance.Xem(dgvCuaHang);
        }

        private void dgvCuaHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvCuaHang.Rows[dgvCuaHang.CurrentCell.RowIndex];
            txtMaCH.Text = row.Cells["MaCH"].Value.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                CuaHang ch = new CuaHang
                {
                    MaCH = txtMaCH.Text,
                    DiaChi = txtDiaChi.Text,
                };
                BUS_CuaHang.Instance.Them(ch);
                MessageBox.Show("Them thanh cong!!!");
                LoadForm();
            }
            catch (Exception)
            {

                MessageBox.Show("Them ko thanh cong!!!");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            BUS_CuaHang.Instance.Xem(dgvCuaHang);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Ban co muon xoa ko???", "Thong Bao",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                BUS_Hang.Instance.Xoa(txtMaCH);
                MessageBox.Show("Xoa Thanh cong");
                LoadForm() ;
            }
            else
            {
                MessageBox.Show("ko The Xoa ");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CuaHang ch = new CuaHang
            {
                MaCH = txtMaCH.Text,
                DiaChi = txtDiaChi.Text,
            };

            BUS_CuaHang bus = new BUS_CuaHang();
            bool result = bus.Sua(txtMaCH.Text, ch);

            if (result)
            {
                MessageBox.Show("Sửa thông tin sản phẩm thành công!");
                LoadForm();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm cần sửa hoặc có lỗi xảy ra khi sửa thông tin!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Ban mun thoat ko????", "Thong Bao",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
