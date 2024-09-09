using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WDF
{
    public partial class QuanLyPhong : Form
    {
        public QuanLyPhong()
        {
            InitializeComponent();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton1.Checked)
            //{
            //   // radioButton1.Checked = false;

            //    listView2.Visible = true;
            //    listView1.Visible = false;
            //}
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton2.Checked)
            //{
            //   // radioButton2.Checked = false;

            //    listView1.Visible = true;
            //    listView2.Visible = false;
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thêm_Phòng form = new Thêm_Phòng(); // Tạo instance của form mới
            form.Show();
        }

        private void QuangLyPhong_Load(object sender, EventArgs e)
        {

        }
    }
}
