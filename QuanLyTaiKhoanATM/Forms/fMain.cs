using QuanLyTaiKhoanATM.Forms;
using QuanLyTaiKhoanATM.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiKhoanATM
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void DangNhap_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f = this.MdiChildren.Where(a => a.Name == "fLogin").FirstOrDefault();
            if (f != null)
            {
                f.Activate();
                return;
            }
            fLogin form = new fLogin();
            form.MdiParent = this;
            form.Show();
            form.thongBaoDangNhap += Form_thongBaoDangNhap;

        }

        private void Form_thongBaoDangNhap(string fullname)
        {
            Status(true);
            lblWelcome.Text = "Xin chào " + fullname;
        }

        public void Status(bool tr)
        {
                DangNhap.Visible = !tr;
                DangXuat.Visible = tr;
                QuanLyTaiKhoan.Visible = tr;
                lblWelcome.Visible = tr;
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            Status(false);
            f = this.MdiChildren.Where(a => a.Name == "fManageATM").FirstOrDefault();
            if (f != null)
            {
                f.Close();
            }
        }

        private void QuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f = this.MdiChildren.Where(a => a.Name == "fManageATM").FirstOrDefault();
            if (f != null)
            {
                f.Activate();
                return;
            }
            fManageATM form = new fManageATM();
            form.MdiParent = this;
            form.Show();
        }
    }
}
