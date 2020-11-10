using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class NhanVienBLL
    {
        QLLaoDongDataContext db;

        public NhanVienBLL()
        {
            db = new QLLaoDongDataContext();
        }

        public List<eNhanVien> getNhanVienByIdPhongBan(string idPhongBan)
        {
            List<NhanVien> list = db.NhanViens.Where(p => p.idPhongBan == idPhongBan && p.chucVu == 1).ToList();
            List<eNhanVien> eList = new List<eNhanVien>();

            foreach (NhanVien item in list)
            {
                eNhanVien e = new eNhanVien(item.idNhanVien, item.tenNhanVien, item.diaChi, item.sdt, item.chucVu, item.idPhongBan);
                eList.Add(e);
            }

            return eList;
        }


        // CHỨC NĂNG DÀNH CHO QUẢN LÝ
        public bool phanCongNhanVien(string idNhanVien,string idCongTrinh,string idCongViec)
        {
            DanhSachCongViecCongTrinh a = db.DanhSachCongViecCongTrinhs.Where(p => p.idCongTrinh == idCongTrinh && p.idCongViec == idCongViec).SingleOrDefault();

            DanhSachPhanCong aa = db.DanhSachPhanCongs.Where(p => p.idDSCongViecCongTrinh == a.id && p.idNhanVien == idNhanVien).SingleOrDefault();

            if(aa == null)
            {
                DanhSachPhanCong aaa = new DanhSachPhanCong();
                aaa.idDSCongViecCongTrinh = a.id;
                aaa.idNhanVien = idNhanVien;

                db.DanhSachPhanCongs.InsertOnSubmit(aaa);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool xoaPhanCongCongViec(int idPhanCong)
        {
            DanhSachPhanCong a = db.DanhSachPhanCongs.Where(p => p.id == idPhanCong).SingleOrDefault();

            if(a != null)
            {
                db.DanhSachPhanCongs.DeleteOnSubmit(a);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
