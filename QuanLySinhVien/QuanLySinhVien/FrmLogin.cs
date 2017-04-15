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
          
            this.Hide();
  
        }
        private void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }



    }
}
