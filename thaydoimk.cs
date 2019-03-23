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
    public partial class thaydoimk : Form
    {
        public thaydoimk()
        {
            InitializeComponent();
        }
        bool tam = true, tam1 = true;

        private void btthaydoi_Click(object sender, EventArgs e)
        {
            if (txtmatkhaucu.Text.Trim() != KTdangnhap.strmatkhau.Trim())
            {
                MessageBox.Show("Mật khẩu cũ không đúng,hãy nhập lại", "Thông báo");
                tam = false;

            }
            else
            {
                
                tam = true;
            }
            if (txtmatkhaumoi.Text != txtnhaplai.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp,hãy nhập lại", "Thông báo");
                tam1 = false;
            }
            else
            {
               
                tam1 = true;
            }
            if (tam && tam1)
            {
                Lnhanvien nv = new Lnhanvien(KTdangnhap.strmanhanvien, KTdangnhap.strhoten, KTdangnhap.strdiachi, KTdangnhap.strquyenhan, KTdangnhap.strnguoidung, KTdangnhap.strmatkhau);
                if (nv.doimatkhau(txtmatkhaumoi.Text) == true)
                    MessageBox.Show("Đã hoàn thành việc thay đôi mật khẩu", "Thông báo");
                else
                    MessageBox.Show("Việc thay đổi đã bị lỗi hãy thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thaydoimk_Load(object sender, EventArgs e)
        {

        }
    }
}