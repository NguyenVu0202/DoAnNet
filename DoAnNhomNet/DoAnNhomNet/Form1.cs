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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachLoai frm = new frmDanhSachLoai();
            frm.Show();
            frm.MdiParent = this;
        }

        private void hãngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDanhMucHang frm = new FormDanhMucHang();
            frm.Show();
            frm.MdiParent = this;
        }

        private void cửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachCuaHang frm = new frmDanhSachCuaHang();
            frm.Show();
            frm.MdiParent = this;
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachSanPham fr = new frmDanhSachSanPham();
            fr.MdiParent = this;
            fr.Show();
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachKho frm = new frmDanhSachKho();
            frm.Show();
            frm.MdiParent = this;
        }
    }
}
