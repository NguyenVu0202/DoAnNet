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
    public partial class frmTimKiemSanPham : Form
    {
        public frmTimKiemSanPham()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.ReadOnly == true && txtTenSP.ReadOnly == true && txtMaHang.ReadOnly == true && chkDuoi2tr.Checked == false &&
          chkDuoi5tr.Checked == false &&
          chkDuoi10tr.Checked == false &&
          chkDuoi15tr.Checked == false && chkDuoi20tr.Checked == false && chkTren20tr.Checked == false)
            {
                BUS_TimKiemSanPham.Instance.TimKiemSPTheoMaSP(txtMaSP, dgvTimKiemSP);
            }
            else if (txtMaLoai.ReadOnly == true && txtMaSP.ReadOnly == true && txtMaHang.ReadOnly == true && chkDuoi2tr.Checked == false &&
            chkDuoi5tr.Checked == false &&
            chkDuoi10tr.Checked == false &&
            chkDuoi15tr.Checked == false && chkDuoi20tr.Checked == false && chkTren20tr.Checked == false)
            {
                BUS_TimKiemSanPham.Instance.TimKiemSPTheoTenSP(txtTenSP, dgvTimKiemSP);
            }
            else if (txtTenSP.ReadOnly == true && txtMaSP.ReadOnly == true && txtMaHang.ReadOnly == true && chkDuoi2tr.Checked == false &&
           chkDuoi5tr.Checked == false &&
           chkDuoi10tr.Checked == false &&
           chkDuoi15tr.Checked == false && chkDuoi20tr.Checked == false && chkTren20tr.Checked == false)
            {
                BUS_TimKiemSanPham.Instance.TimKiemSPTheoMaLoai(txtTenSP, dgvTimKiemSP);
            }
            else if (txtMaLoai.ReadOnly == true && txtMaSP.ReadOnly == true && txtTenSP.ReadOnly == true && chkDuoi2tr.Checked == false &&
           chkDuoi5tr.Checked == false &&
           chkDuoi10tr.Checked == false &&
           chkDuoi15tr.Checked == false && chkDuoi20tr.Checked == false && chkTren20tr.Checked == false)
            {
                BUS_TimKiemSanPham.Instance.TimKiemSPTheoMaHang(txtTenSP, dgvTimKiemSP);
            }
            else if (txtMaLoai.ReadOnly == true && txtMaSP.ReadOnly == true && txtMaHang.ReadOnly == true && txtTenSP.ReadOnly == true &&
           chkDuoi5tr.Checked == false &&
           chkDuoi10tr.Checked == false &&
           chkDuoi15tr.Checked == false && chkDuoi20tr.Checked == false && chkTren20tr.Checked == false)
            {
                BUS_TimKiemSanPham.Instance.TimKiemSPTheoGiaDuoi2TR(chkDuoi2tr, dgvTimKiemSP);
            }
            else if (txtMaLoai.ReadOnly == true && txtMaSP.ReadOnly == true && txtMaHang.ReadOnly == true && txtTenSP.ReadOnly == true &&
              chkDuoi2tr.Checked == false &&
              chkDuoi10tr.Checked == false &&
              chkDuoi15tr.Checked == false && chkDuoi20tr.Checked == false && chkTren20tr.Checked == false)
            {
                BUS_TimKiemSanPham.Instance.TimKiemSPTheoGiaDuoi5TR(chkDuoi5tr, dgvTimKiemSP);
            }
            else if (txtMaLoai.ReadOnly == true && txtMaSP.ReadOnly == true && txtMaHang.ReadOnly == true && txtTenSP.ReadOnly == true &&
              chkDuoi5tr.Checked == false &&
              chkDuoi2tr.Checked == false &&
              chkDuoi15tr.Checked == false && chkDuoi20tr.Checked == false && chkTren20tr.Checked == false)
            {
                BUS_TimKiemSanPham.Instance.TimKiemSPTheoGiaDuoi10TR(chkDuoi10tr, dgvTimKiemSP);
            }
            else if (txtMaLoai.ReadOnly == true && txtMaSP.ReadOnly == true && txtMaHang.ReadOnly == true && txtTenSP.ReadOnly == true &&
          chkDuoi5tr.Checked == false &&
          chkDuoi10tr.Checked == false &&
          chkDuoi2tr.Checked == false && chkDuoi20tr.Checked == false && chkTren20tr.Checked == false)
            {
                BUS_TimKiemSanPham.Instance.TimKiemSPTheoGiaDuoi15TR(chkDuoi15tr, dgvTimKiemSP);
            }
            else if (txtMaLoai.ReadOnly == true && txtMaSP.ReadOnly == true && txtMaHang.ReadOnly == true && txtTenSP.ReadOnly == true &&
          chkDuoi5tr.Checked == false &&
          chkDuoi10tr.Checked == false &&
          chkDuoi15tr.Checked == false && chkDuoi2tr.Checked == false && chkTren20tr.Checked == false)
            {
                BUS_TimKiemSanPham.Instance.TimKiemSPTheoGiaDuoi20TR(chkDuoi20tr, dgvTimKiemSP);
            }
            else if (txtMaLoai.ReadOnly == true && txtMaSP.ReadOnly == true && txtMaHang.ReadOnly == true && txtTenSP.ReadOnly == true &&
          chkDuoi5tr.Checked == false &&
          chkDuoi10tr.Checked == false &&
          chkDuoi15tr.Checked == false && chkDuoi20tr.Checked == false && chkDuoi2tr.Checked == false)
            {
                BUS_TimKiemSanPham.Instance.TimKiemSPTheoGiaTren20TR(chkTren20tr, dgvTimKiemSP);
            }



        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Length > 0)
            {
                txtTenSP.ReadOnly = true;
                txtTenSP.Text = "";
                txtMaLoai.ReadOnly = true;
                txtMaLoai.Text = "";
                txtMaHang.ReadOnly = true;
                txtMaHang.Text = "";
                chkDuoi2tr.Checked = false;
                chkDuoi5tr.Checked = false;
                chkDuoi10tr.Checked = false;
                chkDuoi15tr.Checked = false;
                chkDuoi20tr.Checked = false;
                chkTren20tr.Checked = false;
            }
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSP.Text.Length > 0)
            {
                txtTenSP.ReadOnly = true;
                txtTenSP.Text = "";
                txtMaSP.ReadOnly = true;
                txtMaSP.Text = "";
                txtMaHang.ReadOnly = true;
                txtMaHang.Text = "";
                chkDuoi2tr.Checked = false;
                chkDuoi5tr.Checked = false;
                chkDuoi10tr.Checked = false;
                chkDuoi15tr.Checked = false;
                chkDuoi20tr.Checked = false;
                chkTren20tr.Checked = false;
            }
        }

        private void txtMaLoai_TextChanged(object sender, EventArgs e)
        {
            if (txtMaLoai.Text.Length > 0)
            {
                txtTenSP.ReadOnly = true;
                txtTenSP.Text = "";
                txtMaSP.ReadOnly = true;
                txtMaSP.Text = "";
                txtMaHang.ReadOnly = true;
                txtMaHang.Text = "";
                chkDuoi2tr.Checked = false;
                chkDuoi5tr.Checked = false;
                chkDuoi10tr.Checked = false;
                chkDuoi15tr.Checked = false;
                chkDuoi20tr.Checked = false;
                chkTren20tr.Checked = false;
            }
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHang.Text.Length > 0)
            {
                txtTenSP.ReadOnly = true;
                txtTenSP.Text = "";
                txtMaSP.ReadOnly = true;
                txtMaSP.Text = "";
                txtMaLoai.ReadOnly = true;
                txtMaLoai.Text = "";
                chkDuoi2tr.Checked = false;
                chkDuoi5tr.Checked = false;
                chkDuoi10tr.Checked = false;
                chkDuoi15tr.Checked = false;
                chkDuoi20tr.Checked = false;
                chkTren20tr.Checked = false;
            }
        }

        private void chkDuoi2tr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDuoi2tr.Checked == true)
            {
                txtTenSP.ReadOnly = true;
                txtTenSP.Text = "";
                txtMaSP.ReadOnly = true;
                txtMaSP.Text = "";
                txtMaLoai.ReadOnly = true;
                txtMaLoai.Text = "";
                txtMaHang.ReadOnly = true;
                txtMaHang.Text = "";
                chkDuoi5tr.Checked = false;
                chkDuoi10tr.Checked = false;
                chkDuoi15tr.Checked = false;
                chkDuoi20tr.Checked = false;
                chkTren20tr.Checked = false;
            }
        }

        private void chkDuoi5tr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDuoi5tr.Checked == true)
            {
                txtTenSP.ReadOnly = true;
                txtTenSP.Text = "";
                txtMaSP.ReadOnly = true;
                txtMaSP.Text = "";
                txtMaLoai.ReadOnly = true;
                txtMaLoai.Text = "";
                txtMaHang.ReadOnly = true;
                txtMaHang.Text = "";
                chkDuoi2tr.Checked = false;
                chkDuoi10tr.Checked = false;
                chkDuoi15tr.Checked = false;
                chkDuoi20tr.Checked = false;
                chkTren20tr.Checked = false;
            }
        }

        private void chkDuoi10tr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDuoi10tr.Checked == true)
            {
                txtTenSP.ReadOnly = true;
                txtTenSP.Text = "";
                txtMaSP.ReadOnly = true;
                txtMaSP.Text = "";
                txtMaLoai.ReadOnly = true;
                txtMaLoai.Text = "";
                txtMaHang.ReadOnly = true;
                txtMaHang.Text = "";
                chkDuoi2tr.Checked = false;
                chkDuoi5tr.Checked = false;
                chkDuoi15tr.Checked = false;
                chkDuoi20tr.Checked = false;
                chkTren20tr.Checked = false;
            }
        }

        private void chkDuoi15tr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDuoi15tr.Checked == true)
            {
                txtTenSP.ReadOnly = true;
                txtTenSP.Text = "";
                txtMaSP.ReadOnly = true;
                txtMaSP.Text = "";
                txtMaLoai.ReadOnly = true;
                txtMaLoai.Text = "";
                txtMaHang.ReadOnly = true;
                txtMaHang.Text = "";
                chkDuoi2tr.Checked = false;
                chkDuoi5tr.Checked = false;
                chkDuoi10tr.Checked = false;
                chkDuoi20tr.Checked = false;
                chkTren20tr.Checked = false;
            }
        }

        private void chkTren20tr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTren20tr.Checked == true)
            {
                txtTenSP.ReadOnly = true;
                txtTenSP.Text = "";
                txtMaSP.ReadOnly = true;
                txtMaSP.Text = "";
                txtMaLoai.ReadOnly = true;
                txtMaLoai.Text = "";
                txtMaHang.ReadOnly = true;
                txtMaHang.Text = "";
                chkDuoi2tr.Checked = false;
                chkDuoi5tr.Checked = false;
                chkDuoi10tr.Checked = false;
                chkDuoi15tr.Checked = false;
                chkDuoi20tr.Checked = false;
            }
        }

        private void chkDuoi20tr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDuoi20tr.Checked == true)
            {
                txtTenSP.ReadOnly = true;
                txtTenSP.Text = "";
                txtMaSP.ReadOnly = true;
                txtMaSP.Text = "";
                txtMaLoai.ReadOnly = true;
                txtMaLoai.Text = "";
                txtMaHang.ReadOnly = true;
                txtMaHang.Text = "";
                chkDuoi2tr.Checked = false;
                chkDuoi5tr.Checked = false;
                chkDuoi10tr.Checked = false;
                chkDuoi15tr.Checked = false;
                chkTren20tr.Checked = false;
            }
        }
        private void LoadHinhAnh()
        {
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtMaLoai.Text = "";
            txtMaHang.Text = "";
            dgvTimKiemSP.DataSource = null;
            txtMaSP.ReadOnly = false;
            txtTenSP.ReadOnly = false;
            txtMaLoai.ReadOnly = false;
            txtMaHang.ReadOnly = false;
            chkDuoi2tr.Checked = false;
            chkDuoi5tr.Checked = false;
            chkDuoi10tr.Checked = false;
            chkDuoi15tr.Checked = false;
            chkTren20tr.Checked = false;
            chkDuoi20tr.Checked = false;
        }
    }
}
