using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLKHO1.DataAccessLayer;
namespace QLKHO1.BussinessLogicLayer
{
  public class CPHANQUYEN
    {
       
        public static DataTable LAYDSNGUOIDUNG()
        {
            string query = "SELECT TENDANGNHAP, MATKHAU, QUYENADMIN, QUYENTHEM, QUYENXOA, QUYENSUA  FROM NGUOIDUNG";
            return CDATABASE.ExecuteBang(query);
        }
        public static void NguoiDung_Them(string TenDangNhap, string MatKhau, int QuyenAdmin, int QuyenThem, int QuyenXoa, int QuyenSua)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_NGUOIDUNG_THEM") { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.Add("@TENDN", SqlDbType.VarChar).Value = TenDangNhap;
                    cmd.Parameters.Add("@MATKHAU", SqlDbType.VarChar).Value = MatKhau;
                    cmd.Parameters.Add("@ADMIN", SqlDbType.Bit).Value = QuyenAdmin;
                    cmd.Parameters.Add("@THEM", SqlDbType.Bit).Value = QuyenThem;
                    cmd.Parameters.Add("@XOA", SqlDbType.Bit).Value = QuyenXoa;
                    cmd.Parameters.Add("@SUA", SqlDbType.Bit).Value = QuyenSua;
                    CDATABASE.ThucThiLenh(cmd);
                    //MessageBox.Show("Thêm thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Thêm dữ liệu không thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static void NguoiDung_Sua(string TenDangNhap, string MatKhau, int QuyenAdmin, int QuyenThem, int QuyenXoa, int QuyenSua)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_NGUOIDUNG_SUA") { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.Add("@TENDN", SqlDbType.VarChar).Value = TenDangNhap;
                    cmd.Parameters.Add("@MATKHAU", SqlDbType.VarChar).Value = MatKhau;
                    cmd.Parameters.Add("@ADMIN", SqlDbType.Bit).Value = QuyenAdmin;
                    cmd.Parameters.Add("@THEM", SqlDbType.Bit).Value = QuyenThem;
                    cmd.Parameters.Add("@XOA", SqlDbType.Bit).Value = QuyenXoa;
                    cmd.Parameters.Add("@SUA", SqlDbType.Bit).Value = QuyenSua;
                    CDATABASE.ThucThiLenh(cmd);
                    //MessageBox.Show("Sửa thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Sửa dữ liệu không thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static void NguoiDung_Xoa(string TenDangNhap)
        {
             DialogResult kq = MessageBox.Show("Bạn có chắc là muốn xóa tài khoản này không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
             if (kq == DialogResult.Yes)
             {
                 using (SqlCommand cmd = new SqlCommand("SP_NGUOIDUNG_XOA") { CommandType = CommandType.StoredProcedure })
                 {
                     cmd.Parameters.Add("@TENDN", SqlDbType.VarChar).Value = TenDangNhap;
                     CDATABASE.ThucThiLenh(cmd);
                 }
             }
        }
        
    }
}
