using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Frm_Them_Nha_Cung_Cap : Form
    {
        NhaCungCapBLL _nhaCungCapBLL = new NhaCungCapBLL();
        public Frm_Them_Nha_Cung_Cap()
        {
            InitializeComponent();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            if(txt_NhaCungCap.Text == null)
            {
                Utils.Notification.Error("Bạn chưa nhập tên nhà cung cấp.");
                return;
            }
            NHA_CUNG_CAP ncc = new NHA_CUNG_CAP();
            ncc.Ten_Nha_Cung_Cap = txt_NhaCungCap.Text;
            ncc.Dia_Chi = txt_DiaChi.Text == null ? "" : txt_DiaChi.Text;
            ncc.So_Dien_Thoai = txt_SoDienThoai.Text == null ? "" : txt_SoDienThoai.Text;
            _nhaCungCapBLL.ThemNhaCungCapMoi(ncc);
            Utils.Notification.Success("Thêm nhà cung cấp mới thành công.");
            txt_NhaCungCap.Text = "";
            txt_SoDienThoai.Text = "";
            txt_DiaChi.Text = "";
        }
    }
}
