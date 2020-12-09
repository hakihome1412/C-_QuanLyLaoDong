namespace UI
{
    partial class Form_QLNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.panelThaoTac = new System.Windows.Forms.Panel();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelQuanLyDM = new System.Windows.Forms.Panel();
            this.tbSdt = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panelThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panelQuanLyDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThaoTac
            // 
            this.panelThaoTac.Controls.Add(this.btnLuu);
            this.panelThaoTac.Controls.Add(this.btnXoa);
            this.panelThaoTac.Controls.Add(this.btnThem);
            this.panelThaoTac.Controls.Add(this.btnCapNhat);
            this.panelThaoTac.Location = new System.Drawing.Point(7, 23);
            this.panelThaoTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThaoTac.Name = "panelThaoTac";
            this.panelThaoTac.Size = new System.Drawing.Size(581, 477);
            this.panelThaoTac.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(310, 251);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(252, 140);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(18, 251);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(252, 140);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Location = new System.Drawing.Point(18, 70);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(252, 137);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Location = new System.Drawing.Point(310, 70);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(252, 137);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl2.Controls.Add(this.panelThaoTac);
            this.groupControl2.Location = new System.Drawing.Point(3, 392);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(593, 506);
            this.groupControl2.TabIndex = 61;
            this.groupControl2.Text = "Thao Tác";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl1.Controls.Add(this.panelQuanLyDM);
            this.groupControl1.Location = new System.Drawing.Point(3, 11);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(593, 377);
            this.groupControl1.TabIndex = 60;
            this.groupControl1.Text = "Thông Tin Nhân Viên";
            // 
            // panelQuanLyDM
            // 
            this.panelQuanLyDM.Controls.Add(this.tbSdt);
            this.panelQuanLyDM.Controls.Add(this.label2);
            this.panelQuanLyDM.Controls.Add(this.tbDiaChi);
            this.panelQuanLyDM.Controls.Add(this.label5);
            this.panelQuanLyDM.Controls.Add(this.tbTenNhanVien);
            this.panelQuanLyDM.Controls.Add(this.label1);
            this.panelQuanLyDM.Location = new System.Drawing.Point(8, 23);
            this.panelQuanLyDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelQuanLyDM.Name = "panelQuanLyDM";
            this.panelQuanLyDM.Size = new System.Drawing.Size(580, 349);
            this.panelQuanLyDM.TabIndex = 53;
            // 
            // tbSdt
            // 
            this.tbSdt.Enabled = false;
            this.tbSdt.Location = new System.Drawing.Point(151, 266);
            this.tbSdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSdt.Properties.Appearance.Options.UseFont = true;
            this.tbSdt.Size = new System.Drawing.Size(410, 32);
            this.tbSdt.TabIndex = 1011;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 1012;
            this.label2.Text = "Số điện thoại:";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Enabled = false;
            this.tbDiaChi.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Location = new System.Drawing.Point(151, 100);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(410, 134);
            this.tbDiaChi.TabIndex = 1010;
            this.tbDiaChi.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 1001;
            this.label5.Text = "Địa chỉ:";
            // 
            // tbTenNhanVien
            // 
            this.tbTenNhanVien.Enabled = false;
            this.tbTenNhanVien.Location = new System.Drawing.Point(151, 36);
            this.tbTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenNhanVien.Name = "tbTenNhanVien";
            this.tbTenNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNhanVien.Properties.Appearance.Options.UseFont = true;
            this.tbTenNhanVien.Size = new System.Drawing.Size(410, 32);
            this.tbTenNhanVien.TabIndex = 1;
            this.tbTenNhanVien.EditValueChanged += new System.EventHandler(this.tbTenNhanVien_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Nhân viên:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNhanVien,
            this.tenNhanVien,
            this.diaChi,
            this.sdt});
            this.dataGridView1.Location = new System.Drawing.Point(5, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1182, 859);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idNhanVien
            // 
            this.idNhanVien.DataPropertyName = "idNhanVien";
            this.idNhanVien.FillWeight = 95.84665F;
            this.idNhanVien.HeaderText = "ID Nhân Viên";
            this.idNhanVien.Name = "idNhanVien";
            this.idNhanVien.ReadOnly = true;
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "tenNhanVien";
            this.tenNhanVien.FillWeight = 54.96075F;
            this.tenNhanVien.HeaderText = "Tên Nhân Viên";
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.ReadOnly = true;
            this.tenNhanVien.Width = 200;
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
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Điện Thoại";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl3.Controls.Add(this.dataGridView1);
            this.groupControl3.Location = new System.Drawing.Point(602, 11);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1192, 887);
            this.groupControl3.TabIndex = 62;
            this.groupControl3.Text = "Danh Sách Nhân Viên Trong Phòng Ban";
            // 
            // Form_QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 903);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "Form_QLNhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.Activated += new System.EventHandler(this.Form_QLNhanVien_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_QLNhanVien_FormClosed);
            this.Load += new System.EventHandler(this.Form_QLNhanVien_Load);
            this.panelThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panelQuanLyDM.ResumeLayout(false);
            this.panelQuanLyDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThaoTac;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panelQuanLyDM;
        private System.Windows.Forms.RichTextBox tbDiaChi;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit tbTenNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TextEdit tbSdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}