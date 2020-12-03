namespace UI
{
    partial class Form_ChamCong
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView_CongViecCuaNhanVien = new System.Windows.Forms.DataGridView();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTimKiemNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.dataGridView_NhanVienTrongPhongBan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnXoaPhanCongCongViec = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhanCongViec = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CongViecCuaNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimKiemNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVienTrongPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl1.Controls.Add(this.dataGridView_CongViecCuaNhanVien);
            this.groupControl1.Location = new System.Drawing.Point(432, 11);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(718, 422);
            this.groupControl1.TabIndex = 72;
            this.groupControl1.Text = " Danh Sách Công Việc Của Nhân Viên";
            // 
            // dataGridView_CongViecCuaNhanVien
            // 
            this.dataGridView_CongViecCuaNhanVien.AllowUserToAddRows = false;
            this.dataGridView_CongViecCuaNhanVien.AllowUserToDeleteRows = false;
            this.dataGridView_CongViecCuaNhanVien.AllowUserToResizeRows = false;
            this.dataGridView_CongViecCuaNhanVien.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_CongViecCuaNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CongViecCuaNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.Column1,
            this.Column6,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dataGridView_CongViecCuaNhanVien.Location = new System.Drawing.Point(5, 22);
            this.dataGridView_CongViecCuaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_CongViecCuaNhanVien.MultiSelect = false;
            this.dataGridView_CongViecCuaNhanVien.Name = "dataGridView_CongViecCuaNhanVien";
            this.dataGridView_CongViecCuaNhanVien.ReadOnly = true;
            this.dataGridView_CongViecCuaNhanVien.RowHeadersVisible = false;
            this.dataGridView_CongViecCuaNhanVien.RowTemplate.Height = 24;
            this.dataGridView_CongViecCuaNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_CongViecCuaNhanVien.Size = new System.Drawing.Size(708, 396);
            this.dataGridView_CongViecCuaNhanVien.TabIndex = 56;
            // 
            // groupControl6
            // 
            this.groupControl6.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl6.Appearance.Options.UseBackColor = true;
            this.groupControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl6.Controls.Add(this.label1);
            this.groupControl6.Controls.Add(this.tbTimKiemNhanVien);
            this.groupControl6.Controls.Add(this.dataGridView_NhanVienTrongPhongBan);
            this.groupControl6.Location = new System.Drawing.Point(12, 11);
            this.groupControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(414, 278);
            this.groupControl6.TabIndex = 74;
            this.groupControl6.Text = "Danh Sách Nhân Viên Trong Phòng Ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Nhập tên cần tìm";
            // 
            // tbTimKiemNhanVien
            // 
            this.tbTimKiemNhanVien.Location = new System.Drawing.Point(124, 23);
            this.tbTimKiemNhanVien.Name = "tbTimKiemNhanVien";
            this.tbTimKiemNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tbTimKiemNhanVien.Properties.Appearance.Options.UseFont = true;
            this.tbTimKiemNhanVien.Size = new System.Drawing.Size(285, 30);
            this.tbTimKiemNhanVien.TabIndex = 57;
            this.tbTimKiemNhanVien.TextChanged += new System.EventHandler(this.tbTimKiemNhanVien_TextChanged);
            // 
            // dataGridView_NhanVienTrongPhongBan
            // 
            this.dataGridView_NhanVienTrongPhongBan.AllowUserToAddRows = false;
            this.dataGridView_NhanVienTrongPhongBan.AllowUserToDeleteRows = false;
            this.dataGridView_NhanVienTrongPhongBan.AllowUserToResizeRows = false;
            this.dataGridView_NhanVienTrongPhongBan.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_NhanVienTrongPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NhanVienTrongPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView_NhanVienTrongPhongBan.Location = new System.Drawing.Point(5, 60);
            this.dataGridView_NhanVienTrongPhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_NhanVienTrongPhongBan.MultiSelect = false;
            this.dataGridView_NhanVienTrongPhongBan.Name = "dataGridView_NhanVienTrongPhongBan";
            this.dataGridView_NhanVienTrongPhongBan.ReadOnly = true;
            this.dataGridView_NhanVienTrongPhongBan.RowHeadersVisible = false;
            this.dataGridView_NhanVienTrongPhongBan.RowTemplate.Height = 24;
            this.dataGridView_NhanVienTrongPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_NhanVienTrongPhongBan.Size = new System.Drawing.Size(404, 214);
            this.dataGridView_NhanVienTrongPhongBan.TabIndex = 56;
            this.dataGridView_NhanVienTrongPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_NhanVienTrongPhongBan_CellClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idNhanVien";
            this.dataGridViewTextBoxColumn5.FillWeight = 95.84665F;
            this.dataGridViewTextBoxColumn5.HeaderText = "ID Nhân Viên";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tenNhanVien";
            this.dataGridViewTextBoxColumn6.FillWeight = 54.96075F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Tên Nhân Viên";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "diaChi";
            this.dataGridViewTextBoxColumn7.FillWeight = 186.4927F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Địa Chỉ";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl2.Controls.Add(this.btnXoaPhanCongCongViec);
            this.groupControl2.Controls.Add(this.btnPhanCongViec);
            this.groupControl2.Location = new System.Drawing.Point(12, 293);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(414, 140);
            this.groupControl2.TabIndex = 75;
            this.groupControl2.Text = "Thao Tác";
            // 
            // btnXoaPhanCongCongViec
            // 
            this.btnXoaPhanCongCongViec.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnXoaPhanCongCongViec.Appearance.Options.UseFont = true;
            this.btnXoaPhanCongCongViec.Location = new System.Drawing.Point(239, 50);
            this.btnXoaPhanCongCongViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaPhanCongCongViec.Name = "btnXoaPhanCongCongViec";
            this.btnXoaPhanCongCongViec.Size = new System.Drawing.Size(151, 70);
            this.btnXoaPhanCongCongViec.TabIndex = 9;
            this.btnXoaPhanCongCongViec.Text = "Vắng";
            this.btnXoaPhanCongCongViec.Click += new System.EventHandler(this.btnXoaPhanCongCongViec_Click);
            // 
            // btnPhanCongViec
            // 
            this.btnPhanCongViec.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnPhanCongViec.Appearance.Options.UseFont = true;
            this.btnPhanCongViec.Location = new System.Drawing.Point(24, 50);
            this.btnPhanCongViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhanCongViec.Name = "btnPhanCongViec";
            this.btnPhanCongViec.Size = new System.Drawing.Size(151, 70);
            this.btnPhanCongViec.TabIndex = 8;
            this.btnPhanCongViec.Text = "Có Mặt";
            this.btnPhanCongViec.Click += new System.EventHandler(this.btnPhanCongViec_Click);
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "stt";
            this.dataGridViewTextBoxColumn12.FillWeight = 95.84665F;
            this.dataGridViewTextBoxColumn12.HeaderText = "STT";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 50;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "tenCongTrinh";
            this.dataGridViewTextBoxColumn13.FillWeight = 300.3085F;
            this.dataGridViewTextBoxColumn13.HeaderText = "Tên Công Trình";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "tenCongViec";
            this.dataGridViewTextBoxColumn14.FillWeight = 68.10609F;
            this.dataGridViewTextBoxColumn14.HeaderText = "Tên Công Việc";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idPhanCong";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "idChamCong";
            this.Column6.HeaderText = "ID Chấm Công";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngayPhanCong";
            this.Column4.HeaderText = "Ngày Phân Công";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "ngayBatDau";
            this.Column2.FillWeight = 36.51944F;
            this.Column2.HeaderText = "Ngày Bắt Đầu";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ngayKetThuc";
            this.Column3.FillWeight = 36.51944F;
            this.Column3.HeaderText = "Ngày Kết Thúc";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "trangThaiChamCong";
            this.Column5.HeaderText = "Trạng Thái";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form_ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 444);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl1);
            this.Name = "Form_ChamCong";
            this.Text = "Chấm Công";
            this.Activated += new System.EventHandler(this.Form_ChamCong_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_ChamCong_FormClosed);
            this.Load += new System.EventHandler(this.Form_ChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CongViecCuaNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimKiemNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVienTrongPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dataGridView_CongViecCuaNhanVien;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit tbTimKiemNhanVien;
        private System.Windows.Forms.DataGridView dataGridView_NhanVienTrongPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnXoaPhanCongCongViec;
        private DevExpress.XtraEditors.SimpleButton btnPhanCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}