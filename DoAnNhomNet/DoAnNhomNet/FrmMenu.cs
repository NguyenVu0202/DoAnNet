﻿using System;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang frmKhachHang = new FrmKhachHang();
            frmKhachHang.MdiParent = this;
            frmKhachHang.Show();
        }
    }
}
