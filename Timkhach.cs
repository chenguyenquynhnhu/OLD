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
    public partial class Timkhach : Form
    {
        DataSet dt;
        public Timkhach()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;

            }


            else
            {
                textBox2.Enabled = true;
                textBox3.Enabled = true;

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.Enabled = false;
                textBox3.Enabled = false;

            }


            else
            {
                textBox1.Enabled = true;
                textBox3.Enabled = true;

            }

        }

        private void Timkhach_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox2.Enabled = false;
                textBox1.Enabled = false;

            }


            else
            {
                textBox2.Enabled = true;
                textBox1.Enabled = true;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
          try {
              laydulieu dl=new laydulieu();
              if (radioButton1.Checked)
              {
                  dt=dl.getdata("select * from khachhang where tenkhach LIKE '%"+textBox1.Text+"%'");
                  dataGridView1.DataSource=dt.Tables[0];
              }
              if (radioButton2.Checked)
              {
                  dt=dl.getdata("select * from khachhang where chungminh LIKE '%"+textBox2.Text+"%'");
                  dataGridView1.DataSource=dt.Tables[0];
              }

               if (radioButton3.Checked)
              {
                  dt=dl.getdata("select * from khachhang where ngaydatphong LIKE '%"+textBox3.Text+"%'");
                  dataGridView1.DataSource=dt.Tables[0];
              }
          }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}