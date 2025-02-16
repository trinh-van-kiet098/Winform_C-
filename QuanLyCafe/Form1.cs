using QuanLyCafe.Cashier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dangnhap_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dangnhap_dangKyBtn_Click(object sender, EventArgs e)
        {
            fRegister registerForm = new fRegister();
            registerForm.Show();
            this.Hide();          
        }

        private void dangnhap_dangNhapBtn_Click(object sender, EventArgs e)
        {

        }

        private void dangnhap_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';

        }
    }
}
