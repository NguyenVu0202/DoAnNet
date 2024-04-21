using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_Loai
    {
        private static BUS_Loai instance;

        public static BUS_Loai Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new BUS_Loai();
                }
                return instance;
            }
        }
        public BUS_Loai() { }
        public void Xem(DataGridView data)
        {
            data.DataSource = DAO_Loai.Instance.Xem();
        }
        public void Them(Loai loai)
        {
            DAO_Loai.Instance.Them(loai);
        }
        public void Xoa(TextBox loai)
        {
            DAO_Loai.Instance.Xoa(loai);
        }
        public bool Sua(string maLoai, Loai loai)
        {
            return DAO_Loai.Instance.Sua(maLoai,loai);
        }
    }
}
