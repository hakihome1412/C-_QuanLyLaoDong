﻿using System;
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
    public partial class Form_PhanCong : DevExpress.XtraEditors.XtraForm
    {

        PhongBanBLL pbBLL;
        NhanVienBLL nvBLL;
        CongViecBLL cvBLL;
        CongTrinhBLL ctBLL;

        public Form_PhanCong()
        {
            InitializeComponent();

            pbBLL = new PhongBanBLL();
            nvBLL = new NhanVienBLL();
            cvBLL = new CongViecBLL();
            ctBLL = new CongTrinhBLL();

            dataGridView_CongViecCuaNhanVien.AutoGenerateColumns = dataGridView_DanhSachCongTrinh.AutoGenerateColumns = dataGridView_DanhSachCongViecCuaCongTrinh.AutoGenerateColumns = dataGridView_NhanVienTrongPhongBan.AutoGenerateColumns  = false;

            dataGridView_DanhSachCongTrinh.DataSource = ctBLL.getAllCongTrinh_DangThucHien_QuaHan();
           
        }

        private void loadDataNhanVien()
        {
            tbTenNhanVien.Text = dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[1].Value.ToString();
            tbMaNhanVien.Text = dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString();
            tbSoCongViec.Text = cvBLL.getCongViecByIdNhanVien(dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString()).Count.ToString();
        }

        private void loadDataCongViecCuaNhanVien()
        {
            dataGridView_CongViecCuaNhanVien.DataSource = null;
            dataGridView_CongViecCuaNhanVien.DataSource = cvBLL.getCongViecByIdNhanVien(dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString());
        }

        private void dataGridView_NhanVienTrongPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataNhanVien();
            dataGridView_CongViecCuaNhanVien.DataSource = null;
            dataGridView_CongViecCuaNhanVien.DataSource = cvBLL.getCongViecByIdNhanVien(dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString());
        }

        private void Form_PhanCong_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_PhanCong = true;
        }

        private void loadDataCongViec()
        {
            if(cvBLL.getCongViecByIdCongTrinh(dataGridView_DanhSachCongTrinh.CurrentRow.Cells[0].Value.ToString()).Count != 0)
            {
                tbTenCongViec.Text = dataGridView_DanhSachCongViecCuaCongTrinh.CurrentRow.Cells[1].Value.ToString();
                tbTenCongTrinh.Text = dataGridView_DanhSachCongTrinh.CurrentRow.Cells[1].Value.ToString();
                tbSoNguoiThucHien.Text = cvBLL.soNguoiThucHienCongViec(dataGridView_DanhSachCongViecCuaCongTrinh.CurrentRow.Cells[0].Value.ToString(), dataGridView_DanhSachCongTrinh.CurrentRow.Cells[0].Value.ToString()).ToString();
            }
        }

        private void Form_PhanCong_Load(object sender, EventArgs e)
        {
            dataGridView_NhanVienTrongPhongBan.DataSource = nvBLL.getNhanVienByIdPhongBan(Form_Main.idPhongBan);
            loadDataNhanVien();
            if (ctBLL.getAllCongTrinh().Count() > 0)
            {
                dataGridView_DanhSachCongViecCuaCongTrinh.DataSource = cvBLL.getCongViecByIdCongTrinh(dataGridView_DanhSachCongTrinh.CurrentRow.Cells[0].Value.ToString());
            }
            loadDataCongViecCuaNhanVien();
            loadDataCongViec();
        }

        private void dataGridView_DanhSachCongTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_DanhSachCongViecCuaCongTrinh.DataSource = null;
            dataGridView_DanhSachCongViecCuaCongTrinh.DataSource = cvBLL.getCongViecByIdCongTrinh(dataGridView_DanhSachCongTrinh.CurrentRow.Cells[0].Value.ToString());
            loadDataCongViec();
        }

        private void btnPhanCongViec_Click(object sender, EventArgs e)
        {
            try
            {
                string idNhanVien = dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString();
                string idCongTrinh = dataGridView_DanhSachCongTrinh.CurrentRow.Cells[0].Value.ToString();
                DateTime ngayBatDau = (DateTime)dateNgayBatDau.Value;
                DateTime ngayKetThuc = (DateTime)dateNgayKetThuc.Value;
                string tenNhanVien = dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[1].Value.ToString();

                int countCongViec = cvBLL.getCongViecByIdCongTrinh(dataGridView_DanhSachCongTrinh.CurrentRow.Cells[0].Value.ToString()).Count;
                if (countCongViec == 0)
                {
                    XtraMessageBox.Show("Công trình này chưa có công việc nào !");
                }
                else
                {
                    if (ngayBatDau > ngayKetThuc)
                    {
                        XtraMessageBox.Show("Ngày bắt đầu công việc phải nhỏ hơn ngày kết thúc công việc");
                    }
                    else
                    {
                        string idCongViec = dataGridView_DanhSachCongViecCuaCongTrinh.CurrentRow.Cells[0].Value.ToString();
                        bool kq = nvBLL.phanCongNhanVien(idNhanVien, idCongTrinh, idCongViec, ngayBatDau, ngayKetThuc);

                        if (kq)
                        {
                            dataGridView_CongViecCuaNhanVien.DataSource = null;
                            dataGridView_CongViecCuaNhanVien.DataSource = cvBLL.getCongViecByIdNhanVien(dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString());
                            loadDataCongViec();
                            loadDataNhanVien();
                            XtraMessageBox.Show("Phân công thành công");
                        }
                        else
                        {
                            XtraMessageBox.Show("Nhân viên " + tenNhanVien + " đã được phân công vào công việc này !!!");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("có lỗi");
            }   
        }

        private void btnXoaPhanCongCongViec_Click(object sender, EventArgs e)
        {
            try
            {               
                int countDSPhanCong = cvBLL.getCongViecByIdNhanVien(dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString()).Count;
                if(countDSPhanCong == 0)
                {
                    XtraMessageBox.Show("Nhân viên chưa được phân công công việc nào !");
                }
                else
                {
                    DialogResult dialog = new DialogResult();
                    dialog = XtraMessageBox.Show("Bạn có muốn xóa phân công này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        bool kq = nvBLL.xoaPhanCongCongViec((int)dataGridView_CongViecCuaNhanVien.CurrentRow.Cells[3].Value, dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString());

                        if (kq)
                        {
                            dataGridView_CongViecCuaNhanVien.DataSource = null;
                            dataGridView_CongViecCuaNhanVien.DataSource = cvBLL.getCongViecByIdNhanVien(dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString());
                            loadDataCongViec();
                            loadDataNhanVien();
                            XtraMessageBox.Show("Thao tác thành công");
                        }
                        else
                        {
                            XtraMessageBox.Show("Thao tác thất bại !!!");
                        }
                    }
                    else
                    {
                        dialog = DialogResult.Cancel;

                    }
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("có lỗi");
            }
           
        }

        private void tbTimKiemNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void tbTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {
            string idNV = "";
            foreach (DataGridViewRow row in dataGridView_NhanVienTrongPhongBan.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(tbTimKiemNhanVien.Text))
                {
                    row.Selected = true;
                    idNV =  row.Cells[0].Value.ToString();
                }
            }

            dataGridView_CongViecCuaNhanVien.DataSource = null;
            dataGridView_CongViecCuaNhanVien.DataSource = cvBLL.getCongViecByIdNhanVien(idNV);
        }

        private void dataGridView_NhanVienTrongPhongBan_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView_NhanVienTrongPhongBan_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form_PhanCong_Activated(object sender, EventArgs e)
        {
            dataGridView_NhanVienTrongPhongBan.DataSource = nvBLL.getNhanVienByIdPhongBan(Form_Main.idPhongBan);
            loadDataNhanVien();
            if (ctBLL.getAllCongTrinh().Count() > 0)
            {
                dataGridView_DanhSachCongViecCuaCongTrinh.DataSource = cvBLL.getCongViecByIdCongTrinh(dataGridView_DanhSachCongTrinh.CurrentRow.Cells[0].Value.ToString());
            }
            loadDataCongViecCuaNhanVien();
        }

        private void dataGridView_DanhSachCongViecCuaCongTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataCongViec();
        }
    }
}