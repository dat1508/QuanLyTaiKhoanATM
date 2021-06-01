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

namespace QuanLyTaiKhoanATM.Forms
{
    public partial class fLogin : Form
    {
        public delegate void ThongBaoDangNhap(string fullname);
        public event ThongBaoDangNhap thongBaoDangNhap;
        public fLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Service.Login(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons
                    .OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            thongBaoDangNhap(SystemData.Current.Fullname);
            this.Close();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
            btnLogin.PerformClick();
            btnLogin.PerformClick();
            btnLogin.PerformClick();
        }
    }
}
