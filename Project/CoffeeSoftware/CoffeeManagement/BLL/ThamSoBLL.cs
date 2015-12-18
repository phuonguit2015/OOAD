using CoffeeManagement.DAL;
using System.Linq;

namespace CoffeeManagement.BLL
{
    public class ThamSoBLL
    {
        CoffeeDBDataContext dbContext = new CoffeeDBDataContext();
        public double? LaySoPhieuNhap()
        {
            var thamSo = dbContext.THAM_SOs.FirstOrDefault();
            if(thamSo != null)
            {
                return thamSo.So_Phieu_Nhap;
            }
            return -1;
        }

        public void CapNhatSoPhieuNhap(double soPhieu)
        {
            var thamSo = dbContext.THAM_SOs.FirstOrDefault();
            thamSo.So_Phieu_Nhap = soPhieu;

            dbContext.SubmitChanges();
        }
    }
}
