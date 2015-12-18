namespace CoffeeManagement
{
    partial class Frm_Them_Nha_Cung_Cap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Them_Nha_Cung_Cap));
            this.txt_NhaCungCap = new DevExpress.XtraEditors.TextEdit();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txt_SoDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_ThemMoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoDienThoai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NhaCungCap
            // 
            this.txt_NhaCungCap.Location = new System.Drawing.Point(123, 21);
            this.txt_NhaCungCap.Name = "txt_NhaCungCap";
            this.txt_NhaCungCap.Size = new System.Drawing.Size(226, 20);
            this.txt_NhaCungCap.TabIndex = 0;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(123, 47);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(226, 20);
            this.txt_DiaChi.TabIndex = 1;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Location = new System.Drawing.Point(123, 73);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(226, 20);
            this.txt_SoDienThoai.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tên Nhà Cung Cấp";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Địa Chỉ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Số Điện Thoại";
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemMoi.Image")));
            this.btn_ThemMoi.Location = new System.Drawing.Point(253, 99);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(96, 23);
            this.btn_ThemMoi.TabIndex = 6;
            this.btn_ThemMoi.Text = "THÊM MỚI";
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // Frm_Them_Nha_Cung_Cap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 137);
            this.Controls.Add(this.btn_ThemMoi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_SoDienThoai);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_NhaCungCap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Them_Nha_Cung_Cap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM NHÀ CUNG CẤP";
            ((System.ComponentModel.ISupportInitialize)(this.txt_NhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoDienThoai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_NhaCungCap;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
        private DevExpress.XtraEditors.TextEdit txt_SoDienThoai;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_ThemMoi;
    }
}