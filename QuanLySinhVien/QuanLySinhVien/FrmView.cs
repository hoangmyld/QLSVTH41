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
using System.Drawing.Imaging;
using System.IO;
using Microsoft.Reporting.WinForms;


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
        int ms = 1002;
        private void bttim_Click(object sender, EventArgs e)
        {
            loadAStudent(int.Parse(txttim.Text.Trim()));
            dgvdiemhocki.DataSource = list3();
            dgvdiemtonghop.DataSource = list2();
            
        }
        private void loadAStudent(int MSSV)
        {
            try
            {
                string sql = @"SELECT * FROM SinhVien WHERE MaSV = " + MSSV;

                SinhVien sv = new SinhVien1BUS().getAStudent(sql);

                lbhoten.Text = sv.Ho + " " + sv.Ten;
                lbsdt.Text = sv.SDT;
                lbdc.Text = sv.DiaChi;
                lbemail.Text = sv.Email;
                lbgt.Text = sv.GioiTinh;
                lbmanganh.Text = sv.MaNganh;
                pictureBox1.Image = null;
                if(sv.HinhSV != null)
                {
                    MemoryStream ms = new MemoryStream(sv.HinhSV);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Nhap sai ma so sinh vien");
                txttim.Clear();
            };
        }
            /*private  void load1diemhocki(int MSSV)
            {
                try 
	            {
                    string sql = @"Select * from SV_LH where MaSV=" + MSSV;
                    string ten=  @"Select * from SinhVien where MaSV=" + MSSV;
                    SV_LH svlh = new SV_LHBus().get1diemhocki(sql);
                    SinhVien sv = new SinhVien1BUS().getAStudent(ten);
                    lbhovaten.Text = sv.Ho + " " + sv.Ten;
                    lbmalop.Text = svlh.MaLop;
                    lbgiuaki.Text = svlh.DiemGK.ToString();
                    lbcuoiki.Text = svlh.DiemCK.ToString();
                    lbmalop2.Text = svlh.DiemGK.ToString();
                    


	            }
	            catch (Exception ex)
	            {


                    MessageBox.Show("Sinh viên không có điểm học kì");
                    txttim.Clear();
	            }

            }*/



        private void FrmView_Load(object sender, EventArgs e)
        {
            loadAStudent(mssv);
            dgvdiemhocki.DataSource = list3();
            dgvdiemtonghop.DataSource = list2();

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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbmalop_Click(object sender, EventArgs e)
        {

        }

        private void lbgiuaki_Click(object sender, EventArgs e)
        {

        }

        private void lbhovaten_Click(object sender, EventArgs e)
        {

        }

        private List<SV_LH> list()
        {
            string sql = @"Select * from SV_LH where MaSV='" +txttim.Text+"'";
            SV_LHBus sv = new SV_LHBus();
            List<SV_LH> list = sv.GetSV_LH(sql);
            return list;
        }
        private List<SV_MH> list2()
        {
            string sql = @"Select * from SV_MH where MaSV='" + txttim.Text + "'";
            SV_MHBus mh = new SV_MHBus();
            List<SV_MH> list2 = mh.GetSV_MH(sql);
            return list2;
         }
       
        private List<SV_LH2> list3()
        {
            string sql ="Select SV_LH.MaLop,TenMH,DiemGK,DiemCK from SV_LH,MonHoc,LopHoc where SV_LH.MaLop=LopHoc.MaLop and LopHoc.MaMH=MonHoc.MaMH and MaSV='"+txttim.Text+"'";
            SV_LH2BUS svlh = new SV_LH2BUS();
            List<SV_LH2> list3 = svlh.GetSV_LH2(sql);
            return list3 ;
        }
        
        }
       
   
    }
    

