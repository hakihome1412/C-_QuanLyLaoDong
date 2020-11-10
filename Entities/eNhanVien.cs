﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eNhanVien
    {
        public String idNhanVien { get; set; }
        public String tenNhanVien { get; set; }
        public String diaChi { get; set; }
        public String sdt { get; set; }
        public int chucVu { get; set; }
        public String idPhongBan { get; set; }

        public eNhanVien(String IdNhanVien,String TenNhanVien,String DiaChi,String Sdt, int ChucVu,String IdPhongBan)
        {
            idNhanVien = IdNhanVien;
            tenNhanVien = TenNhanVien;
            diaChi = DiaChi;
            sdt = Sdt;
            chucVu = ChucVu;
            idPhongBan = IdPhongBan;
        }

        public eNhanVien()
        {

        }

    }
}