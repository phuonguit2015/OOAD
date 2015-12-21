using CoffeeManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeManagement.BLL
{
    class KhuyenMaiBLL
    {
        CoffeeDBDataContext dbContext = new CoffeeDBDataContext();

        public IEnumerable<KHUYENMAI> LayDanhSachKM()
        {
            IEnumerable<KHUYENMAI> query = from km in dbContext.KHUYENMAIs select km;
            return query;
        }
        public IEnumerable<CHITIETKHUYENMAI> LayDanhSachCode(int IDKM)
        {
            IEnumerable<CHITIETKHUYENMAI> query = from km in dbContext.CHITIETKHUYENMAIs where km.ID_KhuyenMai==IDKM select km;
            return query;
        }
        public void ThemKMMoi(KHUYENMAI _km)
        {
            dbContext.KHUYENMAIs.InsertOnSubmit(_km);
            dbContext.SubmitChanges();
            ThemCTKMMoi(_km.ID_KM, _km.So_Luong);
        }
        private void ThemCTKMMoi(int _KMID,int? soluong)
        {           
            List<CHITIETKHUYENMAI> list = new List<CHITIETKHUYENMAI>();
            for(int i=0; i< soluong;i++)
            {
                CHITIETKHUYENMAI ctkm = new CHITIETKHUYENMAI();
                ctkm.Code = RandomString();
                ctkm.Trang_Thai = 0;
                ctkm.ID_KhuyenMai = _KMID;
                list.Add(ctkm);
            }
            dbContext.CHITIETKHUYENMAIs.InsertAllOnSubmit(list);
            dbContext.SubmitChanges();
        }
        private string RandomString()
        {
            StringBuilder sb = new StringBuilder();
            char c;
            Random rand = new Random();
            for (int i = 0; i < 9; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(48, 90)));
                if (c < 58 || c > 64)
                    sb.Append(c);
            }

            return sb.ToString();
        }

        public void CapNhatKM(KHUYENMAI km)
        {
            KHUYENMAI _km = dbContext.KHUYENMAIs.Single<KHUYENMAI>(x => x.ID_KM == km.ID_KM);
            _km.Chuong_Trinh_KM = km.Chuong_Trinh_KM;
            _km.Loai_KM = km.Loai_KM;
            _km.Gia_Tri = km.Gia_Tri;
            _km.Ngay_Bat_Dau = km.Ngay_Bat_Dau;
            _km.Ngay_Het_Han = km.Ngay_Het_Han;
            if (_km.So_Luong > km.So_Luong)
                for (int i = 1; i <= _km.So_Luong - km.So_Luong; i++)
                {
                    XoaDongCuoiCTKM(km.ID_KM);
                }
            else
                if (_km.So_Luong < km.So_Luong)
                    ThemCTKMMoi(km.ID_KM, km.So_Luong - _km.So_Luong);
                    
            _km.So_Luong = km.So_Luong;
            // update 
            dbContext.SubmitChanges();
        }
        private void XoaDongCuoiCTKM(int _KMID)
        {
            var ctkm = (from c in dbContext.CHITIETKHUYENMAIs where c.ID_KhuyenMai == _KMID orderby c.ID_CTKM descending select c).First();
            dbContext.CHITIETKHUYENMAIs.DeleteOnSubmit(ctkm);
            dbContext.SubmitChanges();
        }
        public void XoaKM(int _KMID)
        {
            var ctkm = from c in dbContext.CHITIETKHUYENMAIs where c.ID_KhuyenMai == _KMID select c;
            dbContext.CHITIETKHUYENMAIs.DeleteAllOnSubmit(ctkm.ToList());
            dbContext.SubmitChanges();

           KHUYENMAI _km = dbContext.KHUYENMAIs.Single<KHUYENMAI>(x => x.ID_KM == _KMID);
            dbContext.KHUYENMAIs.DeleteOnSubmit(_km);
            dbContext.SubmitChanges();
        }


        /// <summary>
        /// Tình trạng bàn: 0: Bàn trống, 1: Bàn đang sử dụng, -1: Bàn chưa dọn
        /// </summary>
        public void CapNhatTinhTrangBan(int tinhtrang, int id)
        {
            BAN _ban = dbContext.BANs.Single<BAN>(x => x.ID_Ban == id);
            _ban.Trang_Thai = tinhtrang;

            dbContext.SubmitChanges();
        }
    }
}
