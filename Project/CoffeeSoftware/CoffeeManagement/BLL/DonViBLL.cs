using CoffeeManagement.DAL;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeManagement.BLL
{
    public class DonViBLL
    {
        CoffeeDBDataContext dbContext = new CoffeeDBDataContext();

        public IEnumerable<DON_VI> LayDanhSachDonVi()
        {
            IEnumerable<DON_VI> query = from dv in dbContext.DON_VIs select dv;
            return query;
        }

        public void ThemDonViMoi(string _tenDonVi)
        {
            DON_VI dv = new DON_VI();
            dv.Ten_Don_Vi = _tenDonVi;
            dbContext.DON_VIs.InsertOnSubmit(dv);
            dbContext.SubmitChanges();
        }

        public bool KiemTraTenDonViTonTai(string _tenDonVi, int id=-1)
        {
            IEnumerable<DON_VI> query = from dv in dbContext.DON_VIs where dv.Ten_Don_Vi == _tenDonVi select dv;
            if (0 < query.Count() && query.Count() <= 2)
            {
                if (id != -1)
                {
                    query = query.Where(m => m.ID_Don_Vi == id);
                    if (query.Count() == 1)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public void CapNhatDonVi(DON_VI dv)
        {
            DON_VI _khuVuc = dbContext.DON_VIs.Single<DON_VI>(x => x.ID_Don_Vi == dv.ID_Don_Vi);
            _khuVuc.Ten_Don_Vi = dv.Ten_Don_Vi;
            // update 
            dbContext.SubmitChanges();
        }

        public void XoaDonVi(int _khuVucID)
        {
            DON_VI _khuVuc = dbContext.DON_VIs.Single<DON_VI>(x => x.ID_Don_Vi == _khuVucID);
            dbContext.DON_VIs.DeleteOnSubmit(_khuVuc);

            dbContext.SubmitChanges();
        }
    }
}
