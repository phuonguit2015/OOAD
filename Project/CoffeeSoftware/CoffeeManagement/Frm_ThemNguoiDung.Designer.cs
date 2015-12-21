namespace CoffeeManagement
{
    partial class Frm_ThemNguoiDung
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtNhapLaiMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnTaoTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_loaiND = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLaiMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_loaiND.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(57, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tài khoản :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(57, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu :";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(141, 20);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(205, 20);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(141, 59);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(205, 20);
            this.txtMatKhau.TabIndex = 3;
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(141, 99);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(205, 20);
            this.txtNhapLaiMatKhau.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Nhập lại mất khẩu :";
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(245, 171);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(101, 31);
            this.btnTaoTaiKhoan.TabIndex = 6;
            this.btnTaoTaiKhoan.Text = "TẠO TÀI KHOẢN";
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // cbb_loaiND
            // 
            this.cbb_loaiND.Location = new System.Drawing.Point(141, 135);
            this.cbb_loaiND.Name = "cbb_loaiND";
            this.cbb_loaiND.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_loaiND.Properties.Items.AddRange(new object[] {
            "Quản Trị Hệ Thống",
            "Quản Lý",
            "Nhân Viên Thu Ngân",
            "Nhân Viên Phòng Bếp"});
            this.cbb_loaiND.Size = new System.Drawing.Size(205, 20);
            this.cbb_loaiND.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 138);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Loại người dùng :";
            // 
            // Frm_ThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 227);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbb_loaiND);
            this.Controls.Add(this.btnTaoTaiKhoan);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtNhapLaiMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "Frm_ThemNguoiDung";
            this.Text = "Frm_ThemNguoiDung";
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLaiMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_loaiND.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtNhapLaiMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnTaoTaiKhoan;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_loaiND;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}