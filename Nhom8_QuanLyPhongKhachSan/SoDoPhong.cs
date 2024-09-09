using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WDF;


namespace DemoQLP
{
    public partial class frmSoDoPhong : Form
    {
        public frmSoDoPhong()
        {
            InitializeComponent();
            // Đặt icon cho các button
       
            
        }

       


        private void bt101_Click(object sender, EventArgs e)
        {
            string TenKhachHang101="Thanh Luan";
            //string[] Cut101 = TenKhachHang101.Split('');
            int GiaTien101= 999000;
            groupBox1.Visible = true; // Hiển thị GroupBox
            textBox2.Text = bt101.Text; // Giả sử bạn có một label trong GroupBox để hiển thị dữ liệu
            textBox3.Text = TenKhachHang101;
            textBox4.Text = GiaTien101.ToString();
         

        }

        private void grbSoDoPhong_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void bt103_Click(object sender, EventArgs e)
        {
            string TenKhachHang103 = "Nam Khanh";
            int GiaTien103 = 9990000;
            groupBox1.Visible = true; // Hiển thị GroupBox
            textBox2.Text = bt103.Text; // Giả sử bạn có một label trong GroupBox để hiển thị dữ liệu
            textBox3.Text = TenKhachHang103;
            textBox4.Text = GiaTien103.ToString();
           
        }


        private void bt102_Click(object sender, EventArgs e)
        {
            string TenKhachHang102 = "Anh Khoa";
            int GiaTien102 = 1999000; 
            groupBox1.Visible = true; // Hiển thị GroupBox
            textBox2.Text = bt102.Text; // Giả sử bạn có một label trong GroupBox để hiển thị dữ liệu
            textBox3.Text = TenKhachHang102;
            textBox4.Text = GiaTien102.ToString();
        }

        private void btTang1_Click(object sender, EventArgs e)
        {

        }

        private void grBoxHoaDon(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            //if (clickedButton != null)
            //{
            //    //textBox2.Text = clickedButton.Text; // Cập nhật dữ liệu trong GroupBox theo text của button được nhấn
            //}
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan form = new ThanhToan(); // Tạo instance của form mới
            form.Show(); // Hiển thị form mới
      
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ThanhToan form = new ThanhToan(); // Tạo instance của form mới
            form.Show(); // Hiển thị form mới
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            QuanLyPhong form = new QuanLyPhong(); // Tạo instance của form mới
            form.Show(); // Hiển thị form mới
        }

        private void MenuDatPhong_Click(object sender, EventArgs e)
        {
           frmDatPhong form = new frmDatPhong();    
            form.Show();
            //form.Show(); // Hiển thị form mới
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
          
        }

        private void MenuNhanPhong_Click(object sender, EventArgs e)
        {
            frmNhanPhong form = new frmNhanPhong();
            form.Show();
        }

        private void quảnLýNhânViên_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien form = new frmQuanLyNhanVien();
            form.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang form = new KhachHang();
            form.Show();
        }
    }
}
