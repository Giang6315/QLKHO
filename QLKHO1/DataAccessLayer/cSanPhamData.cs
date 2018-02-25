using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLKHO1.DataAccessLayer
{
    class cSanPhamData
    {
        //CDATABASE db = new CDATABASE();
        public DataTable LaySP()
        {
            return CDATABASE.ExecuteBang("SELECT A.MASP, TENSP, MOTASP, DONGIA, TENLOAI, QUICACH FROM  SANPHAM A, LOAISANPHAM B, QUICACH C WHERE A.MALOAI=B.MALOAI AND A.MAQUICACH=C.MAQUICACH");
        }
        public DataTable HienThiSPTheoLoaiSP(string tenloai)
        {
            return CDATABASE.ExecuteBang("SELECT MASP, TENSP, DONGIA, QUICACH FROM SANPHAM A, LOAISANPHAM B, QUICACH C WHERE A.MALOAI=B.MALOAI AND A.MAQUICACH=C.MAQUICACH AND B.TENLOAI=N'" + tenloai + "'");
        }
        public void ThemSanPham(string masp, string tensp, float dongia, string maquicach, string maloai)
        {
            using (SqlCommand cmd = new SqlCommand("SP_THEMSANPHAM"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MASP", SqlDbType.Char).Value = masp;
                cmd.Parameters.Add("@TENSP", SqlDbType.Char).Value = tensp;
                cmd.Parameters.Add("@DONGIA", SqlDbType.Float).Value = dongia;
                cmd.Parameters.Add("@MAQUICACH", SqlDbType.Char).Value = maquicach;
                cmd.Parameters.Add("@MALOAI", SqlDbType.Char).Value = maloai;
                try
                {
                    CDATABASE.ThucThiLenh(cmd);
                   DevExpress.XtraEditors.XtraMessageBox.Show("Thêm sản phẩm thành công!", "Thông Báo!");
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi!" + ex.Message, "Thông báo!");
                }

            }
        }
    }
}
