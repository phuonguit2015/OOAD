using CoffeeManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.BLL
{
    class HoaDonBLL
    {
        CoffeeDBDataContext dbContext = new CoffeeDBDataContext();

        public IEnumerable<HOA_DON> LayDanhSachHoaDon()
        {
            IEnumerable<HOA_DON> query = from b in dbContext.HOA_DONs select b;
            return query;
        }

        // Lấy IDHoaDơn theo bàn chưa được thanh toán
        // Trang Thái Thanh Toán =  1 là chưa thanh toán, 0 là đã thanh toán
        public int LayIDHoaDonTheoBan(int? idBan)
        {
            return dbContext.HOA_DONs.Single<HOA_DON>(x => x.ID_Ban == idBan && x.Trang_Thai_Thanh_Toan == 1).ID_Hoa_Don;
        }

        public HOA_DON LayHoaDonTheoID(int idHoaDon)
        {
            return dbContext.HOA_DONs.Single<HOA_DON>(x => x.ID_Hoa_Don == idHoaDon);
        }
        // Lấy chi tiết hóa đơn
        public List<CHI_TIET_HOA_DON> LayChiTietHoaDonTheoIDHoaDon(int idHoaDon)
        {
            List<CHI_TIET_HOA_DON> l = new List<CHI_TIET_HOA_DON>();
            IEnumerable<CHI_TIET_HOA_DON> query = from cthd in dbContext.CHI_TIET_HOA_DONs
                                                  where cthd.ID_Hoa_Don == idHoaDon
                                                     select cthd;
            l = query.ToList();
            return l;
        }
        public int ThemHoaDonMoi(HOA_DON hoadon)
        {
            dbContext.HOA_DONs.InsertOnSubmit(hoadon);
            dbContext.SubmitChanges();
            return hoadon.ID_Hoa_Don;
        }

        // Thêm chi tiết hóa đơn

        public void ThemDanhSachChiTietHoaDon(List<CHI_TIET_HOA_DON> l, int idHoaDon)
        {            
            // Kiểm tra trong CSDL có CTHD của HD chưa? Nếu có xóa tất cả các chi tiết hóa đơn đó.
            XoaChiTietHoaDonTheoIDHoaDon(idHoaDon);

            foreach (var ct in l)
            {
                dbContext.CHI_TIET_HOA_DONs.InsertOnSubmit(ct);             
            }
            dbContext.SubmitChanges();
        }

        public void ThemChiTietHoaDon(CHI_TIET_HOA_DON ct)
        {
            dbContext.CHI_TIET_HOA_DONs.InsertOnSubmit(ct);
            dbContext.SubmitChanges();
        }
        public void CapNhatHoaDon(HOA_DON b)
        {
            HOA_DON hoadon = dbContext.HOA_DONs.Single<HOA_DON>(x => x.ID_Hoa_Don == b.ID_Hoa_Don);
            hoadon.Tien_Khach_Dua = b.Tien_Khach_Dua;
            hoadon.Tien_Tra_Lai = b.Tien_Tra_Lai;
            hoadon.Tong_Thanh_Toan = b.Tong_Thanh_Toan;
            hoadon.Tong_Tien = b.Tong_Tien;
            hoadon.VAT = b.VAT;           

            // update 
            dbContext.SubmitChanges();
        }
        // cẬp nhật trạng thái thanh toán của hóa đơn
        public void CapNhatTrangThaiThanhToanHD(int trangThai, int idHoaDon)
        {
            HOA_DON hoadon = dbContext.HOA_DONs.Single<HOA_DON>(x => x.ID_Hoa_Don == idHoaDon);
            hoadon.Trang_Thai_Thanh_Toan = trangThai;
            dbContext.SubmitChanges();


        }
        public void XoaHoaDon(int _Hoa_DonID)
        {
            HOA_DON _Hoa_Don = dbContext.HOA_DONs.Single<HOA_DON>(x => x.ID_Hoa_Don == _Hoa_DonID);
            dbContext.HOA_DONs.DeleteOnSubmit(_Hoa_Don);

            dbContext.SubmitChanges();
        }
        public void XoaChiTietHoaDonTheoIDHoaDon(int idHoaDon)
        {
            List<CHI_TIET_HOA_DON> l = LayChiTietHoaDonTheoIDHoaDon(idHoaDon);
            foreach (var item in l)
            {
                dbContext.CHI_TIET_HOA_DONs.DeleteOnSubmit(item);
            }
            dbContext.SubmitChanges();
        }

        public void ChuyenBan(int idHoaDon, int idBan)
        {
            HOA_DON hoadon = dbContext.HOA_DONs.Single<HOA_DON>(x => x.ID_Hoa_Don == idHoaDon);
            hoadon.BAN = dbContext.BANs.Single<BAN>(b => b.ID_Ban == idBan);

            dbContext.SubmitChanges();
        }
    }
}
