using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace DoAnNhomNet
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            BUSAccount.Instance.Register(txtTaiKhoan, txtMatKhau, cboMaNV);
        }

        private void LoadMaNV()
        {
            BUSAccount.Instance.LoadMaNV(cboMaNV);
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            LoadMaNV();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }
    }
}
