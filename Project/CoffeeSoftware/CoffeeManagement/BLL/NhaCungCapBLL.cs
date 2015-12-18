using CoffeeManagement.DAL;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeManagement.BLL
{
    public class NhaCungCapBLL
    {
        CoffeeDBDataContext dbContext = new CoffeeDBDataContext();

        public IEnumerable<NHA_CUNG_CAP> LayDanhSachNhaCungCap()
        {
            IEnumerable<NHA_CUNG_CAP> query = from ncc in dbContext.NHA_CUNG_CAPs select ncc;
            return query;
        }
        
        public NHA_CUNG_CAP LayNhaCungCapByID(int id)
        {
            NHA_CUNG_CAP _nhaCungCap = dbContext.NHA_CUNG_CAPs.Single<NHA_CUNG_CAP>(x => x.ID_Nha_Cung_Cap == id);
            return _nhaCungCap;
        }

        public void ThemNhaCungCapMoi(NHA_CUNG_CAP ncc)
        {           
            dbContext.NHA_CUNG_CAPs.InsertOnSubmit(ncc);
            dbContext.SubmitChanges();
        }

        public bool KiemTraTenNhaCungCapTonTai(string _tenNhaCungCap, int id = -1)
        {
            IEnumerable<NHA_CUNG_CAP> query = from ncc in dbContext.NHA_CUNG_CAPs where ncc.Ten_Nha_Cung_Cap == _tenNhaCungCap select ncc;
            if (0 < query.Count() && query.Count() <= 2)
            {
                if (id != -1)
                {
                    query = query.Where(m => m.ID_Nha_Cung_Cap == id);
                    if (query.Count() == 1)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public void CapNhatNhaCungCap(NHA_CUNG_CAP ncc)
        {
            NHA_CUNG_CAP _nhaCungCap = dbContext.NHA_CUNG_CAPs.Single<NHA_CUNG_CAP>(x => x.ID_Nha_Cung_Cap == ncc.ID_Nha_Cung_Cap);
            _nhaCungCap.Ten_Nha_Cung_Cap = ncc.Ten_Nha_Cung_Cap;
            _nhaCungCap.Dia_Chi = ncc.Dia_Chi;
            _nhaCungCap.So_Dien_Thoai = ncc.So_Dien_Thoai;
            // update 
            dbContext.SubmitChanges();
        }

        public void XoaNhaCungCap(int _nhaCungCapID)
        {
            NHA_CUNG_CAP _nhaCungCap = dbContext.NHA_CUNG_CAPs.Single<NHA_CUNG_CAP>(x => x.ID_Nha_Cung_Cap == _nhaCungCapID);
            dbContext.NHA_CUNG_CAPs.DeleteOnSubmit(_nhaCungCap);

            dbContext.SubmitChanges();
        }
    }
}
