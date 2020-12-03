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

namespace UI
{
    public partial class Form_DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {

        AuthBLL authBLL;

        public Form_DoiMatKhau()
        {
            InitializeComponent();
            authBLL = new AuthBLL();
        }

        private void Form_DoiMatKhau_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void Form_DoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_DoiMatKhau = true;
        }

        private void Form_DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            int kq = authBLL.doiMatKhau(tbMatKhauCu.Text, tbMatKhauMoi.Text, tbNhapLaiMK.Text, Form_Main.idNhanVienDangNhap);

            if(kq == 0)
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (kq == 1)
                {
                    XtraMessageBox.Show("Xác nhận lại mật khẩu không trùng khớp");
                }
                else
                {
                    if (kq == 2)
                    {
                        XtraMessageBox.Show("Mật khẩu cũ không hợp lệ");
                    }
                    else
                    {
                        XtraMessageBox.Show("Đổi mật khẩu thành công");
                    }
                }
            }
        }
    }
}