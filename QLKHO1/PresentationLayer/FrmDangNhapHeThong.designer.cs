namespace QLKHO1.PresentationLayer
{
    partial class FrmDangNhapHeThong
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.gcThongTinDangNhap = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTinDangNhap)).BeginInit();
            this.gcThongTinDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(20, 41);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(20, 85);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật khẩu:";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDangNhap.Location = new System.Drawing.Point(145, 39);
            this.txt_TenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(213, 27);
            this.txt_TenDangNhap.TabIndex = 1;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(95, 85);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(263, 27);
            this.txt_MatKhau.TabIndex = 1;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Appearance.Options.UseFont = true;
            this.btn_DangNhap.Location = new System.Drawing.Point(114, 178);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(155, 36);
            this.btn_DangNhap.TabIndex = 2;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            this.btn_DangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_DangNhap_KeyDown);
            // 
            // gcThongTinDangNhap
            // 
            this.gcThongTinDangNhap.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gcThongTinDangNhap.Controls.Add(this.txt_TenDangNhap);
            this.gcThongTinDangNhap.Controls.Add(this.labelControl1);
            this.gcThongTinDangNhap.Controls.Add(this.labelControl2);
            this.gcThongTinDangNhap.Controls.Add(this.txt_MatKhau);
            this.gcThongTinDangNhap.Location = new System.Drawing.Point(19, 23);
            this.gcThongTinDangNhap.Name = "gcThongTinDangNhap";
            this.gcThongTinDangNhap.Size = new System.Drawing.Size(385, 132);
            this.gcThongTinDangNhap.TabIndex = 3;
            this.gcThongTinDangNhap.Text = "Thông Tin Đăng Nhập";
            // 
            // FrmDangNhapHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 225);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.gcThongTinDangNhap);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDangNhapHeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Nhập Hệ Thống";
            this.Load += new System.EventHandler(this.FrmDangNhapHeThong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTinDangNhap)).EndInit();
            this.gcThongTinDangNhap.ResumeLayout(false);
            this.gcThongTinDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private DevExpress.XtraEditors.SimpleButton btn_DangNhap;
        private DevExpress.XtraEditors.GroupControl gcThongTinDangNhap;
        public System.Windows.Forms.TextBox txt_TenDangNhap;
    }
}