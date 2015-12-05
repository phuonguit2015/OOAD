using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using CoffeeManagement.Utils;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Frm_Nguyen_Lieu : Form
    {
        private NguyenLieuBLL _NguyenLieuBLL = new NguyenLieuBLL();
        private DonViBLL _donViBLL = new DonViBLL();
        private List<int> _listUpdate = new List<int>();      // Danh sách các đối tượng cần update
        DataTable dt = new DataTable();
        public Frm_Nguyen_Lieu()
        {
            InitializeComponent();
        }     

        

        private void LoadDataSource()
        {
            lkup_DonVi.DataSource = Utils.Util.ConvertToDataTable<DON_VI>(_donViBLL.LayDanhSachDonVi());
            lkup_DonVi.DisplayMember = "Ten_Don_Vi";
            lkup_DonVi.ValueMember = "ID_Don_Vi";


            dt = Utils.Util.ConvertToDataTable<NGUYEN_LIEU>(_NguyenLieuBLL.LayDanhSachNguyenLieu());
            gridControl1.DataSource = dt;
            btn_Luu_Lai.Enabled = false;

            _listUpdate.Clear();
        }

        private void Frm_NGUYEN_LIEU_Load(object sender, System.EventArgs e)
        {
            LoadDataSource();
        }

        // Thêm khu vực mới
        private void btn_Them_Moi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Them_Nguyen_Lieu_Moi f = new Frm_Them_Nguyen_Lieu_Moi();
            if (f.ShowDialog() == DialogResult.Cancel)
            {
                LoadDataSource();
            }
        }

        // Xóa thông tin khu vực
        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Notification.Answers("Bạn có thật sự muốn xóa dữ liệu?") == DialogResult.Cancel)
            {
                return;
            }
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                int _ID_NGUYEN_LIEU = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], "ID_NGUYEN_LIEU").ToString());
                _NguyenLieuBLL.XoaNguyenLieu(_ID_NGUYEN_LIEU);
            }
            Notification.Success("Xóa dữ liệu thành công!");
            LoadDataSource();
        }

        // Cập nhật thông tin khi người dùng chỉnh sửa
        private void btn_Luu_Lai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string error = "";
            bool isUpdate = false;
            foreach (int id in _listUpdate)
            {
                NGUYEN_LIEU _NguyenLieu = new NGUYEN_LIEU();
                _NguyenLieu.ID_Nguyen_Lieu = int.Parse(gridView1.GetRowCellValue(id, "ID_Nguyen_Lieu").ToString());
                _NguyenLieu.Ten_Nguyen_Lieu = gridView1.GetRowCellValue(id, "Ten_Nguyen_Lieu").ToString();
                _NguyenLieu.So_Luong_Ton = int.Parse(gridView1.GetRowCellValue(id, "So_Luong_Ton").ToString());
                _NguyenLieu.Ma_Nguyen_Lieu = gridView1.GetRowCellValue(id, "Ma_Nguyen_Lieu").ToString();
                _NguyenLieu.ID_Don_Vi = int.Parse(gridView1.GetRowCellValue(id, "ID_Don_Vi").ToString());
                if (!_NguyenLieuBLL.KiemTraNguyenLieuTonTai(_NguyenLieu.Ma_Nguyen_Lieu,_NguyenLieu.ID_Nguyen_Lieu))
                {
                    _NguyenLieuBLL.CapNhatNguyenLieu(_NguyenLieu);
                    isUpdate = true;
                }
                else
                {
                    if (error == "")
                    {
                        error += _NguyenLieu.ID_Nguyen_Lieu;
                    }
                    else
                    {
                        error += " | " + _NguyenLieu.ID_Nguyen_Lieu;
                    }
                }
            }
            if (isUpdate == true)
            {
                if (error.Length == 0)
                {
                    Notification.Success("Cập dữ liệu thành công.");
                }
                else
                {
                    Notification.Error("Có lỗi xảy ra khi cập nhật dữ liệu. Các ID chưa được cập nhật (" + error + "). Lỗi: Tên nguyên liệu đã tồn tại.");
                }
            }
            else
            {
                Notification.Error("Có lỗi xảy ra khi cập nhật dữ liệu. Lỗi: Tên nguyên liệu đã tồn tại.");
            }
            LoadDataSource();
        }

        // Tải lại dữ liệu lên gridView
        private void btn_Lam_Moi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDataSource();
        }

        // Nếu có chọn dòng để xóa thì bật button xóa, còn nếu không hide nó đi
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
            _listUpdate.Add(e.RowHandle);
        }
    }
}
