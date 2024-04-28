using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_ThongKeSanPham
    {
        private static BUS_ThongKeSanPham instance;

        public static BUS_ThongKeSanPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_ThongKeSanPham();
                return instance;
            }
        }
        private BUS_ThongKeSanPham() { }

        public void TimKiemTheoMaSPMaCH(ComboBox maCH, ComboBox maSP, DateTimePicker tuNgay, DateTimePicker denNgay, DataGridView data)
        {
            data.DataSource = DAO_ThongKeSanPham.Instance.TimKiemTheoMaSPMaCH(maCH.Text, maSP.Text, tuNgay.Text, denNgay.Text);
        }
      
        public void LoadComBoBoxMaCH(ComboBox cb)
        {
            DAO_ThongKeSanPham.Instance.LoadComBoBoxMaCH(cb);
        }
        public void LoadComBoBoxMaSP(ComboBox cb)
        {
            DAO_ThongKeSanPham.Instance.LoadComBoBoxMaSP(cb);
        }
        public string LoadTen(string maSP)
        {
            return DAO_ThongKeSanPham.Instance.LoadTenSP(maSP);
        }

    }
}
