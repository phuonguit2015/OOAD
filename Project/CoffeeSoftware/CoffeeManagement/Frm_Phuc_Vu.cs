using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using System.Data;
using System.Windows.Forms;



namespace CoffeeManagement
{

    public partial class Frm_Phuc_Vu : Form
    {
        const int Ban_Trong = 0;
        const int Ban_Dang_Su_Dung = 1;
        const int Ban_Chua_Don = 2;

        KhuVucBLL _khuVucBLL = new KhuVucBLL();
        BanBLL _banBLL = new BanBLL();
        MonBLL _monBLL = new MonBLL();

        public Frm_Phuc_Vu()
        {
            InitializeComponent();
        }

        private void LoadDataToListView()
        {
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
