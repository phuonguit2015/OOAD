using CoffeeManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.BLL
{
    class NhapHangBLL
    {
        CoffeeDBDataContext dbContext = new CoffeeDBDataContext();

        // Kiểm tra mã phiếu nhập có tồn tại hay chưa?
        public bool TonTaiMaPhieuNhap(string ma_phieu_nhap)
        {
            IEnumerable<PHIEU_NHAP> query = from p in dbContext.PHIEU_NHAPs where p.So_Phieu_Nhap == ma_phieu_nhap select p;
            if (query.Count() == 0)
                return false;
            return true;
        }

        // Lấy ID Phiếu nhập theo SoPhieuNhap
        public int LayIDPhieuNhapTheoSoPhieuNhap(string soPhieuNhap)
        {
            return dbContext.PHIEU_NHAPs.FirstOrDefault<PHIEU_NHAP>(
                pn => pn.So_Phieu_Nhap == soPhieuNhap).ID_Phieu_Nhap;
        }

        // Tạo phiếu nhập hàng
        public int ThemPhieuNhapHang(PHIEU_NHAP phieuNhap)
        {
            dbContext.PHIEU_NHAPs.InsertOnSubmit(phieuNhap);
            dbContext.SubmitChanges();

            return phieuNhap.ID_Phieu_Nhap;

        }

        // Thêm chi tiết phiếu nhập
        
       public void ThemChiTietPhieuNhap(List<CHI_TIET_PHIEU_NHAP> l, int idPhieuNhap)
        {
            NguyenLieuBLL nguyenLieuBLL = new NguyenLieuBLL();
            // Kiểm tra trong CSDL có CTPN của PN chưa? Nếu có xóa tất cả các chi tiết phiếu nhập đó.
            XoaChiTietPhieuNhapTheoIDPhieuNhap(idPhieuNhap);

            foreach(var ct in l)
            {
                dbContext.CHI_TIET_PHIEU_NHAPs.InsertOnSubmit(ct);
                // Cập nhật số lượng tồn nguyên liệu
                nguyenLieuBLL.CapNhatSoLuongTon(ct.ID_Nguyen_Lieu, ct.So_Luong);
            }
            dbContext.SubmitChanges();
        }

        // Lấy danh sách phiếu nhập
        public IEnumerable<PHIEU_NHAP> LayDanhSachPhieuNhap()
        {
            IEnumerable<PHIEU_NHAP> query = from pn in dbContext.PHIEU_NHAPs select pn;
            return query;
        }

        // Lấy chi tiết phiếu nhập
        public List<CHI_TIET_PHIEU_NHAP> LayChiTietPhieuNhapTheoIDPhieuNhap(int idPhieuNhap)
        {
            List<CHI_TIET_PHIEU_NHAP> l = new List<CHI_TIET_PHIEU_NHAP>();
            IEnumerable<CHI_TIET_PHIEU_NHAP> query = from ctpn in dbContext.CHI_TIET_PHIEU_NHAPs where ctpn.ID_Phieu_Nhap == idPhieuNhap
                                                     select ctpn;
            l = query.ToList();
            return l;
        }
        // Cập nhật thông tin phiếu nhập
        public void CapNhatPhieuNhap(PHIEU_NHAP p)
        {
            PHIEU_NHAP _pn = dbContext.PHIEU_NHAPs.Single<PHIEU_NHAP>(x => x.ID_Phieu_Nhap == p.ID_Phieu_Nhap);
            _pn.ID_NguoiDung = p.ID_NguoiDung;
            _pn.Ngay_Lap = p.Ngay_Lap;
            _pn.Tong_Tien = p.Tong_Tien;
            _pn.NHA_CUNG_CAP = dbContext.NHA_CUNG_CAPs.Single<NHA_CUNG_CAP>(ncc => ncc.ID_Nha_Cung_Cap == p.ID_NCC);
            _pn.VAT = p.VAT;
            _pn.Giam_Gia = p.Giam_Gia;
            // update 
            dbContext.SubmitChanges();          
        }
        public void XoaPhieuNhap(int idPhieuNhap)
        {
            PHIEU_NHAP _pn = dbContext.PHIEU_NHAPs.Single<PHIEU_NHAP>(x => x.ID_Phieu_Nhap == idPhieuNhap);
            XoaChiTietPhieuNhapTheoIDPhieuNhap(_pn.ID_Phieu_Nhap);      // Xóa Chi Tiêt Phiếu Nhập
            dbContext.PHIEU_NHAPs.DeleteOnSubmit(_pn);                  // Xóa phiếu nhập

            dbContext.SubmitChanges();
        }

        public void XoaChiTietPhieuNhapTheoIDPhieuNhap(int idPhieuNhap)
        {
            List<CHI_TIET_PHIEU_NHAP> l = LayChiTietPhieuNhapTheoIDPhieuNhap(idPhieuNhap);
            foreach(var item in l)
            {
                dbContext.CHI_TIET_PHIEU_NHAPs.DeleteOnSubmit(item);
            }
            dbContext.SubmitChanges();
        }

    }
}
