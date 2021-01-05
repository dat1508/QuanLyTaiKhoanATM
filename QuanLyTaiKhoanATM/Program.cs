using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Phạm Ngọc Đạt - 1811061744
/// Phan Trần Hoàng Hiệp - 1811062734
/// Lê Bùi Thanh Vũ - 1811061717
/// </summary>

namespace QuanLyTaiKhoanATM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fMain());
        }
    }
}
