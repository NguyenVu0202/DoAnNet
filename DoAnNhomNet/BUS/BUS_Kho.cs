using DAO;
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
         //   DAO_Kho.Instance.LoadComBoxTenCuaHang(cb);
        }
    }
}
