using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLKHO1.DataAccessLayer;
namespace QLKHO1.DataAccessLayer
{
    class cLoaiSanPhamData
    {
     
        string s;
        DataTable dt = new DataTable();
        //Lay danh sach loai san pham
        public DataTable LayLoaiSP()
        {
            return CDATABASE.ExecuteBang("SELECT * FROM LOAISANPHAM");
        }
        //Lay ma loai san pham tu ten loai san pham
        public string LayMaLoaiTuTenLoai(string ten)
        {
            dt = CDATABASE.ExecuteBang("SELECT MALOAI FROM LOAISANPHAM WHERE TENLOAI=N'" + ten + "'");
            s = dt.Rows[0]["MALOAI"].ToString();
            return s;
        }
    }
}
