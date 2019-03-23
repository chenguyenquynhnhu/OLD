using System.Data;
using System.Collections.Generic;
using System.Text;
using Quanlykhachsan.Lopdoituong;
using System.Data.SqlClient;

namespace Quanlykhachsan.Lopdoituong
{
    class laydulieu
    {
        public laydulieu()

        {
            ketnoi.ThietlapketNoi();
            
        }
        public DataSet getdata(string truyvan)
        {
            try
            {
                DataSet ds = new DataSet(); ;
                SqlCommand cmd = new SqlCommand(truyvan, ketnoi.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "bang");
                //ketnoi.HuyKetNoi();
                return ds;
            


            }
            catch { return null; }
        }
        public SqlDataReader lay_reader(string truyvan)
        {
            try
            {
                DataSet ds = new DataSet(); ;
                SqlCommand cmd = new SqlCommand(truyvan, ketnoi.con);
                SqlDataReader dr = cmd.ExecuteReader();

                return dr;

            }
            catch { return null; }
        }
        public int thucthitruyvan(string truyvan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(truyvan, ketnoi.con);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch
            {
                return 0;
            }

        }
    }
}
