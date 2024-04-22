using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_Hang
    {

        private static BUS_Hang instance;

        public static BUS_Hang Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new BUS_Hang();
                }
                return instance;
            }
        }
        public BUS_Hang() { }
        public void Xem(DataGridView data)
        {
            data.DataSource = DAO_Hang.Instance.Xem();
        }
        public void Them(Hang hang)
        {
            DAO_Hang.Instance.Them(hang);
        }
        public void Xoa(TextBox hang)
        {
             DAO_Hang.Instance.Xoa(hang);
        }
        public bool Sua(string maHang,Hang hang)
        {
            return DAO_Hang.Instance.Sua(maHang, hang);
        }
    }
}
