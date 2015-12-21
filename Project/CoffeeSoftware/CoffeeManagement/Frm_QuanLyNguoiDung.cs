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
    public partial class Frm_QuanLyNguoiDung : Form
    {
        private NguoiDungBLL m_NguoiDungBLL = new NguoiDungBLL();
        private List<int> m_ListUpdate = new List<int>();      // Danh sách các đối tượng cần update
        DataTable dt = new DataTable();

        public Frm_QuanLyNguoiDung()
        {
            InitializeComponent();
     //       LoadDataSource();
        }

        private void LoadDataSource()   // Load GridView
        {
            dt = m_NguoiDungBLL.LayDanhSach();
            gridControl1.DataSource = dt;
            btn_Luu_Lai.Enabled = false;
            m_ListUpdate.Clear();
        }

        private void Frm_QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void btn_Them_Moi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_ThemNguoiDung f = new Frm_ThemNguoiDung();
            if (f.ShowDialog() == DialogResult.Cancel)
            {
                LoadDataSource();
            }
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Notification.Answers("Bạn có thật sự muốn xóa dữ liệu?") == DialogResult.Cancel)
            {
                return;
            }
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                int id = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], "ID_Nguoi_Dung").ToString());
                m_NguoiDungBLL.Xoa(id);
            }
            Notification.Success("Xóa dữ liệu thành công!");
            LoadDataSource();
        }

        private void btn_Luu_Lai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //try { 
                foreach (int id in m_ListUpdate)
                {
                    NGUOI_DUNG _nguoidung = new NGUOI_DUNG();
                    _nguoidung.ID_Nguoi_Dung = int.Parse(gridView1.GetRowCellValue(id, "ID_Nguoi_Dung").ToString());
                    _nguoidung.Ten_Nguoi_Dung = gridView1.GetRowCellValue(id, "Ten_Nguoi_Dung").ToString();
                    string a = gridView1.GetRowCellValue(id, "Loai_ND").ToString();
                    if(a=="Quản Trị Hệ Thống")
                    {
                        _nguoidung.ID_LoaiND = 1;
                    }
                    if (a == "Quản Lý")
                    {
                        _nguoidung.ID_LoaiND = 2;
                    }
                    if (a == "Nhân Viên Thu Ngân")
                    {
                        _nguoidung.ID_LoaiND = 3;
                    }
                    if (a == "Nhân Viên Phòng Bếp")
                    {
                        _nguoidung.ID_LoaiND = 4;
                    }
                    m_NguoiDungBLL.Sua(_nguoidung);
                }
                Notification.Success("Cập dữ liệu thành công.");
            //}
            //catch(Exception er)
            //{ 
            //    Notification.Error("Có lỗi xảy ra khi cập nhật dữ liệu: "+ er.Message);
            //}
            LoadDataSource();
        }

        private void btn_Lam_Moi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDataSource();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            btn_Xoa.Enabled = false;

            if (gridView1.SelectedRowsCount > 0)
            {
                btn_Xoa.Enabled = true;
            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btn_Luu_Lai.Enabled = true;
            m_ListUpdate.Add(e.RowHandle);
        }
    }
}
