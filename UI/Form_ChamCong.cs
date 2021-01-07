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
    public partial class Form_ChamCong : DevExpress.XtraEditors.XtraForm
    {
        NhanVienBLL nvBLL;
        CongViecBLL cvBLL;

        public Form_ChamCong()
        {
            InitializeComponent();
            nvBLL = new NhanVienBLL();
            cvBLL = new CongViecBLL();

            dataGridView_CongViecCuaNhanVien.AutoGenerateColumns  = dataGridView_NhanVienTrongPhongBan.AutoGenerateColumns = false;
        }

        private void loadDataCongViecCuaNhanVien()
        {
            dataGridView_CongViecCuaNhanVien.DataSource = null;
            dataGridView_CongViecCuaNhanVien.DataSource = cvBLL.getCongViecByIdNhanVien_ChamCong(dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString());
        }

        private void loadDataNhanVienTrongPhongBan()
        {
            dataGridView_NhanVienTrongPhongBan.DataSource = null;
            dataGridView_NhanVienTrongPhongBan.DataSource = nvBLL.getNhanVienByIdPhongBan(Form_Main.idPhongBan);
        }

        private void Form_ChamCong_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_ChamCong = true;
        }

        private void Form_ChamCong_Load(object sender, EventArgs e)
        {
            loadDataNhanVienTrongPhongBan();
            loadDataCongViecCuaNhanVien();
        }

        private void dataGridView_NhanVienTrongPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataCongViecCuaNhanVien();
        }

        private void btnPhanCongViec_Click(object sender, EventArgs e)
        {
            try
            {
                bool kq = nvBLL.chamCong(dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString(), (int)dataGridView_CongViecCuaNhanVien.CurrentRow.Cells[3].Value, 1);

                if (kq)
                {
                    XtraMessageBox.Show("Thao tác thành công");
                    loadDataCongViecCuaNhanVien();
                }
                else
                {
                    XtraMessageBox.Show("Thao tác thất bại !!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi");
            }
          
        }

        private void btnXoaPhanCongCongViec_Click(object sender, EventArgs e)
        {
            try
            {
                bool kq = nvBLL.chamCong(dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString(), (int)dataGridView_CongViecCuaNhanVien.CurrentRow.Cells[3].Value, 2);

                if (kq)
                {
                    XtraMessageBox.Show("Thao tác thành công");
                    loadDataCongViecCuaNhanVien();
                }
                else
                {
                    XtraMessageBox.Show("Thao tác thất bại !!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi");
            }

        }

        private void Form_ChamCong_Activated(object sender, EventArgs e)
        {
            loadDataNhanVienTrongPhongBan();
            loadDataCongViecCuaNhanVien();
        }

        private void tbTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {
            string idNV = "";
            foreach (DataGridViewRow row in dataGridView_NhanVienTrongPhongBan.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(tbTimKiemNhanVien.Text))
                {
                    row.Selected = true;
                    idNV = row.Cells[0].Value.ToString();
                }
            }

            dataGridView_CongViecCuaNhanVien.DataSource = null;
            dataGridView_CongViecCuaNhanVien.DataSource = cvBLL.getCongViecByIdNhanVien_ChamCong(idNV);
        }
    }
}