using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLKHO1.DataAccessLayer;
namespace QLKHO1.BussinessLogicLayer
{
    class CDOIMATKHAU
    {

        public void DOIMATKHAU(string tendangnhap, string matkhaucu, string matkhaumoi)
        {
            using (SqlCommand cmd = new SqlCommand("SP_DOIMATKHAU"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TENDANGNHAP", SqlDbType.NVarChar).Value = tendangnhap;
                cmd.Parameters.Add("@MATKHAUCU", SqlDbType.VarChar).Value = matkhaucu;
                cmd.Parameters.Add("@MATKHAUMOI", SqlDbType.VarChar).Value = matkhaumoi;
                try
                {
                    CDATABASE.ThucThiLenh(cmd);
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
   
    }
}
