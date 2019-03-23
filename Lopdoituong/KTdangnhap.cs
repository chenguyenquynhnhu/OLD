using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Quanlykhachsan.Lopdoituong;

namespace Quanlykhachsan.Lopdoituong
{
    class KTdangnhap
    {
        private DataSet ds;
        public static string strquyenhan="",strnguoidung="",strhoten = "", strdiachi = "", strmanhanvien = "", strmatkhau = "";
        public bool kt_dangnhap(string ten, string matkhau, string tenserver)
        {
            //Lnhanvien nv = new Lnhanvien();
            try
            {
                if (tenserver != "")
                {
                   ketnoi.strcon = ketnoi.strcon + "; server= " + tenserver;
                 
                    
                }
                ketnoi.ThietlapketNoi();
                laydulieu dl = new laydulieu();
                ds = dl.getdata("select * from nhanvien where matkhau = '" + matkhau + "' and tendangnhap = '" + ten + "'");
                if (ds.Tables[0].Rows.Count == 0) { ketnoi.HuyKetNoi(); return false; }
                else
                {
                    strmanhanvien = ds.Tables[0].Rows[0]["manhanvien"].ToString();
                    strhoten = ds.Tables[0].Rows[0]["hoten"].ToString();
                    strdiachi = ds.Tables[0].Rows[0]["diachi"].ToString();
                    strnguoidung = ds.Tables[0].Rows[0]["tendangnhap"].ToString();
                    strquyenhan=ds.Tables[0].Rows[0]["quyenhan"].ToString();
                   
                   
                    strmatkhau = ds.Tables[0].Rows[0]["matkhau"].ToString();
                    ketnoi.HuyKetNoi();
                    return true;
                }
            }
            catch { return false; }
        }

    }

}
