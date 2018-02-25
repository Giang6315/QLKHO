using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Text;
using System.Drawing;
using QLKHO1.DataAccessLayer;
using QLKHO1.BussinessLogicLayer;
using QLKHO1.PresentationLayer;
using QLKHO1.Controller;
using System.Data;
namespace QLKHO1
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbi_GiaoDien);
        }
        
        CDATABASE db = new CDATABASE();
        public void DisableMenu()
        {
           
            bbi_dangxuat.Enabled = false;
            bbi_dangnhap.Enabled = true;
            bbi_thoat.Enabled = true;
            bbi_DoiMatKhau.Enabled = false;
            bbi_phanquyen.Enabled = false;
            //
            bbiSanPham.Enabled = false;
        }
        public void EnableMenuUser()
        {
            bbiSanPham.Enabled = true;

            bbi_dangnhap.Enabled = false;
            bbi_dangxuat.Enabled = true;
        }
        public void EnableMenuAdmin()
        {
            bbiSanPham.Enabled = true;

            bbi_dangnhap.Enabled = false;
            bbi_dangxuat.Enabled = true;

            bbi_DoiMatKhau.Enabled = true;
            bbi_phanquyen.Enabled = true;
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            
            DisableMenu();
            //this.WindowState = FormWindowState.Maximized;
        }

        private void barButtonItemthoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc không? ", "Trả lời ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
        
        private void bbi_dangnhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDangNhapHeThong dn = new FrmDangNhapHeThong();
            dn.ShowDialog();
            if (!string.IsNullOrEmpty(TenDangNhap))
            {
                this.barStaticItem1.Caption = "Chào " + TenDangNhap + "!";
            }
        }
        public static string TenDangNhap = string.Empty;
        private void bbi_DoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDoiMatKhau ucDMK = new FrmDoiMatKhau();
            DataTable dt1 = new DataTable();
            dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
                {
                    if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                    {
                        ucDMK.Enable_Insert();
                    }
                    if ((bool)dt1.Rows[i]["QUYENSUA"] == true)
                    {
                        ucDMK.Enable_UpDate();
                    }
                    if ((bool)dt1.Rows[i]["QUYENXOA"] == true)
                    {
                        ucDMK.Enable_Delete();
                    }
                    if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                    {
                        ucDMK.Enable_Insert();
                        ucDMK.Enable_Delete();
                        ucDMK.Enable_UpDate();
                    }
                    break;
                }
            }   
            KiemTraTonTaiTab.TaoTabUC(xtraTabControl1, "Doi Mat Khau", "DMK", ucDMK, -1);
        }

        private void bbi_dangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DisableMenu();
            xtraTabControl1.TabPages.Clear();
        }

        private void bbi_phanquyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmPhanQuyen FPG = new FrmPhanQuyen();
            FPG.ShowDialog();
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.XtraTabControl xtab = (DevExpress.XtraTab.XtraTabControl)sender;
            int i = xtab.SelectedTabPageIndex;
            xtab.TabPages.RemoveAt(xtab.SelectedTabPageIndex);
            xtab.SelectedTabPageIndex = i;
        }

        private void xtraTabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            //Neu Right - click thi dong cac tab con lai. Tru tab dang click. 
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                DevExpress.XtraTab.ViewInfo.XtraTabHitInfo hi = xtraTabControl1.CalcHitInfo(e.Location);
                if (hi.HitTest == DevExpress.XtraTab.ViewInfo.XtraTabHitTest.PageHeader)
                {
                    foreach (DevExpress.XtraTab.XtraTabPage page in xtraTabControl1.TabPages)
                        if (hi.Page != page)
                        {
                            DialogResult traloi;
                            traloi = MessageBox.Show("Bạn có đóng các tab còn lại không? ", "Trả lời ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (traloi == DialogResult.OK)
                                page.PageVisible = false;
                        }
                        
                }
            }
        }
        

    //END OF FRM MAIN
    }
}