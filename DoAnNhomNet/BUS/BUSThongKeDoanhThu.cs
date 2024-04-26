using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSThongKeDoanhThu
    {
        private static BUSThongKeDoanhThu instance;

        public static BUSThongKeDoanhThu Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new BUSThongKeDoanhThu();
                }
                return instance;
            }
        }
        public BUSThongKeDoanhThu() { }

        public void LoadMaCH(ComboBox mach)
        {
            mach.DataSource = DAOThongKeDoanhThu.Instance.LoadMaCH();
        }

        public void ThongKeDoanhThu(ComboBox mach, DateTimePicker tungay, DateTimePicker toingay, DataGridView data)
        {
            data.DataSource = DAOThongKeDoanhThu.Instance.ThongKeDoanhThu(mach.Text, tungay.Text, toingay.Text);
        }
    }
}
