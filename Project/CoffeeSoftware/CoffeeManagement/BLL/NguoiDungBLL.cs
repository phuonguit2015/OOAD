using CoffeeManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeManagement.BLL
{
    class NguoiDungBLL
    {
        CoffeeDBDataContext dbContext = new CoffeeDBDataContext();

        public DataTable LayDanhSach()
        {
            var query = from t1 in dbContext.NGUOI_DUNGs
                         join t2 in dbContext.LOAI_NGUOI_DUNGs on t1.ID_LoaiND equals t2.ID_Loai_Nguoi_Dung
                         select new{ t1, t2};

            DataTable tmp = new DataTable();
            tmp.Columns.Add("ID_Nguoi_Dung");
            tmp.Columns.Add("Ten_Nguoi_Dung");
            tmp.Columns.Add("Loai_ND");
            foreach(var item in query)
            {
                DataRow dr = tmp.NewRow();

                dr["ID_Nguoi_Dung"] = item.t1.ID_Nguoi_Dung;
                dr["Ten_Nguoi_Dung"] = item.t1.Ten_Nguoi_Dung;
                dr["Loai_ND"] = item.t2.Loai_ND;
                tmp.Rows.Add(dr);
            }
            return tmp;
        }

        public IEnumerable<LOAI_NGUOI_DUNG> LayLoaiNguoiDung()
        {
            IEnumerable<LOAI_NGUOI_DUNG> query = from b in dbContext.LOAI_NGUOI_DUNGs select b;
            return query;
        }
        public int LayIDQuyen(string loai)
        {
            IEnumerable<LOAI_NGUOI_DUNG> query = from s in dbContext.LOAI_NGUOI_DUNGs where s.Loai_ND == loai select s;
            return query.FirstOrDefault().ID_Loai_Nguoi_Dung;
        }
        public void Them(NGUOI_DUNG entity)
        {
            dbContext.NGUOI_DUNGs.InsertOnSubmit(entity);
            dbContext.SubmitChanges();
        }

        public void Xoa(int id)
        {
            NGUOI_DUNG entity = dbContext.NGUOI_DUNGs.Single<NGUOI_DUNG>(x => x.ID_Nguoi_Dung == id);
            dbContext.NGUOI_DUNGs.DeleteOnSubmit(entity);
            dbContext.SubmitChanges();
        }

        public void Sua(NGUOI_DUNG entity)
        {
            NGUOI_DUNG temp = dbContext.NGUOI_DUNGs.Single<NGUOI_DUNG>(x => x.ID_Nguoi_Dung == entity.ID_Nguoi_Dung);
            temp.Ten_Nguoi_Dung = entity.Ten_Nguoi_Dung;
            temp.Mat_Khau = entity.Mat_Khau;
            temp.ID_LoaiND = entity.ID_LoaiND;
            dbContext.SubmitChanges();
        }

        public bool KiemTraTonTai(string _Ten)
        {
            IEnumerable<NGUOI_DUNG> query = from x in dbContext.NGUOI_DUNGs where x.Ten_Nguoi_Dung == _Ten select x;
            if (query.Count() == 0)
                return false;
            return true;
        }
    }
}
