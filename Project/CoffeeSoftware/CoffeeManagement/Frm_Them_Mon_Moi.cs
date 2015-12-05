using CoffeeManagement.DAL;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Frm_Them_Mon_Moi : Form
    {
        BLL.MonBLL _monBLL = new BLL.MonBLL();
        BLL.LoaiMonBLL _loaiMonBLL = new BLL.LoaiMonBLL();
        BLL.DonViBLL _donViBLL = new BLL.DonViBLL();
        public Frm_Them_Mon_Moi()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            lkup_Loai_Mon.Properties.DataSource = _loaiMonBLL.LayDanhSachLoaiMon();
            lkup_Loai_Mon.Properties.DisplayMember = "Ten_Loai_Mon";
            lkup_Loai_Mon.Properties.ValueMember = "ID_Loai_Mon";

            lkup_DonVi.Properties.DataSource = Utils.Util.ConvertToDataTable<DON_VI>(_donViBLL.LayDanhSachDonVi());
            lkup_DonVi.Properties.DisplayMember = "Ten_Don_Vi";
            lkup_DonVi.Properties.ValueMember = "ID_Don_Vi";
        }

        private void Frm_Them_Mon_Moi_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void btn_Them_Moi_Click(object sender, System.EventArgs e)
        {
            if(lkup_Loai_Mon.EditValue == System.DBNull.Value)
            {
                Utils.Notification.Error("Bạn chưa chọn loại món.");
                return;
            }
            if(txt_Ten_Mon.Text.Length == 0)
            {
                Utils.Notification.Error("Bạn chưa nhập tên món.");
                return;
            }
            if (lkup_DonVi.EditValue == System.DBNull.Value)
            {
                Utils.Notification.Error("Bạn chưa chọn đơn vị tính.");
                return;
            }
            if (spin_Gia_Ban.Value == 0)
            {
                if(Utils.Notification.Answers("Bạn chưa nhập giá bán. Bạn có muốn nhập giá bán trước khi tạo mới không? Nếu không nhấn OK để tạo mới.") == DialogResult.Cancel)
                {
                    return;
                }                       
            }
            ThemMonMoi();
        }
        private void ThemMonMoi()
        {
            DAL.MON _mon = new DAL.MON();
            _mon.Don_Gia = spin_Gia_Ban.Value;
            _mon.Ten_Mon = txt_Ten_Mon.Text;
            _mon.ID_Loai_Mon = int.Parse(lkup_Loai_Mon.EditValue.ToString());
            _mon.Hinh_Anh = new System.Data.Linq.Binary(Utils.Util.ImageToByteArray(pic_Hinh_Anh.Image));
            _mon.ID_Don_Vi = int.Parse(lkup_DonVi.EditValue.ToString());

            // insert
            if (!_monBLL.KiemTraTenMonTonTai(txt_Ten_Mon.Text))
            {
                _monBLL.ThemMonMoi(_mon);
                Utils.Notification.Success("Thêm món mới thành công.");
            }
            else
            {
                Utils.Notification.Error("Tên món đã tồn tại. Vui lòng nhập tên món lại.");
            }

            txt_Ten_Mon.Text = "";
            spin_Gia_Ban.Value = 0;
        }
    }
}
