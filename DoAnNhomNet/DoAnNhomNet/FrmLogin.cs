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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.ShowDialog();
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool check = BUS.BUSAccount.Instance.CheckAccount(txtTaiKhoan, txtMatKhau);
            if (check == true)
            {
                this.Hide();
                FrmMenu frmMenu = new FrmMenu();
                frmMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, vui lòng nhập lại!");
            }    
        }
    }
}
