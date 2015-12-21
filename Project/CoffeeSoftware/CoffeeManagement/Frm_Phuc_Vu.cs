using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using System;
using System.Data;
using System.Windows.Forms;



namespace CoffeeManagement
{

    public partial class Frm_Phuc_Vu : Form
    {
        const int Ban_Trong = 0;
        const int Ban_Dang_Su_Dung = 1;
        const int Ban_Chua_Don = 2;

        private int idBan; // ID của bàn đang được chọn
        private string tenBan;

        KhuVucBLL _khuVucBLL = new KhuVucBLL();
        BanBLL _banBLL = new BanBLL();
        MonBLL _monBLL = new MonBLL();
        HoaDonBLL _hoaDonBLL = new HoaDonBLL();

        DataTable dtHoaDon = new DataTable();

        public Frm_Phuc_Vu()
        {
            InitializeComponent();
            dt_ThoiGian.DateTime = DateTime.Now;
        }

        private void LoadDaTaChiTietHoaDon(int idHoaDon)
        {
            gridControl_HoaDon.DataSource = _hoaDonBLL.LayChiTietHoaDonTheoIDHoaDon(idHoaDon);
        }

        private void LoadDataToListView()
        {
            listView1.Clear();
            DataTable dtKhuVuc = Utils.Util.ConvertToDataTable<KHU_VUC>(_khuVucBLL.LayDanhSachKhuVuc());
            for (int i = 0; i < dtKhuVuc.Rows.Count; i++)
            {
                ListViewGroup group = new ListViewGroup(dtKhuVuc.Rows[i][0].ToString(), dtKhuVuc.Rows[i][1].ToString());
                DataTable dtBan = Utils.Util.ConvertToDataTable<BAN>(_banBLL.LayDanhSachBan());
                listView1.Groups.Add(group);
                for (int j = 0; j < dtBan.Rows.Count; j++)
                {
                    if (dtBan.Rows[j]["ID_Khu_Vuc"].ToString() == dtKhuVuc.Rows[i][0].ToString())
                    {
                        if (dtBan.Rows[j]["Trang_Thai"].ToString() == Ban_Trong.ToString())
                        {
                            ListViewItem item = new ListViewItem(dtBan.Rows[j]["Ten_Ban"].ToString(), 0, group);
                            listView1.Items.Add(item);
                        }
                        else
                        {
                            if (dtBan.Rows[i]["Trang_Thai"].ToString() == Ban_Dang_Su_Dung.ToString())
                            {
                                ListViewItem item = new ListViewItem(dtBan.Rows[j]["Ten_Ban"].ToString(), 1, group);
                                listView1.Items.Add(item);
                            }
                            else
                            {
                                ListViewItem item = new ListViewItem(dtBan.Rows[j]["Ten_Ban"].ToString(), 2, group);
                                listView1.Items.Add(item);
                            }
                        }
                    }                   
                }
            }
        }

        private void LoadDataToGridControlThucDon()
        {
            // Load lkup Loại Món
            LoaiMonBLL _loaiMonBLL = new LoaiMonBLL();
            lkup_LoaiMon.DataSource = Utils.Util.ConvertToDataTable<LOAI_MON>( _loaiMonBLL.LayDanhSachLoaiMon());
            lkup_LoaiMon.DisplayMember = "Ten_Loai_Mon";
            lkup_LoaiMon.ValueMember = "ID_Loai_Mon";


            DataTable dt = Utils.Util.ConvertToDataTable<MON>(_monBLL.LayDanhSachMon());
            gridControl_ThucDon.DataSource = dt;
        }

        private void Frm_Phuc_Vu_Load(object sender, System.EventArgs e)
        {
            LoadDataToListView();
            LoadDataToGridControlThucDon();
        }

        #region Custom Context Menu
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
            var b = listView1.SelectedItems[0];
            idBan = _banBLL.LayIDTheoBan(b.SubItems[0].Text);
            tenBan = b.SubItems[0].Text;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0)
            {
                e.Cancel = true;
                return;
            }
            // Custom menu với các loại bàn khác nhau
            var b = listView1.SelectedItems[0];
            switch(b.ImageIndex)
            {
                case 0:
                    // Bàn trống hiện menu: Tạo Hóa Đơn
                    menu_DonBan.Visible = false;
                    menu_ChuyenBan.Visible = false;
                    menu_InHoaDon.Visible = false;
                    menu_InTamTinh.Visible = false;
                    menu_ThanhToan.Visible = false;
                    menu_XemChiTiet.Visible = false;

                    sep1.Visible = false;           // Hide Sperator

                    menu_ToaHD.Visible = true;

                    break;
                case 1:
                    // Bàn đang sử dụng: Chuyển bàn, Thanh toán, In Tạm Tính, In Hóa Đơn
                    menu_DonBan.Visible = false;
                    menu_ToaHD.Visible = false;

                    menu_XemChiTiet.Visible = true;
                    menu_ChuyenBan.Visible = true;
                    menu_InHoaDon.Visible = true;
                    menu_InTamTinh.Visible = true;
                    menu_ThanhToan.Visible = true;

                    sep1.Visible = true;           // Hide Sperator

                    break;
                case 2:
                    // Bàn chưa dọn: Dọn bàn
                    menu_DonBan.Visible = true;

                    menu_ChuyenBan.Visible = false;
                    menu_InHoaDon.Visible = false;
                    menu_InTamTinh.Visible = false;
                    menu_ThanhToan.Visible = false;
                    menu_XemChiTiet.Visible = false;
                    menu_ToaHD.Visible = false;

                    sep1.Visible = false;           // Hide Sperator

                    break;
            }
            
        }
        #endregion

        // Cập nhật dọn bàn.
        private void menu_DonBan_Click(object sender, System.EventArgs e)
        {
            if(idBan != -1)
            {
                _banBLL.CapNhatTinhTrangBan(0, idBan);
            }
            LoadDataToListView();
        }

        // Tạo hóa đơn mới
        private void menu_ToaHD_Click(object sender, EventArgs e)
        {
            HOA_DON h = new HOA_DON();
            h.ID_Ban = idBan;
            // h.ID_Nguoi_Dung =
            h.Ngay_Lap = dt_ThoiGian.DateTime;
            h.Trang_Thai_Thanh_Toan = 1;
          
            XemChiTietHoaDon(_hoaDonBLL.ThemHoaDonMoi(h));

            // Cập nhật tình trạng bàn thành đang sử dụng
            _banBLL.CapNhatTinhTrangBan(1, idBan);
            LoadDataToListView();
        }


        private void XemChiTietHoaDon(int idHoaDon)
        {
            var h = _hoaDonBLL.LayHoaDonTheoID(idHoaDon);

            dt_ThoiGian.DateTime = (DateTime)h.Ngay_Lap;
            txt_Ban.Text = tenBan;
            txt_KhuVuc.Text = _banBLL.LayKhuVucTheoIDBan(idBan);
            txt_SoHoaDon.Text = idHoaDon.ToString();

            LoadDaTaChiTietHoaDon(idHoaDon);
        }


        //Button thêm món mới cho bàn sử dụng
        private void bnt_ThemMon_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txt_SoHoaDon.Text))
            {
                CHI_TIET_HOA_DON ct = new CHI_TIET_HOA_DON();
                ct.ID_Mon = int.Parse(gridView_ThucDon.GetRowCellValue(gridView_ThucDon.FocusedRowHandle,
                    "ID_Mon").ToString());
                ct.So_Luong = 1;
                int idHoaDon = int.Parse(txt_SoHoaDon.Text);
                ct.ID_Hoa_Don = idHoaDon;
                _hoaDonBLL.ThemChiTietHoaDon(ct);

                LoadDaTaChiTietHoaDon(idHoaDon);
            }
            else
            {
                Utils.Notification.Error("Bạn chưa chọn hóa đơn.");
            }
        }

        private void menu_XemChiTiet_Click(object sender, EventArgs e)
        {
            XemChiTietHoaDon(_hoaDonBLL.LayIDHoaDonTheoBan(idBan));
        }
    }
}
