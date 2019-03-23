using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace Quanlykhachsan.Lopdoituong
{
    class ketnoi
    {
        
        public static string strcon = "Database=khachsan;Integrated Security=SSPI;";
        static public SqlConnection con;
        public static string Chuoiketnoi()
        {
            return (strcon);
        }
       
        
        public static void ThietlapketNoi()
        {
            try
            {
                con = new SqlConnection(strcon);
               con.Open();
            }
               
            catch { };
        }
        public static void HuyKetNoi()
        {
            con.Close();
        }
    }
}
