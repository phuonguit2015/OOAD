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
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
        }
        Form GetMdiFormByName(string name)
        {
            return this.MdiChildren.FirstOrDefault(f => f.Name == name);
        }

        private void Frm_Home_Load(object sender, EventArgs e)
        {

        }

        #region Button
        private void btn_Kho_Hang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                f = new Frm_Nhap_Hang();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
            }
        }     

        private void btn_Ban_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                f = new Frm_Ban();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_KhuVuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                f = new Frm_Khu_Vuc();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_ThucDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                f = new Frm_Mon();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_LoaiMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                f = new Frm_Loai_Mon();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_NguyenLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                f = new Frm_Nguyen_Lieu();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_DonVi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                f = new Frm_Don_Vi();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_Phuc_Vu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                f = new Frm_Phuc_Vu();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_Thuc_Don_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_NhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                f = new Frm_Nha_Cung_Cap();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
            }
        }
        private void btn_NguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                f = new Frm_QuanLyNguoiDung();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_PhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                f = new Frm_PhanQuyen();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_KhuyenMai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                f = new Frm_Khuyen_Mai();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
            }
        }

        #endregion


    }
}
