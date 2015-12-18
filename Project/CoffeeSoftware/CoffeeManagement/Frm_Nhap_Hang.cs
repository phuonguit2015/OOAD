using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Frm_Nhap_Hang : Form
    {
        NhaCungCapBLL _nhaCungCapBLL = new NhaCungCapBLL();
        NhapHangBLL _nhapHangBLL = new NhapHangBLL();
        DataTable dtChiTietPhieuNhap = new DataTable();
        private bool IsUpdate = false;

        public Frm_Nhap_Hang()
        {
            InitializeComponent();
            dtChiTietPhieuNhap.Columns.Add("ID_Nguyen_Lieu", typeof(int));
            dtChiTietPhieuNhap.Columns.Add("So_Luong", typeof(int));
            dtChiTietPhieuNhap.Columns.Add("Don_Gia", typeof(decimal));
            dtChiTietPhieuNhap.Columns.Add("Thanh_Tien", typeof(decimal));

            gridControl_CTPN.DataSource = dtChiTietPhieuNhap;

        }

        private void LoadNhaCungCap()
        {
            lkup_NhaCungCap.Properties.DataSource = _nhaCungCapBLL.LayDanhSachNhaCungCap();
            lkup_NhaCungCap.Properties.ValueMember = "ID_Nha_Cung_Cap";
            lkup_NhaCungCap.Properties.DisplayMember = "Ten_Nha_Cung_Cap";

            lkup_NCC.DataSource = _nhaCungCapBLL.LayDanhSachNhaCungCap();
            lkup_NCC.ValueMember = "ID_Nha_Cung_Cap";
            lkup_NCC.DisplayMember = "Ten_Nha_Cung_Cap"; 
        }

        private void lkup_NhaCungCap_EditValueChanged(object sender, System.EventArgs e)
        {
            txt_DiaChi.Text = "";
            txt_SoDienThoai.Text = "";
            if (lkup_NhaCungCap.EditValue == null)
                return;
            NHA_CUNG_CAP _ncc = _nhaCungCapBLL.LayNhaCungCapByID(int.Parse(lkup_NhaCungCap.EditValue.ToString()));
            txt_DiaChi.Text = _ncc.Dia_Chi == null ? "" : _ncc.Dia_Chi;
            txt_SoDienThoai.Text = _ncc.So_Dien_Thoai ==  null ? "" : _ncc.So_Dien_Thoai;
        }

       
        private void LoadNguyenLieu()
        {
            NguyenLieuBLL nguyenLieuBLL = new NguyenLieuBLL();
            // Load danh sách nguyên liệu lên grid
            gridControl2.DataSource = nguyenLieuBLL.LayDanhSachNguyenLieu();
            // Load danh sách nguyên liệu lên lookupEdit
            lkup_NguyenLieuGrid.DataSource = nguyenLieuBLL.LayDanhSachNguyenLieu();
            lkup_NguyenLieuGrid.DisplayMember = "Ten_Nguyen_Lieu";
            lkup_NguyenLieuGrid.ValueMember = "ID_Nguyen_Lieu";
        }

        private void check_MaTuSinh_CheckedChanged(object sender, System.EventArgs e)
        {
            ThamSoBLL thamSoBLL = new ThamSoBLL();
            if(check_MaTuSinh.CheckState == CheckState.Checked)
            {
                txt_SoPhieuNhap.Enabled = false;
                string soPhieu = TaoSoPhieuNhap();
                while (_nhapHangBLL.TonTaiMaPhieuNhap(soPhieu))
                    soPhieu = TaoSoPhieuNhap();
                txt_SoPhieuNhap.Text = soPhieu;
            }
            else
            {
                txt_SoPhieuNhap.Text = null;
                txt_SoPhieuNhap.Enabled = true;
            }
        }

        private string TaoSoPhieuNhap()
        {
            return "PN" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
        }    
        
        private void Frm_Nhap_Hang_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();

            LoadNguyenLieu();

            DanhSachPhieuNhap();

            dt_NgayLap.EditValue = DateTime.Now;
        }

        private decimal ConvertTextToDecimal()
        {
            return decimal.Parse(txt_TongCong.Text.Split(' ')[0].ToString());
        }

        private void spin_GiamGia_EditValueChanged(object sender, EventArgs e)
        {
            if (spin_GiamGia.Value == 0 || txt_TongCong.Text == "0")
            {
                txt_GiamGia.Text = "0 VNĐ";
                return;
            }
            if (spin_GiamGia.Value != 0)
            {
                decimal giamGia = (ConvertTextToDecimal() / 100) * spin_GiamGia.Value;
                txt_GiamGia.Text = giamGia.ToString(",0.00") + " VNĐ";
            }

            TinhThanhTien();
        }

        private void spin_VAT_EditValueChanged(object sender, EventArgs e)
        {
            if (spin_VAT.Value == 0 || txt_TongCong.Text == "0")
            {
                txt_VAT.Text = "0 VNĐ";
                return;
            }
            if (spin_VAT.Value != 0)
            {
                decimal vat = (ConvertTextToDecimal() / 100) * spin_VAT.Value;
                txt_VAT.Text = vat.ToString(",0.00") + " VNĐ";
            }
            TinhThanhTien();
        }

        private void menuItem_Them_Click(object sender, EventArgs e)
        {
            DataRow row = dtChiTietPhieuNhap.NewRow();
            row["ID_Nguyen_Lieu"] = gridView2.GetRowCellValue(gridView2.FocusedRowHandle,
                "ID_Nguyen_Lieu");
            row["So_Luong"] = 0;
            row["Don_Gia"] = 0;
            decimal thanhtien = 0;
            try
            {
                thanhtien = int.Parse(row["So_Luong"].ToString()) * decimal.Parse(row["Don_Gia"].ToString());
            }
            catch
            {
                thanhtien = 0;
            }
            row["Thanh_Tien"] = thanhtien;           
            dtChiTietPhieuNhap.Rows.Add(row);
           

        }

        private void spinDonGia_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (String.IsNullOrEmpty(e.NewValue.ToString()))
                return;
            if (decimal.Parse(e.NewValue.ToString()) < 0)
            {
                e.NewValue = e.OldValue;
            }

            decimal thanhtien = 0;

            thanhtien = decimal.Parse(gridView_CTPN.GetRowCellDisplayText(gridView_CTPN.FocusedRowHandle,
                    "So_Luong").ToString()) * decimal.Parse(e.NewValue.ToString());
            gridView_CTPN.SetRowCellValue(gridView_CTPN.FocusedRowHandle, "Thanh_Tien", thanhtien);

        }

        private void spinEditGrid_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (String.IsNullOrEmpty(e.NewValue.ToString()))
                return;
            if (decimal.Parse(e.NewValue.ToString()) < 0)
            {
                e.NewValue = e.OldValue;
            }
            decimal thanhtien = 0;
            try {
                thanhtien = decimal.Parse(e.NewValue.ToString()) *
                    decimal.Parse(gridView_CTPN.GetRowCellDisplayText(gridView_CTPN.FocusedRowHandle,
                        "Don_Gia").ToString());
            }
            catch
            {

            }
            gridView_CTPN.SetRowCellValue(gridView_CTPN.FocusedRowHandle, "Thanh_Tien", thanhtien);

        }

        private void gridView_CTPN_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            txt_TongCong.Text = e.Info.DisplayText;
        }

        private void txt_TongCong_EditValueChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
            spin_GiamGia_EditValueChanged(sender, e);
            spin_VAT_EditValueChanged(sender, e);

        }

        private void TinhThanhTien()
        {
            string giamgia = txt_GiamGia.Text.Split(' ')[0];
            string vat = txt_VAT.Text.Split(' ')[0];
            decimal thanhTien = decimal.Parse(txt_TongCong.Text == null ? "0" : txt_TongCong.Text) -
                decimal.Parse(giamgia) + decimal.Parse(vat);
            txt_ThanhTien.Text = thanhTien.ToString("N1", CultureInfo.InvariantCulture);
        }

        private void spin_GiamGia_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (String.IsNullOrEmpty(e.NewValue.ToString()))
                return;
            if (decimal.Parse(e.NewValue.ToString()) < 0)
            {
                e.NewValue = 0;
            }

        }

        private void spin_VAT_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (String.IsNullOrEmpty(e.NewValue.ToString()))
                return;
            if (decimal.Parse(e.NewValue.ToString()) < 0)
            {
                e.NewValue = 0;
            }         
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                PHIEU_NHAP pn = new PHIEU_NHAP();
                pn.ID_NCC = int.Parse(lkup_NhaCungCap.EditValue.ToString());
                pn.So_Phieu_Nhap = txt_SoPhieuNhap.Text;
                pn.Ngay_Lap = dt_NgayLap.DateTime;
                pn.Tong_Tien = decimal.Parse(txt_ThanhTien.Text);
                pn.VAT = (double?)spin_VAT.Value;
                pn.Giam_Gia = (double?)spin_GiamGia.Value;
                // Thêm phiếu nhập
                int idPhieuNhap;
                if (IsUpdate == false)
                {
                    idPhieuNhap = _nhapHangBLL.ThemPhieuNhapHang(pn);
                }
                else
                {
                    pn.ID_Phieu_Nhap = _nhapHangBLL.LayIDPhieuNhapTheoSoPhieuNhap(pn.So_Phieu_Nhap);
                    idPhieuNhap = pn.ID_Phieu_Nhap;
                    _nhapHangBLL.CapNhatPhieuNhap(pn);
                }

                List<CHI_TIET_PHIEU_NHAP> dsChiTietPN = new List<CHI_TIET_PHIEU_NHAP>();
                if (gridView_CTPN.RowCount > 0)
                {
                    for (int i = 0; i < gridView_CTPN.RowCount; i++)
                    {
                        CHI_TIET_PHIEU_NHAP ct = new CHI_TIET_PHIEU_NHAP();
                        ct.ID_Phieu_Nhap = idPhieuNhap;
                        ct.ID_Nguyen_Lieu = int.Parse(gridView_CTPN.GetRowCellValue(i, "ID_Nguyen_Lieu").ToString());
                        ct.So_Luong = int.Parse(gridView_CTPN.GetRowCellValue(i, "So_Luong").ToString());
                        ct.Don_Gia = int.Parse(gridView_CTPN.GetRowCellValue(i, "Don_Gia").ToString());
                        ct.Thanh_Tien = int.Parse(gridView_CTPN.GetRowCellValue(i, "Thanh_Tien").ToString());

                        dsChiTietPN.Add(ct);
                    }
                }
                _nhapHangBLL.ThemChiTietPhieuNhap(dsChiTietPN, idPhieuNhap);
                Utils.Notification.Success("Thêm mới phiếu nhập hàng thành công!");

                Frm_Nhap_Hang_Load(sender, e); // Load lại tất cả dư liệu thay đổi

                ClearAll();                 // Refresh data control
            }
        }

        private void ClearAll()
        {
            txt_SoPhieuNhap.Text = "";
            check_MaTuSinh.Checked = false;
            lkup_NhaCungCap.EditValue = null;
            spin_GiamGia.EditValue = 0;
            spin_VAT.EditValue = 0;

            dtChiTietPhieuNhap.Clear();
            txt_TongCong.Text = "0";
            txt_ThanhTien.Text = "0";

            IsUpdate = false;


            txt_SoPhieuNhap.Enabled = true;
            check_MaTuSinh.Enabled = true;
        }

        // Kiểm tra hợp lệ dư liệu nhập
        private bool IsValidate()
        {        
            if (lkup_NhaCungCap.EditValue == null)
            {
                Utils.Notification.Error("Bạn chưa chọn nhà cung cấp. Vui lòng chọn nhà cung cấp");
                return false;
            }       
            if (String.IsNullOrEmpty(txt_SoPhieuNhap.Text))
            {
                Utils.Notification.Error("Bạn chưa nhập số phiếu nhập! Vui lòng nhập số phiếu nhập");
                return false;
            }
            if (_nhapHangBLL.TonTaiMaPhieuNhap(txt_SoPhieuNhap.Text) && IsUpdate == false)
            {
                Utils.Notification.Error("Số phiếu nhập đã tồn tại vui lòng chọn số phiếu nhập khác");
                return false;
            }
            if (gridView_CTPN.RowCount <= 0)
            {
                Utils.Notification.Error("Bạn chưa nhập danh sách nguyên liệu cần nhập!");
                return false;
            }
            return true;
        }
        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        #region Tab Danh Sach Phieu Nhap
        // Load danh sách phiếu nhập lên gridcontrol
        private void DanhSachPhieuNhap()
        {
            gridControl1.DataSource = _nhapHangBLL.LayDanhSachPhieuNhap();
        }
        
        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            ClearAll();
            tab_NhapHang.SelectedTabPage = tabPage_NHAPHANG;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            DanhSachPhieuNhap();
        }

        private void btn_In1_Click(object sender, EventArgs e)
        {

        }
        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            ClearAll();

            int focusRow = gridView1.FocusedRowHandle;


            txt_SoPhieuNhap.Text = gridView1.GetRowCellValue(focusRow, "So_Phieu_Nhap").ToString();
            // Người dùng

            // Nhà Cung cấp
            int id_NCC = int.Parse(gridView1.GetRowCellValue(focusRow,
                "ID_NCC").ToString());
            lkup_NhaCungCap.EditValue = _nhaCungCapBLL.LayNhaCungCapByID(id_NCC).ID_Nha_Cung_Cap;

            // Ngày lập
            dt_NgayLap.DateTime = DateTime.Parse(gridView1.GetRowCellValue(focusRow,
                "Ngay_Lap").ToString());

            // VAT
            spin_VAT.EditValue = int.Parse(gridView1.GetRowCellValue(focusRow,
              "VAT") == null ? "0" : gridView1.GetRowCellValue(focusRow,
              "VAT").ToString());
            // GIẢM GIÁ
            spin_GiamGia.EditValue = int.Parse(gridView1.GetRowCellValue(focusRow,
              "Giam_Gia") == null ? "0" : gridView1.GetRowCellValue(focusRow,
              "Giam_Gia").ToString());

            // Chi tiết phiếu nhập
            foreach (var item in _nhapHangBLL.LayChiTietPhieuNhapTheoIDPhieuNhap(int.Parse(gridView1.GetRowCellValue
                (focusRow, "ID_Phieu_Nhap").ToString())))
            {
                DataRow dr = dtChiTietPhieuNhap.NewRow();
                dr["ID_Nguyen_Lieu"] = item.ID_Nguyen_Lieu;
                dr["So_Luong"] = item.So_Luong;
                dr["Don_Gia"] = item.Don_Gia;
                dr["Thanh_Tien"] = item.Thanh_Tien;
                dtChiTietPhieuNhap.Rows.Add(dr);
            }
            gridControl_CTPN.DataSource = dtChiTietPhieuNhap;
            tab_NhapHang.SelectedTabPage = tabPage_NHAPHANG;

            txt_SoPhieuNhap.Enabled = false;
            check_MaTuSinh.Enabled = false;

            IsUpdate = true;
        }
        private void btn_XoaPN_Click(object sender, EventArgs e)
        {
            string soPhieuNhap = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "So_Phieu_Nhap").ToString();
            if(Utils.Notification.Answers("Bạn có muốn xóa phiếu nhập {" + soPhieuNhap + "}. Nhấn Cancel để Hủy. ") == DialogResult.OK)
            {
                _nhapHangBLL.XoaPhieuNhap(int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,
                    "ID_Phieu_Nhap").ToString()));
                DanhSachPhieuNhap();
            }
        }

        #endregion

        // Thêm nguyên liệu vào grid chi tiết nhập hàng
        private void btn_ThemNL_Click(object sender, EventArgs e)
        {
            menuItem_Them_Click(sender, e);
        }

        private void btn_XoaChiPN_Click(object sender, EventArgs e)
        {
            gridView_CTPN.DeleteRow(gridView_CTPN.FocusedRowHandle);
        }

        private void btn_InPhieuNhap_Click(object sender, EventArgs e)
        {
            string soPhieuNhap = txt_SoPhieuNhap.Text;
            btn_Luu_Click(sender, e);

        }
    }
}
