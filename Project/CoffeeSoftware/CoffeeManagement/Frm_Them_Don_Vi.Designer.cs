namespace CoffeeManagement
{
    partial class Frm_Them_Don_Vi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Them_Don_Vi));
            this.btn_ThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TenDonVi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDonVi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemMoi.Image")));
            this.btn_ThemMoi.Location = new System.Drawing.Point(298, 10);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(89, 23);
            this.btn_ThemMoi.TabIndex = 4;
            this.btn_ThemMoi.Text = "THÊM MỚI";
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // txt_TenDonVi
            // 
            this.txt_TenDonVi.Location = new System.Drawing.Point(80, 12);
            this.txt_TenDonVi.Name = "txt_TenDonVi";
            this.txt_TenDonVi.Size = new System.Drawing.Size(194, 20);
            this.txt_TenDonVi.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Tên Đơn Vị";
            // 
            // Frm_Them_Don_Vi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 47);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_ThemMoi);
            this.Controls.Add(this.txt_TenDonVi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(423, 86);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(423, 86);
            this.Name = "Frm_Them_Don_Vi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM ĐƠN VỊ MỚI";
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDonVi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_ThemMoi;
        private DevExpress.XtraEditors.TextEdit txt_TenDonVi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}