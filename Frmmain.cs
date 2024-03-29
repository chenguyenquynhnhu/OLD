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
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }
        public static string s = "Chương trình quản lý khách sạn,Hãy đăng nhập để sử dụng chương trình ";

        public void Frmmain_Load(object sender, EventArgs e)
        {
   
            if (KTdangnhap.strquyenhan.IndexOf("ADMIN") >= 0)
            {
                ttcanhan.Enabled = true;
                dangxuat.Enabled = true;
                mnquanlykhachhang.Enabled = true;
                mnquanlydichvu.Enabled = true;
                mnquanlynhanvien.Enabled = true;
                capnhat.Enabled = true;
                them.Enabled = true;
            }

            if (KTdangnhap.strquyenhan.IndexOf("QUANLY") >= 0)
            {
                ttcanhan.Enabled = true;
                dangxuat.Enabled = true;
                mnquanlykhachhang.Enabled = true;
                mnquanlydichvu.Enabled = true;
                mnquanlynhanvien.Enabled = true;
                capnhat.Enabled = true;
                them.Enabled = false;
              
            }
            if (KTdangnhap.strquyenhan.IndexOf("NHANVIEN") >= 0)
            {
                ttcanhan.Enabled = true;
                dangxuat.Enabled = true;
                mnquanlykhachhang.Enabled = true;
                mnquanlydichvu.Enabled = true;
                mnquanlynhanvien.Enabled = false;
              
             

            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = s;

            string tam = s[0].ToString();
            s = s.Substring(1, s.Length - 1) + tam;
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap fr = new Dangnhap();
            fr.Show();
            //s = "Người đang sử dụng chương trình có tài khoản là: " + KTdangnhap.strnguoidung.Trim() + " và quyền hạn là: " + KTdangnhap.strquyenhan + "        ";
            Frmmain_Load(sender, e);
        }

        private void mnkhachhang_Click(object sender, EventArgs e)
        {
            Thaydoittcanhan fr = new Thaydoittcanhan();
            fr.Show();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themkhach fr = new themkhach();
            fr.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ttluutru fr=new Ttluutru();
            fr.Show();
        }

        private void tìmKiémToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timkhach fr = new Timkhach();
            fr.Show();
        }

        private void cậpNhậtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            suattkhach fr = new suattkhach();
            fr.Show();
        }

        private void xoáKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xoakhach fr=new Xoakhach();
            fr.Show();
        }

        private void checkOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Checkout fr=new Checkout();
            fr.Show();
        }

        private void anuong_Click(object sender, EventArgs e)
        {
            DVanuong fr = new DVanuong();
            fr.Show();
        }

        private void dịchVụGiặtLàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DVgiatla fr = new DVgiatla();
            fr.Show();
        }

        private void dịchVụGiảiTríToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DVgiaitri fr = new DVgiaitri();
            fr.Show();
        }

        private void capnhat_Click(object sender, EventArgs e)
        {
            Phanquyen fr = new Phanquyen();
            fr.Show();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            timnv fr = new timnv();
            fr.Show();
        }

        private void them_Click(object sender, EventArgs e)
        {
            themnv fr = new themnv();
            fr.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aboutus fr = new Aboutus();
            fr.Show();
        }

        private void dangxuat_Click(object sender, EventArgs e)
        {
            dangnhap.Enabled = true;
            ttcanhan.Enabled = false;
            dangxuat.Enabled = false; ;
            mnquanlykhachhang.Enabled = false;
            mnquanlydichvu.Enabled = false;
            mnquanlynhanvien.Enabled = false;
            s="Chương trình Quản Lý Khách Sạn,hãy đăng nhập để sử dụng chương trình ";
            
        }
    }
}