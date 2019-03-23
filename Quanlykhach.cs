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
    public partial class Quanlykhach : Form
    {
        public Quanlykhach()
        {
            InitializeComponent();
        }

        private void Quanlykhach_Load(object sender, EventArgs e)
        {
            //ketnoi.strcon += Dangnhap.strtensv;

            
           //SqlConnection con=new SqlConnection(strcon);
            DataSet ds;
          
            try
            {
               // con.Open();
                laydulieu dl=new laydulieu();

                ds = dl.getdata("select * from khachhang");
                dataGridView1.DataSource = ds.Tables[0];
               //con.Close();
                ketnoi.HuyKetNoi();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            themkhach fr = new themkhach();
            fr.Show();


            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            suattkhach fr = new suattkhach();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Timkhach fr = new Timkhach();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Xoakhach fr = new Xoakhach();
            fr.Show();
        }
    }
}