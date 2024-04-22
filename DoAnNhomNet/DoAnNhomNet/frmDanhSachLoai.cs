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
    public partial class frmDanhSachLoai : Form
    {
        public frmDanhSachLoai()
        {
            InitializeComponent();
        }
        public void LoadForm()
        {
            BUS_Loai.Instance.Xem(dgvLoai);
        }
        private void dgvLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvLoai.Rows[dgvLoai.CurrentCell.RowIndex];
            txtMaLoai.Text = row.Cells["MaLoai"].Value.ToString();
            txtTenLoai.Text = row.Cells["TenLoai"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Loai loai = new Loai
                {
                    MaLoai = txtMaLoai.Text,
                    TenLoai = txtTenLoai.Text,
                };
                BUS_Loai.Instance.Them(loai);
                MessageBox.Show("Them thanh cong");
                LoadForm();
            }
            catch (Exception)
            {
                MessageBox.Show("Them ko thanh cong!!!!!!!!!!");
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Ban co muon xoa ko???", "Thong Bao",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                BUS_Loai.Instance.Xoa(txtMaLoai);
                MessageBox.Show("Xoa Thanh cong");
                LoadForm();
            }
            else
            {
                MessageBox.Show("ko The Xoa ");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Loai loai = new Loai
            {
                MaLoai = txtMaLoai.Text,
                TenLoai = txtTenLoai.Text,
            };

            BUS_Loai bus = new BUS_Loai();
            bool result = bus.Sua(txtMaLoai.Text, loai);

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

        private void btnShow_Click(object sender, EventArgs e)
        {
            BUS_Loai.Instance.Xem(dgvLoai);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Ban co muon Thoat ko???", "Thong Bao",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
