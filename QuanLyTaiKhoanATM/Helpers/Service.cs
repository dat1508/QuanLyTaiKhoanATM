using QuanLyTaiKhoanATM.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiKhoanATM.Helpers
{
    class Service
    {
        public static bool Login(string username, string password)
        {
            using(DBManageATM db = new DBManageATM())
            {
                password = MD5.MD5Hash(password);
                var user = db.Accounts.
                    Where(x => x.Username == username &&
                    x.Password == password).FirstOrDefault();
                if (user is null) return false;
                SystemData.Current = user;
                return true;
            }
        }
        public static List<History> GetHistory()
        {
            var list = new List<History>();
            using(DBManageATM db = new DBManageATM())
            {
                list = db.Histories.ToList();
            }
            return list;
        }

        public static void AddHistory(History history)
        {

                using (DBManageATM db = new DBManageATM())
                {
                    db.Histories.Add(history);
                    db.SaveChanges();
                }
        }

        public static void Edit(int id,int money)
        {

            using (DBManageATM db = new DBManageATM())
            {
                var DBAccount = db.Accounts.Where(x => x.IdUser == id).FirstOrDefault();
                DBAccount.TotalMoney -= money;
                SystemData.Current = DBAccount;
                db.SaveChanges();
            }
        }
    }
}
