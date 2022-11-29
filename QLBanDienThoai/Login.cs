using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanDienThoai
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        if (Kiemtradangnhap(txtTaikhoan.Text,txtMatkhau.Text))
            {
                Main f=new Main();  
                f.Show();
                this.Hide();
               
            }
        else
            {
                MessageBox.Show("Tài khoản mật khẩu không chính xác");

            }
        }
        string tentaikhoan = "admin";
        string matkhau="admin"; 
        bool Kiemtradangnhap(string tentaikhoan,string matkhau)
        {
            if (tentaikhoan == this.tentaikhoan && matkhau == matkhau)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtTaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpass.Checked)
            {
                txtMatkhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatkhau.PasswordChar = '*';
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }
    }
}
