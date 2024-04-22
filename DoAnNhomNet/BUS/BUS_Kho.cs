﻿using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_Kho
    {
        private static BUS_Kho instance;

        public static BUS_Kho Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_Kho();
                }
                return instance;
            }


        }
        private BUS_Kho() { }


        public void Xem(DataGridView data)
        {
            var dt = DAO_Kho.Instance.Xem().Select(t =>
            {
               

                return new
                {
                   t.MaKho,
                   t.MaCH,
                   t.MaSP,
                   t.SoLuong,

                };
            }).ToList();
            data.DataSource = dt;
        }
        public void LoadSanPham(ComboBox cb)
        {
            DAO_Kho.Instance.LoadComBoBox(cb);
        }
        public void LoadCuaHang(ComboBox cb)
        {
            DAO_Kho.Instance.LoadComBoBoxMaCH(cb);
        }

        public void ThemKho(TextBox maKho, ComboBox maCH, ComboBox maSP, TextBox soLuong)
        {
            Kho kho = new Kho
            {
                MaKho = maKho.Text,
                MaCH = maCH.Text,
                MaSP = maSP.SelectedValue.ToString().Trim(),
                SoLuong = int.Parse(soLuong.Text)
            };
            DAO_Kho.Instance.ThemKho(kho);
        }

        public void XoaKho(TextBox maKho)
        {
            DAO_Kho.Instance.XoaKho(maKho.Text);
        }

        public void LoadDgvLenForm(TextBox maKho, ComboBox maCH, ComboBox maSP, TextBox soLuong, DataGridView data)
        {
            DAO_Kho.Instance.LoadDgvLenForm(maKho, maCH, maSP, soLuong, data);
        }
    }
}
