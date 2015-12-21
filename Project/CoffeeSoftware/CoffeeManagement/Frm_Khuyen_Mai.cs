using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using CoffeeManagement.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using ZXing;
using ZXing.Common;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing;
using LinqToExcel;
using System.Linq;


namespace CoffeeManagement
{
    public partial class Frm_Khuyen_Mai : Form
    {
        private KhuyenMaiBLL _KMBLL = new KhuyenMaiBLL();
        private List<int> _listUpdate = new List<int>();      // Danh sách các đối tượng cần update
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        int testrowclick = 0;
        int testimportexcel = 0;
        public Frm_Khuyen_Mai()
        {
            InitializeComponent();

        }
        private void LoadDataSource()
        {
            dt = Utils.Util.ConvertToDataTable<KHUYENMAI>(_KMBLL.LayDanhSachKM());
            gridControl1.DataSource = dt;
            btn_Luu_Lai.Enabled = false;

            _listUpdate.Clear();
        }
        private void LoadDataCode(int IDKM)
        {
            dt1 = Utils.Util.ConvertToDataTable<CHITIETKHUYENMAI>(_KMBLL.LayDanhSachCode(IDKM));
            gridControl2.DataSource = dt1;
        }
        private void Frm_Khuyen_Mai_Load(object sender, System.EventArgs e)
        {
            LoadDataSource();
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Notification.Answers("Bạn có thật sự muốn xóa dữ liệu?") == DialogResult.Cancel)
            {
                return;
            }
            int _ID_KM = 0;
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                _ID_KM = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], "ID_KM").ToString());
                _KMBLL.XoaKM(_ID_KM);
            }
            Notification.Success("Xóa dữ liệu thành công!");
            LoadDataSource();
            LoadDataCode(_ID_KM);
        }

        private void btn_Luu_Lai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                foreach (int id in _listUpdate)
                {
                    KHUYENMAI _km = new KHUYENMAI();
                    _km.ID_KM = int.Parse(gridView1.GetRowCellValue(id, "ID_KM").ToString());
                    _km.Chuong_Trinh_KM = gridView1.GetRowCellValue(id, "Chuong_Trinh_KM").ToString();
                    _km.Loai_KM = gridView1.GetRowCellValue(id, "Loai_KM").ToString();
                    _km.Gia_Tri = int.Parse(gridView1.GetRowCellValue(id, "Gia_Tri").ToString());
                    _km.Ngay_Bat_Dau = DateTime.Parse(gridView1.GetRowCellValue(id, "Ngay_Bat_Dau").ToString());
                    _km.Ngay_Het_Han = DateTime.Parse(gridView1.GetRowCellValue(id, "Ngay_Het_Han").ToString());
                    _km.So_Luong = int.Parse(gridView1.GetRowCellValue(id, "So_Luong").ToString());

                    _KMBLL.CapNhatKM(_km);
                }
                LoadDataSource();
                Notification.Success("Cập dữ liệu thành công.");
            }
            catch (Exception er)
            {
                Notification.Error("Có lỗi xảy ra khi cập nhật dữ liệu: (" + er.Message + ").");

            }

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
            _listUpdate.Add(e.RowHandle);
        }

        private void btn_Them_Moi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (testimportexcel == 0)
            {
                Frm_Them_Khuyen_Mai frm_Them_KM = new Frm_Them_Khuyen_Mai();
                if (frm_Them_KM.ShowDialog() == DialogResult.Cancel)
                    LoadDataSource();
            }
            else
            {
                try
                {
                    foreach (int id in _listUpdate)
                    {
                        KHUYENMAI _km = new KHUYENMAI();
                        _km.ID_KM = int.Parse(gridView1.GetRowCellValue(id, "ID_KM").ToString());
                        _km.Chuong_Trinh_KM = gridView1.GetRowCellValue(id, "Chuong_Trinh_KM").ToString();
                        _km.Loai_KM = gridView1.GetRowCellValue(id, "Loai_KM").ToString();
                        _km.Gia_Tri = int.Parse(gridView1.GetRowCellValue(id, "Gia_Tri").ToString());
                        _km.Ngay_Bat_Dau = DateTime.Parse(gridView1.GetRowCellValue(id, "Ngay_Bat_Dau").ToString());
                        _km.Ngay_Het_Han = DateTime.Parse(gridView1.GetRowCellValue(id, "Ngay_Het_Han").ToString());
                        _km.So_Luong = int.Parse(gridView1.GetRowCellValue(id, "So_Luong").ToString());

                        _KMBLL.ThemKMMoi(_km);
                    }
                    LoadDataSource();
                    Notification.Success("Thêm mới dữ liệu thành công.");
                    testimportexcel = 0;
                }
                catch (Exception er)
                {
                    Notification.Error("Có lỗi xảy ra khi thêm mới dữ liệu: (" + er.Message + ").");

                }
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadDataCode(int.Parse(gridView1.GetRowCellValue(e.RowHandle,"ID_KM").ToString()));
            testrowclick = 1;
        }
        private List<Image> MaHoaCode()
        {

            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Height = 150,
                    Width = 150,
                    Margin = 0
                }
            };
            List<Image> list = new List<Image>();
            foreach (DataRow dr in dt1.Rows)
            {
                string content = dr["Code"].ToString();

                using (var bitmap = barcodeWriter.Write(content))
                {
                    using (var stream = new MemoryStream())
                    {
                        bitmap.Save(stream, ImageFormat.Png);
                        list.Add(Image.FromStream(stream));
                    }
                }
            }
            return list;
        }
        private void btn_In_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (testrowclick == 1)
            {
                try
                {
                    List<Image> list = MaHoaCode();
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i].Save(@"F:\Code_" + gridView1.GetFocusedRowCellValue("Chuong_Trinh_KM") + "_" + +i + ".png", ImageFormat.Png);
                    }
                    Notification.Success("Lưu mã QR thành công!");
                }
                catch (Exception er)
                {
                    Notification.Error("Có lỗi xảy ra khi lưu QR: (" + er.Message + ").");
                }
            }
            else Notification.Error("Vui lòng chọn 1 chương trình khuyến mãi để in mã QR.");
        }



        private void btn_Browse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            txt_DuongDan.EditValue = of.FileName;
          
        }

        private void btn_Import_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_DuongDan.EditValue.ToString() != "")
            {
                string file = txt_DuongDan.EditValue.ToString();

                string ext = Path.GetExtension(file);
                if (ext.ToLower() == ".xls" || ext.ToLower().Equals(".xlsx"))
                {
                    var exceltmp = new ExcelQueryFactory(file);
                    var tmp = from s in exceltmp.Worksheet("Sheet1") select s;
                    var columnNames = exceltmp.GetColumnNames("Sheet1");
                    DataTable dtExcelRecords = new DataTable();
                    foreach (var columnName in columnNames)
                    {
                        dtExcelRecords.Columns.Add(columnName);
                    }
                    foreach (var row in tmp)
                    {
                        DataRow dr = dtExcelRecords.NewRow();
                        foreach (var columnName in columnNames)
                        {
                            dr[columnName] = row[columnName];
                        }
                        dtExcelRecords.Rows.Add(dr);
                    }

                    gridControl1.DataSource = dtExcelRecords;
                }
                testimportexcel = 1;
            }
            else MessageBox.Show("Vui lòng chọn file excel muốn import!");
        }
    }
}
