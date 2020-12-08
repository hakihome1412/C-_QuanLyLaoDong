using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;
using Entities;
using System.Text.RegularExpressions;

namespace UI
{
    public partial class Form_ThongTinCaNhan : DevExpress.XtraEditors.XtraForm
    {

        NhanVienBLL nvBLL;
        PhongBanBLL pbBLL;

        public Form_ThongTinCaNhan()
        {
            InitializeComponent();

            nvBLL = new NhanVienBLL();
            pbBLL = new PhongBanBLL();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_ThongTinCaNhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_ThongTinCaNhan = true;
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            loadDataNhanVien();
        }

        private void loadDataNhanVien()
        {
            eNhanVien a = nvBLL.getNhanVienById(Form_Main.idNhanVienDangNhap);
            ePhongBan aa = pbBLL.getPhongBanById(a.idPhongBan);

            tbMaNV.Text = a.idNhanVien;
            tbTenNV.Text = a.tenNhanVien;
            tbDiaChi.Text = a.diaChi;
            tbSDT.Text = a.sdt;
            tbPhongBan.Text = aa.tenPhongBan;
            if(a.chucVu == 0)
            {
                tbChucVu.Text = "Quản lý";
            }
            else
            {
                tbChucVu.Text = "Nhân viên";
            }

            
        }

        public void enableOptions(bool e)
        {
            tbTenNV.Enabled = tbDiaChi.Enabled = tbSDT.Enabled = btnLuu.Enabled = e;
            btnSua.Enabled = !e;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableOptions(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(tbTenNV.Text.Trim().Length == 0 || tbSDT.Text.Trim().Length == 0 || tbDiaChi.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if (!Regex.IsMatch(tbSDT.Text, "0([1-9]){9}"))
                {
                    XtraMessageBox.Show("Số điện thoại không hợp lệ!");
                }
                else
                {
                    eNhanVien a = new eNhanVien(Form_Main.idNhanVienDangNhap, tbTenNV.Text, tbDiaChi.Text, tbSDT.Text, true);
                    bool kq = nvBLL.capNhatNhanVien(a);

                    if (kq)
                    {
                        XtraMessageBox.Show("Cập nhật thông tin thành công");

                    }
                    else
                    {
                        XtraMessageBox.Show("Cập nhật thông tin thất bại !!!");
                    }
                    enableOptions(false);
                    loadDataNhanVien();
                }
            }
          
        }

        private void Form_ThongTinCaNhan_Activated(object sender, EventArgs e)
        {
            loadDataNhanVien();
        }
    }
}