using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAnNhomNet
{
    public partial class frmDanhSachSanPham : Form
    {
        
        public frmDanhSachSanPham()
        {
            InitializeComponent();
            LoadForm();

        }
        
        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void LoadForm()
        {
            LoadSanPham();
            LoadTenLoai();
            LoadTenHang();
            //HienThiHinhAnh();
           
        }

        private void LoadSanPham()
        {
            BUS_SanPham.Instance.Xem(dgvSanPham);
        }

        private void dgvSanPham_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Kiểm tra nếu lỗi liên quan đến việc không có giá trị mặc định cho cell
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Vui lòng nhập giá trị cho cell.");
                e.Cancel = true;
            }
        }

        private void dgvSanPham_Click(object sender, EventArgs e)
        {
            var row = dgvSanPham.Rows[dgvSanPham.CurrentCell.RowIndex];
            txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
            cboTenLoai.Text = row.Cells["MaLoai"].Value.ToString();
            cboTenHang.Text = row.Cells["MaHang"].Value.ToString();
            txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
            txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();

            var anh = row.Cells["HinhAnh"].Value as Image;
            picHinhAnh.Image = anh;
        }

        private void cboTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        public void LoadTenLoai()
        {
            BUS_SanPham.Instance.LoadTenLoai(cboTenLoai);
        }
        public void LoadTenHang()
        {
            BUS_SanPham.Instance.LoadTenHang(cboTenHang);
        }

       

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)|*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(openFileDialog.FileName);
                txtHinhAnh.Text = Path.GetFileName(openFileDialog.FileName);
            }
        }
        private byte[] ConvertImageToBytes(string imagePath)
        {
            byte[] imageData = null;

            try
            {
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, imageData.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chuyển đổi hình ảnh: " + ex.Message);
            }

            return imageData;
        }

        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)|*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.ImageLocation = openFileDialog.FileName;
                txtHinhAnh.Text = openFileDialog.FileName;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LayHinhAnhBangMaSP();
            BUS_SanPham.Instance.Sua(txtMaSP, txtTenSP, cboTenLoai, cboTenHang, txtGiaBan, txtHinhAnh, txtGhiChu);
            LoadSanPham();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS_SanPham.Instance.Xoa(txtMaSP);
            LoadSanPham();
        }
        public void LayHinhAnhBangMaSP()
        {
            BUS_SanPham.Instance.LayHinhAnhBangMaSP(txtMaSP);
        }
        private void ofdOpenFile_FileOk(object sender, CancelEventArgs e)
        {
            ofdOpenFile.ShowDialog();
            string file = ofdOpenFile.FileName;
            if (string.IsNullOrEmpty(file))
            {
                return;
            }
            Image spImage = Image.FromFile(file);
            picHinhAnh.Image = spImage;
        }

        private void frmDanhSachSanPham_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            BUS_SanPham.Instance.Them(txtMaSP, txtTenSP, cboTenLoai, cboTenHang, txtGiaBan, txtHinhAnh, txtGhiChu);
            LoadSanPham();

        }
    }
}
