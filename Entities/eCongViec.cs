using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eCongViec
    {
        public String idCongViec { get; set; }
        public String tenCongViec { get; set; }
        public bool isDelete { get; set; }

        //Trường thuộc tính để hỗ trợ cho việc show dữ liệu cho người dùng
        public String tenCongTrinh { get; set; }
        public int stt { get; set; }
        public int idPhanCong { get; set; }
        public int idChamCong { get; set; }
        public int soNguoiThucHienCongViec { get; set; }
        public String ngayBatDau { get; set; }
        public String ngayKetThuc { get; set; }
        public String ngayPhanCong { get; set; }

        public String trangThaiChamCong { get; set; }

        public eCongViec(String IdCongViec, String TenCongViec, bool IsDelete)
        {
            idCongViec = IdCongViec;
            tenCongViec = TenCongViec;
            isDelete = IsDelete;
        }

        public eCongViec(String IdCongViec, String TenCongViec)
        {
            idCongViec = IdCongViec;
            tenCongViec = TenCongViec;
        }

        public eCongViec(String IdCongViec, String TenCongViec, int SoNguoiThucHienCongViec)
        {
            idCongViec = IdCongViec;
            tenCongViec = TenCongViec;
            soNguoiThucHienCongViec = SoNguoiThucHienCongViec;
        }



        public eCongViec(int IdPhanCong, String TenCongViec,string TenCongTrinh, int Stt, String NgayBatDau, String NgayKetThuc)
        {
            idPhanCong = IdPhanCong;
            tenCongViec = TenCongViec;
            tenCongTrinh = TenCongTrinh;
            stt = Stt;
            ngayBatDau = NgayBatDau;
            ngayKetThuc = NgayKetThuc;
        }

        public eCongViec(int IdChamCong, int IdPhanCong, String TenCongViec, string TenCongTrinh, int Stt, String NgayPhanCong, String NgayBatDau, String NgayKetThuc, String TrangThaiChamCong)
        {
            idChamCong = IdChamCong;
            idPhanCong = IdPhanCong;
            tenCongViec = TenCongViec;
            tenCongTrinh = TenCongTrinh;
            stt = Stt;
            ngayPhanCong = NgayPhanCong;
            ngayBatDau = NgayBatDau;
            ngayKetThuc = NgayKetThuc;
            trangThaiChamCong = TrangThaiChamCong;
        }

        public eCongViec(String TenCongViec)
        {
            tenCongViec = TenCongViec;
        }

        public eCongViec()
        {

        }
    }
}
