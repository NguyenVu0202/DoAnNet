using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAOAccount
    {
        private static DAOAccount instance;

        public static DAOAccount Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAOAccount();
                return instance;
            }
        }

        private DAOAccount() { }

        public void Register(Account account)
        {
            try
            {
                TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
                db.Accounts.InsertOnSubmit(account);
                db.SubmitChanges();
                MessageBox.Show("Đăng Ký Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng Ký Thất Bại" + ex.Message);
            }
        }

        public List<string> LoadMaNV()
        {
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var manv = (from nv in db.NhanViens
                       select nv.MaNV).ToList();
            return manv;
        }

        public bool CheckAccount(string taikhoan, string matkhau)
        {
            bool ketqua = false;
            TheGioiDiDongDataContext db = new TheGioiDiDongDataContext();
            var account = (from ac in db.Accounts
                           where ac.TaiKhoan == taikhoan && ac.MatKhau == matkhau
                           select ac).FirstOrDefault();
            if (account != null)
            {
                ketqua = true;
            }
            return ketqua;
        }
    }
}
