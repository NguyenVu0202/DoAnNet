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

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)|*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the image location and display it in PictureBox
                picHinhAnh.ImageLocation = openFileDialog.FileName;
                txtHinhAnh.Text = openFileDialog.FileName;

                // Get the selected file name and destination path
                string selectedFileName = Path.GetFileName(openFileDialog.FileName);
                string destinationPath = Path.Combine(Application.StartupPath, "Image", selectedFileName);

                try
                {
                    // Copy the selected file to the "hinhanh" folder
                    File.Copy(openFileDialog.FileName, destinationPath, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi sao chép hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void dgvSanPham_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            BUS_SanPham.Instance.LoadDgvLenForm(txtMaSP, txtTenSP, cboTenLoai, cboTenHang, txtGiaBan, picHinhAnh, txtGhiChu, dgvSanPham);
        }
    }
}
