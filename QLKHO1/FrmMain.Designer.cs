namespace QLKHO1
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbi_dangnhap = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_dangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_thoat = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSanPham = new DevExpress.XtraBars.BarButtonItem();
            this.rgbi_GiaoDien = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.bbi_DoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_phanquyen = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPagehethong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGrouphethong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPagedanhmuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGiaoDien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonText = null;
            // 
            // 
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbi_dangnhap,
            this.bbi_dangxuat,
            this.bbi_thoat,
            this.bbiSanPham,
            this.rgbi_GiaoDien,
            this.bbi_DoiMatKhau,
            this.bbi_phanquyen,
            this.barStaticItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.barStaticItem1);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPagehethong,
            this.ribbonPagedanhmuc,
            this.ribbonPageGiaoDien});
            this.ribbon.Size = new System.Drawing.Size(985, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bbi_dangnhap
            // 
            this.bbi_dangnhap.Caption = "Đăng Nhập";
            this.bbi_dangnhap.Id = 1;
            this.bbi_dangnhap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbi_dangnhap.LargeGlyph")));
            this.bbi_dangnhap.Name = "bbi_dangnhap";
            this.bbi_dangnhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_dangnhap_ItemClick);
            // 
            // bbi_dangxuat
            // 
            this.bbi_dangxuat.Caption = "Đăng Xuất";
            this.bbi_dangxuat.Id = 2;
            this.bbi_dangxuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbi_dangxuat.LargeGlyph")));
            this.bbi_dangxuat.Name = "bbi_dangxuat";
            this.bbi_dangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_dangxuat_ItemClick);
            // 
            // bbi_thoat
            // 
            this.bbi_thoat.Caption = "Thoát";
            this.bbi_thoat.Id = 3;
            this.bbi_thoat.LargeGlyph = global::QLKHO1.Properties.Resources.Close_32x32;
            this.bbi_thoat.Name = "bbi_thoat";
            this.bbi_thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemthoat_ItemClick);
            // 
            // bbiSanPham
            // 
            this.bbiSanPham.Caption = "Sản Phẩm";
            this.bbiSanPham.Id = 4;
            this.bbiSanPham.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSanPham.LargeGlyph")));
            this.bbiSanPham.Name = "bbiSanPham";
            // 
            // rgbi_GiaoDien
            // 
            this.rgbi_GiaoDien.Caption = "ribbonGalleryBarItem1";
            this.rgbi_GiaoDien.Id = 5;
            this.rgbi_GiaoDien.Name = "rgbi_GiaoDien";
            // 
            // bbi_DoiMatKhau
            // 
            this.bbi_DoiMatKhau.Caption = "Đổi Mật Khẩu";
            this.bbi_DoiMatKhau.Id = 7;
            this.bbi_DoiMatKhau.LargeGlyph = global::QLKHO1.Properties.Resources.doimatkhau;
            this.bbi_DoiMatKhau.Name = "bbi_DoiMatKhau";
            this.bbi_DoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_DoiMatKhau_ItemClick);
            // 
            // bbi_phanquyen
            // 
            this.bbi_phanquyen.Caption = "Phân Quyền";
            this.bbi_phanquyen.Id = 8;
            this.bbi_phanquyen.LargeGlyph = global::QLKHO1.Properties.Resources.justice_balance_icon;
            this.bbi_phanquyen.Name = "bbi_phanquyen";
            this.bbi_phanquyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_phanquyen_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Chào <Ten Dang Nhap>";
            this.barStaticItem1.Id = 9;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonPagehethong
            // 
            this.ribbonPagehethong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGrouphethong});
            this.ribbonPagehethong.Name = "ribbonPagehethong";
            this.ribbonPagehethong.Text = "Hệ thống";
            // 
            // ribbonPageGrouphethong
            // 
            this.ribbonPageGrouphethong.ItemLinks.Add(this.bbi_thoat);
            this.ribbonPageGrouphethong.ItemLinks.Add(this.bbi_dangnhap);
            this.ribbonPageGrouphethong.ItemLinks.Add(this.bbi_dangxuat);
            this.ribbonPageGrouphethong.ItemLinks.Add(this.bbi_DoiMatKhau);
            this.ribbonPageGrouphethong.ItemLinks.Add(this.bbi_phanquyen);
            this.ribbonPageGrouphethong.Name = "ribbonPageGrouphethong";
            this.ribbonPageGrouphethong.Text = "Hệ thống";
            // 
            // ribbonPagedanhmuc
            // 
            this.ribbonPagedanhmuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupDanhMuc});
            this.ribbonPagedanhmuc.Name = "ribbonPagedanhmuc";
            this.ribbonPagedanhmuc.Text = "Danh Mục";
            // 
            // ribbonPageGroupDanhMuc
            // 
            this.ribbonPageGroupDanhMuc.AllowTextClipping = false;
            this.ribbonPageGroupDanhMuc.ItemLinks.Add(this.bbiSanPham);
            this.ribbonPageGroupDanhMuc.Name = "ribbonPageGroupDanhMuc";
            this.ribbonPageGroupDanhMuc.Text = "Danh Mục";
            // 
            // ribbonPageGiaoDien
            // 
            this.ribbonPageGiaoDien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageGiaoDien.Name = "ribbonPageGiaoDien";
            this.ribbonPageGiaoDien.Text = "Giao Diện";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.rgbi_GiaoDien);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Giao Diện";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 448);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(985, 31);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderButtons = DevExpress.XtraTab.TabButtons.Close;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 144);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Size = new System.Drawing.Size(985, 304);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.CloseButtonClick += new System.EventHandler(this.xtraTabControl1_CloseButtonClick);
            this.xtraTabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xtraTabControl1_MouseDown);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 479);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản Lý Kho";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPagehethong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGrouphethong;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPagedanhmuc;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageGiaoDien;
        private DevExpress.XtraBars.BarButtonItem bbi_dangnhap;
        private DevExpress.XtraBars.BarButtonItem bbi_dangxuat;
        private DevExpress.XtraBars.BarButtonItem bbi_thoat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDanhMuc;
        private DevExpress.XtraBars.BarButtonItem bbiSanPham;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbi_GiaoDien;
        private DevExpress.XtraBars.BarButtonItem bbi_DoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem bbi_phanquyen;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
    }
}