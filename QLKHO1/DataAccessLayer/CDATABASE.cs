using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace QLKHO1.DataAccessLayer
{
   public class CDATABASE
    {

        public static SqlConnection sqlconn;
        public static string chuoiketnoi = null;
        public static void KetNoi()
        {
            try
            {
                chuoiketnoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLKHO;Integrated Security=True";
                sqlconn = new SqlConnection(chuoiketnoi);
                sqlconn.Open();
                //MessageBox.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Khong the ket noi den CSDL." + ex.Message, "FAIL CONNECT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                    sqlconn.Close();
                sqlconn.Dispose();

            }
        }

        public static DataTable ExecuteBang(string query)
        {
            sqlconn = new SqlConnection(chuoiketnoi);
            SqlDataAdapter da = new SqlDataAdapter(query, chuoiketnoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Ham thuc hien cau truy van Insert, Update, Delete
        public static void ThucThiLenh(string strquery)
        {
            try
            {
                sqlconn = new SqlConnection(chuoiketnoi);
                SqlCommand sqlcom = new SqlCommand(strquery, sqlconn);
                sqlconn.Open();
                sqlcom.ExecuteNonQuery();
                sqlconn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi thự thi câu lệnh SQL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ThucThiLenh(SqlCommand cmd)
        {
            sqlconn = new SqlConnection(chuoiketnoi);
            sqlconn.Open();
            cmd.Connection = sqlconn;
            cmd.ExecuteNonQuery();
            sqlconn.Close();
        }

    }
}
