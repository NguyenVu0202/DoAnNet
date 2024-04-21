﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class BUSAccount
    {
        private static BUSAccount instance;

        public static BUSAccount Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUSAccount();
                return instance;
            }
        }
        private BUSAccount() { }

        public void Register(TextBox taikhoan, TextBox matkhau, ComboBox manv)
        {
            Account sanPham = new Account
            {
                TaiKhoan = taikhoan.Text,
                MatKhau = matkhau.Text,
                MaNV = manv.Text
            };

            DAOAccount.Instance.Register(sanPham);
        }

        public void LoadMaNV(ComboBox manv)
        {
            List<string> listmanv = new List<string>();
            listmanv = DAOAccount.Instance.LoadMaNV();
            manv.DataSource = listmanv;
        }

        public bool CheckAccount(TextBox taikhoan, TextBox matkhau)
        {
            bool check = DAOAccount.Instance.CheckAccount(taikhoan.Text, matkhau.Text);
            if (check == true)
            {
                return true;
            }
            else
            {
                return false;
            }    
        }
    }
}
