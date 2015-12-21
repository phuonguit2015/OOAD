namespace CoffeeManagement
{
    partial class Frm_Khuyen_Mai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Khuyen_Mai));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_Them_Moi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Luu_Lai = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Lam_Moi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_In = new DevExpress.XtraBars.BarButtonItem();
            this.txt_DuongDan = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btn_Browse = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Import = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Chuong_Trinh_KM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Loai_KM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Gia_Tri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.col_Ngay_Bat_Dau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Ngay_Het_Han = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_So_Luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_ID_CTKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Trang_Thai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Them_Moi,
            this.btn_Xoa,
            this.btn_Luu_Lai,
            this.btn_In,
            this.btn_Lam_Moi,
            this.txt_DuongDan,
            this.btn_Import,
            this.barButtonItem1,
            this.btn_Browse});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Them_Moi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Luu_Lai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Lam_Moi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_In, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, this.txt_DuongDan, "", false, false, true, 0),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Browse),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Import, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_Them_Moi
            // 
            this.btn_Them_Moi.Caption = "THÊM MỚI";
            this.btn_Them_Moi.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_Them_Moi.Glyph")));
            this.btn_Them_Moi.Id = 0;
            this.btn_Them_Moi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_Them_Moi.LargeGlyph")));
            this.btn_Them_Moi.Name = "btn_Them_Moi";
            this.btn_Them_Moi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Them_Moi_ItemClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Caption = "XÓA";
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Glyph")));
            this.btn_Xoa.Id = 1;
            this.btn_Xoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.LargeGlyph")));
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Xoa_ItemClick);
            // 
            // btn_Luu_Lai
            // 
            this.btn_Luu_Lai.Caption = "LƯU LẠI";
            this.btn_Luu_Lai.Enabled = false;
            this.btn_Luu_Lai.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_Luu_Lai.Glyph")));
            this.btn_Luu_Lai.Id = 2;
            this.btn_Luu_Lai.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_Luu_Lai.LargeGlyph")));
            this.btn_Luu_Lai.Name = "btn_Luu_Lai";
            this.btn_Luu_Lai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Luu_Lai_ItemClick);
            // 
            // btn_Lam_Moi
            // 
            this.btn_Lam_Moi.Caption = "LÀM MỚI";
            this.btn_Lam_Moi.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_Lam_Moi.Glyph")));
            this.btn_Lam_Moi.Id = 4;
            this.btn_Lam_Moi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_Lam_Moi.LargeGlyph")));
            this.btn_Lam_Moi.Name = "btn_Lam_Moi";
            this.btn_Lam_Moi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Lam_Moi_ItemClick);
            // 
            // btn_In
            // 
            this.btn_In.Caption = "IN ";
            this.btn_In.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_In.Glyph")));
            this.btn_In.Id = 3;
            this.btn_In.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_In.LargeGlyph")));
            this.btn_In.Name = "btn_In";
            this.btn_In.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_In_ItemClick);
            // 
            // txt_DuongDan
            // 
            this.txt_DuongDan.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txt_DuongDan.Edit = this.repositoryItemTextEdit1;
            this.txt_DuongDan.Id = 5;
            this.txt_DuongDan.Name = "txt_DuongDan";
            this.txt_DuongDan.Width = 200;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // btn_Browse
            // 
            this.btn_Browse.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Browse.Caption = "Browse...";
            this.btn_Browse.Id = 9;
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Browse_ItemClick);
            // 
            // btn_Import
            // 
            this.btn_Import.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Import.Caption = "IMPORT EXCEL";
            this.btn_Import.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_Import.Glyph")));
            this.btn_Import.Id = 6;
            this.btn_Import.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_Import.LargeGlyph")));
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Import_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(944, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 322);
            this.barDockControlBottom.Size = new System.Drawing.Size(944, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 298);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(944, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 298);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.65772F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.34228F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 298);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(938, 139);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Padding = new System.Windows.Forms.Padding(5);
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(934, 135);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_ID,
            this.col_Chuong_Trinh_KM,
            this.col_Loai_KM,
            this.col_Gia_Tri,
            this.col_Ngay_Bat_Dau,
            this.col_Ngay_Het_Han,
            this.col_So_Luong});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm dòng mới tại đây...";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // col_ID
            // 
            this.col_ID.AppearanceCell.Options.UseTextOptions = true;
            this.col_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.col_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_ID.Caption = "ID";
            this.col_ID.FieldName = "ID_KM";
            this.col_ID.Name = "col_ID";
            this.col_ID.Visible = true;
            this.col_ID.VisibleIndex = 1;
            this.col_ID.Width = 82;
            // 
            // col_Chuong_Trinh_KM
            // 
            this.col_Chuong_Trinh_KM.AppearanceCell.Options.UseTextOptions = true;
            this.col_Chuong_Trinh_KM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Chuong_Trinh_KM.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Chuong_Trinh_KM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Chuong_Trinh_KM.Caption = "Chương Trình Khuyến Mãi";
            this.col_Chuong_Trinh_KM.FieldName = "Chuong_Trinh_KM";
            this.col_Chuong_Trinh_KM.Name = "col_Chuong_Trinh_KM";
            this.col_Chuong_Trinh_KM.Visible = true;
            this.col_Chuong_Trinh_KM.VisibleIndex = 2;
            this.col_Chuong_Trinh_KM.Width = 204;
            // 
            // col_Loai_KM
            // 
            this.col_Loai_KM.AppearanceCell.Options.UseTextOptions = true;
            this.col_Loai_KM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Loai_KM.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Loai_KM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Loai_KM.Caption = "Loại Khuyến Mãi";
            this.col_Loai_KM.FieldName = "Loai_KM";
            this.col_Loai_KM.Name = "col_Loai_KM";
            this.col_Loai_KM.Visible = true;
            this.col_Loai_KM.VisibleIndex = 3;
            this.col_Loai_KM.Width = 122;
            // 
            // col_Gia_Tri
            // 
            this.col_Gia_Tri.AppearanceCell.Options.UseTextOptions = true;
            this.col_Gia_Tri.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Gia_Tri.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Gia_Tri.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Gia_Tri.Caption = "Giá Trị";
            this.col_Gia_Tri.ColumnEdit = this.repositoryItemComboBox1;
            this.col_Gia_Tri.FieldName = "Gia_Tri";
            this.col_Gia_Tri.Name = "col_Gia_Tri";
            this.col_Gia_Tri.Visible = true;
            this.col_Gia_Tri.VisibleIndex = 4;
            this.col_Gia_Tri.Width = 122;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // col_Ngay_Bat_Dau
            // 
            this.col_Ngay_Bat_Dau.AppearanceCell.Options.UseTextOptions = true;
            this.col_Ngay_Bat_Dau.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Ngay_Bat_Dau.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Ngay_Bat_Dau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Ngay_Bat_Dau.Caption = "Ngày Bắt Đầu";
            this.col_Ngay_Bat_Dau.FieldName = "Ngay_Bat_Dau";
            this.col_Ngay_Bat_Dau.Name = "col_Ngay_Bat_Dau";
            this.col_Ngay_Bat_Dau.Visible = true;
            this.col_Ngay_Bat_Dau.VisibleIndex = 5;
            this.col_Ngay_Bat_Dau.Width = 122;
            // 
            // col_Ngay_Het_Han
            // 
            this.col_Ngay_Het_Han.AppearanceCell.Options.UseTextOptions = true;
            this.col_Ngay_Het_Han.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Ngay_Het_Han.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Ngay_Het_Han.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Ngay_Het_Han.Caption = "Ngày Hết Hạn";
            this.col_Ngay_Het_Han.FieldName = "Ngay_Het_Han";
            this.col_Ngay_Het_Han.Name = "col_Ngay_Het_Han";
            this.col_Ngay_Het_Han.Visible = true;
            this.col_Ngay_Het_Han.VisibleIndex = 6;
            this.col_Ngay_Het_Han.Width = 109;
            // 
            // col_So_Luong
            // 
            this.col_So_Luong.AppearanceCell.Options.UseTextOptions = true;
            this.col_So_Luong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_So_Luong.AppearanceHeader.Options.UseTextOptions = true;
            this.col_So_Luong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_So_Luong.Caption = "Số Lượng";
            this.col_So_Luong.FieldName = "So_Luong";
            this.col_So_Luong.Name = "col_So_Luong";
            this.col_So_Luong.Visible = true;
            this.col_So_Luong.VisibleIndex = 7;
            this.col_So_Luong.Width = 90;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(3, 148);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(938, 147);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControl2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(934, 143);
            this.panelControl3.TabIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 2);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.MenuManager = this.barManager1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Padding = new System.Windows.Forms.Padding(5);
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox2});
            this.gridControl2.Size = new System.Drawing.Size(930, 139);
            this.gridControl2.TabIndex = 7;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_ID_CTKM,
            this.col_Code,
            this.col_Trang_Thai});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.NewItemRowText = "Thêm dòng mới tại đây...";
            this.gridView2.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowDetailButtons = false;
            this.gridView2.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // col_ID_CTKM
            // 
            this.col_ID_CTKM.AppearanceCell.Options.UseTextOptions = true;
            this.col_ID_CTKM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_ID_CTKM.AppearanceHeader.Options.UseTextOptions = true;
            this.col_ID_CTKM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_ID_CTKM.Caption = "ID";
            this.col_ID_CTKM.FieldName = "ID_CTKM";
            this.col_ID_CTKM.Name = "col_ID_CTKM";
            this.col_ID_CTKM.Visible = true;
            this.col_ID_CTKM.VisibleIndex = 0;
            this.col_ID_CTKM.Width = 82;
            // 
            // col_Code
            // 
            this.col_Code.AppearanceCell.Options.UseTextOptions = true;
            this.col_Code.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Code.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Code.Caption = "Code";
            this.col_Code.FieldName = "Code";
            this.col_Code.Name = "col_Code";
            this.col_Code.Visible = true;
            this.col_Code.VisibleIndex = 1;
            this.col_Code.Width = 122;
            // 
            // col_Trang_Thai
            // 
            this.col_Trang_Thai.AppearanceCell.Options.UseTextOptions = true;
            this.col_Trang_Thai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Trang_Thai.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Trang_Thai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Trang_Thai.Caption = "Trạng Thái";
            this.col_Trang_Thai.FieldName = "Trang_Thai";
            this.col_Trang_Thai.Name = "col_Trang_Thai";
            this.col_Trang_Thai.Visible = true;
            this.col_Trang_Thai.VisibleIndex = 2;
            this.col_Trang_Thai.Width = 90;
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // Frm_Khuyen_Mai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 322);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_Khuyen_Mai";
            this.Text = "Frm_Khuyen_Mai";
            this.Load += new System.EventHandler(this.Frm_Khuyen_Mai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_Them_Moi;
        private DevExpress.XtraBars.BarButtonItem btn_Xoa;
        private DevExpress.XtraBars.BarButtonItem btn_Luu_Lai;
        private DevExpress.XtraBars.BarButtonItem btn_Lam_Moi;
        private DevExpress.XtraBars.BarButtonItem btn_In;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_ID;
        private DevExpress.XtraGrid.Columns.GridColumn col_Chuong_Trinh_KM;
        private DevExpress.XtraGrid.Columns.GridColumn col_Loai_KM;
        private DevExpress.XtraGrid.Columns.GridColumn col_Gia_Tri;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn col_Ngay_Bat_Dau;
        private DevExpress.XtraGrid.Columns.GridColumn col_Ngay_Het_Han;
        private DevExpress.XtraGrid.Columns.GridColumn col_So_Luong;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn col_ID_CTKM;
        private DevExpress.XtraGrid.Columns.GridColumn col_Code;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraGrid.Columns.GridColumn col_Trang_Thai;
        private DevExpress.XtraBars.BarEditItem txt_DuongDan;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem btn_Import;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_Browse;
    }
}