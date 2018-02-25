using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLKHO1.DataAccessLayer;
using QLKHO1.BussinessLogicLayer;
namespace QLKHO1.PresentationLayer
{
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        //CDATABASE db = new CDATABASE();
        //CLAYDULIEUSANPHAM sp = new CLAYDULIEUSANPHAM();
        //public void HienThiTenLoaiSP()
        //{
        //    for (int i = 0; i < sp.LayLoaiSP().Rows.Count; i++)
        //    {
        //        cb_LoaiSanPham.Properties.Items.Add(sp.LayLoaiSP().Rows[i]["TENLOAI"].ToString());
        //    }
        //}
        //public void HienThiComboboxQuiCach()
        //{
        //    for (int i = 0; i < sp.LayQuiCach().Rows.Count; i++)
        //    {
        //        cb_QuiCach.Properties.Items.Add(sp.LayQuiCach().Rows[i]["QUICACH"].ToString());
        //    }
        //}
        private void xfrmSanPham_Load(object sender, EventArgs e)
        {
            //HienThiTenLoaiSP();
            //HienThiComboboxQuiCach();
            //dgv_SanPham.DataSource = sp.LoadSanPham();
        }

        private void cb_LoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dgv_SanPham.DataSource = sp.HienThiSPTheoLoaiSP(cb_LoaiSanPham.Text);
        }
        //CThemSanPham cthem = new CThemSanPham();
        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //cthem.ThemSanPham(txt_MaSP.Text, txt_TenSanPham.Text, float.Parse(txt_DonGia.ToString()), cb_QuiCach.Text, cb_LoaiSanPham.Text);
            //dgv_SanPham.DataSource = sp.HienThiSPTheoLoaiSP(cb_LoaiSanPham.Text);
        }

    
    }
}