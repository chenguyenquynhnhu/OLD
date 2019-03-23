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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        public static string strtendn, strmatkhaudn, strtensv;
        private void button1_Click(object sender, EventArgs e)
        {
            strtendn = textBox2.Text;
            strmatkhaudn = textBox3.Text;
            strtensv = textBox1.Text;
            KTdangnhap dn = new KTdangnhap();


            if (dn.kt_dangnhap(Dangnhap.strtendn, Dangnhap.strmatkhaudn, Dangnhap.strtensv))
            {
                MessageBox.Show("Bạn đã đăng nhập thành công vào hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
                // Lnhanvien nv = new Lnhanvien(KTdangnhap.strmanhanvien, KTdangnhap.strhoten, KTdangnhap.strdiachi, KTdangnhap.strquyenhan, KTdangnhap.strnguoidung, KTdangnhap.strmatkhau);

               Frmmain.s = "Người đang sử dụng chương trình có tài khoản là: " + KTdangnhap.strnguoidung.Trim() + " và quyền hạn là: " + KTdangnhap.strquyenhan + "        ";
               
                 //this.Close();
            }
               
               
            else
            {

                MessageBox.Show("Bạn đã nhập không đúng dữ liệu,hãy chắc chắn tên sử dụng và mật khẩu là chính xác", "Login Failed");

            }


            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

