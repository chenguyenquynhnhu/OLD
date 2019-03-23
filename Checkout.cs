using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Quanlykhachsan.Lopdoituong;


namespace Quanlykhachsan
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        SqlDataReader rd;

        private void Checkout_Load(object sender, EventArgs e)
        {
            laydulieu dl = new laydulieu();
            rd= dl.lay_reader("SELECT checkin.macheckin, checkin.makhach, khachhang.tenkhach FROM checkin INNER JOIN khachhang ON checkin.makhach = khachhang.makhach");
            while (rd.Read())
            {
                comboBox1.Items.Add(rd.GetString(0)+"  "+rd.GetString(1)+"  "+rd.GetString(2));

            }
            rd.NextResult();
           

            //rd.Close();
            
        }
        string taoma()
        {
            laydulieu dl = new laydulieu();
            string tam1 = "";
            int i = 0;
            SqlDataReader dr = dl.lay_reader("select macheckout from checkout");
            while (dr.Read())
                tam1 = dr[0].ToString();
            ketnoi.HuyKetNoi();
            i = int.Parse(tam1.Substring(2, tam1.Length - 2));
            i++;
            if (i < 10) return "CK00" + i.ToString();
            else
                if (i < 100) return "CK0" + i.ToString();
                else return "CK" + i.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            laydulieu dl1 = new laydulieu();
            string s = comboBox1.Text.Substring(0, comboBox1.Text.IndexOf(" "));
            double chiphi,tienphong;
            
            try
            {
                DataSet dt1 = dl1.getdata("SELECT luutru.sophong AS sophong,loaiphong.gia AS gia FROM loaiphong INNER JOIN phong ON loaiphong.maphong = phong.maphong INNER JOIN luutru ON phong.sophong = luutru.sophong WHERE  (luutru.macheckin = '" + s + "')");
                DataSet dt2 = dl1.getdata("select SUM(gia)AS giaca from dichvuanuong where macheckin='" + s + "'");
                DataSet dt3 = dl1.getdata("select SUM(gia)AS giaca from dichvugiatla where macheckin='" + s + "'");
                DataSet dt4 = dl1.getdata("select SUM(gia)AS giaca from dichvugiaitri where macheckin='" + s + "'");



                if (dt2.Tables[0].Rows.Count==0) tanuong.Text = "0";

                else tanuong.Text = dt2.Tables[0].Rows[0]["giaca"].ToString();


                if (dt3.Tables[0].Rows.Count==0) tgiatla.Text = "0";

                  
                    

                else tgiatla.Text = dt3.Tables[0].Rows[0]["giaca"].ToString();


                if (dt4.Tables[0].Rows.Count==0) tgiaitri.Text = "0";
                else tgiaitri.Text = dt4.Tables[0].Rows[0]["giaca"].ToString();

                if (tchiphi.Text=="") chiphi=0;
                else chiphi=Convert.ToInt32(tchiphi.Text);
                if (tngaythue.Text == "") tngaythue.Text="1";
               
                tienphong = Convert.ToInt32(dt1.Tables[0].Rows[0]["gia"].ToString()) * Convert.ToInt32(tngaythue.Text);

              
                        
                  
                /*if (dt2.Tables[0].Rows[0]["giaca"] == null) tanuong.Text = "0";
                if (dt3.Tables[0].Rows[0]["giaca"] == null) tgiatla.Text = "0";
                if (dt4.Tables[0].Rows[0]["giaca"] == null) tgiaitri.Text = "0";*/
                 

                
                
                   
                   
                tcheckin.Text = s;
                
               tphong.Text = dt1.Tables[0].Rows[0]["sophong"].ToString();
               ttienphong.Text = tienphong.ToString();
               // tanuong.Text = dr1.ToString();
                //tgiaitri.Text = dr3.ToString();
                //tgiatla.Text = dr2.ToString();
                double p = Convert.ToInt32(ttienphong.Text) + Convert.ToInt32(tanuong.Text) + Convert.ToInt32(tgiatla.Text) + Convert.ToInt32(tgiaitri.Text)+chiphi;
                   ttong.Text=p.ToString();
                   /*if (MessageBox.Show("Bạn có muốn lưu trữ thông tin check out?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                   {
                       string strcom = "insert into checkout values('" + taoma() + "','" + tcheckin.Text + "'," + Convert.ToInt32(ttienphong.Text) + "," + Convert.ToInt32(tanuong.Text) + "," + Convert.ToInt32(tgiatla.Text) + "," + Convert.ToInt32(tgiaitri.Text) + ")";
                       SqlCommand com = new SqlCommand(strcom, ketnoi.con);

                           MessageBox.Show("Đã lưư trữ", "Thông Báo");
                   }
                    */
            }
            catch (Exception ex )

            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}