﻿using CoffeeManagement.DAL;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeManagement.BLL
{
    public class BanBLL
    {
        CoffeeDBDataContext dbContext = new CoffeeDBDataContext();

        public IEnumerable<BAN> LayDanhSachBan()
        {
            IEnumerable<BAN> query = from b in dbContext.BANs select b;
            return query;
        }
        
        public string LayKhuVucTheoIDBan(int idBan)
        {
            var b = dbContext.BANs.Single<BAN>(x => x.ID_Ban == idBan);
            return dbContext.KHU_VUCs.Single<KHU_VUC>(k => k.ID_Khu_Vuc == b.ID_Khu_Vuc).Ten_Khu_Vuc;
        }

        public int LayIDTheoBan(string tenBan)
        {
            BAN _ban = dbContext.BANs.Single<BAN>(x => x.Ten_Ban == tenBan);
            if (_ban != null)
                return _ban.ID_Ban;
            else
                return -1;
        }       
        public void ThemBanMoi(BAN _ban)
        {            
            dbContext.BANs.InsertOnSubmit(_ban);
            dbContext.SubmitChanges();
        }

        public bool KiemTraTenBanTonTai(string _tenBan, int id = -1)
        {
            IEnumerable<BAN> query = from b in dbContext.BANs where b.Ten_Ban == _tenBan
                                     select b;
            if (0 < query.Count() && query.Count() <= 2)
            {
                if (id != -1)
                {
                    query = query.Where(m => m.ID_Ban == id);
                    if (query.Count() == 1)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public void CapNhatBan(BAN b)
        {
            BAN _ban = dbContext.BANs.Single<BAN>(x => x.ID_Ban == b.ID_Ban);
            _ban.Ten_Ban = b.Ten_Ban;           
            _ban.KHU_VUC = dbContext.KHU_VUCs.Single<KHU_VUC>(kv => kv.ID_Khu_Vuc == b.ID_Khu_Vuc);
            // update 
            dbContext.SubmitChanges();
        }

        public void XoaBan(int _BanID)
        {
            BAN _Ban = dbContext.BANs.Single<BAN>(x => x.ID_Ban == _BanID);
            dbContext.BANs.DeleteOnSubmit(_Ban);

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
