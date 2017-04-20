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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }
        int mssv;
        public FrmLogin fmlogin;
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            mssv = fmlogin.MSSV;
        }
        DataTable dtChuyenNganh, dtHocKi;
        List<HienThi> ListHT;
        List<DangKi> ListDK;
        private void loadChuyenNganh()
        {
            dtChuyenNganh = new DichVuSVBUS().getChuyenNganh();
            cbBan.DataSource = dtChuyenNganh;
            cbBan.DisplayMember = "TenNganh";
            cbBan.ValueMember = "MaNganh";
            cbBan.SelectedIndex = 0;

            dtChuyenNganh = new DichVuSVBUS().getChuyenNganh();
            cbNganh.DataSource = dtChuyenNganh;
            cbNganh.DisplayMember = "TenNganh";
            cbNganh.ValueMember = "MaNganh";
            cbNganh.SelectedIndex = 0;

            dtHocKi = new DichVuSVBUS().getHK();
            cbHocKi.DataSource = dtHocKi;
            cbHocKi.DisplayMember = "NamHoc";
            cbHocKi.ValueMember = "MaHK";
        }
        private void loadDangKi()
        {
            int maHK = int.Parse(cbHocKi.SelectedValue.ToString());
            lvDangKi.Items.Clear();
            ListDK = new DichVuSVBUS().getDangKi(mssv, maHK);
            foreach (DangKi dk in ListDK)
            {
                string[] arr = {dk.MaLop, dk.TenMH, dk.SoTinChi};
                var item = new ListViewItem(arr);
                lvDangKi.Items.Add(item);
            }
        }
        private void loadHienThi()
        {
            string Ban, cn;
            int tt;
            if (ckBan.Checked) {Ban = cbBan.SelectedValue.ToString();} else Ban = null;
            if (ckNganh.Checked) { cn = cbNganh.SelectedValue.ToString(); } else cn = null;
            if (rdXem.Checked) tt = 0;
            else tt = 1;
            int maHK = int.Parse(cbHocKi.SelectedValue.ToString());
            
            lvHienThi.Items.Clear();
            ListHT = new DichVuSVBUS().getHienThi(maHK, Ban, cn, tt);
            if (rdXem.Checked)
            {
                foreach (HienThi ht in ListHT)
                {
                    string[] arr = { ht.MaLop, ht.MaMH, ht.TenMH, ht.SoTinChi };
                    var item = new ListViewItem(arr);
                    lvHienThi.Items.Add(item);
                }
            }
            else
            {
                foreach (HienThi ht in ListHT)
                {
                    if (!isDK(lvDangKi, ht.MaLop)) 
                    {
                        string[] arr = { ht.MaLop, ht.MaMH, ht.TenMH, ht.SoTinChi};
                        var item = new ListViewItem(arr);
                        lvHienThi.Items.Add(item);
                    }
                }
            }
        }
        private bool isDK(ListView lv, string str)
        {
            for (int i = 0; i < lv.Items.Count; i++)
            {
                if (lv.Items[i].SubItems[0].Text == str)
                {
                    return true;
                }
            }
            return false;
        }
        private void tab_Enter(object sender, EventArgs e)
        {
            loadChuyenNganh();
            loadDangKi();
            loadHienThi();
        }

        private void btLoc_Click(object sender, EventArgs e)
        {
            
            loadDangKi();            
            loadHienThi();
        }

        private void btPull_Click(object sender, EventArgs e)
        {
            string mh = lvHienThi.SelectedItems[0].Text;
          
            foreach (HienThi ht in ListHT)
            {
                if (ht.MaLop == mh)
                {
                    string[] arr = { ht.MaLop, ht.TenMH, ht.SoTinChi };
                    var item = new ListViewItem(arr);
                    lvDangKi.Items.Add(item);
                }
            }
            lvHienThi.Items.Clear();
            loadHienThi();
        }

        private void btpush_Click(object sender, EventArgs e)
        {
            lvDangKi.SelectedItems[0].Remove();
            loadHienThi();
        }

        private void btDangKi_Click(object sender, EventArgs e)
        {
            if (rdXem.Checked)
            {
                MessageBox.Show("Xin vui lòng chuyển sang chế dộ DKMH để sử dụng tính năng này");
            }
            string[] kq = new string[10];
            int i = 0;
            rtbKQ.Text = "";
            bool flag = false;
            foreach (DangKi dk in ListDK)
            {
                for (int j = 0; j < lvDangKi.Items.Count; j++)
                {
                  
                    if(lvDangKi.Items[j].Text == dk.MaLop)
                    {                        
                        kq[i++] = string.Format(@"{0}. Môn học có mã là {1} đã đăng kí rồi.
", i - 1,dk.MaLop);
                        flag = true;
                    }
                }                
            }
            foreach (DangKi dk in ListDK)
            {
                for (int j = 0; j < lvHienThi.Items.Count; j++)
                {
                    if (lvHienThi.Items[j].Text == dk.MaLop)
                    {                      
                            int temp = new DichVuSVBUS().XoaSV_LH(mssv, dk.MaLop);
                            if (temp == 1)
                            {
                                kq[i++] = string.Format(@"{0}. Môn học có mã là {1} đã xóa thành công.
", i - 1, lvHienThi.Items[j].Text);
                            }
                            else kq[i++] = string.Format(@"{0}. Môn học có mã là {1} đã xóa thất bại.
", i - 1, lvHienThi.Items[j].Text);
                       
                    }
                }
            }
            for (int k = 0; k < lvDangKi.Items.Count; k++)
            {
                flag = false;
                foreach (DangKi ht in ListDK)
                {
                    if (lvDangKi.Items[k].Text == ht.MaLop)
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    
                    int temp = new DichVuSVBUS().ThemSV_LH(new SV_LH(mssv, lvDangKi.Items[k].Text, 0, 0));
                    if (temp == 1)
                    {
                        kq[i++] = string.Format(@"{0}. Môn học có mã là {1} đã đăng kí thành công.
                          ", i - 1, lvDangKi.Items[k].Text);
                    }
                    else kq[i++] = string.Format(@"{0}. Môn học có mã là {1} đã xóa thất bại.
                           ", i - 1, lvDangKi.Items[k].Text);
                }
            }
            foreach (string str in kq)
            {
                rtbKQ.Text += str;
            }
        }

        private void rdXem_CheckedChanged(object sender, EventArgs e)
        {
            btPull.Enabled = false;
            btpush.Enabled = false;
        }

        private void rdDangKo_CheckedChanged(object sender, EventArgs e)
        {
            btPull.Enabled = true;
            btpush.Enabled = true;
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            loadChuyenNganh();
            loadDangKi();
            loadHienThi();
            rtbKQ.Text = "";
        }

      

     

      
    }
}
