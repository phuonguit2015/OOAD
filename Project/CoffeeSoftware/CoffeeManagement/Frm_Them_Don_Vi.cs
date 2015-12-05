using CoffeeManagement.BLL;
using System;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Frm_Them_Don_Vi : Form
    {
        DonViBLL _donViBLL = new DonViBLL();
        public Frm_Them_Don_Vi()
        {
            InitializeComponent();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            if (txt_TenDonVi.Text == null)
            {
                Utils.Notification.Error("Bạn chưa nhập tên đơn vị.");
                return;
            }
            if(_donViBLL.KiemTraTenDonViTonTai(txt_TenDonVi.Text))
            {
                Utils.Notification.Error("Tên đơn vị đã tồn tại.");
                return;
            }
            _donViBLL.ThemDonViMoi(txt_TenDonVi.Text);
            Utils.Notification.Success("Thêm đơn vị mới thành công.");
            txt_TenDonVi.Text = "";
        }
    }
}
