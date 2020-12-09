using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using BLL;
using Entities;

namespace UI
{
    public partial class Form_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static bool statusLogin = false;
        public static string idNhanVienDangNhap = "";
        public static string idPhongBan = "";

        public static bool f_QLCongTrinh = true;
        public static bool f_QLCongViec = true;
        public static bool f_DoiMatKhau = true;
        public static bool f_ThongTinCaNhan = true;
        public static bool f_PhanCong = true;
        public static bool f_QLNhanVien = true;
        public static bool f_ChamCong = true;
        public static bool f_BC_TatCaCongTrinh = true;
        public static bool f_BC_CongTrinhQuaHan = true;
        public static bool f_BC_CongTrinhDangThucHien = true;
        public static bool f_BC_CongTrinhDaHoanThanh = true;
        public static bool f_BC_TatCaNhanVien = true;
        public static bool f_TimKiemCongTrinh = true;
        public static bool f_TimKiemCongViec = true;

        NhanVienBLL nvBLL;
        PhongBanBLL pbBLL;

        ePhongBan aa;
        List<eNhanVien> data;

        public Form_Main()
        {
            InitializeComponent();
            nvBLL = new NhanVienBLL();
            pbBLL = new PhongBanBLL();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            int kq = nvBLL.checkChucVuCongViec(idNhanVienDangNhap);
            eNhanVien nv = nvBLL.getNhanVienById(idNhanVienDangNhap);
            idPhongBan = nv.idPhongBan;
            data = nvBLL.getNhanVienByIdPhongBan(idPhongBan);
            //MessageBox.Show(data.Count.ToString());
            aa = pbBLL.getPhongBanById(idPhongBan);

            if (kq == 1)
            {
                btn_QuanLyCongTrinh.Visibility = btn_QuanLyDanhMuc.Visibility = BarItemVisibility.Never;

            }

            if (kq == 2)
            {
                btn_QuanLyNhanVien.Visibility = BarItemVisibility.Never;
                ribbonPageGroup3.Visible = false;
            }

            if (kq == 3)
            {
                ribbonPageGroup3.Visible = ribbonPageGroup13.Visible = false;
            }
        }


        private void btn_BC_TatCa_CongTrinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_BC_TatCaCongTrinh form = new Form_BC_TatCaCongTrinh();

            if (f_BC_TatCaCongTrinh == true)
            {
                form.MdiParent = this;
                form.Show();
                f_BC_TatCaCongTrinh = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_BC_TatCaCongTrinh)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void btn_BC_CT_MuonQuaHan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_BC_CongTrinhQuaHan form = new Form_BC_CongTrinhQuaHan();

            if (f_BC_CongTrinhQuaHan == true)
            {
                form.MdiParent = this;
                form.Show();
                f_BC_CongTrinhQuaHan = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_BC_CongTrinhQuaHan)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void btn_BC_CongTrinhDangThucHien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_BC_CongTrinhDangThucHien form = new Form_BC_CongTrinhDangThucHien();

            if (f_BC_CongTrinhDangThucHien == true)
            {
                form.MdiParent = this;
                form.Show();
                f_BC_CongTrinhDangThucHien = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_BC_CongTrinhDangThucHien)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void btn_BC_CongTrinhDaHoanThanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_BC_CongTrinhDaHoanThanh form = new Form_BC_CongTrinhDaHoanThanh();

            if (f_BC_CongTrinhDaHoanThanh == true)
            {
                form.MdiParent = this;
                form.Show();
                f_BC_CongTrinhDaHoanThanh = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_BC_CongTrinhDaHoanThanh)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void btn_BC_TatCaNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_BC_TatCaNhanVien form = new Form_BC_TatCaNhanVien();

            if (f_BC_TatCaNhanVien == true)
            {
                form.MdiParent = this;
                form.PrintNhanVien(aa.tenPhongBan, data);
                form.Show();
                f_BC_TatCaNhanVien = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_BC_TatCaNhanVien)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void btn_PhanCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_PhanCong form = new Form_PhanCong();

            if (f_PhanCong == true)
            {
                form.MdiParent = this;
                form.Show();
                f_PhanCong = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_PhanCong)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void btn_ChamCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_ChamCong form = new Form_ChamCong();

            if (f_ChamCong == true)
            {
                form.MdiParent = this;
                form.Show();
                f_ChamCong = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_ChamCong)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void btn_QLNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_QLNhanVien form = new Form_QLNhanVien();

            if (f_QLNhanVien == true)
            {
                form.MdiParent = this;
                form.Show();
                f_QLNhanVien = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_QLNhanVien)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void btn_QLCongTrinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_QLCongTrinh form = new Form_QLCongTrinh();

            if (f_QLCongTrinh == true)
            {
                form.MdiParent = this;
                form.Show();
                f_QLCongTrinh = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_QLCongTrinh)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void btn_CapNhatThongTinCaNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_ThongTinCaNhan form = new Form_ThongTinCaNhan();

            if (f_ThongTinCaNhan == true)
            {
                form.MdiParent = this;
                form.Show();
                f_ThongTinCaNhan = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_ThongTinCaNhan)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void btn_QLCongViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_QLCongViec form = new Form_QLCongViec();

            if (f_QLCongViec == true)
            {
                form.MdiParent = this;
                form.Show();
                f_QLCongViec = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_QLCongViec)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void btn_DoiMatKhauu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_DoiMatKhau form = new Form_DoiMatKhau();

            if (f_DoiMatKhau == true)
            {
                form.MdiParent = this;
                form.Show();
                f_DoiMatKhau = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_DoiMatKhau)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void btn_DangXuatt_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_TimKiemCongTrinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_TimKiemCongTrinh form = new Form_TimKiemCongTrinh();

            if (f_TimKiemCongTrinh == true)
            {
                form.MdiParent = this;
                form.Show();
                f_TimKiemCongTrinh = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_TimKiemCongTrinh)
                    {
                        item.Activate();
                    }
                }
            }
        }
    }
}