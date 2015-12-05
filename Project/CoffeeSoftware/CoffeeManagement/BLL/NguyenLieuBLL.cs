using CoffeeManagement.DAL;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeManagement.BLL
{
    public class NguyenLieuBLL
    {
        CoffeeDBDataContext dbContext = new CoffeeDBDataContext();

        public IEnumerable<NGUYEN_LIEU> LayDanhSachNguyenLieu()
        {
            IEnumerable<NGUYEN_LIEU> query = from nl in dbContext.NGUYEN_LIEUs select nl;
            return query;
        }

        public void ThemNguyenLieuMoi(string _maNguyenLieu,string _tenNguyenLieu, int id_DonVi)
        {
            NGUYEN_LIEU nl = new NGUYEN_LIEU();
            nl.Ten_Nguyen_Lieu = _tenNguyenLieu;
            nl.So_Luong_Ton = 0;
            nl.Ma_Nguyen_Lieu = _maNguyenLieu;
            nl.DON_VI = dbContext.DON_VIs.Single<DON_VI>(dv => dv.ID_Don_Vi == id_DonVi);
            dbContext.NGUYEN_LIEUs.InsertOnSubmit(nl);
            dbContext.SubmitChanges();
        }

        public bool KiemTraNguyenLieuTonTai(string _maNguyenLieu, int id = -1)
        {
            IEnumerable<NGUYEN_LIEU> query = from nl in dbContext.NGUYEN_LIEUs where nl.Ma_Nguyen_Lieu == _maNguyenLieu select nl;
            if (0 < query.Count() && query.Count() <= 2)
            {
                if (id != -1)
                {
                    query = query.Where(m => m.ID_Nguyen_Lieu == id);
                    if (query.Count() == 1)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public void CapNhatNguyenLieu(NGUYEN_LIEU nl)
        {
            NGUYEN_LIEU _NguyenLieu = dbContext.NGUYEN_LIEUs.Single<NGUYEN_LIEU>(x => x.ID_Nguyen_Lieu == nl.ID_Nguyen_Lieu);
            _NguyenLieu.Ten_Nguyen_Lieu = nl.Ten_Nguyen_Lieu;
            _NguyenLieu.So_Luong_Ton = nl.So_Luong_Ton;
            _NguyenLieu.Ma_Nguyen_Lieu = nl.Ma_Nguyen_Lieu;
            _NguyenLieu.DON_VI = dbContext.DON_VIs.Single<DON_VI>(dv => dv.ID_Don_Vi == nl.ID_Don_Vi);
            // update 
            dbContext.SubmitChanges();
        }

        public void XoaNguyenLieu(int _NguyenLieuID)
        {
            NGUYEN_LIEU _NguyenLieu = dbContext.NGUYEN_LIEUs.Single<NGUYEN_LIEU>(x => x.ID_Nguyen_Lieu == _NguyenLieuID);
            dbContext.NGUYEN_LIEUs.DeleteOnSubmit(_NguyenLieu);

            dbContext.SubmitChanges();
        }
    }
}
