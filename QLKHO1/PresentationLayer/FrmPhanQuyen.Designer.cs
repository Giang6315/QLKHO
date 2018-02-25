namespace QLKHO1.PresentationLayer
{
    partial class FrmPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhanQuyen));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvQuanLyNguoiDung = new System.Windows.Forms.DataGridView();
            this.TENDANGNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLQUYENADMIN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.COLQUYENTHEM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.COLQUYENXOA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.COLQUYENSUA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSoanLai = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlThongTinVeQuyen = new DevExpress.XtraEditors.GroupControl();
            this.checkEditSua = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditXoa = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditThem = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditAdmin = new DevExpress.XtraEditors.CheckEdit();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.gclThonngTinDangNhap = new DevExpress.XtraEditors.GroupControl();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThongTinVeQuyen)).BeginInit();
            this.groupControlThongTinVeQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditXoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditThem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclThonngTinDangNhap)).BeginInit();
            this.gclThonngTinDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.btnSoanLai);
            this.panelControl1.Controls.Add(this.groupControlThongTinVeQuyen);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.gclThonngTinDangNhap);
            this.panelControl1.Controls.Add(this.btnCapNhat);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1006, 531);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvQuanLyNguoiDung);
            this.groupControl1.Location = new System.Drawing.Point(20, 188);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(986, 247);
            this.groupControl1.TabIndex = 62;
            this.groupControl1.Text = "Thông tin người dùng";
            // 
            // dgvQuanLyNguoiDung
            // 
            this.dgvQuanLyNguoiDung.AllowUserToAddRows = false;
            this.dgvQuanLyNguoiDung.AllowUserToDeleteRows = false;
            this.dgvQuanLyNguoiDung.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvQuanLyNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENDANGNHAP,
            this.MATKHAU,
            this.COLQUYENADMIN,
            this.COLQUYENTHEM,
            this.COLQUYENXOA,
            this.COLQUYENSUA});
            this.dgvQuanLyNguoiDung.Location = new System.Drawing.Point(23, 36);
            this.dgvQuanLyNguoiDung.Name = "dgvQuanLyNguoiDung";
            this.dgvQuanLyNguoiDung.ReadOnly = true;
            this.dgvQuanLyNguoiDung.Size = new System.Drawing.Size(943, 193);
            this.dgvQuanLyNguoiDung.TabIndex = 61;
            this.dgvQuanLyNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyNguoiDung_CellClick);
            // 
            // TENDANGNHAP
            // 
            this.TENDANGNHAP.DataPropertyName = "TENDANGNHAP";
            this.TENDANGNHAP.HeaderText = "Tên Đăng Nhập";
            this.TENDANGNHAP.Name = "TENDANGNHAP";
            this.TENDANGNHAP.ReadOnly = true;
            this.TENDANGNHAP.Width = 150;
            // 
            // MATKHAU
            // 
            this.MATKHAU.DataPropertyName = "MATKHAU";
            this.MATKHAU.HeaderText = "Mật Khẩu";
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.ReadOnly = true;
            this.MATKHAU.Width = 150;
            // 
            // COLQUYENADMIN
            // 
            this.COLQUYENADMIN.DataPropertyName = "QUYENADMIN";
            this.COLQUYENADMIN.FalseValue = "2";
            this.COLQUYENADMIN.HeaderText = "Quyền Admin";
            this.COLQUYENADMIN.Name = "COLQUYENADMIN";
            this.COLQUYENADMIN.ReadOnly = true;
            this.COLQUYENADMIN.TrueValue = "1";
            this.COLQUYENADMIN.Width = 150;
            // 
            // COLQUYENTHEM
            // 
            this.COLQUYENTHEM.DataPropertyName = "QUYENTHEM";
            this.COLQUYENTHEM.FalseValue = "0";
            this.COLQUYENTHEM.HeaderText = "Quyền Thêm";
            this.COLQUYENTHEM.Name = "COLQUYENTHEM";
            this.COLQUYENTHEM.ReadOnly = true;
            this.COLQUYENTHEM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COLQUYENTHEM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.COLQUYENTHEM.TrueValue = "1";
            this.COLQUYENTHEM.Width = 150;
            // 
            // COLQUYENXOA
            // 
            this.COLQUYENXOA.DataPropertyName = "QUYENXOA";
            this.COLQUYENXOA.FalseValue = "0";
            this.COLQUYENXOA.HeaderText = "Quyền Xóa";
            this.COLQUYENXOA.Name = "COLQUYENXOA";
            this.COLQUYENXOA.ReadOnly = true;
            this.COLQUYENXOA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COLQUYENXOA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.COLQUYENXOA.TrueValue = "1";
            this.COLQUYENXOA.Width = 150;
            // 
            // COLQUYENSUA
            // 
            this.COLQUYENSUA.DataPropertyName = "QUYENSUA";
            this.COLQUYENSUA.FalseValue = "0";
            this.COLQUYENSUA.HeaderText = "Quyền Sửa";
            this.COLQUYENSUA.Name = "COLQUYENSUA";
            this.COLQUYENSUA.ReadOnly = true;
            this.COLQUYENSUA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COLQUYENSUA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.COLQUYENSUA.TrueValue = "1";
            this.COLQUYENSUA.Width = 150;
            // 
            // btnSoanLai
            // 
            this.btnSoanLai.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoanLai.Appearance.Options.UseFont = true;
            this.btnSoanLai.Image = ((System.Drawing.Image)(resources.GetObject("btnSoanLai.Image")));
            this.btnSoanLai.Location = new System.Drawing.Point(715, 24);
            this.btnSoanLai.Name = "btnSoanLai";
            this.btnSoanLai.Size = new System.Drawing.Size(112, 40);
            this.btnSoanLai.TabIndex = 61;
            this.btnSoanLai.Text = "Soạn Lại";
            // 
            // groupControlThongTinVeQuyen
            // 
            this.groupControlThongTinVeQuyen.Controls.Add(this.checkEditSua);
            this.groupControlThongTinVeQuyen.Controls.Add(this.checkEditXoa);
            this.groupControlThongTinVeQuyen.Controls.Add(this.checkEditThem);
            this.groupControlThongTinVeQuyen.Controls.Add(this.checkEditAdmin);
            this.groupControlThongTinVeQuyen.Location = new System.Drawing.Point(370, 24);
            this.groupControlThongTinVeQuyen.Name = "groupControlThongTinVeQuyen";
            this.groupControlThongTinVeQuyen.Size = new System.Drawing.Size(195, 158);
            this.groupControlThongTinVeQuyen.TabIndex = 59;
            this.groupControlThongTinVeQuyen.Text = "Thông Tin Về Quyền";
            // 
            // checkEditSua
            // 
            this.checkEditSua.Location = new System.Drawing.Point(51, 117);
            this.checkEditSua.Name = "checkEditSua";
            this.checkEditSua.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditSua.Properties.Appearance.Options.UseFont = true;
            this.checkEditSua.Properties.Caption = "Sửa";
            this.checkEditSua.Size = new System.Drawing.Size(75, 24);
            this.checkEditSua.TabIndex = 62;
            // 
            // checkEditXoa
            // 
            this.checkEditXoa.Location = new System.Drawing.Point(51, 92);
            this.checkEditXoa.Name = "checkEditXoa";
            this.checkEditXoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditXoa.Properties.Appearance.Options.UseFont = true;
            this.checkEditXoa.Properties.Caption = "Xóa";
            this.checkEditXoa.Size = new System.Drawing.Size(75, 24);
            this.checkEditXoa.TabIndex = 61;
            // 
            // checkEditThem
            // 
            this.checkEditThem.Location = new System.Drawing.Point(51, 61);
            this.checkEditThem.Name = "checkEditThem";
            this.checkEditThem.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditThem.Properties.Appearance.Options.UseFont = true;
            this.checkEditThem.Properties.Caption = "Thêm";
            this.checkEditThem.Size = new System.Drawing.Size(75, 24);
            this.checkEditThem.TabIndex = 1;
            // 
            // checkEditAdmin
            // 
            this.checkEditAdmin.Location = new System.Drawing.Point(51, 33);
            this.checkEditAdmin.Name = "checkEditAdmin";
            this.checkEditAdmin.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditAdmin.Properties.Appearance.Options.UseFont = true;
            this.checkEditAdmin.Properties.Caption = "Admin";
            this.checkEditAdmin.Size = new System.Drawing.Size(75, 24);
            this.checkEditAdmin.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(580, 125);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 40);
            this.btnXoa.TabIndex = 55;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // gclThonngTinDangNhap
            // 
            this.gclThonngTinDangNhap.Controls.Add(this.txtMatKhau);
            this.gclThonngTinDangNhap.Controls.Add(this.txtTenDangNhap);
            this.gclThonngTinDangNhap.Controls.Add(this.labelControl2);
            this.gclThonngTinDangNhap.Controls.Add(this.labelControl1);
            this.gclThonngTinDangNhap.Location = new System.Drawing.Point(26, 24);
            this.gclThonngTinDangNhap.Name = "gclThonngTinDangNhap";
            this.gclThonngTinDangNhap.Size = new System.Drawing.Size(338, 158);
            this.gclThonngTinDangNhap.TabIndex = 54;
            this.gclThonngTinDangNhap.Text = "Thông Tin Đăng Nhập";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(156, 92);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhau.Properties.UseSystemPasswordChar = true;
            this.txtMatKhau.Size = new System.Drawing.Size(157, 26);
            this.txtMatKhau.TabIndex = 12;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(156, 44);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(157, 26);
            this.txtTenDangNhap.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(24, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 19);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(24, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 19);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(580, 75);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(103, 40);
            this.btnCapNhat.TabIndex = 51;
            this.btnCapNhat.Text = "Sửa";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(580, 24);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 40);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // FrmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 531);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmPhanQuyen";
            this.Text = "Phân Quyền";
            this.Load += new System.EventHandler(this.FrmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThongTinVeQuyen)).EndInit();
            this.groupControlThongTinVeQuyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditXoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditThem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclThonngTinDangNhap)).EndInit();
            this.gclThonngTinDangNhap.ResumeLayout(false);
            this.gclThonngTinDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvQuanLyNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDANGNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATKHAU;
        private System.Windows.Forms.DataGridViewCheckBoxColumn COLQUYENADMIN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn COLQUYENTHEM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn COLQUYENXOA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn COLQUYENSUA;
        private DevExpress.XtraEditors.SimpleButton btnSoanLai;
        private DevExpress.XtraEditors.GroupControl groupControlThongTinVeQuyen;
        private DevExpress.XtraEditors.CheckEdit checkEditSua;
        private DevExpress.XtraEditors.CheckEdit checkEditXoa;
        private DevExpress.XtraEditors.CheckEdit checkEditThem;
        private DevExpress.XtraEditors.CheckEdit checkEditAdmin;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.GroupControl gclThonngTinDangNhap;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}