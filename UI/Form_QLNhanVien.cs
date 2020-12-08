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
    public partial class Form_QLNhanVien : DevExpress.XtraEditors.XtraForm
    {
        NhanVienBLL nvBLL;

        private int trangThaiLuu = -1;

        public Form_QLNhanVien()
        {
            InitializeComponent();
            nvBLL = new NhanVienBLL();

            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = nvBLL.getNhanVienByIdPhongBan(Form_Main.idPhongBan);


        }

        private void tbTenNhanVien_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_QLNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_QLNhanVien = true;
        }

        private void enableOptions(bool e)
        {
            tbTenNhanVien.Enabled = tbDiaChi.Enabled = tbSdt.Enabled  = e;
        }

        private void loadDataCellNhanVien()
        {
            if (dataGridView1.DataSource != null)
            {
                tbTenNhanVien.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tbDiaChi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tbSdt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu cho Nhân Viên");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataCellNhanVien();
            btnXoa.Enabled = btnCapNhat.Enabled = btnThem.Enabled = true;
            enableOptions(false);
            btnLuu.Enabled = false;
            trangThaiLuu = -1;
            btnThem.Text = "Thêm Mới";
    }

        private void clearAll()
        {
            tbTenNhanVien.Text = tbDiaChi.Text = tbSdt.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (trangThaiLuu == -1)
            {
                trangThaiLuu = 0;
                btnThem.Text = "Hủy";
                enableOptions(true);
                btnLuu.Enabled = true;
                btnCapNhat.Enabled = btnXoa.Enabled = false;
                clearAll();
            }
            else
            {
                trangThaiLuu = -1;
                btnThem.Text = "Thêm mới";
                enableOptions(false);
                btnLuu.Enabled = false;
                btnCapNhat.Enabled = btnXoa.Enabled = true;
                loadDataCellNhanVien();
            }
        }

        private void Form_QLNhanVien_Load(object sender, EventArgs e)
        {
            loadDataCellNhanVien();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            trangThaiLuu = 1;
            btnCapNhat.Enabled = btnThem.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            enableOptions(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = XtraMessageBox.Show("Bạn có muốn xóa nhân viên này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bool kq = nvBLL.xoaNhanVien(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                if (kq)
                {
                    XtraMessageBox.Show("Xóa nhân viên thành công");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = nvBLL.getNhanVienByIdPhongBan(Form_Main.idPhongBan);
                    loadDataCellNhanVien();
                }
                else
                {
                    XtraMessageBox.Show("Xóa nhân viên thất bại !!");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = nvBLL.getNhanVienByIdPhongBan(Form_Main.idPhongBan);
                    loadDataCellNhanVien();
                }
            }
            else
            {
                dialog = DialogResult.Cancel;

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (trangThaiLuu == 0) // Thêm
            {
                if(tbTenNhanVien.Text.Trim().Length == 0 || tbDiaChi.Text.Trim().Length == 0 || tbSdt.Text.Trim().Length == 0)
                {
                    XtraMessageBox.Show("Vui lòng nhập đầy đủ dữ liệu cho nhân viên mới!");
                }
                else
                {
                    if(!Regex.IsMatch(tbSdt.Text, "0([1-9]){9}"))
                    {
                        XtraMessageBox.Show("Số điện thoại không hợp lệ!");
                    }
                    else
                    {
                        eNhanVien a = new eNhanVien(tbTenNhanVien.Text, tbDiaChi.Text, tbSdt.Text, Form_Main.idPhongBan);
                        bool kq = nvBLL.themNhanVien(a);

                        if (kq)
                        {
                            XtraMessageBox.Show("Thêm nhân viên thành công");

                        }
                        else
                        {
                            XtraMessageBox.Show("Thêm nhân viên thất bại !!!");
                        }





                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = nvBLL.getNhanVienByIdPhongBan(Form_Main.idPhongBan);
                        loadDataCellNhanVien();
                        btnCapNhat.Enabled = btnXoa.Enabled = btnThem.Enabled = true;
                        btnLuu.Enabled = false;
                        enableOptions(false);
                        trangThaiLuu = -1;
                        btnThem.Text = "Thêm mới";
                    }
                }
            }
            else //Cập nhật
            {
                if (tbTenNhanVien.Text.Trim().Length == 0 || tbDiaChi.Text.Trim().Length == 0 || tbSdt.Text.Trim().Length == 0)
                {
                    XtraMessageBox.Show("Vui lòng nhập đầy đủ dữ liệu cho nhân viên mới!");
                }
                else
                {
                    if (!Regex.IsMatch(tbSdt.Text, "0([1-9]){9}"))
                    {
                        XtraMessageBox.Show("Số điện thoại không hợp lệ!");
                    }
                    else
                    {
                        eNhanVien a = new eNhanVien(dataGridView1.CurrentRow.Cells[0].Value.ToString(), tbTenNhanVien.Text, tbDiaChi.Text, tbSdt.Text, true);
                        bool kq = nvBLL.capNhatNhanVien(a);

                        if (kq)
                        {
                            XtraMessageBox.Show("Cập nhật thông tin nhân viên thành công");

                        }
                        else
                        {
                            XtraMessageBox.Show("Cập nhật thông tin nhân viên thất bại !!!");
                        }

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = nvBLL.getNhanVienByIdPhongBan(Form_Main.idPhongBan);
                        loadDataCellNhanVien();
                        btnCapNhat.Enabled = btnXoa.Enabled = btnThem.Enabled = true;
                        btnLuu.Enabled = false;
                        enableOptions(false);
                    }
                }              
            }
        }

        private void Form_QLNhanVien_Activated(object sender, EventArgs e)
        {
            loadDataCellNhanVien();
        }
    }
}