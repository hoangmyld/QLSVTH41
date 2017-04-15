using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTO;
using BUS;

namespace QuanLySinhVien
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void rdView_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = false;
        }

        private void rdStudent_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = true;
        }

        private void rdQTV_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = true;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login() == 1)
                {
                    if (rdView.Checked == true)
                    {
                        FrmView f = new FrmView();
                        f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                        f.Show();
                    }
                    else if (rdStudent.Checked == true)
                    {
                        FrmStudent f = new FrmStudent();
                        f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                        f.Show();
                    }
                    else
                    {
                        FrmAdmin f = new FrmAdmin();
                        f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                        f.Show();
                    }
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                }
                else if (Login() == 0)
                {
                    MessageBox.Show("Đăng nhập thất bại");
                    txtID.Text = "";
                    txtPassword.Text = "";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Nhập lại", "Nhập sai !");
                txtID.Text = "";
                txtPassword.Text = "";
            }
           
        }
        private int Login()
        {
            string id, pass;
            id = txtID.Text;
            int choose = 0;
            if (rdView.Checked) { choose = 0; pass = ""; }
            else if (rdStudent.Checked) { choose = 1; pass = txtPassword.Text; }
            else { choose = 2; pass = txtPassword.Text; }
            return new LoginBUS().Login(id, pass, choose);
        } 

        private void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
