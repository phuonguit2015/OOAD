using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using CoffeeManagement.Utils;
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
    public partial class Frm_Don_Vi : Form
    {
        private DonViBLL _donViBLL = new DonViBLL();
        private List<int> _listUpdate = new List<int>();      // Danh sách các đối tượng cần update
        DataTable dt = new DataTable();

        public Frm_Don_Vi()
        {
            InitializeComponent();
        }    
        


        private void LoadDataSource()
        {
            dt = Utils.Util.ConvertToDataTable<DON_VI>(_donViBLL.LayDanhSachDonVi());
            gridControl1.DataSource = dt;
            btn_Luu_Lai.Enabled = false;

            _listUpdate.Clear();
        }

        private void Frm_Don_Vi_Load(object sender, System.EventArgs e)
        {
            LoadDataSource();
        }

        // Thêm đơn vị mới
        private void btn_Them_Moi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Them_Don_Vi f = new Frm_Them_Don_Vi();
            if (f.ShowDialog() == DialogResult.Cancel)
            {
                LoadDataSource();
            }
        }

        // Xóa thông tin đơn vị
        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Notification.Answers("Bạn có thật sự muốn xóa dữ liệu?") == DialogResult.Cancel)
            {
                return;
            }
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                int _ID_Don_Vi = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], "ID_Don_Vi").ToString());
                _donViBLL.XoaDonVi(_ID_Don_Vi);
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
                DON_VI _donVi = new DON_VI();
                _donVi.ID_Don_Vi = int.Parse(gridView1.GetRowCellValue(id, "ID_Don_Vi").ToString());
                _donVi.Ten_Don_Vi = gridView1.GetRowCellValue(id, "Ten_Don_Vi").ToString();
                if (!_donViBLL.KiemTraTenDonViTonTai(_donVi.Ten_Don_Vi,_donVi.ID_Don_Vi))
                {
                    _donViBLL.CapNhatDonVi(_donVi);
                    isUpdate = true;
                }
                else
                {
                    if (error == "")
                    {
                        error += _donVi.ID_Don_Vi;
                    }
                    else
                    {
                        error += " | " + _donVi.ID_Don_Vi;
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
                    Notification.Error("Có lỗi xảy ra khi cập nhật dữ liệu. Các ID chưa được cập nhật (" + error + "). Lỗi: Tên Đơn Vị đã tồn tại.");
                }
            }
            else
            {
                Notification.Error("Có lỗi xảy ra khi cập nhật dữ liệu. Lỗi: Tên đơn vị đã tồn tại.");
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
