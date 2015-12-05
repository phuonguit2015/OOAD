using CoffeeManagement.DAL;
using CoffeeManagement.Utils;
using System;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Frm_Them_Nguyen_Lieu_Moi : Form
    {
        BLL.NguyenLieuBLL _nguyenLieuBLL = new BLL.NguyenLieuBLL();
        BLL.DonViBLL _donViBLL = new BLL.DonViBLL();
        public Frm_Them_Nguyen_Lieu_Moi()
        {
            InitializeComponent();

            lkup_DonVi.Properties.DataSource = Utils.Util.ConvertToDataTable<DON_VI>(_donViBLL.LayDanhSachDonVi());
            lkup_DonVi.Properties.DisplayMember = "Ten_Don_Vi";
            lkup_DonVi.Properties.ValueMember = "ID_Don_Vi";
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            if (txt_MaNguyenLieu.Text == null)
            {
                Notification.Error("Bạn chưa nhập mã nguyên liệu.");
                return;
            }
            if (txt_MaNguyenLieu.Text == null)
            {
                Notification.Error("Bạn chưa nhập tên nguyên liệu.");
                return;
            }
            if(lkup_DonVi.EditValue == System.DBNull.Value)
            {
                Notification.Error("Bạn chưa chọn đơn vị tính.");
                return;
            }
            if (!_nguyenLieuBLL.KiemTraNguyenLieuTonTai(txt_MaNguyenLieu.Text))
            {
                _nguyenLieuBLL.ThemNguyenLieuMoi(txt_MaNguyenLieu.Text, txt_TenNguyenLieu.Text, ((DON_VI)lkup_DonVi.EditValue).ID_Don_Vi);
                Notification.Success("Thêm nguyên liệu mới thành công.!");
                txt_MaNguyenLieu.Text = "";
                txt_TenNguyenLieu.Text = "";
            }
            else
            {
                Notification.Error("Thêm mới thất bại. Lỗi: Mã nguyên liệu đã tồn tại.");
            }
        }
    }
}
