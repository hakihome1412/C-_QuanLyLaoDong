using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class AuthBLL
    {
        QLLaoDongDataContext db;

        public AuthBLL()
        {
            db = new QLLaoDongDataContext();
        }

        public int XuLyDangNhap(string tenTK,string matKhau)
        {
            TaiKhoan tk = db.TaiKhoans.Where(a => a.idTaiKhoan == tenTK).SingleOrDefault();

            if(tk == null)
            {
                return 0; //tài khoản không tồn tại
            }
            else
            {
                if(tk.matKhau != matKhau)
                {
                    return 1; // mật khẩu không chính xác
                }
                else
                {
                    return 2; // tài khoản hợp lệ
                }
            }
        }

        public int doiMatKhau(string passOld, string passNew, string verify, string idNhanVien)
        {
            if(passOld.Trim().Length == 0 || passNew.Trim().Length == 0 || verify.Trim().Length == 0)
            {
                return 0; // chưa điền đầy đủ field
            }
            else
            {
                if(passNew != verify)
                {
                    return 1; // mật khẩu mới và xác nhận không trùng khớp
                }
                else
                {
                    TaiKhoan a = db.TaiKhoans.Where(p => p.idTaiKhoan == idNhanVien).SingleOrDefault();

                    if(a.matKhau != passOld)
                    {
                        return 2; // mật khẩu cũ không đúng
                    }
                    else
                    {
                        a.matKhau = passNew;
                        db.SubmitChanges();
                        return 3; // thành công
                    }
                }
            }
        }

    }
}
