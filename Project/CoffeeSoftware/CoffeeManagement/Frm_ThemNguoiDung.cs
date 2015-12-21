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
using CoffeeManagement.Utils;

namespace CoffeeManagement
{
    public partial class Frm_ThemNguoiDung : Form
    {
        private NguoiDungBLL m_NguoiDungBLL = new NguoiDungBLL();
        private delegate void TaoTaiKhoanEventHandler();

        public Frm_ThemNguoiDung()
        {
            InitializeComponent();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            if (m_NguoiDungBLL.KiemTraTonTai(txtTaiKhoan.Text))
            {
                Notification.Error("Tài khoản đã tồn tại !");
            }
            else
            {
                if (txtMatKhau.Text != txtNhapLaiMatKhau.Text)
                {
                    Notification.Error("Mật khẩu không trùng khớp");
                }
                else
                {
                    NGUOI_DUNG entity = new NGUOI_DUNG();
                    entity.Ten_Nguoi_Dung = txtTaiKhoan.Text;
                    entity.Mat_Khau = txtMatKhau.Text;
                    entity.ID_Nguoi_Dung = m_NguoiDungBLL.LayIDQuyen(cbb_loaiND.Text);
                    m_NguoiDungBLL.Them(entity);
                    Notification.Success("Tạo tài khoản thành công");
                }
            }
        }


    }
}
