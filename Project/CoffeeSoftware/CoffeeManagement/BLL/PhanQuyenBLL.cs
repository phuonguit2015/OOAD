using CoffeeManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeManagement.BLL
{
    class PhanQuyenBLL
    {
        CoffeeDBDataContext dbContext = new CoffeeDBDataContext();

        public void InitialFirstData()
        {
            if (LayDanhSach().Count() > 0)
                return;
            PHAN_QUYEN pq = new PHAN_QUYEN();
            pq.ID_Loai_ND = 1;
            dbContext.PHAN_QUYENs.InsertOnSubmit(pq);

            PHAN_QUYEN pq1 = new PHAN_QUYEN();
            pq1.ID_Loai_ND = 2;
            dbContext.PHAN_QUYENs.InsertOnSubmit(pq1);

            PHAN_QUYEN pq2 = new PHAN_QUYEN();
            pq2.ID_Loai_ND = 3;
            dbContext.PHAN_QUYENs.InsertOnSubmit(pq2);

            PHAN_QUYEN pq3 = new PHAN_QUYEN();
            pq3.ID_Loai_ND = 4;
            dbContext.PHAN_QUYENs.InsertOnSubmit(pq3);
            dbContext.SubmitChanges();
        }

        public IEnumerable<PHAN_QUYEN> LayDanhSach()
        {
            IEnumerable<PHAN_QUYEN> query = from b in dbContext.PHAN_QUYENs select b;
            return query;
        }
        public int LayID_Loai_ND(string loai)
        {
            IEnumerable<LOAI_NGUOI_DUNG> query = from s in dbContext.LOAI_NGUOI_DUNGs where s.Loai_ND == loai select s;
            return query.FirstOrDefault().ID_Loai_Nguoi_Dung;
        }
        public string LayLoai_ND(int ID)
        {
            IEnumerable<LOAI_NGUOI_DUNG> query = from s in dbContext.LOAI_NGUOI_DUNGs where s.ID_Loai_Nguoi_Dung == ID select s;
            return query.FirstOrDefault().Loai_ND;
        }
        public void Sua(PHAN_QUYEN entity)
        {
            PHAN_QUYEN temp = dbContext.PHAN_QUYENs.Single<PHAN_QUYEN>(x => x.ID_PQ == entity.ID_PQ);
            temp.ID_Loai_ND = entity.ID_Loai_ND;
            temp.ViewKhuyenMai = entity.ViewKhuyenMai;
            temp.ViewDanhMucMon = entity.ViewDanhMucMon;
            temp.ViewDanhMucBan = entity.ViewDanhMucBan;
            temp.ViewDanhMucKhuVuc = entity.ViewDanhMucKhuVuc;
            temp.ViewDanhMucNguyenLieu = entity.ViewDanhMucNguyenLieu;
            temp.ViewDanhMucNguoiDung = entity.ViewDanhMucNguoiDung;
            temp.UpdateKhuyenMai = entity.UpdateKhuyenMai;
            temp.UpdateThucDon = entity.UpdateThucDon;
            temp.UpdateBan = entity.UpdateBan;
            temp.UpdateKhuVuc = entity.UpdateKhuVuc;
            temp.UpdateNguyenLieu = entity.UpdateNguyenLieu;
            temp.UpdateNguoiDung = entity.UpdateNguoiDung;
            dbContext.SubmitChanges();
        }
    }
}
