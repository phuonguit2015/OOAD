namespace CoffeeManagement
{
    partial class Frm_Them_Nguyen_Lieu_Moi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Them_Nguyen_Lieu_Moi));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_ThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.txt_MaNguyenLieu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenNguyenLieu = new DevExpress.XtraEditors.TextEdit();
            this.lkup_DonVi = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNguyenLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNguyenLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkup_DonVi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Nguyên Liệu";
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemMoi.Image")));
            this.btn_ThemMoi.Location = new System.Drawing.Point(207, 122);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(89, 23);
            this.btn_ThemMoi.TabIndex = 2;
            this.btn_ThemMoi.Text = "THÊM MỚI";
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // txt_MaNguyenLieu
            // 
            this.txt_MaNguyenLieu.Location = new System.Drawing.Point(102, 12);
            this.txt_MaNguyenLieu.Name = "txt_MaNguyenLieu";
            this.txt_MaNguyenLieu.Size = new System.Drawing.Size(194, 20);
            this.txt_MaNguyenLieu.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên Nguyên Liệu";
            // 
            // txt_TenNguyenLieu
            // 
            this.txt_TenNguyenLieu.Location = new System.Drawing.Point(102, 48);
            this.txt_TenNguyenLieu.Name = "txt_TenNguyenLieu";
            this.txt_TenNguyenLieu.Size = new System.Drawing.Size(194, 20);
            this.txt_TenNguyenLieu.TabIndex = 1;
            // 
            // lkup_DonVi
            // 
            this.lkup_DonVi.Location = new System.Drawing.Point(102, 86);
            this.lkup_DonVi.Name = "lkup_DonVi";
            this.lkup_DonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkup_DonVi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_Don_Vi", "ĐƠN VỊ")});
            this.lkup_DonVi.Properties.NullText = "[Chọn Đơn Vị]";
            this.lkup_DonVi.Size = new System.Drawing.Size(194, 20);
            this.lkup_DonVi.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Đơn Vị Tính";
            // 
            // Frm_Them_Nguyen_Lieu_Moi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 158);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lkup_DonVi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_TenNguyenLieu);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_ThemMoi);
            this.Controls.Add(this.txt_MaNguyenLieu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(328, 197);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(328, 197);
            this.Name = "Frm_Them_Nguyen_Lieu_Moi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM NGUYÊN LIỆU MỚI";
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNguyenLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNguyenLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkup_DonVi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_ThemMoi;
        private DevExpress.XtraEditors.TextEdit txt_MaNguyenLieu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_TenNguyenLieu;
        private DevExpress.XtraEditors.LookUpEdit lkup_DonVi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}