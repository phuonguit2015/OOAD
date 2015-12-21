using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeManagement.BLL;
using CoffeeManagement.DAL;

namespace CoffeeManagement
{
    public partial class Frm_DangNhap : Form
    {
        private NguoiDungBLL m_DangNhapBLL = new NguoiDungBLL();

        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (!m_DangNhapBLL.KiemTraTonTai(txt_TaiKhoan.Text))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
