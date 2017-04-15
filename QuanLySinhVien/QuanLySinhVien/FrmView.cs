using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


using DTO;
using BUS;

namespace QuanLySinhVien
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }

        private void lbhoten_Click(object sender, EventArgs e)
        {

        }
        int mssv = 1001;
        private void bttim_Click(object sender, EventArgs e)
        {
            loadAStudent(int.Parse(txttim.Text.Trim()));
        }
        private void loadAStudent(int MSSV)
        {
            try
            {
                string sql = @"SELECT * FROM SinhVien WHERE MaSV = " + MSSV;

                SinhVien sv = new SinhVien1BUS().getAStudent(sql);

                lbhoten.Text = sv.Ho+" "+sv.Ten;
                lbsdt.Text = sv.SDT;
                lbdc.Text = sv.DiaChi;
                lbemail.Text = sv.Email;
                lbgt.Text = sv.GioiTinh;
                lbmanganh.Text = sv.MaNganh;

            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Nhap sai ma so sinh vien");
            }
            


        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            loadAStudent(mssv);
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txttim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            } 
        }

    }
    
}
