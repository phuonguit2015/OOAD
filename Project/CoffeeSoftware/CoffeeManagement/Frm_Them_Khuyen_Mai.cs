using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using CoffeeManagement.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Frm_Them_Khuyen_Mai : Form
    {
        public Frm_Them_Khuyen_Mai()
        {
            InitializeComponent();
            check_VND.Checked = true;
        }
        
        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                KhuyenMaiBLL _KMBLL = new KhuyenMaiBLL();
                KHUYENMAI _km = new KHUYENMAI();
                _km.Chuong_Trinh_KM = txt_CTKM.Text;
                if (check_PT.Checked == true)
                    _km.Loai_KM = "phần trăm";
                if (check_VND.Checked == true)
                    _km.Loai_KM = "voucher";
                _km.Gia_Tri = int.Parse(spin_GiaTri.Text);
                if(DateTime.Compare(dt_NgayKetThuc.DateTime,dt_NgayBatDau.DateTime)<0)
                {
                    Notification.Error("Có lỗi xảy ra khi Thêm dữ liệu.");
                    return;
                }
                _km.Ngay_Bat_Dau = dt_NgayBatDau.DateTime;
                _km.Ngay_Het_Han = dt_NgayKetThuc.DateTime;
                _km.So_Luong = int.Parse(spin_SoLuong.Text);

                _KMBLL.ThemKMMoi(_km);
                Notification.Success("Thêm dữ liệu thành công.");
            }
            catch (Exception er)
            {
                Notification.Error("Có lỗi xảy ra khi Thêm dữ liệu: (" + er.Message + ").");

            }
        }
    }
}
