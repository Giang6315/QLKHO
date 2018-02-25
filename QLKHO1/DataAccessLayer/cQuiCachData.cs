using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLKHO1.DataAccessLayer
{
    class cQuiCachData
    {
        string s;
        DataTable dt = new DataTable();
        //Lay qui cach
        public DataTable LayQuiCach()
        {
            return CDATABASE.ExecuteBang("SELECT * FROM QUICACH");
        }
        //lay ma qui cach tu bang qui cach
        public string LayMaQuiCacgTuTenQuiCach(string ten)
        {
            dt = CDATABASE.ExecuteBang("SELECT MAQUICACH FROM QUICACH WHERE QUICACH=N''" + ten + "'");
            s = dt.Rows[0]["MAQUICACH"].ToString();
            return s;
        }
        //Lay ma qui cach tu ten qui cach
        public string LayMaQuiCachTuTenQuiCach(string ten)
        {
            dt = CDATABASE.ExecuteBang("SELECT MAQUICACH FROM QUICACH WHERE QUICACH='" + ten + "'");
            s = dt.Rows[0]["MAQUICACH"].ToString();
            return s;
        }
    }
}
