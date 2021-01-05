using QuanLyTaiKhoanATM.Database;
using QuanLyTaiKhoanATM.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiKhoanATM.Forms
{
    public partial class fManageATM : Form
    {
        int num = 0;
        List<History> list = new List<History>();
        public fManageATM()
        {
            InitializeComponent();
            LoadData();
            lblFullname.Text = SystemData.Current.Fullname;

        }

        public void LoadData()
        {
            list = Service.GetHistory();
            foreach(var item in list)
            {
                num++;
            }
            lblTotalmoney.Text = string.Format("{0:0,0}", SystemData.Current.TotalMoney);
            listView1.Items.Clear();
            foreach(var history in list)
            {
                string time = history.Date;
                ListViewItem item = new ListViewItem(time);
                item.SubItems.Add(string.Format("{0:0,0}",history.Money));
                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.Parse(txtMoney.Text) > SystemData.Current.TotalMoney)
            {
                MessageBox.Show("Không được lớn hơn số dư!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            History history = new History();
            history.IdHistory = num;
            history.Date = DateTime.Now.ToString();
            history.Money = int.Parse(txtMoney.Text);
            history.IdUser = SystemData.Current.IdUser;
            Service.AddHistory(history);
            Service.Edit(SystemData.Current.IdUser, int.Parse(txtMoney.Text));
            LoadData();
        }
    }
}
