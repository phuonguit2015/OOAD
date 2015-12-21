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
    public partial class Frm_PhanQuyen : Form
    {
        private PhanQuyenBLL m_PhanQuyenBLL = new PhanQuyenBLL();
        private List<int> m_ListUpdate = new List<int>();      // Danh sách các đối tượng cần update
        DataTable dt = new DataTable();
        BindingList<PHAN_QUYEN> list = new BindingList<PHAN_QUYEN>();
        
        private void LoadLoaiNguoiDung()
        {
            NguoiDungBLL nguoiDungBLL = new NguoiDungBLL();
            lkup_LoaiNguoiDung.DataSource = nguoiDungBLL.LayLoaiNguoiDung();
            lkup_LoaiNguoiDung.ValueMember = "ID_Loai_Nguoi_Dung";
            lkup_LoaiNguoiDung.DisplayMember = "Loai_ND";
        }
        public Frm_PhanQuyen()
        {
            InitializeComponent();

            LoadLoaiNguoiDung();
        }
        private void LoadDataSource()   // Load GridView
        {
            list.Clear();
            dt = Utils.Util.ConvertToDataTable<PHAN_QUYEN>(m_PhanQuyenBLL.LayDanhSach());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PHAN_QUYEN a = new PHAN_QUYEN();
                a.ID_PQ = int.Parse(dt.Rows[i]["ID_PQ"].ToString());
                a.ID_Loai_ND = int.Parse(dt.Rows[i]["ID_Loai_ND"].ToString());
                a.ViewKhuyenMai = bool.Parse(dt.Rows[i]["ViewKhuyenMai"] == System.DBNull.Value ? "false" : dt.Rows[i]["ViewKhuyenMai"].ToString());
                a.ViewDanhMucMon = bool.Parse(dt.Rows[i]["ViewDanhMucMon"] == System.DBNull.Value ? "false" : dt.Rows[i]["ViewDanhMucMon"].ToString());
                a.ViewDanhMucBan = bool.Parse(dt.Rows[i]["ViewDanhMucBan"] == System.DBNull.Value ? "false" : dt.Rows[i]["ViewDanhMucBan"].ToString());
                a.ViewDanhMucKhuVuc = bool.Parse(dt.Rows[i]["ViewDanhMucKhuVuc"] == System.DBNull.Value ? "false" : dt.Rows[i]["ViewDanhMucKhuVuc"].ToString());
                a.ViewDanhMucNguyenLieu = bool.Parse(dt.Rows[i]["ViewDanhMucNguyenLieu"] == System.DBNull.Value ? "false" : dt.Rows[i]["ViewDanhMucNguyenLieu"].ToString());
                a.ViewDanhMucNguoiDung = bool.Parse(dt.Rows[i]["ViewDanhMucNguoiDung"] == System.DBNull.Value ? "false" : dt.Rows[i]["ViewDanhMucNguoiDung"].ToString());
                a.UpdateKhuyenMai = bool.Parse(dt.Rows[i]["UpdateKhuyenMai"] == System.DBNull.Value ? "false" : dt.Rows[i]["UpdateKhuyenMai"].ToString());
                a.UpdateThucDon = bool.Parse(dt.Rows[i]["UpdateThucDon"] == System.DBNull.Value ? "false" : dt.Rows[i]["UpdateThucDon"].ToString());
                a.UpdateBan = bool.Parse(dt.Rows[i]["UpdateBan"] == System.DBNull.Value ? "false" : dt.Rows[i]["UpdateBan"].ToString());
                a.UpdateKhuVuc = bool.Parse(dt.Rows[i]["UpdateKhuVuc"] == System.DBNull.Value ? "false" : dt.Rows[i]["UpdateKhuVuc"].ToString());
                a.UpdateNguyenLieu = bool.Parse(dt.Rows[i]["UpdateNguyenLieu"] == System.DBNull.Value ? "false" : dt.Rows[i]["UpdateNguyenLieu"].ToString());
                a.UpdateNguoiDung = bool.Parse(dt.Rows[i]["UpdateNguoiDung"] == System.DBNull.Value ? "false" : dt.Rows[i]["UpdateNguoiDung"].ToString());
                list.Add(a);

            }
            gridControl1.DataSource = list;
            btn_Luu_Lai.Enabled = false;

            m_ListUpdate.Clear();
        }

        private void Frm_PhanQuyen_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void btn_Lam_Moi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDataSource();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btn_Luu_Lai.Enabled = true;
            m_ListUpdate.Add(e.RowHandle);
        }

        private void btn_Luu_Lai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                foreach (int id in m_ListUpdate)
                {
                    PHAN_QUYEN _pq = new PHAN_QUYEN();
                    _pq.ID_PQ = int.Parse(gridView1.GetRowCellValue(id, "ID_PQ").ToString());
                    _pq.ID_Loai_ND = int.Parse(gridView1.GetRowCellValue(id, "ID_Loai_ND").ToString());
                    _pq.ViewKhuyenMai = (bool)gridView1.GetRowCellValue(id, "ViewKhuyenMai");
                    _pq.ViewDanhMucMon = (bool)gridView1.GetRowCellValue(id, "ViewDanhMucMon");
                    _pq.ViewDanhMucBan = (bool)gridView1.GetRowCellValue(id, "ViewDanhMucBan");
                    _pq.ViewDanhMucKhuVuc = (bool)gridView1.GetRowCellValue(id, "ViewDanhMucKhuVuc");
                    _pq.ViewDanhMucNguyenLieu = (bool)gridView1.GetRowCellValue(id, "ViewDanhMucNguyenLieu");
                    _pq.ViewDanhMucNguoiDung = (bool)gridView1.GetRowCellValue(id, "ViewDanhMucNguoiDung");
                    _pq.UpdateKhuyenMai = (bool)gridView1.GetRowCellValue(id, "UpdateKhuyenMai");
                    _pq.UpdateThucDon = (bool)gridView1.GetRowCellValue(id, "UpdateThucDon");
                    _pq.UpdateBan = (bool)gridView1.GetRowCellValue(id, "UpdateBan");
                    _pq.UpdateKhuVuc = (bool)gridView1.GetRowCellValue(id, "UpdateKhuVuc");
                    _pq.UpdateNguyenLieu = (bool)gridView1.GetRowCellValue(id, "UpdateNguyenLieu");
                    _pq.UpdateNguoiDung = (bool)gridView1.GetRowCellValue(id, "UpdateNguoiDung");

                    m_PhanQuyenBLL.Sua(_pq);
                }
                Notification.Success("Cập dữ liệu thành công.");
            }
            catch (Exception er)
            {
                Notification.Error("Có lỗi xảy ra khi cập nhật dữ liệu: " + er.Message);
            }
            LoadDataSource();
        }

  
    }
}
