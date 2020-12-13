using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class CongViecBLL
    {
        QLLaoDongDataContext db;

        public CongViecBLL()
        {
            db = new QLLaoDongDataContext();
        }

        public List<eCongViec> getAllCongViec()
        {
            List<CongViec> list = db.CongViecs.Where(p => p.isDelete == false).ToList();
            List<eCongViec> eList = new List<eCongViec>();

            foreach (CongViec item in list)
            {
                eCongViec e = new eCongViec(item.idCongViec, item.tenCongViec, (bool)item.isDelete);
                eList.Add(e);
            }

            return eList;
        }

        public List<eCongViec> getCongViecByIdCongTrinh(string idCongTrinh)
        {
            List<eCongViec> eList = new List<eCongViec>();

            var query = (from a in db.CongViecs
                         join b in db.DanhSachCongViecCongTrinhs on a.idCongViec equals b.idCongViec
                         where b.idCongTrinh == idCongTrinh
                         select a).ToList();

            foreach(var item in query)
            {
                eCongViec e = new eCongViec(item.idCongViec, item.tenCongViec,(bool) item.isDelete);
                eList.Add(e);
            }

            return eList;
        }


        public List<eCongViec> getCongViecByIdNhanVien(string idNhanVien)
        {
            List<eCongViec> eList = new List<eCongViec>();

            var query = (from a in db.NhanViens
                         join b in db.DanhSachPhanCongs on a.idNhanVien equals b.idNhanVien
                         join c in db.DanhSachCongViecCongTrinhs on b.idDSCongViecCongTrinh equals c.id
                         join d in db.CongViecs on c.idCongViec equals d.idCongViec
                         join e in db.CongTrinhs on c.idCongTrinh equals e.idCongTrinh
                         where a.idNhanVien == idNhanVien && d.isDelete == false && e.isDelete == false
                         select new { b.id, d.tenCongViec, e.tenCongTrinh, b.ngayBatDau, b.ngayKetThuc }).ToList();

            int i = 1;
            foreach (var item in query)
            {
                eCongViec e = new eCongViec(item.id, item.tenCongViec, item.tenCongTrinh, i++, item.ngayBatDau.ToString("dd/MM/yyyy"), item.ngayKetThuc.ToString("dd/MM/yyyy"));
                eList.Add(e);
            }

            return eList;
        }

        public List<eCongViec> getCongViecByIdNhanVien_ChamCong(string idNhanVien)
        {
            List<eCongViec> eList = new List<eCongViec>();
            DateTime dateNow = DateTime.Now;
            List<DanhSachChamCong> abc = db.DanhSachChamCongs.Where(p => p.idNhanVien == idNhanVien && p.ngayChamcong == dateNow).ToList();
            
            var query = (from a in db.NhanViens
                         join f in db.DanhSachChamCongs on a.idNhanVien equals f.idNhanVien
                         join b in db.DanhSachPhanCongs on f.idNhanVien equals b.idNhanVien
                         join c in db.DanhSachCongViecCongTrinhs on b.idDSCongViecCongTrinh equals c.id
                         join d in db.CongViecs on c.idCongViec equals d.idCongViec
                         join e in db.CongTrinhs on c.idCongTrinh equals e.idCongTrinh
                         where a.idNhanVien == idNhanVien && d.isDelete == false && e.isDelete == false && dateNow >= b.ngayBatDau && dateNow <= b.ngayKetThuc && f.ngayChamcong == dateNow
                         select new { f.idChamCong, b.id, d.tenCongViec, e.tenCongTrinh, b.ngayPhanCong, b.ngayBatDau, b.ngayKetThuc, f.trangThaiChamCong }).ToList();     

            int i = 1;
            int temp = 1;
            foreach (var item in query)
            {
                if(temp <= abc.Count)
                {
                    if(temp == 1)
                    {
                        string trangthai = "Chưa Chấm";

                        if (item.trangThaiChamCong == 1)
                        {
                            trangthai = "Có Mặt";
                        }
                        else
                        {

                            if (item.trangThaiChamCong == 2)
                            {
                                trangthai = "Vắng Mặt";
                            }
                        }

                        eCongViec e = new eCongViec(item.idChamCong, item.id, item.tenCongViec, item.tenCongTrinh, i++, item.ngayPhanCong.ToString("dd/MM/yyyy"), item.ngayBatDau.ToString("dd/MM/yyyy"), item.ngayKetThuc.ToString("dd/MM/yyyy"), trangthai);
                        eList.Add(e);
                    }               
                }
                else
                {
                    temp = 0;
                }
                temp++;
            }

            return eList;
        }

        public bool themCongViecVaoCongTrinh(string idCongViec,string idCongTrinh)
        {
            DanhSachCongViecCongTrinh a = db.DanhSachCongViecCongTrinhs.Where(p => p.idCongViec == idCongViec && p.idCongTrinh == idCongTrinh).SingleOrDefault();

            if (a == null)
            {
                DanhSachCongViecCongTrinh aa = new DanhSachCongViecCongTrinh();
                aa.idCongTrinh = idCongTrinh;
                aa.idCongViec = idCongViec;

                db.DanhSachCongViecCongTrinhs.InsertOnSubmit(aa);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool xoaCongViecKhoiCongTrinh(string idCongViec, string idCongTrinh)
        {
            DanhSachCongViecCongTrinh a = db.DanhSachCongViecCongTrinhs.Where(p => p.idCongViec == idCongViec && p.idCongTrinh == idCongTrinh).SingleOrDefault();

            if (a != null)
            {
                db.DanhSachCongViecCongTrinhs.DeleteOnSubmit(a);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getIdCongViecFirst()
        {
            CongViec a = db.CongViecs.ToList().FirstOrDefault();
            return a.idCongViec;
        }

        public string getIdCongViecLast()
        {
            CongViec a = db.CongViecs.ToList().LastOrDefault();
            return a.idCongViec;
        }

        public string idTuDongTang()
        {
            string idLast = getIdCongViecLast();
            string kq = idLast.Substring(2, 4);

            int so = Int32.Parse(kq) + 1;

            if (so < 10)
            {
                return "CV" + "000" + so.ToString();
            }
            else
            {
                if (so >= 10 && so < 100)
                {
                    return "CV" + "00" + so.ToString();
                }
                else
                {
                    if (so >= 100 && so < 1000)
                    {
                        return "CV" + "0" + so.ToString();
                    }
                    else
                    {
                        return "CV" + so.ToString();
                    }
                }
            }
        }

        public bool themCongViec(eCongViec a)
        {
            CongViec aa = new CongViec();
            aa.idCongViec = idTuDongTang();
            aa.idCongViec = a.tenCongViec;
            aa.isDelete = false;

            if (!db.CongViecs.Contains(aa))
            {
                db.CongViecs.InsertOnSubmit(aa);
                db.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool xoaCongViec(string idCongViec)
        {
            CongViec a = db.CongViecs.Where(p => p.idCongViec == idCongViec).SingleOrDefault();

            List<DanhSachCongViecCongTrinh> list = db.DanhSachCongViecCongTrinhs.Where(p => p.idCongViec == idCongViec).ToList();

            if (a != null)
            {
                a.isDelete = true;

                foreach(DanhSachCongViecCongTrinh item in list)
                {
                    db.DanhSachCongViecCongTrinhs.DeleteOnSubmit(item);
                }

                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool capNhatCongViec(eCongViec a)
        {
            CongViec aa = db.CongViecs.Where(p => p.idCongViec == a.idCongViec).SingleOrDefault();

            if (a != null)
            {
                aa.tenCongViec = a.tenCongViec;

                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public int soNguoiThucHienCongViec(string idCongViec,string idCongTrinh)
        {
            DanhSachCongViecCongTrinh a = db.DanhSachCongViecCongTrinhs.Where(p => p.idCongViec == idCongViec && p.idCongTrinh == idCongTrinh).SingleOrDefault();

            if(a == null)
            {
                return -1;
            }

            List<DanhSachPhanCong> list = db.DanhSachPhanCongs.Where(p => p.idDSCongViecCongTrinh == a.id).ToList();

            return list.Count;
        }
    }
}
