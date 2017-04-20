using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public int MSSV;
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (Login() == 1)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    if (rdView.Checked == true)
                    {
                        FrmView f = new FrmView();
                        MSSV = int.Parse(txtID.Text);
                        f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                        f.Show();
                    }
                    else if (rdStudent.Checked == true)
                    {
                        FrmStudent f = new FrmStudent();
                        MSSV = int.Parse(txtID.Text);
                        f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                        f.Show();
                    }
                    else
                    {
                        FrmAdmin f = new FrmAdmin();
                        f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                        f.Show();
                    }

                    this.Hide();
                }
                else MessageBox.Show("Đăng nhập thất bại");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
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

    }
}
