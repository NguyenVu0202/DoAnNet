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
        Hang h = new Hang();
        public FormDanhMucHang()
        {
            InitializeComponent();
           
        }
        public void LoadForm()
        {
            BUS_Hang.Instance.Xem(dgvHang);
        }

        private void dgvHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvHang.Rows[dgvHang.CurrentCell.RowIndex];
            txtMaHang.Text = row.Cells["MaHang"].Value.ToString();
            txtTenHang.Text = row.Cells["TenHang"].Value.ToString();
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
                LoadForm();
               
            }
            catch (Exception)
            {
                MessageBox.Show("Them khong thanh cong");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Ban co muon xoa ko???","Thong Bao",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                BUS_Hang.Instance.Xoa(txtMaHang);
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
            Hang hang = new Hang
            {
               MaHang = txtMaHang.Text,
               TenHang = txtTenHang.Text,
            };

            BUS_Hang bus = new BUS_Hang();
            bool result = bus.Sua(txtMaHang.Text, hang);

            if (result)
            {
                MessageBox.Show("Sửa thông tin sản phẩm thành công!");
                LoadForm() ;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm cần sửa hoặc có lỗi xảy ra khi sửa thông tin!");
            }
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            BUS_Hang.Instance.Xem(dgvHang);
        }
    }
}
