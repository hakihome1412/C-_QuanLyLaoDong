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
            List<NhanVien> list = db.NhanViens.Where(p => p.idPhongBan == idPhongBan && p.chucVu == 1 && p.isDelete == false).ToList();
            List<eNhanVien> eList = new List<eNhanVien>();

            foreach (NhanVien item in list)
            {
                eNhanVien e = new eNhanVien(item.idNhanVien, item.tenNhanVien, item.diaChi, item.sdt, item.chucVu, item.idPhongBan,item.isDelete);
                eList.Add(e);
            }

            return eList;
        }

        public eNhanVien getNhanVienById(string id)
        {
            NhanVien a = db.NhanViens.Where(p => p.idNhanVien == id).SingleOrDefault();
            eNhanVien aa = new eNhanVien(a.idNhanVien, a.tenNhanVien, a.diaChi, a.sdt, a.chucVu, a.idPhongBan,a.isDelete);

            return aa;
        }

        public bool phanCongNhanVien(string idNhanVien,string idCongTrinh,string idCongViec, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            DanhSachCongViecCongTrinh a = db.DanhSachCongViecCongTrinhs.Where(p => p.idCongTrinh == idCongTrinh && p.idCongViec == idCongViec).SingleOrDefault();

            DanhSachPhanCong aa = db.DanhSachPhanCongs.Where(p => p.idDSCongViecCongTrinh == a.id && p.idNhanVien == idNhanVien).SingleOrDefault();

            if(aa == null)
            {
                DanhSachPhanCong aaa = new DanhSachPhanCong();
                aaa.idDSCongViecCongTrinh = a.id;
                aaa.idNhanVien = idNhanVien;
                aaa.ngayPhanCong = DateTime.Now;
                aaa.ngayBatDau = (DateTime)ngayBatDau;
                aaa.ngayKetThuc = (DateTime)ngayKetThuc;

                db.DanhSachPhanCongs.InsertOnSubmit(aaa);
                db.SubmitChanges();

                int kq = (int) ngayKetThuc.Subtract(ngayBatDau).TotalDays;
                DateTime ngayThucHienCongViec = ngayBatDau;

                for (int i = 0; i <= kq+1 ; i++)
                {
                    DanhSachChamCong bbb = new DanhSachChamCong();

                    bbb.idNhanVien = idNhanVien;
                    bbb.idPhanCong = aaa.id;
                    bbb.ngayChamcong = ngayThucHienCongViec;
                    bbb.trangThaiChamCong = 0;

                    db.DanhSachChamCongs.InsertOnSubmit(bbb);
                    db.SubmitChanges();
                    ngayThucHienCongViec = ngayThucHienCongViec.AddDays(1);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool chamCong(string idnhanvien, int idphancong, int status)
        {

            DateTime dateNow = DateTime.Now;

            DanhSachChamCong a = db.DanhSachChamCongs.Where(p => p.idNhanVien == idnhanvien && p.idPhanCong == idphancong && p.ngayChamcong == dateNow).SingleOrDefault();

            if(a != null)
            {
                a.trangThaiChamCong = status;
                db.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool xoaPhanCongCongViec(int idPhanCong, string idNhanVien)
        {
            DanhSachPhanCong a = db.DanhSachPhanCongs.Where(p => p.id == idPhanCong && p.idNhanVien == idNhanVien).SingleOrDefault();
            List<DanhSachChamCong> aa = db.DanhSachChamCongs.Where(p => p.idPhanCong == idPhanCong && p.idNhanVien == idNhanVien).ToList();

            if(a != null)
            {
                db.DanhSachPhanCongs.DeleteOnSubmit(a);
                foreach(DanhSachChamCong item in aa)
                {
                    db.DanhSachChamCongs.DeleteOnSubmit(item);
                }
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool xoaNhanVien(string id)
        {
            NhanVien a = db.NhanViens.Where(p => p.idNhanVien == id).SingleOrDefault();

            if (a != null)
            {
                a.isDelete = true;
                
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getIdNhanVienLast()
        {
            NhanVien a = db.NhanViens.ToList().LastOrDefault();
            return a.idNhanVien;
        }

        public string idTuDongTang()
        {
            string idLast = getIdNhanVienLast();
            string kq = idLast.Substring(2, 4);

            int so = Int32.Parse(kq) + 1;

            if (so < 10)
            {
                return "NV" + "000" + so.ToString();
            }
            else
            {
                if (so >= 10 && so < 100)
                {
                    return "NV" + "00" + so.ToString();
                }
                else
                {
                    if (so >= 100 && so < 1000)
                    {
                        return "NV" + "0" + so.ToString();
                    }
                    else
                    {
                        return "NV" + so.ToString();
                    }
                }
            }
        }

        public bool themNhanVien(eNhanVien a)
        {
            NhanVien aa = new NhanVien();
            aa.idNhanVien = idTuDongTang();
            aa.tenNhanVien = a.tenNhanVien;
            aa.diaChi = a.diaChi;
            aa.sdt = a.sdt;
            aa.chucVu = 1;
            aa.idPhongBan = a.idPhongBan;
            aa.isDelete = false;

            if (!db.NhanViens.Contains(aa))
            {
                db.NhanViens.InsertOnSubmit(aa);
                db.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool capNhatNhanVien(eNhanVien a)
        {
            NhanVien aa = db.NhanViens.Where(p => p.idNhanVien == a.idNhanVien).SingleOrDefault();

            if (a != null)
            {
                aa.tenNhanVien = a.tenNhanVien;
                aa.diaChi = a.diaChi;
                aa.sdt = a.sdt;

                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public int checkChucVuCongViec(string id)
        {
            NhanVien a = db.NhanViens.Where(p => p.idNhanVien == id).SingleOrDefault();

            PhongBan b = db.PhongBans.Where(p => p.idPhongBan == a.idPhongBan).SingleOrDefault();

            if(a.chucVu == 0) // là quản lý
            {
                if(b.tenPhongBan == "Dự án")
                {
                    return 0; // là quản lý phòng dự án
                }
                else
                {
                    return 1; // là quản lý của các phòng còn lại
                }
            }
            else // là nhân viên
            {
                if (b.tenPhongBan == "Dự án")
                {
                    return 2; // là nhân viên phòng dự án
                }
                else
                {
                    return 3; // là nhân viên của các phòng còn lại
                }
            }
        }
    }
}
