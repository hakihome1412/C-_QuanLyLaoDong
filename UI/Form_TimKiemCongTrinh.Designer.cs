namespace UI
{
    partial class Form_TimKiemCongTrinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbTenCongTrinh = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThucDuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHoanThanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenCongTrinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên công trình:";
            // 
            // tbTenCongTrinh
            // 
            this.tbTenCongTrinh.Location = new System.Drawing.Point(271, 33);
            this.tbTenCongTrinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenCongTrinh.Name = "tbTenCongTrinh";
            this.tbTenCongTrinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenCongTrinh.Properties.Appearance.Options.UseFont = true;
            this.tbTenCongTrinh.Size = new System.Drawing.Size(564, 32);
            this.tbTenCongTrinh.TabIndex = 2;
            this.tbTenCongTrinh.TextChanged += new System.EventHandler(this.tbTenCongTrinh_TextChanged);
            this.tbTenCongTrinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTenCongTrinh_KeyDown);
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl3.Controls.Add(this.dataGridView1);
            this.groupControl3.Location = new System.Drawing.Point(23, 85);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1764, 807);
            this.groupControl3.TabIndex = 63;
            this.groupControl3.Text = "Danh Sách Nhân Viên Trong Phòng Ban";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCongTrinh,
            this.tenCongTrinh,
            this.diaChi,
            this.ngayBatDau,
            this.ngayKetThucDuKien,
            this.ngayHoanThanh,
            this.trangThai});
            this.dataGridView1.Location = new System.Drawing.Point(5, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1754, 781);
            this.dataGridView1.TabIndex = 57;
            // 
            // idCongTrinh
            // 
            this.idCongTrinh.DataPropertyName = "idCongTrinh";
            this.idCongTrinh.FillWeight = 95.84665F;
            this.idCongTrinh.HeaderText = "ID Công Trình";
            this.idCongTrinh.Name = "idCongTrinh";
            this.idCongTrinh.ReadOnly = true;
            // 
            // tenCongTrinh
            // 
            this.tenCongTrinh.DataPropertyName = "tenCongTrinh";
            this.tenCongTrinh.FillWeight = 54.96075F;
            this.tenCongTrinh.HeaderText = "Tên Công Trình";
            this.tenCongTrinh.Name = "tenCongTrinh";
            this.tenCongTrinh.ReadOnly = true;
            this.tenCongTrinh.Width = 120;
            // 
            // diaChi
            // 
            this.diaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.FillWeight = 186.4927F;
            this.diaChi.HeaderText = "Địa Chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // ngayBatDau
            // 
            this.ngayBatDau.DataPropertyName = "ngayBatDau";
            this.ngayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.ngayBatDau.Name = "ngayBatDau";
            this.ngayBatDau.ReadOnly = true;
            this.ngayBatDau.Visible = false;
            // 
            // ngayKetThucDuKien
            // 
            this.ngayKetThucDuKien.DataPropertyName = "ngayKetThucDuKien";
            this.ngayKetThucDuKien.HeaderText = "Ngày Kết Thúc Dự Kiến";
            this.ngayKetThucDuKien.Name = "ngayKetThucDuKien";
            this.ngayKetThucDuKien.ReadOnly = true;
            this.ngayKetThucDuKien.Visible = false;
            // 
            // ngayHoanThanh
            // 
            this.ngayHoanThanh.DataPropertyName = "ngayHoanThanh";
            this.ngayHoanThanh.HeaderText = "Ngày Hoàn Thành";
            this.ngayHoanThanh.Name = "ngayHoanThanh";
            this.ngayHoanThanh.ReadOnly = true;
            this.ngayHoanThanh.Visible = false;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.FillWeight = 48.86432F;
            this.trangThai.HeaderText = "Trạng Thái";
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            this.trangThai.Width = 120;
            // 
            // Form_TimKiemCongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 903);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.tbTenCongTrinh);
            this.Controls.Add(this.label1);
            this.Name = "Form_TimKiemCongTrinh";
            this.Text = "Tìm Kiếm Công Trình";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_TimKiemCongTrinh_FormClosed);
            this.Load += new System.EventHandler(this.Form_TimKiemCongTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTenCongTrinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit tbTenCongTrinh;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThucDuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}